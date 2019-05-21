using FabricApplication.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FabricApplication.Controllers
{
    public class PlayerRoleController : Controller
    {
        private IAllRespository<PlayerRole> IplayerRole;

        public PlayerRoleController()
        {
            this.IplayerRole = new AllRespository<PlayerRole>();
        }
        // GET: Player
        public ActionResult Index()
        {
            return View(IplayerRole.GetModel().ToList());
        }

        // GET: Player/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Player/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Player/Create
        [HttpPost]
        public ActionResult Create(PlayerRole collection)
        {
            try
            {
                // TODO: Add insert logic here

                IplayerRole.InsertModel(collection);
                IplayerRole.Save();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Player/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Player/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Player/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Player/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
