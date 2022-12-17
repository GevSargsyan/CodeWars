using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SelectNonNullValuesFromObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Model model1 = new Model() { Address = "Address", FirstName = "G", LastName = null, Age = 2 };
            Model model2 = new Model() { Address = "Address2", FirstName = "G2", LastName = null, Age = 2 };
            Model model3 = new Model() { Address = "Address3", FirstName = "G3", LastName = null, Age = 2 };
            Model model4 = new Model() { Address = "Address4", FirstName = "G4", LastName = null, Age = 2 };


            List<Model> list = new List<Model>();

            list.Add(model1);
            list.Add(model2);
            list.Add(model3);
            list.Add(model4);
            var x = list.Select(x => x.LastName);


            var test = list
               .Select(x => x.GetType().GetProperty("Address").GetValue(x))
               .Cast<string>()
               .ToList();



            void GetListOfProperty(string property)
            {
                var p = list.GetType().GetProperties();

                var test = list
                   .Select(x => x.GetType().GetProperty(property, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance).GetValue(x))
                   .ToList();

            }

        }



    }



    class Model
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  Address { get; set; }
    }
}
