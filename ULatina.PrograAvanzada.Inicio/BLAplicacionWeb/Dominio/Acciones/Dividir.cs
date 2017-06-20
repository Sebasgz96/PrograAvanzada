using System;

namespace BLAplicacionWeb.Dominio.Acciones
{
    public class Dividir
    {
        public double CalcularLaDivision(double valor1, double valor2)
        {
            var laEspecificacion = new Especificaciones.ReliceLaDivision();
            double resultado = laEspecificacion.CalculeLaDivision(valor1, valor2);
            return resultado;
        }
    }
}