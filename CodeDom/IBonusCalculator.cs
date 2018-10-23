namespace CodeDom
{
    public interface IBonusCalculator
    {
        decimal Calculate(int seniority, decimal salary, int grade, double rating, int numberOfCertificates);
    }
}
