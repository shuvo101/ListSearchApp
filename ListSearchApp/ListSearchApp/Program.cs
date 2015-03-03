using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSearchApp
{
   public class Program
    {
        public static void Main()
        {
            Country country1 = new Country(){Code = "ASU", Name = "AUSTRAILA", Capital = "Canberra"};
            Country country2 = new Country(){Code = "BAN", Name = "BANGLADESH", Capital = "Dhaka"};
            Country country3 = new Country(){Code = "IND", Name = "USA", Capital = "Washington D.C."};
            Country country4 = new Country(){Code = "GBR", Name = "UNITED STATES", Capital = "London"};
            Country country5 = new Country(){Code = "CAN", Name = "CANADA", Capital = "Ottawa"};
            
            List<Country> listCountries = new List<Country>();
            listCountries.Add(country1);
            listCountries.Add(country2);
            listCountries.Add(country3);
            listCountries.Add(country4);
            listCountries.Add(country5);

            Console.WriteLine("Plese Enter Country Code :");
            string strCountryCode = Console.ReadLine().ToUpper();

            Country resultCountry = listCountries.Find(country => country.Code == strCountryCode);

            if (resultCountry == null)
            {
                Console.WriteLine("Country Code is not Valis ! ");
            }
            else
            {
                Console.WriteLine("Name = {0}, Capital = {1}", resultCountry.Name, resultCountry.Capital);
            }
        }
    }

   public class Country
   {
       public string Name { get; set; }
       public string Code { get; set; }
       public string Capital { get; set; }
   }
}

