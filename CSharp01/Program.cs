//using directive
using System;

// 관련된 개체들의 집합을 포함하는 범위
// .net 6 => namespace CSharp01;
namespace CSharp01
{
    internal class Program
    {
        // member variables => fields

        // string, Type => class, etc => struct

        // string == System.String
        private static string _employeeName = "Michael Bruce";
        // int == System.Int32
        private static int _age = 29;
        private static DateTime _startDate = Convert.ToDateTime("2011-06-27");
        // bool == System.Boolean
        private static bool _isMale = true;

        // method
        static void Main(string[] args)
        {
            // local variables
            Type typeOfEmployeeName = _employeeName.GetType();
            Type typeOfAge = _age.GetType();
            Type typeOfStartDate = _startDate.GetType();
            Type typeOfIsMale = _isMale.GetType();

            Console.WriteLine($"Type Of EmployeeName : {typeOfEmployeeName}");
            Console.WriteLine($"Type Of Age : {typeOfAge}");
            Console.WriteLine($"Type Of StartDate : {typeOfStartDate}");
            Console.WriteLine($"Type Of IsMale : {typeOfIsMale}");
        }
    }

    public class EmployeeInfo
    {

    }
}
