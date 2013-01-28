using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HobbiesServices
{
    [ServiceContract]
    public interface IHobbies
    {
        [OperationContract]
        void registrarServicio(int codigo, string descripcion);

    }
}
