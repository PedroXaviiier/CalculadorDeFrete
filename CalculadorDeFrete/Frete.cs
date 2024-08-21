using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorDeFrete
{
    public class Frete
    {
        double TaxaTotal { get; set; }
        double TaxaKM { get; set; }
        double TaxaPeso { get; set; }


        public double CalcularTaxas(int distancia, double peso)
        {
            TaxaKM = TaxaKM + (distancia * 0.10);

            if (distancia >= 200)
            {
                TaxaKM = TaxaKM + ((distancia / 200) * 1);
            }

            if (distancia >= 1000)
            {
                TaxaKM = TaxaKM + ((distancia / 1000) * 10);
            }

            if (peso > 5 && peso <= 25)
            {
                TaxaTotal = TaxaKM * 5;
            }

            else if (peso > 25 && peso <= 75)
            {
                TaxaTotal = TaxaKM * 3;
            }

            else if (peso == 5)
            {
                TaxaTotal = TaxaKM;   
            }


            return TaxaTotal;
        }

        
    }
}

