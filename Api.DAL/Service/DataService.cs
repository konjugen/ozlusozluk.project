using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Api.DAL.DTO;
using Api.DAL.Repository;
using Api.Data;
using AutoMapper;

namespace Api.DAL.Service
{
    public class DataService
    {
        public static readonly Lazy<DalMapperContainer> LazyInstance = new Lazy<DalMapperContainer>(() => new DalMapperContainer());

        public DataService()
        {
            var value = LazyInstance.Value;
        }

        public List<CategoryDto> GetCategories()
        {
            var categoryRepository = new CategoryRepository();
            var categorilist = categoryRepository.GetAll();
            return Mapper.Map<List<Category>, List<CategoryDto>>(categorilist);
        }

        public List<StoriesDto> GetStories()
        {
            var storiesRepository = new StoriesRepository();
            var storylist = storiesRepository.GetAll();
            return Mapper.Map<List<Stories>, List<StoriesDto>>(storylist);
        }

        public List<WriterDto> GetWriter()
        {
            var writerRepository = new WriterRepository();
            var writerlist = writerRepository.GetAll();
            return Mapper.Map<List<Writer>, List<WriterDto>>(writerlist);
        }

        public List<WriterTemplateDto> GetWriterTemplate()
        {
            var writerTemplateRepository = new WriterTemplateRepository();
            var writerTemplatelist = writerTemplateRepository.GetAll();
            return Mapper.Map<List<WriterTemplate>, List<WriterTemplateDto>>(writerTemplatelist);
        }

        public List<CategoryDto> GetCategoriesById(int categoryId)
        {
            var categoryRepository = new CategoryRepository();
            var categorilist = categoryRepository.GetCategoryById(categoryId);
            return Mapper.Map<List<Category>, List<CategoryDto>>(categorilist);
        }
    }
}
