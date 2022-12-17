using System;
using System.Collections.Generic;

namespace calimoverview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = GetClaimFilters(null,new List<long>() { 1,2,3});
        }

        private static string GetClaimFilter(long? providerId = null, long? systemId = null, bool sub = true, string tableAlias = "[C]")
        {
            string result = string.Empty;
            if (systemId.HasValue)
                result = sub
                    ? $"{tableAlias}.[ProviderID] IN (SELECT [ID] FROM [shark].[Provider] [PI] WHERE [PI].[SystemID] = {systemId})"
                    : $"[P].[SystemID] = {systemId}";
            else if (providerId.HasValue)
                result = $"{tableAlias}.[ProviderID] = {providerId}";

            result += $@"
AND {tableAlias}.[IsDeleted] = 0
AND {tableAlias}.[IsQuarantine] = 0
AND ({tableAlias}.[DivisionID] IS NULL OR {tableAlias}.[DivisionID] NOT IN (15, 97))
";

            return result;
        }
        private static string GetClaimFilters(List<long> providerIds, List<long> systemIds = null, bool sub = true, string tableAlias = "[C]")
        {
            string result = string.Empty;
            if (systemIds?.Count>0)
                result = sub
                    ? $"{tableAlias}.[ProviderID] IN (SELECT [ID] FROM [shark].[Provider] [PI] WHERE [PI].[SystemID] IN ({string.Join(',', systemIds)}))"
                    : $"[P].[SystemID] = {systemIds}";
            else if (providerIds?.Count > 0)
                result = $"{tableAlias}.[ProviderID] IN ({string.Join(',',providerIds)})";

            result += $@"
AND {tableAlias}.[IsDeleted] = 0
AND {tableAlias}.[IsQuarantine] = 0
AND ({tableAlias}.[DivisionID] IS NULL OR {tableAlias}.[DivisionID] NOT IN (15, 97))
";

            return result;
        }

    }
}
