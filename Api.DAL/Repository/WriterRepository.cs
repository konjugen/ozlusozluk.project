using System;
using System.Collections.Generic;
using System.Linq;
using Api.DAL.DTO;
using Api.Data;
using AutoMapper;

namespace Api.DAL.Repository
{
    public class WriterRepository
    {
        public List<Writer> GetAll()
        {
            using (var entites = new ContentDBEntities())
            {
                var writer = entites.Writer.Where(p => p.IsActive).ToList();
                return writer;
            }
        }
    }
}
