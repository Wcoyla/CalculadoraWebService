using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace webservice
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod (Description ="Mi primer web Services")]
        public string HolaMundo()
        {
            return "Hola a todos";
        }
        [WebMethod (Description ="Sumar dos numeros")]
        public double Sumar(double nro1, double nro2)
        {
            double sumar = nro1 + nro2;
            return sumar;
        }
        private double factorial(int nro)
        {
            if (nro == 0) return 1;
            else return nro * factorial(nro - 1);
        }
        [WebMethod(Description ="Factorial de un numero")]
        public double Fact(int nro)
        {
            return factorial(nro);
        }
        [WebMethod(Description ="La resta de dos numeros")]
        public double Resta(double nro1,double nro2)
        {
            double resta = nro1 - nro2;
            return resta;
        }
        [WebMethod(Description ="Multiplicar 2 numeros")]
        public double Multiplicar(double nro1,double nro2)
        {
            double mult = nro1 * nro2;
            return mult;
        }
        [WebMethod(Description ="Dividir 2 numeros")]
        public double Dividir(double nro1,double nro2)
        {
            double div = nro1 / nro2;
            return div;
        }
        [WebMethod(Description = "Potencia de un numero")]
        public double Potencia(int bas,int exp)
        {
            double pot = Math.Pow(bas, exp);
            return pot;
        }
        [WebMethod(Description = "Seno de un numero")]
        public double Seno(double nro)
        {
            double sen = Math.Sin(nro);
            return sen;
        }

        [WebMethod(Description ="Coseno de un numero")]
        public double Coseno(double nro)
        {
            double cos = Math.Cos(nro);
            return cos;
        }
        [WebMethod(Description ="Tangente de un numero")]
        public double Tangente(double nro)
        {
            double tan = Math.Tan(nro);
            return tan;
        }
        [WebMethod(Description ="Inverso de un numero")]
        public double Inverso(double nro)
        {
            double inv = 1 / nro;
            return inv;
        }
    }
}
