using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data) 
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public int somar(int val1, int val2)
        {
            var result = val1 + val2;

            listaHistorico.Insert(0, "Res:" + result + " - data: " + data);

            return result;
        }

        public int subtrair(int val1, int val2)
        {
            var result = val1 - val2;

            listaHistorico.Insert(0, "Res:" + result + " - data: " + data);

            return result;
        }

        public int mutiplicar(int val1, int val2)
        {
            var result = val1 * val2;

            listaHistorico.Insert(0, "Res:" + result + " - data: " + data);

            return val1 * val2;
        }

        public int dividir(int val1, int val2)
        {
            var result = val1 / val2;

            listaHistorico.Insert(0, "Res:" + result + " - data: " + data);

            return val1 / val2;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);

            return listaHistorico;
        }
    }
}
