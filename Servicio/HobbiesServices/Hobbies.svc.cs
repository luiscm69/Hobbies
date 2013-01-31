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
            try
            {
                hobby hb = new hobby();
                hb.codigo = codigo;
                hb.descripcion = descripcion;

                HobbyDAO hDAO = new HobbyDAO();
                hDAO.registrarHobby(hb);
            }
            catch (Exception e)
            {
                
                //throw new FaultException("El codigo ya se encuentra registrado. Ingreso uno distinto");
                throw new FaultException(e.Message);
            }
        }

        public List<string> listarHobbies()
        {
            try
            {
                HobbyDAO hDAO = new HobbyDAO();
                return hDAO.ListarHobbies();
            }
            catch (Exception e)
            {

                throw new FaultException(e.Message);
                
            }
        }

    }
}
