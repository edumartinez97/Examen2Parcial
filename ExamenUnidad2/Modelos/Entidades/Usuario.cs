using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUnidad2.Modelos.Entidades
{
    public class Usuario
    {
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string EMAIL { get; set; }
        public string CLAVE { get; set; }
        public bool EsAdministrador { get; set; }

    }
}
