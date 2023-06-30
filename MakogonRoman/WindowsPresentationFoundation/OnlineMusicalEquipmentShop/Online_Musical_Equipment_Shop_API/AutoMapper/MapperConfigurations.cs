using AutoMapper;
using Online_Musical_Equipment_Shop_BLL.DTOs.RequestsDTOs;
using Online_Musical_Equipment_Shop_BLL.DTOs.ResponseDTOs;
using Online_Musical_Equipment_Shop_DAL.Entities;

namespace Online_Musical_Equipment_Shop_API.AutoMapper
{
    public class MapperConfigurations : Profile
    {
        public MapperConfigurations()
        {
            InstrumentsMapperConfigurations();
        }

        private void InstrumentsMapperConfigurations()
        {
            CreateMap<Instruments, GetInstrumentsDTO>();
            CreateMap<InsertInstrumentsDTO, Instruments>();
            CreateMap<UpdateInstrumentsDTO, Instruments>();
        }
    }
}
