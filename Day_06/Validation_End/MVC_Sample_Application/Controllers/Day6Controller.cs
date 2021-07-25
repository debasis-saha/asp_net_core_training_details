using Microsoft.AspNetCore.Mvc;
using MVC_Sample_Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MVC_Sample_Application.Controllers
{
    public class Day6Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewModel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLoginViewModel user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (user.Password.Length > 8)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "The user name or password provided is incorrect.");
                    }
                }
                catch (Exception ex)
                {
                }
            }
            return View(user);
        }


        public IActionResult ExplicitServer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ExplicitServer(RegistrationModel mRegister)
        {
            //Write custom logic to validate RegistrationModel
            if (string.IsNullOrEmpty(mRegister.UserName))
            {
                ModelState.AddModelError("UserName", "Please enter your name");
            }
            if (!string.IsNullOrEmpty(mRegister.UserName))
            {
                Regex emailRegex = new Regex(".+@.+\\..+");
                if (!emailRegex.IsMatch(mRegister.UserName))
                    ModelState.AddModelError("UserName", "Please enter correct email address");
            }
            if (string.IsNullOrEmpty(mRegister.Password))
            {
                ModelState.AddModelError("Password", "Please enter password");
            }
            if (string.IsNullOrEmpty(mRegister.ConfirmPassword))
            {
                ModelState.AddModelError("ConfirmPassword", "Please enter confirm password");
            }
            if (string.IsNullOrEmpty(mRegister.ConfirmPassword) && string.IsNullOrEmpty(mRegister.ConfirmPassword))
            {
                if (mRegister.ConfirmPassword != mRegister.Password)
                    ModelState.AddModelError("ConfirmPassword", "Confirm password doesn't match");
            }
            //if (mRegister.Country.ID == null || mRegister.Country.ID == 0)
            //{
            //    ModelState.AddModelError("Country", "Please select Country");
            //}
            //if (mRegister.City.ID == null || mRegister.City.ID == 0)
            //{
            //    ModelState.AddModelError("City", "Please select City");
            //}
            if (string.IsNullOrEmpty(mRegister.Address))
            {
                ModelState.AddModelError("Address", "Please enter your address");
            }
            if (string.IsNullOrEmpty(mRegister.MobileNo))
            {
                ModelState.AddModelError("MobileNo", "Please enter your mobile no");
            }
            if (!mRegister.TermsAccepted)
            {
                ModelState.AddModelError("TermsAccepted", "You must accept the terms");
            }
            if (ModelState.IsValid)
            {
                return View("Completed");
            }
            else
            {
                ViewBag.Selpwd = mRegister.Password;
                ViewBag.Selconfirmpwd = mRegister.ConfirmPassword;
                //BindCountry();

                //if (mRegister.Country != null)
                //    BindCity(mRegister.Country.ID);
                //else BindCity(null);

                return View();
            }
        }

        //[HttpPost]
        //public ActionResult ServerMeta(RegistrationMetaModel mRegister)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        return View("Completed");
        //    }
        //    else
        //    {
        //        ViewBag.Selpwd = mRegister.Password;
        //        ViewBag.Selconfirmpwd = mRegister.ConfirmPassword;
        //        BindCountry();

        //        if (mRegister.Country != null)
        //            BindCity(mRegister.Country.ID);
        //        else
        //            BindCity(null);
        //        return View();
        //    }
        //}
    }
}
