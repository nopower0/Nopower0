using Microsoft.HistoricalDebuggerHost;
using System.Collections.Generic;

namespace PDQ
{
    public class SamplePDQ : IProgrammableDataQuery
    {
        public object[] EntryQuery(object thisArg, object[] args)
        {
            return args;
        }

        public object[] ExitQuery(object returnValue)
        {
            return null;
        }

        public List<CollectedValueTuple> FormatCollectedValues(object[] results)
        {
            return new List<CollectedValueTuple>();
        }

        public string FormatLongDescription(object[] results)
        {
            return "Yeah";
        }

        public string FormatShortDescription(object[] results)
        {
            return "Cool";
        }

        public List<Location> GetAlternateLocations(object[] results)
        {
            return null;
        }
    }
}