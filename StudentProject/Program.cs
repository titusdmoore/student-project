using System;

namespace StudentProject {
    class Program {
        static void Main(string[] args) {

            //Add Brailee as a student
            Student brailee = new Student();
            brailee.firstName = "Brailee";
            brailee.setStatus("CURRENT");
            Console.WriteLine($"Brailee's status is: {brailee.status}");
            brailee.isPaid = true;
            brailee.birthdate = new DateTime(1990, 01, 01);

            // Add Jesse as a student
            Student jesse = new Student();
            jesse.firstName = "Jesse";
            jesse.setStatus("past");
            jesse.lastName = "Kyle";
            jesse.isPaid = true;
            jesse.birthdate = new DateTime(1990, 1, 1);

            // Add Titus as a student
            Student titus = new Student();
            titus.firstName = "Titus";
            titus.setCreditScore(500);
            titus.lastName = "Moore";
            titus.isPaid = true;
            titus.birthdate = new DateTime(2001, 04, 09);
            Console.WriteLine($"Titus's credit score is: {titus.creditScore}");
            // Concat Name and Console.WriteLine();
            string name = titus.firstName + " " + titus.lastName;
            Console.WriteLine(name);

            // Add John as a student
            Student john = new Student();
            john.firstName = "John";
            john.isPaid = false;
            john.state = "California";
            // Using the datetime constructor
            john.birthdate = new DateTime(1999, 05, 01, 12, 30, 00);
            john.bootcamp = ".Net";
            john.status = "future";

            // Adding Alex Chan using the new Student constructor
            Student alex = new Student("Alex", "Chan");

            // Using some interpolation
            Console.WriteLine($"Alex: {alex.firstName}, {alex.lastName}");


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
            public int creditScore { get; private set; }

            // Methods
            public void setStatus (string statusSet) {
                if (statusSet == "CURRENT" 
                    || statusSet == "PAST" 
                    || statusSet == "FUTURE") {
                    this.status = statusSet;
                } else {
                    Console.WriteLine("Status must be: PAST, CURRENT, or FUTURE");
                }
            }

            public void setCreditScore(int scoreCheck) {
                if (scoreCheck >= 400 && scoreCheck <= 900) {
                    this.creditScore = scoreCheck;
                } else {
                    Console.WriteLine("Credit Score must be between 400 and 900");
                }
            }

            // Constructors
            public Student() {
                //Unless otherwise specified Bootcap will default to .Net, only when using this constructor
                this.bootcamp = ".Net";
            }
            public Student (string firstName, string lastName) {
                this.firstName = firstName;
                this.lastName = lastName;
                //When using this constructor the default Bootcamp is Java
                this.bootcamp = "Java";
            }
        }
    }
}
