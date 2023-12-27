using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using enterprise_expenses.Controllers;
using enterprise_expenses.Models;

namespace enterprise_expenses.Tests
{
    [TestFixture]
    public class CategoryControllerTests
    {
        private CategoryController _controller;
        private ApplicationDbContext _context;

        [SetUp]
        public void Setup()
        {
            // Initialize ApplicationDbContext and CategoryController
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                //.UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _context = new ApplicationDbContext(options);
            _controller = new CategoryController(_context);
        }

        [Test]
        public async Task TestIndex()
        {
            var result = await _controller.Index();
            //Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public void TestAddOrEditGet_NewCategory()
        {
            var result = _controller.AddOrEdit(0);
            //Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public void TestAddOrEditGet_ExistingCategory()
        {
            // Add a test category to the context
            var testCategory = new Category { CategoryId = 1, Title = "Test", Icon = "TestIcon", Type = "TestType" };
            _context.Categories.Add(testCategory);
            _context.SaveChanges();

            var result = _controller.AddOrEdit(1);
            //Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public async Task TestAddOrEditPost_NewCategory()
        {
            var testCategory = new Category { CategoryId = 0, Title = "Test", Icon = "TestIcon", Type = "TestType" };
            var result = await _controller.AddOrEdit(testCategory);
            //Assert.IsInstanceOf<RedirectToActionResult>(result);
        }

        [Test]
        public async Task TestAddOrEditPost_ExistingCategory()
        {
            var testCategory = new Category { CategoryId = 1, Title = "Test", Icon = "TestIcon", Type = "TestType" };
            _context.Categories.Add(testCategory);
            _context.SaveChanges();

            testCategory.Title = "Updated";
            var result = await _controller.AddOrEdit(testCategory);
            //Assert.IsInstanceOf<RedirectToActionResult>(result);
        }

        [Test]
        public async Task TestDeleteConfirmed()
        {
            var testCategory = new Category { CategoryId = 1, Title = "Test", Icon = "TestIcon", Type = "TestType" };
            _context.Categories.Add(testCategory);
            _context.SaveChanges();

            var result = await _controller.DeleteConfirmed(1);
            //Assert.IsInstanceOf<RedirectToActionResult>(result);
        }
    }
}
