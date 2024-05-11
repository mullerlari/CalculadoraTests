using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listahistorico;
        private string data;

        public Calculadora(string data)
        {
            listahistorico = new List<string>();
            this. data = data;
        }
        public int somar(int val1, int val2)
        {
            int res = val1 + val2;

            listahistorico.Insert(0, "Resultado: " + res + " - data: "  + data);

            return res;
        }
        public int subtrair(int val1, int val2)
        {

            int res = val1 - val2;
            listahistorico.Insert(0, "Resultado: " + res + " - data: " + data);
            return res;
        }
        public int multiplicar(int val1, int val2)
        {

            int res = val1 * val2;
            listahistorico.Insert(0, "Resultado: " + res + " - data: " + data);
            return res;
        }
        public int dividir(int val1, int val2)
        {

            int res = val1 / val2;
            listahistorico.Insert(0, "Resultado: " + res + " - data: " + data);
            return res;
        }
        public List<string> historico()
        {
            
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }
       
            
    }
}
