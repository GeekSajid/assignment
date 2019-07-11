using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using A4AeroAssisgment.Models;
using A4AeroAssisgment.BusinessLogic;

namespace A4AeroAssisgment.Controllers
{
    public class AgentController : Controller
    {
        private AgentDbContext db = new AgentDbContext();
        private AgentBL agentBL = new AgentBL();

        // GET: /Agent/
        public ActionResult Index()
        {
            return View(agentBL.AgentList());
        }

        // GET: /Agent/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinessEntities businessentities = agentBL.GetAgentById((long) id);
            if (businessentities == null)
            {
                return HttpNotFound();
            }
            return View(businessentities);
        }

        // GET: /Agent/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Agent/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BusinessEntities businessentities)
        {
            string message = "";
            if (ModelState.IsValid)
            {
                message = agentBL.Add(businessentities);                
            }
            return Json(message, JsonRequestBehavior.AllowGet);
        }

        

        // GET: /Agent/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinessEntities businessentities = agentBL.GetAgentById((long)id);
            if (businessentities == null)
            {
                return HttpNotFound();
            }
            return View(businessentities);
        }

        // POST: /Agent/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BusinessEntities businessentities)
        {
            string message = "";
            if (ModelState.IsValid)
            {
                message = agentBL.Update(businessentities);
            }
            return Json(message, JsonRequestBehavior.AllowGet);
        }

        // GET: /Agent/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinessEntities businessentities = agentBL.GetAgentById((long)id);
            if (businessentities == null)
            {
                return HttpNotFound();
            }
            return View(businessentities);
        }

        // POST: /Agent/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            BusinessEntities businessentities = agentBL.GetAgentById(id);
            string message = agentBL.SoftDelete(businessentities);
            if (message != "")
            {
                return RedirectToAction("Index");
            }
            return Json("Delete Failed", JsonRequestBehavior.AllowGet);

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
