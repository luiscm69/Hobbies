using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HobbiesServices.Dominio;
using HobbiesServices.Persistencia;

namespace HobbiesServices
{
    public class Hobbies : IHobbies
    {

        public void registrarServicio(int codigo, string descripcion)
        {
            Hobbie nuevoHobbie = new Hobbie();
            nuevoHobbie.codigo = codigo;
            nuevoHobbie.descripcion = descripcion;

            HobbieDAO hDAO = new HobbieDAO();
            hDAO.registrarHobbie(nuevoHobbie);
        }
    }
}
