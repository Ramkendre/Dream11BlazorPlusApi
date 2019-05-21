using FabricApplication.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FabricApplication.Controllers
{
    public class UserController : Controller
    {
        private IAllRespository<User> interfaceobj;

        public UserController()
        {
            this.interfaceobj = new AllRespository<User>();
        }
        // GET: User
        public ActionResult Index()
        {
            return View(interfaceobj.GetModel().ToList());
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User collection)
        {
            try
            {
                // TODO: Add insert logic here
                interfaceobj.InsertModel(collection);
                interfaceobj.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            var model = interfaceobj.GetById(id);
            return View(model);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User collection)
        {
            try
            {
                // TODO: Add update logic here
                interfaceobj.UpdateModel(collection);
                interfaceobj.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            var model = interfaceobj.GetById(id);
            return View(model);
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, User collection)
        {
            try
            {
                // TODO: Add delete logic here
                interfaceobj.DeleteModel(collection);
                interfaceobj.Save();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }
    }
}
