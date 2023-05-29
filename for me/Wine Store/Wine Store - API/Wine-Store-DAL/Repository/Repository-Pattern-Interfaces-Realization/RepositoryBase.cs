using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Text;
using Dapper;
using Microsoft.Data.SqlClient;
using Wine_Store_DAL.Base_Entity;
using Wine_Store_DAL.Repository.Repository_Pattern_Interfaces_Realization.Interfaces;

namespace Wine_Store_DAL.Repository.Repository_Pattern_Interfaces_Realization
{
    public class RepositoryBase<TEntity> : IGenericRepository<TEntity> where TEntity : Entity
    {
        protected SqlConnection _connection;
        protected IDbTransaction _transaction;
        protected string _table;

        public RepositoryBase(SqlConnection connection, IDbTransaction transaction, string table)
        {
            _connection = connection;
            _transaction = transaction;
            _table = table;
        }
        public async Task<IEnumerable<TEntity>> GetInformation()
        {
            return await _connection.QueryAsync<TEntity>($"Select * From {_table}", transaction: _transaction);
        }
        public async Task<TEntity> GetById(int id)
        {
            var result =
                await _connection.QuerySingleOrDefaultAsync<TEntity>($"Select * From {_table} Where Id = @Id", 
                    param: new { Id = id }, 
                    transaction: _transaction);

            if (result == null)
            {
                throw new KeyNotFoundException($"{_table} with id [{id}] could not be found.");
            }
            return result;
        }
        public async Task InsertEntity(TEntity entity)
        {
            string query = this.GenerateInsertQuery();

            await _connection.ExecuteAsync(query, param: entity, transaction: _transaction);
        }
        public async Task UpdateEntity(TEntity entity)
        {
            string query = this.GenerateUpdateQuery();

            await _connection.ExecuteAsync(query, param: entity, transaction: _transaction);
        }
        public async Task DeleteEntity(int id)
        {
            await _connection.ExecuteAsync($"Delete from {_table} where Id = @Id", 
                param: new { Id = id }, 
                transaction: _transaction);
        }
        private IEnumerable<PropertyInfo> GetProperties => typeof(TEntity).GetProperties();
        private static List<string> ListProperties(IEnumerable<PropertyInfo> list_Properties)
        {
            return (from property in list_Properties let attributes = 
                property.GetCustomAttributes(typeof(DescriptionAttribute), false) where attributes.Length <= 0 ||
                (attributes[0] as DescriptionAttribute)?.Description != "ingore" select property.Name).ToList();
        }
        private string GenerateInsertQuery()
        {
            var builder = new StringBuilder($"SET IDENTITY_INSERT {_table} ON Insert into {_table}");
            builder.Append(" (");

            var properties = ListProperties(GetProperties);
            properties.ForEach(property => { builder.Append($"[{property}],");});

            builder.Remove(builder.Length - 1, 1).Append(") Values (");

            properties.ForEach(property => { builder.Append($"@{property},");});

            builder.Remove(builder.Length - 1, 1).Append(")");

            return builder.ToString();
        }
        private string GenerateUpdateQuery()
        {
            var builder = new StringBuilder($"Update {_table} set ");
            var properties = ListProperties(GetProperties);

            properties.ForEach(property =>
            {
                if (!property.Equals("Id"))
                {
                    builder.Append($"{property} = @{property},");
                }
            });

            builder.Remove(builder.Length - 1, 1).Append(" Where Id = @Id");

            return builder.ToString();
        }
    }
}
