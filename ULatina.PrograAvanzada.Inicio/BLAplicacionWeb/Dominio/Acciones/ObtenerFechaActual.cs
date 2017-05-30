using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLAplicacionWeb.Dominio.Acciones
{
    public class ObtenerFechaActual
    {
        public string ObtengaLaFecha()
        {

            var laEspecifiacion = new Especificaciones.ObtengaFecha();
            var laFecha = laEspecifiacion.FormatearUnaFecha(DateTime.Now, "dd/mm/yyyy");
            return laFecha;
        }
    }
}