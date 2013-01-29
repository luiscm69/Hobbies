using System;
using System.Collections.Generic;

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
    }
}