using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double>   list;
        public string Name;


        public Book(string name)
        {
            Name = name;
            this.list =  new List<double>();
        }
        public void AddGrade(double grade)
        {
            list.Add(grade);
            list.Sort();
        }
        public void displayInfo(){
            System.Console.WriteLine($"The lowest grade: {list[0]}");
            System.Console.WriteLine($"The highest grade: {list[list.Count - 1]}");
            System.Console.WriteLine($"The average: {calculateAverage()}");
        }
        public double calculateAverage()
        {
            var result = 0.0;
            list.ForEach(num => result+=num);
            var average = result/list.Count;
            return  average;
            // throw new System.NotImplementedException();
        }

        public double getHighest(){
            list.Sort();
            return this.list[list.Count - 1];
        }

        public double getLowest(){
            return this.list[0];
        }

        public double getAverage(){
            return calculateAverage();
        }

        public Stats getStatistics(){
            var stats = new Stats();
            stats.average = calculateAverage();
            stats.lowest = this.list[0];
            stats.highest = this.list[list.Count - 1];
            return stats;
        }
    }
}