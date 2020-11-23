using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Operaciones
    { 
        float resultado, memoria;
        string operador, mensaje;
        public float Resultado
        {
            get { return resultado;  }
            set { resultado = value;  }

        }
        public float Memoria
        {
            get { return memoria;  }
            set { memoria = value;  }
        }
        public string Operador
        {
            get { return operador; }
            set { operador = value; }
        }

        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        public void Multiplicar()
        {
            Resultado = Memoria * Resultado;
        }
        public void Dividir()
        {
            if (Resultado != 0)
                Resultado = Memoria / Resultado;
            else
                Mensaje = "Error";
        }
        public void Sumar()
        {
            Resultado = Memoria + Resultado;
        }
        public void Restar()
        {
            Resultado = Memoria - Resultado;
        }
        public void Invertir()
        {
            Resultado = 1 / Resultado;
        }
        public void Sacar_Raiz()
        {
            Resultado = Convert.ToSingle(Math.Sqrt(Convert.ToDouble(Resultado)));
        }
        public void Elevar_Al_Cuadrado()
        {
            Resultado = Resultado * Resultado;
        }
        public void Elevar_Al_Cubo()
        {
            Resultado = Resultado * Resultado * Resultado;
        }
        public void Sacar_Potencia()
        {
            Resultado = Resultado * Memoria;
        }
        public void Pai()
        {
            Resultado = Convert.ToSingle(Resultado * 3.1415);    
        }
        public void Sacar_Seno()
        {
            Resultado = Convert.ToSingle(Math.Sin(Resultado));
        }
        public void Sacar_Coseno()
        {
            Resultado = Convert.ToSingle(Math.Cos(Resultado));
        }
        public void Sacar_Tangente()
        {
            Resultado = Convert.ToSingle(Math.Tan(Resultado));
        }
        public void Sacar_Secante()
        {
            Resultado = Convert.ToSingle(1 / (Math.Cos(Resultado)));
        }
        public void Sacar_Cosecante()
        {
            Resultado = Convert.ToSingle(1 / (Math.Sin(Resultado)));
        }
        public void Sacar_Cotangente()
        {
            Resultado = Convert.ToSingle(1 / (Math.Tan(Resultado)));
        }
        public void Valor_Absoluto()
        {
            Resultado = Math.Abs(Resultado);
        }
        public void Sacar_Factorial()
        {
            for (int f = 0; f <= Memoria; f++)
            {
                Resultado *= f;
            }
        }
        public void Logaritmo()
        {
            Resultado = Convert.ToSingle(Math.Log(Memoria));
        }
        public void Logaritmo_Natural()
        {

        }
        public void e()
        {
            Resultado = Convert.ToSingle(Math.Exp(Resultado));
        }
        public void Mod()
        {
            Resultado = Resultado % Memoria;
        }

        public void EvaluarOperaciones()
        {
            switch (Operador)
            {
                case "+":
                    Sumar();
                    break;
                case "-":
                    Restar();
                    break;
                case "/":
                    Dividir();
                    break;
                case "x":
                    Multiplicar();
                    break;
                case "1/x":
                    Invertir();
                    break;
                case "sqr":
                    Sacar_Raiz();
                    break;
                case "cua":
                    Elevar_Al_Cuadrado();
                    break;
                case "cub":
                    Elevar_Al_Cubo();
                    break;
                case "pot":
                    Sacar_Potencia();
                    break;
                case "pi":
                    Pai();
                    break;
                case "sin":
                    Sacar_Seno();
                    break;
                case "cos":
                    Sacar_Coseno();
                    break;
                case "tan":
                    Sacar_Tangente();
                    break;
                case "sec":
                    Sacar_Secante();
                    break;
                case "csc":
                    Sacar_Cosecante();
                    break;
                case "cot":
                    Sacar_Cotangente();
                    break;
                case "|x|":
                    Valor_Absoluto();
                    break;
                case "n!":
                    Sacar_Factorial();
                    break;
                case "log":
                    Logaritmo();
                    break;
                case "ln":
                    Logaritmo_Natural();
                    break;
                case "e":
                    e();
                    break;
                case "mod":
                    Mod();
                    break;
                default:
                    break;
            }
        }
    }
}
