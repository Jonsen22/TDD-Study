using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace Calculadora
{
    public class CalculadoraTest
    {
        private List<string> listaHistorico;
        private string _data;
      

        public CalculadoraTest(string data)
        {
            listaHistorico = new List<string>();
            _data = data;
        }

        public int somar(int val1, int val2)
        {
            int res = val1 + val2;

            listaHistorico.Insert(0, "Res: " + res + " - data:" + _data);
            return res;
        }

        public int subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            listaHistorico.Insert(0, "Res: " + res + " - data:" + _data);
            return res;
        }

        public int multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            listaHistorico.Insert(0, "Res: " + res + " - data:" + _data);
            return res;

        }

        public int dividir(int val1, int val2)
        {
            int res = val1 / val2;
            listaHistorico.Insert(0, "Res: " + res + " - data:" + _data);
            return res;
        }

        public List<string> historico()
        {

            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}
