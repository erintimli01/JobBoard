using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class JobsController : Controller
  {

    [HttpGet("/jobs")]
    public ActionResult Index()
    {
      List<Job> allJobs = Job.GetAll();
      return View(allJobs);
    }

    [HttpGet("/jobs/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/jobs")]
    public ActionResult Create(string description)
    {
      Job myJob = new Job(description);
      return RedirectToAction("Index");
    }

  }
}