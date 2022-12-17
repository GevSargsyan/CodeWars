using System;

namespace Ternary_Operator
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

            // {(((OutgoingMailsReportOptions)Model).IsShowUnProcess ? "" : " AND ISNULL([L].[IsProcessed], 0) = 1 ")}
        }
    }
}
