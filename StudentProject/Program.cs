using System;

namespace StudentProject {
    class Program {
        static void Main(string[] args) {

            //Add Brailee as a student
            Student brailee = new Student();
            brailee.firstName = "Brailee";
            brailee.isPaid = true;
            brailee.birthdate = new DateTime(1990, 01, 01);

            // Add Jesse as a student
            Student jesse = new Student();
            jesse.firstName = "Jesse";
            jesse.lastName = "Kyle";
            jesse.isPaid = true;
            jesse.birthdate = new DateTime(1990, 1, 1);

            // Add Titus as a student
            Student titus = new Student();
            titus.firstName = "Titus";
            titus.lastName = "Moore";
            titus.isPaid = true;
            titus.birthdate = new DateTime(2001, 04, 09);

            // Concat Name and Console.WriteLine();
            string name = titus.firstName + " " + titus.lastName;
            Console.WriteLine(name);

            // Add John as a student
            Student john = new Student();
            john.firstName = "John";
            john.isPaid = false;
            john.state = "California";
            john.birthdate = new DateTime(1999, 05, 01, 12, 30, 00);

        }
        class Student {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string address { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string zip { get; set; }
            public string bootcamp { get; set; }
            public string status { get; set; } // current, future, past
            public string email { get; set; }
            public string phone { get; set; }
            public bool isPaid { get; set; } = false;
            public DateTime birthdate { get; set; }

            public Student() {
            }
        }
    }
}
