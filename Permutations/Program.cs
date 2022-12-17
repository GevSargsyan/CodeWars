using System;
using System.Collections.Generic;
using System.Linq;

namespace Permutations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = "All Events";

            var whereQuery = (employee != "" && employee != "All Events") ? employee.Contains("TAR") ? $@" [Calendar].[EventCategory] IN ('NonTrial Appearance', 'Trial/Arbitration')
				         AND [MainScreen].[CASEASSIGNEDTO] IN (SELECT [Employees].[EmployeeName]
                                                              FROM [dbo].[EmployeeByGroup] AS [EmployeeByGroup]
					                                          INNER JOIN [dbo].[Employees] AS [Employees] ON [EmployeeByGroup].[EmployeesID] = [Employees].[EmployeesID]
					                                          INNER JOIN [dbo].[Groups] AS [Groups] ON [EmployeeByGroup].[GroupID] = [Groups].[GroupID]
					                                          WHERE [Groups].[GroupName] = '{employee}') "
                                                          : !employee.Contains("Crew") && !employee.Contains("Squad") ? $" [MainScreen].[CaseAssignedTo] = '{employee}' "
                                                          : $@" [MainScreen].[CASEASSIGNEDTO] IN (SELECT [Employees].[EmployeeName]
							FROM [dbo].[EmployeeByGroupColor] AS [EmployeeByGroupColor]
							INNER JOIN [dbo].[Employees] AS [Employees] ON [EmployeeByGroupColor].[EmployeesID] = [Employees].[EmployeesID]
							INNER JOIN [dbo].[Groups] AS [Groups] ON [EmployeeByGroupColor].[GroupID] = [Groups].[GroupID]
							WHERE [Groups].[GroupName] = '{employee}') " : "1 = 1";









            string[] cars = { "Nissan", "Aston Martin", "Chevrolet", "Alfa Romeo", "Chrysler", "Dodge", "BMW",
                            "Ferrari", "Audi", "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};

            IEnumerable<char> chars = cars.SelectMany(p => p.ToArray());

            var names = new string[] { "Ana", "Raz", "John" };
            var numbers = new int[] { 1, 2, 3 };
            var newList = names.SelectMany(
                x => numbers,
                (y, z) => { return y + z + " test "; });
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
            SinglePermutations("ab");
        }
        public static List<string> SinglePermutations(string word)
        {
            
            var combo = from w in word
                        from w2 in word
                        select new { w, w2 };
          

            return null;
        }
    }
}
