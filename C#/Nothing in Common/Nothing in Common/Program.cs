using System;
using System.Collections.Generic;
using System.Linq;
//https://www.codechef.com/problems/NOTINCOM
namespace Nothing_in_Common {
    class Program {
        static void Main(string[] args) {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
            while (numberOfTestCases-- != 0) {
                int[] numberOfElementsEachHas = ReadSpaceSeperatedNumbersFromConsole();
                int count = 0;
                Dictionary<int, bool> temp = new Dictionary<int, bool>();
                int[] aliceElements = ReadSpaceSeperatedNumbersFromConsole();
                for (int i = 0; i < aliceElements.Length; i++) {
                    temp[aliceElements[i]] = true;
                }

                int[] bertaElements = ReadSpaceSeperatedNumbersFromConsole();

                for (int i = 0; i < bertaElements.Length; i++) {

                    if (temp.ContainsKey(bertaElements[i]))
                        count++;
                }

                Console.WriteLine(count);
            }
        }

        private static int[] ReadSpaceSeperatedNumbersFromConsole() {
            return Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x.TrimEnd().TrimStart())).ToArray();
        }
    }
}
