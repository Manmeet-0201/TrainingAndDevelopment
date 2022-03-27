using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    class AbstractFactoryDesignPatternExecutor
    {
        static void Main(string[] args)
        {
            List<string> accountNumbers = new List<string>
            {
                "CITI-456","National-987","Chase-222"
            };
            for (int i = 0; i < accountNumbers.Count; i++)
            {
                try
                {
                    ICreditUnionFactory anAbstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(accountNumbers[i]);
                    AbstractLoanAccount loan = anAbstractFactory.CreateLoanAccount();
                    AbstractSavingsAccount savings = anAbstractFactory.CreateSavingsAccount();
                    Console.WriteLine(savings.Balance() + " " + loan.Loan());


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadKey();
        }
    }
    #region savings
    public abstract class AbstractSavingsAccount
    {
        public abstract string Balance();
    }
    public class CitiSavingsAccount : AbstractSavingsAccount
    {
        public CitiSavingsAccount()
        {

        }
        public override string Balance()
        {
            return "Citi Savings Account Balance";
        }
    }
    public class NationalSavingsAccount : AbstractSavingsAccount
    {
        public NationalSavingsAccount()
        {

        }
        public override string Balance()
        {
            return "Natinal Savings Account Balance";
        }

    }
    #endregion
    #region Loan
    public abstract class AbstractLoanAccount
    {
        public abstract string Loan();
    }
    public class CitiLoanAccount : AbstractLoanAccount
    {
        public CitiLoanAccount()
        {

        }
        public override string Loan()
        {
            return "Citi Loan Account Loan";
        }
    }
    public class NationalLoanAccount : AbstractLoanAccount
    {
        public NationalLoanAccount()
        {

        }
        public override string Loan()
        {
            return "National Loan Account Loan";
        }

    }
    #endregion
    #region AbstractFactory
    public interface ICreditUnionFactory
    {
        AbstractSavingsAccount CreateSavingsAccount();
        AbstractLoanAccount CreateLoanAccount();
    }
    #endregion
    #region CitiConcreteFactory
    public class CitiCreditUnionFactory : ICreditUnionFactory
    {
        public AbstractLoanAccount CreateLoanAccount()
        {
            return new CitiLoanAccount();
        }

        public AbstractSavingsAccount CreateSavingsAccount()
        {
            return new CitiSavingsAccount();
        }
    }
    #endregion
    #region NationalConcreteFactory
    public class NationalCreditUnionFactory : ICreditUnionFactory
    {
        public AbstractLoanAccount CreateLoanAccount()
        {
            return new NationalLoanAccount();
        }

        public AbstractSavingsAccount CreateSavingsAccount()
        {
            return new NationalSavingsAccount();
        }
    }
    #endregion
    public class CreditUnionFactoryProvider
    {
        public static ICreditUnionFactory GetCreditUnionFactory(string accountNo)
        {
            if (accountNo.Contains("CITI")) { return new CitiCreditUnionFactory(); }
            else if (accountNo.Contains("National")) { return new NationalCreditUnionFactory(); }
            else { throw new NotImplementedException(); }
        }
    }
}
