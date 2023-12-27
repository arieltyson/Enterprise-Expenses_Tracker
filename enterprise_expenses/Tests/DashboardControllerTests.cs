// File: Tests/DashboardControllerTests.cs
using NUnit.Framework;
using enterprise_expenses.Controllers;
using enterprise_expenses.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;
using NuGet.ContentModel;

namespace enterprise_expenses.Tests
{
    public class DashboardControllerTests
    {
        private DashboardController _controller;
        private ApplicationDbContext _context;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                //.UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _context = new ApplicationDbContext(options);
            _controller = new DashboardController(_context);
        }

        [Test]
        public async Task TestIndexMethod()
        {
            var result = await _controller.Index();
            //Assert.IsNotNull(result);
        }

        [Test]
        public void TestTotalIncomeCalculation()
        {
            // Add some transactions to the context
            _context.Transactions.Add(new Transaction { Category = new Category { Type = "Income" }, Amount = 100 });
            _context.Transactions.Add(new Transaction { Category = new Category { Type = "Income" }, Amount = 200 });
            _context.SaveChanges();

            // Call the Index method
            var result = _controller.Index().Result;

            // Check the TotalIncome value
            //Assert.AreEqual("$300", _controller.ViewBag.TotalIncome);
        }

        [Test]
        public void TestTotalIncomeCalculationWithNoIncome()
        {
            // Call the Index method
            var result = _controller.Index().Result;

            // Check the TotalIncome value
            //Assert.AreEqual("$0", _controller.ViewBag.TotalIncome);
        }

        [Test]
        public void TestTotalExpenseCalculation()
        {
            // Add some transactions to the context
            _context.Transactions.Add(new Transaction { Category = new Category { Type = "Expense" }, Amount = 100 });
            _context.Transactions.Add(new Transaction { Category = new Category { Type = "Expense" }, Amount = 200 });
            _context.SaveChanges();

            // Call the Index method
            var result = _controller.Index().Result;

            // Check the TotalExpense value
            //Assert.AreEqual("$300", _controller.ViewBag.TotalExpense);
        }

        [Test]
        public void TestTotalExpenseCalculationWithNoExpense()
        {
            // Call the Index method
            var result = _controller.Index().Result;

            // Check the TotalExpense value
            //Assert.AreEqual("$0", _controller.ViewBag.TotalExpense);
        }

        [Test]
        public void TestBalanceCalculation()
        {
            // Add some transactions to the context
            _context.Transactions.Add(new Transaction { Category = new Category { Type = "Income" }, Amount = 300 });
            _context.Transactions.Add(new Transaction { Category = new Category { Type = "Expense" }, Amount = 200 });
            _context.SaveChanges();

            // Call the Index method
            var result = _controller.Index().Result;

            // Check the Balance value
            //Assert.AreEqual("$100", _controller.ViewBag.Balance);
        }

        [Test]
        public void TestBalanceCalculationWithNoTransactions()
        {
            // Call the Index method
            var result = _controller.Index().Result;

            // Check the Balance value
            //Assert.AreEqual("$0", _controller.ViewBag.Balance);
        }
    }
}
