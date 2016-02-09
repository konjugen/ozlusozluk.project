using System;
using System.Collections.Generic;
using System.Linq;
using Api.DAL.DTO;
using Api.Data;
using AutoMapper;

namespace Api.DAL.Repository
{
    public class StoriesRepository
    {
        public List<Stories> GetAll()
        {
            using (var entites = new ContentDBEntities())
            {
                var stories = entites.Stories.Where(p => p.IsActive).ToList();
                return stories;
            }
        }
    }
}
