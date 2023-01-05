using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_day3
{
    internal class Program
    {
        #region Meier
        //public static void Arrange(ref int[] array, in int k)
        //{
        //    int startIdx = 0;
        //    int endIdx = array.Length - 1; 
        //    int pivotIdx;
        //    int requiredNum; 
        //    int availableNum = k;

        //    if (array.Length == 0 || array == null || k < 1) return;

        //    while (availableNum > 0)
        //    {
        //        pivotIdx = startIdx + (endIdx - startIdx + 1) / 2;

        //        //pick pivots to reach (nlogn) time complexity
        //        //if k is not huge, this for loop will take main control
        //        for (int i = 0; i < pivotIdx; i++)
        //        {
        //            requiredNum = array[pivotIdx] - array[i];
        //            if (requiredNum <= 0) continue;

        //            if (availableNum > requiredNum)
        //            {
        //                array[i] += requiredNum;
        //                availableNum -= requiredNum;
        //            }
        //            else
        //            {
        //                array[i] += availableNum;
        //                return;
        //            }
        //        }
        //        startIdx = pivotIdx;

        //        //last loop if available machine has remaining after fulfill all slots
        //        if (pivotIdx == array.Length - 1 && availableNum > 0)
        //        {
        //            int remainNum = availableNum % array.Length;
        //            requiredNum = availableNum / array.Length;
        //            for (int i = 0; i < array.Length; i++)
        //            {
        //                if (remainNum > 0)
        //                    array[i] += requiredNum + 1;
        //                else array[i] += requiredNum;
        //                remainNum -= 1;
        //            }
        //            return;
        //        }
        //    }
        //}
        #endregion

        /// <summary>
        /// Reference to Rongyu
        /// </summary>
        /// <param name="array"></param>
        /// <param name="k"></param>
        public static void Arrange(int[] array, int k)
        {
            //Corner Case
            if (array == null || array.Length == 0 || k <= 0)
            {
                return;
            }

            int startIndex = 0;
            while (k > 0)
            {
                //Find Last Occurance of Min Value [startIndex, length)
                startIndex = FindLastMinIndex(array, startIndex);

                //Find the difference 
                int nextValue = Math.Max(array[0] + (k / (startIndex + 1)), array[0] + 1);
                if (startIndex + 1 < array.Length)
                {
                    nextValue = Math.Min(array[startIndex + 1], nextValue);
                }
                int difference = nextValue - array[0];

                //Add difference [0, startIndex]
                for (int i = startIndex; i >= 0; i--)
                {
                    if (k == 0)
                    {
                        return;
                    }
                    array[i] += difference;
                    k -= difference;
                }
            }
        }

        public static int FindLastMinIndex(int[] array, int startIndex)
        {
            //Iteration
            int endIndex = array.Length - 1;
            for (int i = startIndex; i < endIndex; i++)
            {
                if (array[i] < array[i + 1])
                {
                    return i;
                }
            }
            return endIndex;
        }

        static void Main(string[] args)
        {
            int[] testers = new int[] { 0,0,0,0,0,0,0,0};
            int machineOnWait = 9;

            //Arrange(ref testers, machineOnWait);
            Arrange(testers, machineOnWait);


            Console.Write("Testers' final outputs are: ");
            foreach (int member in testers)
                Console.Write(member + " ");

        }
    }
}
