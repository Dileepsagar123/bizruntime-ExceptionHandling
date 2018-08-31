using System;
using System.Text.RegularExpressions;
using ExceptionApplication;
class Program
{
    static void Main(string[] args)
    {
        CustomException newStudent = null;

        try
        {
            newStudent = new CustomException();
            newStudent.name = "James007";

            ValidateStudent(newStudent);
        }
        catch (InvalidStudentNameException ex)
        {
            Console.WriteLine(ex.Message);
        }


        Console.ReadKey();
    }

    private static void ValidateStudent(CustomException std)
    {
        Regex regex = new Regex("^[a-zA-Z]+$");

        if (!regex.IsMatch(std.name))
            throw new InvalidStudentNameException(std.name);

    }
}