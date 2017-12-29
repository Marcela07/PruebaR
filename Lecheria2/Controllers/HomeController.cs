using Lecheria2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecheria2.Controllers
{
    public class HomeController : Controller
    {

        LecheriaEntities contexto;
        public HomeController()
        {
            contexto = new LecheriaEntities();
        }
        public ActionResult Formulario()
        {

            return View();
        }
        public ActionResult Guardar(string nombre, string sexo, string raza, string promedio_leche_Dia)
        {
            Vacas nuevo = new Vacas()
            {
                
                Nombre = nombre,
                Sexo = sexo,
                Raza = raza,
               Promedio_leche_Dia = promedio_leche_Dia

            };
            contexto.Vacas.Add(nuevo);
            contexto.SaveChanges();

            return View("Listado", contexto.Vacas.ToList());
        }


        public ActionResult Listado()
        {
            List<Vacas> listadoAnimal = contexto.Vacas.ToList();
            return View(listadoAnimal);
        }

        public ActionResult Ficha(String NOMBRE ) 
        {


                return View("Guardar", contexto.Vacas.ToList());
            }
          
           
        
    }
}