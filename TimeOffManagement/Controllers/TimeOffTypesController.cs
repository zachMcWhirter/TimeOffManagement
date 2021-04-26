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
            if (!_repo.IsExistingId(id))
            {
                return NotFound();
            }
            var timeOffType = _repo.GetById(id);
            var model = _mapper.Map<TimeOffTypeVM>(timeOffType);
            return View(model);
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
            if (!_repo.IsExistingId(id))
            {
                return NotFound();
            }
            var timeOffType = _repo.GetById(id);
            var model = _mapper.Map<TimeOffTypeVM>(timeOffType);
            return View(model);
        }

        // POST: TimeOffTypesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TimeOffType model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var timeOffType = _mapper.Map<TimeOffType>(model);

                var isSuccessful = _repo.Update(timeOffType);
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

        // GET: TimeOffTypesController/Delete/5
        public ActionResult Delete(int id)
        {
            var timeOffType = _repo.GetById(id);
            if (timeOffType == null)
            {
                return NotFound();
            }

            var isSuccessful = _repo.Delete(timeOffType);
            if (!isSuccessful)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
        }

        //// POST: TimeOffTypesController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, TimeOffTypeVM model)
        //{
        //    try
        //    {
        //        var timeOffType = _repo.GetById(id);

        //        // If the correct Id is not found, return NotFound message
        //        if (timeOffType == null)
        //        {
        //            return NotFound();
        //        }

        //        var isSuccessful = _repo.Delete(timeOffType);
        //        if (!isSuccessful)
        //        {
        //            return View(model);
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View(model);
        //    }
        //}
    }
}
