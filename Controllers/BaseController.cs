﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tfzr_rsok_autosalon.Models;
using tfzr_rsok_autosalon.Services.IServices;
using tfzr_rsok_autosalon.Viewmodels.Base;

namespace tfzr_rsok_autosalon.Controllers
{
    public abstract class BaseController<T> : Controller where T : BaseModel
    {
        protected readonly IService<T, IBaseViewModel<T>> _service;

        public BaseController(IService<T, IBaseViewModel<T>> service)
        {
            _service = service;
        }
        public ActionResult Add([FromForm] T value)
        {
            var isValid = value.IsModelValid();
            if (isValid)
            {
                _service.Add(value);
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Update([FromForm] T value)
        {
            try
            {
                _service.Update(value);
            }
            catch (Exception)
            {
                return RedirectToAction("Edit");
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
