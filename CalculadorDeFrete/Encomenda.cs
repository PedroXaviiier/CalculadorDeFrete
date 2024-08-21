using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorDeFrete
{
    public class Encomenda
    {
        public int ID = 012345;
        public double Peso {  get; set; }
        public int TamanhoTrajetoKM {  get; set; }

        

        public override string ToString()
        {
            return "Ecomenda " + ID + "\n" + 
                    "Tamanho do trajeto: " + TamanhoTrajetoKM + "\n" +
                    "Peso do pacote: " + Peso;
        }
    }
}
