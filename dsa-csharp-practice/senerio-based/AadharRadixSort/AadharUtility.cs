using System;
using System.Collections.Generic;

namespace AadharRadixSort
{
    class AadharUtility : IAadharService
    {
        private List<Aadhar> list = new List<Aadhar>();

        public void AddAadhar(string number)
        {
            list.Add(new Aadhar(number));
        }

        // Stable Radix Sort (LSD)
        public void RadixSort()
        {
            int maxDigits = 12;

            for (int pos = maxDigits - 1; pos >= 0; pos--)
            {
                List<Aadhar>[] buckets = new List<Aadhar>[10];
                for (int i = 0; i < 10; i++)
                    buckets[i] = new List<Aadhar>();

                // Distribute (STABLE)
                foreach (var a in list)
                {
                    int digit = a.Number[pos] - '0';
                    buckets[digit].Add(a);
                }

                // Collect
                list.Clear();
                for (int i = 0; i < 10; i++)
                    list.AddRange(buckets[i]);
            }
        }

        // Binary Search (after sorting)
        public int BinarySearch(string target)
        {
            int low = 0, high = list.Count - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int cmp = string.Compare(list[mid].Number, target);

                if (cmp == 0)
                    return mid;
                else if (cmp < 0)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return -1;
        }

        public void Display()
        {
            foreach (var a in list)
                Console.WriteLine(a);
        }
    }
}
