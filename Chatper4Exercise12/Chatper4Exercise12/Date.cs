using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatper4Exercise12
{
    
    //Create a class called Date that includes three pieces of information
    //as auto-implemented properties
    class Date
    {
        public Date() : this(10, 28, 2018) { }
        //a month (type int), a day (type int) and a year (type int). 
        //Your class should have a constructor that initializes the three automatic
        // properties and assumes that the values provided are correct.
        public Date(int month, int day, int year)
        {
            Month = month;
            Day = day;
            Year = year;
        }

        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }
        //Provide a method DisplayDate that displays the month, day and year
        public string DisplayDate()
        {    //separated by forward slashes (/)
            return (Month + "/" + Day + "/" + Year);
        }
    }
}
