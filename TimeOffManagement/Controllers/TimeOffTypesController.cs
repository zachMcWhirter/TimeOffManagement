using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeOffManagement.Contracts;
using TimeOffManagement.Data;
using TimeOffManagement.Models;

namespace TimeOffManagement.Controllers
{
    public class TimeOffTypesController : Controller
    {
        private readonly ITimeOffTypeRepository _repo;
        private readonly IMapper _mapper;

        public TimeOffTypesController(ITimeOffTypeRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // GET: TimeOffTypesController
        public ActionResult Index()
        {
            var timeOffTypes = _repo.GetAll().ToList();
            var model = _mapper.Map<List<TimeOffType>, List<TimeOffTypeVM>>(timeOffTypes);
            return View(model);
        }

        // GET: TimeOffTypesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TimeOffTypesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TimeOffTypesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TimeOffType model)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                // Create a variable containing the mapped model
                var timeOffType = _mapper.Map<TimeOffType>(model);

                // Set the DateCreated prop to be the current DateTime
                timeOffType.DateCreated = DateTime.Now;

                // Create an variable that stores a boolean response when we call
                // the Create method from the repository and pass in the mapped object
                var isSuccessful = _repo.Create(timeOffType);
                if (!isSuccessful)
                {
                    ModelState.AddModelError("", "Oops.. Something Went Wrong");
                    return View(model);
                }


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "Oops.. Something Went Wrong");
                return View(model);
            }
        }

        // GET: TimeOffTypesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TimeOffTypesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TimeOffTypesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TimeOffTypesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
