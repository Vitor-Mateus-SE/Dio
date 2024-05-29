using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.models
{
    public class Calculadora
    {
        public void somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void diminuir(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void dividir(int x, int y)
        {
            Console.WriteLine($"{x} % {y} = {x / y}");
        }
        public void potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} =" + pot);
        }
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($" Seno de {angulo} = + {Math.Round(seno)}");
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($" Coseno de {angulo} =" + coseno);
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($" Tangente de {angulo} =" + tangente);
        }
        public void Raiz(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($" Raiz quadrade de {x} = {raiz}");
        }
    }
}