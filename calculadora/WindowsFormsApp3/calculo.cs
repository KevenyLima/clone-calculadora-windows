using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp3
{
    class calculo
    {
        public int Calculadora(int parcela, int parcela2,string operacao)
        {
            if (operacao == "+")
            {
                int final = parcela + parcela2;
                return final;
            }
            else if (operacao == "-")
            {
                int final = parcela - parcela2;
                return final;
            }
            else if (operacao == "/")
            {
                int final = parcela / parcela2;
                return final;
            }
            else if (operacao == "*")
            {
                int final = parcela * parcela2;
                return final;
            }
            else
            {
                return -1;
            }
        }
    }
}

