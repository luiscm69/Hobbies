using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace HobbiesServices.Dominio
{
    [DataContract]
    [Table("hobbies")]
    public class Hobbie
    {

        public Hobbie()
        { 
        }

        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.DatabaseGeneratedOption.None)]
        public int codigo { get; set; }
        public string descripcion { get; set; }

    }
}