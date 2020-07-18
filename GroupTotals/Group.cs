using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GroupTotals
{
    public class Group
    {
        public string GroupTotals(string[] strArr)
        {
            var dicc = new Dictionary<string, int>();

            foreach (var item in strArr)
            {
                var convert = item.Split(':');
                if (dicc.ContainsKey(convert[0]))
                {
                    dicc[convert[0]] += int.Parse(convert[1]);

                }
                else
                {
                    dicc.Add(convert[0], int.Parse(convert[1]));
                }
                
            }

            var output = dicc.Where(x => x.Value != 0).Select(x => x.Key + ":" + x.Value).ToList();
            output.Sort();
            return string.Join(",", output);
             
        }
    }
}
