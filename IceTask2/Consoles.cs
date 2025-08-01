using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask2
{
    public class Consoles
    {
        string ConsoleName, ConsoleBrand, ConsolePerformance;
        int ConsoleAge, ConsolePrice;

        public Consoles(string ConsoleName, int ConsoleAge, string ConsoleBrand, int ConsolePrice, string ConsolePerformance)
        {
            this.ConsoleName = ConsoleName;
            this.ConsoleAge = ConsoleAge;
            this.ConsoleBrand = ConsoleBrand;
            this.ConsolePrice = ConsolePrice;
            this.ConsolePerformance = ConsolePerformance;
        }
    public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.ConsoleName;
                else if (index == 1)
                    return this.ConsoleAge;
                else if (index == 2)
                    return this.ConsoleBrand;
                else if (index == 3)
                    return this.ConsolePrice;
                else if (index == 4)
                    return this.ConsolePerformance;
                return null;
            }
            set
            {
                if(index == 0)
                    this.ConsoleName = (string)value;
                else if (index == 1)
                    this.ConsoleAge = (int)value;
                else if (index == 2)
                    this.ConsoleBrand = (string)value;
                else if(index == 3)
                    this.ConsolePrice = (int)value;
                else if(index == 4)
                    this.ConsolePerformance = (string)value;
            }
        }
        public object this[string query]
        {
            get
            {
                if (query == "ConsoleName")
                    return this.ConsoleName;
                else if (query == "ConsoleAge")
                    return this.ConsoleAge;
                else if (query == "ConsoleBrand")
                    return this.ConsoleBrand;
                else if (query == "ConsolePrice")
                    return this.ConsolePrice;
                else if (query == "ConsolePerformance")
                    return this.ConsolePerformance;
                return null;
            }
            set
            {
                if(query.ToLower().Equals("ConsoleName"))
                    this.ConsoleName= (string)value;
                else if(query.ToLower().Equals("ConsoleAge"))
                    this.ConsoleAge= (int)value;
                else if(query.ToLower().Equals("ConsoleBrand"))
                    this.ConsoleBrand= (string)value;
                else if (query.ToLower().Equals("ConsolePrice"))
                    this.ConsolePrice = (int)value;
                else if (query.ToLower().Equals("ConsolePerformance"))
                    this.ConsolePerformance = (string)value;
            }
        }
    }
}
