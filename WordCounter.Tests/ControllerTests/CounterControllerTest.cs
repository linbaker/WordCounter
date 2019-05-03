using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterControllerTest
  {
    [TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToActionResult()
    {
      CounterController controller = new CounterController();

      IActionResult view = controller.Create("hello", "HeLlO world I said hello");

      Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    }

    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
      CounterController controller = new CounterController();
      RedirectToActionResult actionResult = controller.Create("hello", "HeLlO world I said hello") as RedirectToActionResult;

      string result = actionResult.ActionName;

      Assert.AreEqual(result, "Index");
    }
  }
}
