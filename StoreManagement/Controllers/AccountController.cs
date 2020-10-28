using StoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace StoreManagement.Controllers
{
    public class AccountController : Controller
    {
        public StoreDBContext _db = new StoreDBContext();

        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserInfo oUserInfo)
        {
            if (ModelState.IsValid == true)
            {
            var user = _db.UserInfos.SingleOrDefault(x => x.UserName == oUserInfo.UserName && x.Password == oUserInfo.Password);
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                Session["UserName"] = user.UserName;
                return RedirectToAction("Index", "Vilage");
            }
            else
            {
                ModelState.AddModelError("", "Login details are wrong.");
                return RedirectToAction("Login");
            }
            }
            return RedirectToAction("Login");
        }


        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            Session.RemoveAll();
            Session.Clear();
            return RedirectToAction("Login");
        }

       
    }
}