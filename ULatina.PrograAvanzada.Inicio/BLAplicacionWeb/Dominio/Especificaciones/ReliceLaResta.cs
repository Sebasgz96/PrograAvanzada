using System;

namespace BLAplicacionWeb.Dominio.Especificaciones
{
    public class ReliceLaResta
    {
        public ReliceLaResta()
        {
        }

        public double CalcularLaResta(double valor1, double valor2)
        {
            return valor1 - valor2;
        }
    }
}