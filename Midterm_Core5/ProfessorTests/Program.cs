using System;

using ProfessorClasses;

namespace ProfessorTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestProgramConstructors();
            TestProgramToString();
            TestProgramGetters();
            TestProgramPropertySetters();

            static void TestProgramConstructors()

            {
                Professor p1 = new Professor();
                Professor p2 = new Professor(1, "Phil", "Miller", "Biology", "L00817419");

                Console.WriteLine("Testing both constructors");
                Console.WriteLine("Default constructor.  Expecting default values. " + p1.ToString());
                Console.WriteLine("Overloaded constructor.  Expecting 1, bob, miller  " + p2.ToString());
                Console.WriteLine();
            }
            static void TestProgramToString()
            {
                Program p1 = new Professor(1, "Phil", "This is a test class", "Biology", "L00817419");

                Console.WriteLine("Testing ToString");
                Console.WriteLine("Expecting L00817419, Phil, Miller, This is a test class, L00817419 " + p1.ToString());
                Console.WriteLine("Expecting L00817419, Phil, Miller, This is a test class, L00817419 " + p1);
                Console.WriteLine();
            }
            static void TestProgramGetters()
            {
                Program p1 = new Professor(00817419, "Phil", "This is a test class", "Biology");

                Console.WriteLine("Testing getters");
                Console.WriteLine("Id.  Expecting 1. " + p1.id);
                Console.WriteLine("firstName.  Expecting Phil. " + p1.firstName);
                Console.WriteLine("lastName.  Expecting This is a test Class. " + p1.lastName);
                Console.WriteLine("teachingSubject.  Expecting Biology. " + p1.teachingSubject);
                Console.WriteLine();
            }
            static void TestProgramPropertySetters()
            {
                Program p1 = new Professor(00817419, "Phil", "This is a test classs", "Biology");

                Console.WriteLine("Testing setters");
                p1.id = 00817419;
                p1.firstName = "Phil";
                p1.lastName = "Miller";
                p1.teachingSubject = "Biology";
                Console.WriteLine("Expecting L00817419, Phil, Miller,Biology, 5411234567 " + p1);
                Console.WriteLine();
            }
        }
    }
}
