namespace AdventOfCode.HistorianHysteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var leftArray = new List<int>();
            var rightArray = new List<int>();
            var diffArray = new List<int>();
            //var reader = new StreamReader("./NumbersInput.txt", System.Text.Encoding.UTF8, true, 4 * 1024);
            string directory = Directory.GetCurrentDirectory();
            string path = Directory.GetFiles(directory).Where(name => name.Contains("NumbersInput.txt")).FirstOrDefault() ?? "";
            //string path = "./NumbersInput.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var temp = line.ToString().Split("   ");
                    if (temp.Length > 0)
                    {
                        leftArray.Add(int.Parse(temp[0]));
                        rightArray.Add(int.Parse(temp[1]));
                    }
                }
            }
            //Console.WriteLine(reader.ReadToEnd());

            leftArray.Sort();
            rightArray.Sort();

            var indexes = Enumerable.Range(0, leftArray.Count);
            foreach (var index in indexes)
            {
                diffArray.Add( Math.Abs(leftArray[index] - rightArray[index]));
            }

            //Correct answer was 1941353
            int sum = diffArray.Sum();

            Console.ReadKey();
        }
    }


}
