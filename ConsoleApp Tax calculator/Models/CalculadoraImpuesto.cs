using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tax_calculator.Models
{
    public class CalculadoraImpuesto
    {
        public float getTaxRate(string pais)
        {
            float precioImpuesto = 0;
            switch (pais)
            {
                case "Estados Unidos":
                    precioImpuesto = getUSTax();
                    break;

                case "China":

                    precioImpuesto = getCHTax();
                    break;

                case "España":

                    precioImpuesto = getEUTax();
                    break;
                        
                default:

                    break;
            }

            return precioImpuesto;
        }

        private float getUSTax()
        {
            return 0.07f;
        }

        private float getCHTax()
        {
            return 0;
        }

        private float getEUTax()
        {
            return 0.20f;
        }

        
    }
}
