using FabricApplication.Models;
using FabricApplication.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FabricApplication.Controllers
{
    public class PlayerController : Controller
    {
        private IAllRespository<Player> Iplayer;

        // ServiceFabricEntities context = new ServiceFabricEntities();

        public PlayerController()
        {
            this.Iplayer = new AllRespository<Player>();
        }
        // GET: Player
        public ActionResult Index()
        {
            var listObjects = Iplayer.GetModel().Where(a => a.RoleId != null);

            return View(listObjects);
        }

        // GET: Player/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Player/Create
        public ActionResult Create()
        {
            Player player = new Player();
          //  player.lstlstplayerrole = PlayerRoleList();
            return View(player);
        }

        // POST: Player/Create
        [HttpPost]
        public ActionResult Create(Player collection)
        {
            try
            {
                // TODO: Add insert logic here

                Iplayer.InsertModel(collection);
                Iplayer.Save();
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
            Player player = new Player();
            player = Iplayer.GetById(id);
           // player.lstlstplayerrole = PlayerRoleModel(Convert.ToInt32(player.RoleId));
            return View(player);
        }

        // POST: Player/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Player collection)
        {
            try
            {
                // TODO: Add update logic here
                Iplayer.UpdateModel(collection);
                Iplayer.Save();
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
            var model = Iplayer.GetById(id);
            return View(model);
        }

        // POST: Player/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Player collection)
        {
            try
            {
                // TODO: Add delete logic here
                Iplayer.DeleteModel(collection);
                Iplayer.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public List<PlayerRole> PlayerRoleList()
        {
            IAllRespository<PlayerRole> plrole = new AllRespository<PlayerRole>();
            return (plrole.GetModel().ToList());
        }

        public List<PlayerRole> PlayerRoleModel(int id)
        {
            IAllRespository<PlayerRole> plrole = new AllRespository<PlayerRole>();
            return (plrole.GetModel().Where(a => a.Id == id).ToList());
        }
    }
}
