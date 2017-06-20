namespace BLAplicacionWeb.Dominio.Acciones
{
    public class Sumar
    {      

        public double CalcularLaSuma(double valor1, double valor2)
        {
            var laEspecificacion = new Especificaciones.ReliceLaSuma();
            double resultado = laEspecificacion.CalculeLaSuma(valor1, valor2);
            return resultado;
        }
    }
}