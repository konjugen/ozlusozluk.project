using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OzluSozlukAPI;
using OzluSozlukAPI.Controllers;

namespace OzluSozlukAPI.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void GetCategories()
        {
            var categoryController = new CategoryController();
            var result = categoryController.GetAll();
        }

        [TestMethod]
        public void GetStories()
        {
            var storiesController = new StoriesController();
            var result = storiesController.GetAll();
        }

        [TestMethod]
        public void GetWriter()
        {
            var writerController = new WriterController();
            var result = writerController.GetAll();
        }

        [TestMethod]
        public void GetWriterTemplate()
        {
            var writerTemplateController = new WriterTemplateController();
            var result = writerTemplateController.GetAll();
        }

        [TestMethod]
        public void GetCategoryById()
        {
            var GetCategoryById = new CategoryController();
            var result = GetCategoryById.GetCategoryById(1);
        }
    }
}                                                                          
