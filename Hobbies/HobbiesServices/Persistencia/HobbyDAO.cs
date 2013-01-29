using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HobbiesServices.Persistencia
{
    public class HobbyDAO
    {
        public void registrarHobby(hobby hobbyEntity)
        {
            
            using (var db = new MySqlEntities())
            {
                db.hobbies.AddObject(hobbyEntity);
                db.SaveChanges();
            }
        }

        public List<int> ListarHobbies()
        {
            using (var db = new MySqlEntities())
            {
                var resultado = from l in db.hobbies select 1;
                return resultado.ToList();
            }
        }

        public string ObtenerDescripcionHobby(int codigo)
        {
            using (var db = new MySqlEntities())
            {
                var resultado = from l in db.hobbies where l.codigo == codigo select l;
                return resultado.FirstOrDefault().descripcion;
            }
        }

    }
}