using System;

namespace Acciones
{
    public class InvocarALaSuma
    {
        public InvocarALaSuma()
        {
        }

        public string CalculeLaSuma(string valor1, string valor2)
        {
            string resultado;

            //parsear el primer elemento
            double numero1 = Parsear(valor1);

            //parsear el segundo elemnto
            double numero2 = Parsear(valor2);

            //instanciar el wcf
            var elCliente = new AplicacionWeb.OperacionesMatematicas.Service1Client();

            //invocar el metodo wcf\
            var resultadoNumerico = elCliente.Sumar(numero1, numero2);

            //convertir el resultado a string
            resultado = resultadoNumerico.ToString();

            //retornar
            return resultado;
        }

        private double Parsear(string numeroString)
        {
            double resultado;
            double.TryParse(numeroString, out resultado);
            return resultado;
        }        
    }
}