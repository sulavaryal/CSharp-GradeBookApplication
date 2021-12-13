using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook:BaseGradeBook
    {

        /*
            Create RankedGradeBook Class

            Create a new class RankedGradeBook that inherits the BaseGradeBook class.

            This should be located in the GradeBooks directory.
            This should use the GradeBook.GradeBooks namespace.

            Create a constructor for the RankedGradeBook class that accepts a string parameter called "name". 
            This constructor is required to invoke a constructor from BaseGradeBook. 
            This can be done by adding : base(name) after the constructor declaration. 
            (this will make it so when the RankedGradeBook constructor is called it will execute code in both RankedGradeBook's constructor as well as the BaseGradeBook's constructor)

            Update RankedGradeBook's Type

            Create a constructor for RankedGradeBook that sets the Type property to GradeBookType.Ranked.
         
         */

       
         
         
        public RankedGradeBook(string name):base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        /*
           Create GetLetterGrade Override

           In the RankedGradeBook class create an override for the GetLetterGrade method.

           The GetLetterGrade method returns a char and accepts a double named "averageGrade".

           If there are less than 5 students throw an InvalidOperationException. (Ranked-grading requires a minimum of 5 students to work)

           Return 'F' at the end of the method.
       */

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5) 
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");
            }

            // Top 20 percent of the number of total students in class 
            var top20percent = (int)Math.Ceiling(Students.Count * (0.20));

            // Take all your students avg grade, put it in descending order         
            var grades = Students.OrderByDescending(s => s.AverageGrade)
                .Select(s=>s.AverageGrade).ToList();

            if (grades[top20percent -1 ] <= averageGrade)
                return 'A';
            else if (grades[(top20percent * 2) - 1] <= averageGrade)
                return 'B';
            else if (grades[(top20percent * 3) -1] <= averageGrade)
                return 'C';
            else if (grades[(top20percent * 4) - 1] <= averageGrade)
                return 'D';
            else
                return 'F';
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5) 
            {
                Console.WriteLine(@"Ranked grading requires at least 5 students with 
                            grades in order to properly calculate a student's overall grade.");
                return;
            }
            base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine(@"Ranked grading requires at least 5 students with grades
                                in order to properly calculate a student's overall grade.");
                return;
            }
            base.CalculateStudentStatistics(name);
        }

    }
}
