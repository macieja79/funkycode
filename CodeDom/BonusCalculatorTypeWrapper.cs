using System;
using System.Reflection;

namespace CodeDom
{
    public class BonusCalculatorTypeWrapper : CodeDomTypeWrapper, IBonusCalculator
    {
        MethodInfo _calculateMethod;

        public BonusCalculatorTypeWrapper(Type matchType)
            : base(matchType)
        {
            _calculateMethod = _wrappedType.GetMethod(nameof(IBonusCalculator.Calculate));
        }
       
        public decimal Calculate(int seniority, decimal salary, int grade, double rating, int numberOfCertificates)
        {
            decimal result = (decimal)_calculateMethod.Invoke(_instance, new object[] { seniority, salary, grade, rating, numberOfCertificates });        
            return result;
        }
     
    }
}
