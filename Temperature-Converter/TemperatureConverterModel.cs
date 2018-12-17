using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProgHW1
{
    public class TemperatureConverterModel {
        public double FahrTemp { get; set; }
        public double CelsTemp { get; set; }
        public double KelvTemp { get; set; }

        public TemperatureConverterModel()
        {
            FahrTemp = 0;
            CelsTemp = 0;
            KelvTemp = 0;
         
        }

        public void convertFromFahr(double fahr)
        {
            FahrTemp = fahr;
            CelsTemp = (FahrTemp - 32) / 1.8;
            KelvTemp = CelsTemp + 273.15;

        }

        public void convertFromCels(double cels)
        {
            CelsTemp = cels;
            FahrTemp = (1.8 * CelsTemp) + 32;
            KelvTemp = CelsTemp + 273.15;

        }

        public void convertFromKelv(double kelv)
        {
            KelvTemp = kelv;
            CelsTemp = KelvTemp - 273.15;
            FahrTemp = (1.8 * CelsTemp) + 32;
            
        }


    }
}
