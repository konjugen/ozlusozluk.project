using Api.DAL.DTO;
using Api.Data;
using AutoMapper;

namespace Api.DAL
{
    public class DalMapperContainer
    {
        public DalMapperContainer()
        {
              Setup();
        }

        public void Setup()
        {
            Mapper.CreateMap<Category, CategoryDto>();
            Mapper.CreateMap<Stories, StoriesDto>();
            Mapper.CreateMap<Writer, WriterDto>();
            Mapper.CreateMap<WriterTemplate, WriterTemplateDto>();
        }
    }
}
