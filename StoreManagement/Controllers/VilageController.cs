using StoreManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreManagement.Controllers
{
    [Authorize]
    public class VilageController : Controller
    {
        public StoreDBContext _db = new StoreDBContext();
        // GET: Vilage
        public ActionResult Index()
        {
          var VilageList = _db.VilageInfos.ToList();
            return View(VilageList);
        }

        [HttpGet]
        public ActionResult AddVilage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddVilage(VilageInfo oVilageInfo)
        {
            var AddVilageList = _db.VilageInfos.Add(oVilageInfo);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditVilage(int id)
        {
            var edidatalist =  _db.VilageInfos.Single(x => x.Id == id);
            return View(edidatalist);
        }

        [HttpPost]
        public ActionResult EditVilage(int id , VilageInfo oVilageInfo)
        {
            var edidatalist = _db.VilageInfos.Where(x => x.Id == id).ToList();
            foreach (var item in edidatalist)
            {
                item.VilageName = oVilageInfo.VilageName;
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteVilage(int id)
        {
            var DeleteVilageData = _db.VilageInfos.Single(x => x.Id == id);
            _db.VilageInfos.Remove(DeleteVilageData);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}