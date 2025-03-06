using System.IO;
using System.Collections.Generic;

namespace WpfApp2
{
    public class FileManager
    {
        public void Save(string filePath, List<int> numbers)
        {
            File.WriteAllLines(filePath, numbers.ConvertAll(num => num.ToString()));
        }

        public List<int> Open(string filePath)
        {
            var numbers = new List<int>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                if (int.TryParse(line, out int number))
                {
                    numbers.Add(number);
                }
            }
            return numbers;
        }
    }
}