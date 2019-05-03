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
    return View();
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

  }
}
