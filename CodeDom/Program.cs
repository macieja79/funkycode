using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeDom
{
    class Program
    {

        const string CLASS_TEMPLATE = @"

using System;

namespace CodeDom
{
 
    public class BonusCalculator : IBonusCalculator 
    { 	    
         public decimal Calculate(int seniority, decimal salary, int grade, double rating, int numberOfCertificates)
         {
             @OUR_CUSTOMER_CODE
         }
    }
}";


        static void Main(string[] args)
        {
            int seniority = 6;
            decimal salary = 15000;
            int grade = 9;
            double rating = 9.2;
            int numberOfCertificates = 5;

            // this is our customer code that came via HTTP from editor exposed to customer
            string clientCode = "return salary * 0.25m + (seniority / numberOfCertificates);";
       
            // we are creatting full fledged class with customers part 
            var classCode = CLASS_TEMPLATE.Replace("@OUR_CUSTOMER_CODE", clientCode);

            // magic lays here
            var calculator = CodeDomFactory.Compile<BonusCalculatorTypeWrapper>(classCode,"CodeDom.BonusCalculator");

            // then we use 
            decimal bonus = calculator.Calculate(seniority, salary, grade, rating, numberOfCertificates);

        }




    }
}
