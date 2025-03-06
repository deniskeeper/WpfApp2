using System;
using System.Collections.Generic;

namespace WpfApp2
{
    public class NumberManager
    {
        private List<int> numbers;

        public NumberManager()
        {
            numbers = new List<int>();
        }



        public void Fill(int n)
        {
            numbers.Clear();
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                numbers.Add(rand.Next(0, 100));//комм
            }
        }



        public int CalculateDifference()
        {
            if (numbers.Count < 2) return 0;
            int max = int.MinValue;
            int min = int.MaxValue;

            foreach (var num in numbers)
            {
                if (num > max) max = num;
                if (num < min) min = num;
            }

            return max - min;
        }

        public void Clear()
        {
            numbers.Clear();
        }
    }

}