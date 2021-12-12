using System;
using System.Collections.Generic;
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
    }
}
