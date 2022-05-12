using System;

namespace ClassPersonStudentAndTeacher
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Greet("Hello!");

            Student student = new Student();
            student.Greet("Hello!");
            student.SetAge(21);
            student.ShowAge();

            Professor professor = new Professor();
            professor.Greet("Hello!");
            professor.Explain();



            Console.ReadLine();
        }
    }

    public class Person
    {

        public int Age { get; set; }

        public void Greet(string message)
        {
            Console.WriteLine(message);
        }

        public void SetAge(int age)
        {
            Age = age;
        }

    }

    public class Student : Person
    {
        public void study()
        {
            Console.WriteLine("I am studying.");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is: {Age} years old");
        }


    }
    public class Professor : Person
    {
        public void Explain()
        {
            Console.WriteLine("I am explaining.");
        }
    }



}
