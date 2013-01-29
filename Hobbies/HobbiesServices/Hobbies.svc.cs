using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HobbiesServices.Persistencia;

namespace HobbiesServices
{
    public class Hobbies : IHobbies
    {

        public void registrarHobby(int codigo, string descripcion)
        {
            var hb = hobby.Createhobby(codigo);
            hb.descripcion = descripcion;

            HobbyDAO hDAO = new HobbyDAO();
            hDAO.registrarHobby(hb);
        }
    }
}
