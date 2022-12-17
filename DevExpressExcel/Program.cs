using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Spreadsheet;

namespace DevExpressExcel
{
    public class MyClass
    {
        public string insurer { get; set; }
        public string provider { get; set; }
        public int numberOfClaims { get; set; }
        public int sumOfGrossReferral { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MyClass> list = new List<MyClass>();
            MyClass [] data = new MyClass[]
            {
                new MyClass{insurer = "BLUE SHIELD HMO Sr" ,provider = "FRESNO COMMUNITY HOSPITAL",numberOfClaims = 1, sumOfGrossReferral = 9000000 },
                new MyClass{insurer = "BLUE SHIELD OF CALIFORNIA HMO" ,provider = "WEST HILLS RETIREMENT CENTER",numberOfClaims = 1, sumOfGrossReferral = 4534563 },
                new MyClass{insurer = "New Mexico Medicaid" ,provider = "KINDRED HOSPITAL - SAN DIEGO",numberOfClaims = 1, sumOfGrossReferral = 890000 },
                new MyClass{insurer = "Cherokee Insurance Company" ,provider = "ANAHEIM MEMORIAL MEDICAL CENTER (MEDI-CAL)",numberOfClaims = 1, sumOfGrossReferral = 860000 },
                new MyClass{insurer = "A Very New Insurer" ,provider = "ALAMEDA HEALTH SYSTEM",numberOfClaims = 6, sumOfGrossReferral = 689150 },
                new MyClass{insurer = "Magellan Behavioral Health" ,provider = "Arizona Regional Medical Center",numberOfClaims = 1, sumOfGrossReferral = 498000 },
                new MyClass{insurer = "Blue Shield" ,provider = "MERCY HOSPITAL & HEALTH SERVICES",numberOfClaims = 1, sumOfGrossReferral = 250000 },
                new MyClass{insurer = "Blue Shield" ,provider = "FAC1",numberOfClaims = 1, sumOfGrossReferral = 250000 },
                new MyClass{insurer = "Herritage IPA" ,provider = "TWO LFC PROVIDER",numberOfClaims = 1, sumOfGrossReferral = 234433 },
                new MyClass{insurer = "Adventist Health Group" ,provider = "MERCY HOSPITAL & HEALTH SERVICES",numberOfClaims = 1, sumOfGrossReferral = 220000 },
            };

            list.AddRange(data);


            var providers = list.Select(x => x.provider).Distinct();
            var insurers = list.GroupBy(x => x.insurer).Select((x,i)=>new {Index = i,Insurer = x.Key}).ToList();




        }
    }
}

