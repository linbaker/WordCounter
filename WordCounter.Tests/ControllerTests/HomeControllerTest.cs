using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
      [TestMethod]
          public void IndexHome_ReturnsCorrectView_True()
          {
              HomeController controller = new HomeController();

              ActionResult indexView = controller.Index();

              Assert.IsInstanceOfType(indexView, typeof(ViewResult));
          }
    }
}
