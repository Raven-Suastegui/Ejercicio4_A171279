﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C_Areas
{
    public class Class1
    {
        public decimal Numero01 { get; set; }
        public decimal Numero02 { get; set; }
        public decimal A_Cuadrado()
        {
            return Numero01 * Numero02;        
        }
        public decimal A_Circulo(decimal N01)
        {
            Numero01 = N01;
            double Pi, N;
            Pi = 3.1416;
            N = Convert.ToDouble (Numero01);
            //Pi = convert.todouble(3.1416);
            return Convert.ToDecimal(Pi * N * N);
        }
        public decimal A_Triangulo(decimal N01, decimal N02)
        {
            Numero01 = N01;
            Numero02 = N02;
            var Resultado = ((N01 * N02) / 2);
            return Resultado;
        }
    }
}