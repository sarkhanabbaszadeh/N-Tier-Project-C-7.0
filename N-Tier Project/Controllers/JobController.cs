using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace N_Tier_Project.Controllers
{
    public class JobController : Controller
    {
        JobManager jobManager = new JobManager(new EfJobDal());

        public IActionResult Index()
        {
            var values= jobManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddJob()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddJob(Job j)
        {
            JobValidator validationRules= new JobValidator();
            ValidationResult results= validationRules.Validate(j);
            if(results.IsValid)
            {
                jobManager.TInsert(j);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }

        public IActionResult DeleteJob(int id)
        {
            var value= jobManager.TGetByID(id);
            jobManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateJob(int id)
        {
            var value = jobManager.TGetByID(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateJob(Job j)
        {
            jobManager.TUpdate(j);
            return RedirectToAction("Index");
        }
    }
}
