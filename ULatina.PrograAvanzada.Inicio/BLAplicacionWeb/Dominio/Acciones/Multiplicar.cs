using System;

namespace BLAplicacionWeb.Dominio.Acciones
{
    public class Multiplicar
    {
        public Multiplicar()
        {
        }

        internal double CalcularLaMultiplicacion(double valor1, double valor2)
        {
            var laEspecificacion = new Especificaciones.ReliceLaMultiplicacion();
            double resultado = laEspecificacion.CalculeLaMultiplicaion(valor1, valor2);
            return resultado;
        }
    }
}