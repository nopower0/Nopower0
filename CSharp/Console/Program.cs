using Microsoft.HistoricalDebuggerHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestPDQ;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Sample.Write("Writing to console...");
            Sample.Write("Hello World!");
            Sample.Write("Writing complete.");
        }
    }
}