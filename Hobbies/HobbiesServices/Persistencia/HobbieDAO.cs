using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HobbiesServices.Dominio;

namespace HobbiesServices.Persistencia
{
    public class HobbieDAO
    {
        public void registrarHobbie(Hobbie hobbie)
        { 
            using (EFContext db = new EFContext(ConexionUtil.obtenerCadena())) 
            {
                db.HobbieDbSet.Add(hobbie);
                db.SaveChanges();
            }
        }
    }
}