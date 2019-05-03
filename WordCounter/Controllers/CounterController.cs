using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class CounterController : Controller
  {
    [HttpGet("/counter")]
    public ActionResult Index()
    {

      List<Counter> allCounters = Counter.UserInput;
      return View(allCounters);
    }

    [HttpGet("/counter/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/counter")]
    public ActionResult Create(string wordToCount, string sentenceToCheck)
    {
      Counter myCounter = new Counter(wordToCount, sentenceToCheck);
      return RedirectToAction("Index");
    }

    [HttpPost("/counter/{id}/delete")]
    public ActionResult Destroy(int id)
    {
      Counter.RemoveCounter(id);
      return RedirectToAction("Index");
    }

  }
}
