using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HobbiesMVC.Models;
using HobbiesMVC.HobbiesServices;

namespace HobbiesMVC.Controllers
{
    public class HobbyController : Controller
    {

        public ActionResult Index()
        {
            List<HobbyModel> listaHobbies = new List<HobbyModel>();
            HobbiesServices.HobbiesClient hs = new HobbiesServices.HobbiesClient();

            foreach (var item in hs.listarHobbies())
            {
                
                HobbyModel hbm = new HobbyModel();
                hbm.codigo = item;
                hbm.descripcion = hs.obtenerDescripcionHobby(item);

                listaHobbies.Add(hbm);

            }

            return View(listaHobbies);
        }


        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Hobby/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Hobby/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Hobby/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Hobby/Edit/5

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

        //
        // GET: /Hobby/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Hobby/Delete/5

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
