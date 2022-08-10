using Microsoft.VisualStudio.TestTools.UnitTesting;
using RESTmovieValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTmovieValidation.Models.Tests
{
    [TestClass()]
    public class MovieTests
    {
        [TestMethod()]
        public void TestAll()
        {
            Movie movie = new Movie();
            Assert.IsNotNull(movie);

            Movie movie2 = new Movie { Price = -1 };
        }
    }
}