using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Leetcode_day4
{
    public class Testers
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
    internal class Program
    {
        public static List<Testers> PartialRandomlySort(List<Testers> list)
        {
            if (list == null || list.Count == 0) return null;

            var orderedList = list.OrderBy(x => x.Count).ThenBy(x => Guid.NewGuid());
            return orderedList.ToList<Testers>();
        } 
        static void Main(string[] args)
        {
            List<Testers> testers = new List<Testers>()
            {
               new Testers { Name = "A", Count = 1 },
               new Testers { Name = "B", Count = 1 },
               new Testers { Name = "C", Count = 1 },
               new Testers { Name = "D", Count = 2 },
               new Testers { Name = "E", Count = 3 },
               new Testers { Name = "EF", Count = 4 },
               new Testers { Name = "G", Count = 5 },
               new Testers { Name = "H", Count = 6 }
            };

            List<Testers> orderedList = PartialRandomlySort(testers);

            foreach (Testers tester in orderedList)
            {
                Console.Write("(" + tester.Name + ", " + tester.Count + "); ");
            }
        }
    }
}
