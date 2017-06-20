using System;

namespace BLAplicacionWeb.Dominio.Acciones
{
    public class Restar
    {
        public Restar()
        {
        }

        internal double CalcularLaResta(double valor1, double valor2)
        {
            var laEspecifiacion = new Especificaciones.ReliceLaResta();
            double resultado = laEspecifiacion.CalcularLaResta(valor1, valor2);
            return resultado;
        }
    }
}