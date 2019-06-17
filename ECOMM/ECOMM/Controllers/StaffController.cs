﻿using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECOMM.Controllers
{
    public class StaffController : Controller
    {
        //
        // GET: /Staff/

        List<Staff> staffList = new List<Staff>();


        public StaffController()
        {
            staffList.Add(new Staff { Id = 1, Name = "Jaywant Shinde", Age = 34 });
            staffList.Add(new Staff { Id = 2, Name = "Raghu Pande", Age = 26 });
            staffList.Add(new Staff { Id = 3, Name = "Seeta Raman", Age = 24 });
            staffList.Add(new Staff { Id = 4, Name = "Neena Pethe", Age = 28 });
            staffList.Add(new Staff { Id = 5, Name = "Dilip Patil", Age = 38 });
        }
        //public ActionResult Edit(int id)
        //{
        //    var std = staffList.Where(s => s.Id == id)
        //        .FirstOrDefault();

        //    return View(std);
        //}



        [HttpPost]
        public ActionResult Edit(Staff std)
        {
            if (ModelState.IsValid)
            {

                //write code to update student 

                return RedirectToAction("Index", "Home");
            }

            return View(std);
        }

    }
}
