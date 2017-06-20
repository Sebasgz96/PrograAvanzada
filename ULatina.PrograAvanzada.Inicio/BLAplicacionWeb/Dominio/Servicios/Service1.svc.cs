using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BLAplicacionWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public double Sumar(double valor1, double valor2)
        {
            double resultado;
            var laAccion = new Dominio.Acciones.Sumar();
            resultado = laAccion.CalcularLaSuma(valor1, valor2);

            return resultado;
        }

        public double Restar(double valor1, double valor2)
        {
            double resultado;
            var laAccion = new Dominio.Acciones.Restar();
            resultado = laAccion.CalcularLaResta(valor1, valor2);

            return resultado;
        }

        public double Multiplicar(double valor1, double valor2)
        {
            double resultado;
            var laAccion = new Dominio.Acciones.Multiplicar();
            resultado = laAccion.CalcularLaMultiplicacion(valor1, valor2);

            return resultado;
        }

        public double Dividir(double valor1, double valor2)
        {
            double resultado;
            var laAccion = new Dominio.Acciones.Dividir();
            resultado = laAccion.CalcularLaDivision(valor1, valor2);

            return resultado;
        }



        public string WhatDateIsToday()
        {
            string elResultado;
            var laAccion = new Dominio.Acciones.ObtenerFechaActual();
            elResultado = laAccion.ObtengaLaFecha();

            return elResultado;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
