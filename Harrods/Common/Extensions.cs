using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace Harrods.Common
{
    public static class Extensions
    {
        /// <summary>
        /// Table extension class - AsDictionary method will accept specfow table data
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static IDictionary<string, string> AsDictionary(this Table table)
        {
            var dictionary = new Dictionary<string, string>();
            foreach (var row in table.Rows)
                dictionary.Add(row[0], row[1]);

            return dictionary;
        }
    }
}
