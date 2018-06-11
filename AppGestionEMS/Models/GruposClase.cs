using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEMS.Models
{
    public class GruposClase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CapacidadAlumnosGrupo { get; set; }
    }
}