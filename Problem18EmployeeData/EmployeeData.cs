using System;


namespace Problem18EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            int age = 27;
            char gender = 'f';
            decimal egn = 8306112507m;
            int number = 27563571;

            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Last Name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", egn);
            Console.WriteLine("Unique Employee numbe: {0}", number);
        }
    }
}
