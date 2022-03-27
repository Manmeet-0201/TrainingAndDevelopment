using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    class FactoryMethodDesignPatternExecutor
    {
        static void Main(string[] args)
        {
            try
            {
                string accountNo = Console.ReadLine();
                if (accountNo.Contains("CITI"))
                {
                    var citiAccount = new CitiSavingsAccountFactory().GetSavingsAccount();
                    Console.WriteLine($"My Citi balance is ${citiAccount.Balance}");
                }
                else if (accountNo.Contains("National"))
                {
                    var nationalAccount = new NationalSavingsAccountFactory().GetSavingsAccount();
                    Console.WriteLine($" My national balance is ${nationalAccount.Balance}");
                }

                Console.ReadKey();
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
    public abstract class AbstractSavingsAccount
    {
        public decimal Balance { get; set; }
    }
    public class CitiSavingsAccount : AbstractSavingsAccount
    {
        public CitiSavingsAccount()
        {
            Balance = 5000;
        }
    }
    public class NationalSavingsAccount : AbstractSavingsAccount
    {
        public NationalSavingsAccount()
        {
            Balance = 2000;
        }

    }
    interface ICreditUnionFactory
    {
        AbstractSavingsAccount GetSavingsAccount();
    }
    public class CitiSavingsAccountFactory : ICreditUnionFactory
    {
        public AbstractSavingsAccount GetSavingsAccount()
        {
            return new CitiSavingsAccount();

        }

    }
    public class NationalSavingsAccountFactory : ICreditUnionFactory
    {
        public AbstractSavingsAccount GetSavingsAccount()
        {
            return new NationalSavingsAccount();
        }
    }
}
