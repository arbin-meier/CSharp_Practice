using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_day5
{
    /* All the possible Power that will appear in the supportedPower list.
     * Reference Enum {
     *      10V,
     *      30V,
     *      50V,
     *      110V,
     *      220V,
     *      300V
     * }
     */
    public class TestStation
    {
        public List<string> supportedPower;
        public string MachineName { get; set; }
        public string Name { get; set; }
    }

    public class Machine
    {
        public string Power { get; set; }
        public string Name { get; set; }
    }

    internal class Program
    {
        /// <summary>
        /// Find the maximum number of pairs of matching testStation and machine,
        /// in which function the MachineName of TestStations List is implicity changed,
        /// while Machines List is left without modification.
        /// </summary>
        /// <param name="testStations"></param>
        /// <param name="machines"></param>
        /// <returns>Returns the number of Machines newly added into the testStations</returns>
        public static int Arrange(ref List<TestStation> testStations, in List<Machine> machines)
        {
            if (testStations == null || !testStations.Any() || machines == null || !machines.Any())
            {
                Console.WriteLine("list is empty");
                return 0;
            }

            bool[,] bipartiteGraph = BooleanGraphCreater(testStations, machines);

            //The value of matched[i] is the machine number assgined to testStation i;
            //the value -1 indicates no machine is assigned;
            int result = 0;
            int[] matched = new int[testStations.Count];

            for (int i = 0; i < machines.Count; i++)
                matched[i] = -1;

            for (int testStation = 0; testStation < testStations.Count; testStation++)
            {
                bool[] visited = new bool[machines.Count];
                for (int i = 0; i < machines.Count; i++)
                    visited[i] = false;

                if (BipartiteMatching(bipartiteGraph, testStation, visited,
                                      matched, ref testStations, machines))
                    result++; 
            }

            return result;
        }

        /// <summary>
        /// A DFS helper function that will be used recursively
        /// </summary>
        /// <param name="bipartiteGraph"></param>
        /// <param name="testStation"></param>
        /// <param name="visited"></param>
        /// <param name="matched"></param>
        /// <param name="testStations"></param>
        /// <param name="machines"></param>
        /// <returns>return true if a matching for testStation u is possible</returns>
        public static bool BipartiteMatching(bool[,] bipartiteGraph, int testStation, bool[] visited, 
                                             int[] matched, ref List<TestStation> testStations, in List<Machine> machines)
        {
            for (int machine = 0; machine < machines.Count; machine++)
            {
                if (bipartiteGraph[testStation, machine] && !visited[machine])
                {
                    visited[machine] = true;
                    if (matched[machine] < 0 || BipartiteMatching(bipartiteGraph, matched[machine], 
                        visited, matched, ref testStations, machines))
                    {
                        matched[machine] = testStation;
                        testStations[testStation].MachineName = machines[machine].Name; 
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Create Bipartite Mapping Matrix of dimension MxN according to the passed-in 
        /// lists of TestStations and Machines. Where the number of rows indicates the 
        /// number of Teststations[M], and noumber of columns indicates the number of machines[N].
        /// </summary>
        /// <param name="testStations"></param>
        /// <param name="machines"></param>
        /// <returns></returns>
        public static bool[,] BooleanGraphCreater(in List<TestStation> testStations, in List<Machine> machines) 
        {
            bool[,] bipartiteGraph = new bool[testStations.Count, machines.Count];

            for (int i = 0; i < testStations.Count; i++)
            {
                for (int j = 0; j < machines.Count; j++)
                {
                    //Mapping Machines to suitable TestStations at the same time
                    //check if the TestStation is already assigned with task
                    if (testStations[i].supportedPower.Contains(machines[j].Power)
                        && String.IsNullOrEmpty(testStations[i].MachineName))
                        bipartiteGraph[i, j] = true;
                    else bipartiteGraph[i, j] = false;
                }
            }

            return bipartiteGraph;
        }

        static void Main(string[] args)
        {
            List<TestStation> testStations = new List<TestStation>()
            {
                new TestStation() { Name = "T0", supportedPower = new List<string> {"10V", "110V"} },
                new TestStation() { Name = "T1", supportedPower = new List<string> {"10V", "30V", "110V"} },
                new TestStation() { Name = "T2", supportedPower = new List<string> {"300V", "220V"} },
                new TestStation() { Name = "T3", supportedPower = new List<string> {"10V", "50V", "300V"} },
                new TestStation() { Name = "T4", supportedPower = new List<string> {"50V", "110V"} },
                new TestStation() { Name = "T5", supportedPower = new List<string> {"110V", "220V"}, MachineName = "M101" }
            };

            List<Machine> machines = new List<Machine>()
            {
                new Machine() { Name = "M0", Power = "220V" },
                new Machine() { Name = "M1", Power = "110V" },
                new Machine() { Name = "M2", Power = "30V" },
                new Machine() { Name = "M3", Power = "110V" },
                new Machine() { Name = "M4", Power = "50V" },
                new Machine() { Name = "M5", Power = "10V"}
            };

            int result = Arrange(ref testStations, machines);

            foreach(var testStation in testStations)
            {
                Console.Write("(" + testStation.Name + ", " + testStation.MachineName + "), ");
            }

            Console.WriteLine("Maximum matching number is: " + result);
        }
    }
}
