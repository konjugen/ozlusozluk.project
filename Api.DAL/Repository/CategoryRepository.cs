using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using Api.Contract.DTO;
using Api.DAL.DTO;
using Api.Data;
using AutoMapper;

namespace Api.DAL.Repository
{
    public class CategoryRepository
    {
        public List<Category> GetAll()
        {
            using (var entites = new ContentDBEntities())
            {
                var categories = entites.Categories.Where(p => p.IsActive).ToList();
                return categories;
            }
        }

        public List<Category> GetCategoryById(int categoryId)
        {
            using (var entities = new ContentDBEntities())
            {
                var categories = entities.Categories.Where(w => w.PKCategoryId == categoryId);
                return categories.ToList();
            }
        }

    }
}
