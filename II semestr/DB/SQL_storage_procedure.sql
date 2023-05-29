USE Airport

/*---------------------------------------------*/
CREATE PROCEDURE dbo.SP_GetAllValuesFromTable
    @table_name NVARCHAR(50)
AS
BEGIN

    DECLARE @actual_table NVARCHAR(50)
    SELECT @actual_table = QUOTENAME(TABLE_NAME)
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_NAME = @table_name

    DECLARE @query AS NVARCHAR(MAX)
    SELECT @query = 'SELECT * FROM ' + @actual_table
    EXEC(@query)

END

EXEC SP_GetAllValuesFromTable 'Pilot';
GO
/*---------------------------------------------*/


CREATE PROCEDURE SP_GetValueByIdFromTables
	@table_name NVARCHAR(50),
	@table_id INT
AS
BEGIN
	DECLARE @actual_table NVARCHAR(50)
	SELECT @actual_table = QUOTENAME(TABLE_NAME)
	FROM INFORMATION_SCHEMA.TABLES
	WHERE TABLE_NAME = @table_name

	DECLARE @query NVARCHAR(MAX)
	SELECT @query = N'SELECT * FROM ' + @actual_table + ' WHERE id = ' + STR(@table_id)
	EXEC (@query)
END

EXEC SP_GetValueByIdFromTables 'FlightDestination', 4;
GO
/*---------------------------------------------*/


CREATE PROCEDURE SP_DeleteFromTable
	@table_name NVARCHAR(50),
	@table_id INT
AS
BEGIN
	DECLARE @actual_table NVARCHAR(50)
	SELECT @actual_table = QUOTENAME(TABLE_NAME)
	FROM INFORMATION_SCHEMA.TABLES
	WHERE TABLE_NAME = @table_name

	DECLARE @query NVARCHAR(MAX);
	SELECT @query = N'DELETE FROM ' + @actual_table + ' WHERE id = ' + STR(@table_id)
	EXEC (@query)
END

EXEC SP_DeleteFromTable 'FlightDestination', 4;
GO
/*---------------------------------------------*/

CREATE PROCEDURE SP_UpdateInTable
	@table_name NVARCHAR(50),
	@table_id INT,
	@column_list NVARCHAR(MAX)
AS
BEGIN
	DECLARE @actual_table NVARCHAR(50)
	SELECT @actual_table = QUOTENAME(TABLE_NAME)
	FROM INFORMATION_SCHEMA.TABLES
	WHERE TABLE_NAME = @table_name

	DECLARE @query NVARCHAR(MAX)
	SET @query = 'UPDATE ' + @actual_table + ' SET ' + @column_list + 'WHERE id = ' + STR(@table_id)
	EXEC (@query)
END

EXEC SP_UpdateInTable 'Pilot', 3, 'last_name = ''Lalka''';
GO
/*---------------------------------------------*/

CREATE PROCEDURE SP_InsertTable
	@table_name NVARCHAR(50),
	@column_list NVARCHAR(MAX),
	@property_list NVARCHAR(MAX)
AS
BEGIN
	DECLARE @actual_table NVARCHAR(50)
	SELECT @actual_table = QUOTENAME(TABLE_NAME)
	FROM INFORMATION_SCHEMA.TABLES
	WHERE TABLE_NAME = @table_name

	DECLARE @query NVARCHAR(MAX);

	SELECT @query = 'INSERT INTO ' + @actual_table + ' ( ' +  @column_list + ' ) ' + ' VALUES ( ' + @property_list + ' ) '
	EXECUTE (@query);
END

EXEC SP_InsertTable 'Pilot', 'first_name, last_name, age, rating', '''Stas'', ''Stus'', 18, 3.7';
GO
/*---------------------------------------------*/







