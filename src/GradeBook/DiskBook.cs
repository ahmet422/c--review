using System.IO;

namespace GradeBook
{
    internal class DiskBook : Book
    {
        public DiskBook(string name) : base(name)
        {
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText($"{Name}.txt")) 
            {
                writer.WriteLine(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new System.EventArgs());
                }
            }
        }

        public override void displayInfo()
        {
            var stats = getStatistics();
            System.Console.WriteLine($"For the gradeBook with name {this.Name}");
            System.Console.WriteLine($"The lowest grade: {stats.Lowest}");
            System.Console.WriteLine($"The highest grade: {stats.Highest}");
            System.Console.WriteLine($"The average: {stats.Average:N1}");
            System.Console.WriteLine($"The letter grade is {stats.Letter}");
        }

        public override Stats getStatistics()
        {
            var result = new Stats();

            using(var reader = File.OpenText($"{Name}.txt"))
            {
                var line = reader.ReadLine();
                while(line != null)
                {
                    var number = double.Parse(line);
                    result.Add(number);
                    line = reader.ReadLine();
                }
            }
            return result;
        }
    }
}