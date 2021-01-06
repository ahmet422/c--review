using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(8.00);
            book.AddGrade(86.1);
            book.AddGrade(81.9);
            book.AddGrade(82.2);
            var expected = (8+86.1+81.9+82.2)/4;
            var stats = book.getStatistics();

            //act
           // stats.average = Math.Round((Double)book.calculateAverage(), 2);

            // assert
            Assert.Equal(expected,stats.average,1);
            Assert.Equal(8.00,stats.lowest,1);
            Assert.Equal(86.1,stats.highest,1);

        }
    }
}
