using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook:BaseGradeBook
    {
        /*
            Create a StandardGradeBook class that inherits the BaseGradeBook class

            This should be located in the GradeBooks directory.
            This should use the GradeBook.GradeBooks namespace.

            Create a constructor for the StandardGradeBook class that accepts a string parameter called "name".
            This constructor is required to invoke a constructor from BaseGradeBook.
            This can be done by adding : base(name) after the constructor declaration. 
            (this will make it so when the StandardGradeBook constructor is called it will execute code in both StandardGradeBook's constructor as well as the BaseGradeBook's constructor)

            Update StandardGradeBook 's Type

            Create a constructor for StandardGradeBook  that sets the Type property to GradeBookType.Standard.
         
         */
        public StandardGradeBook(string name, bool isWeighted):
            base(name, isWeighted)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}
