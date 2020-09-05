
namespace Reconstution.Before
{

    /** 
        银行账户计算利息的时候,在利息表中引用了BankAccount 
        导致他们相互引用,职责不单一
        BankAccount应该只记录他的基础信息,不参与计算
    **/
    public class BankAccount
    {
        public BankAccount(int accountAge, int creditScore, AccountInterest accountInterest)
        {
            AccountAge = accountAge;
            CreditScore = creditScore;
            AccountInterest = accountInterest;
        }
 

        public int AccountAge { get; private set; }
        public int CreditScore { get; private set; }
        public AccountInterest AccountInterest { get; private set; }

        public double CalculateInterestRate()
        {
            if (CreditScore > 800)
                return 0.02;

            if (AccountAge > 10)
                return 0.03;

            return 0.05;
        }
    }

    public class AccountInterest
    {
        public BankAccount Account { get; private set; }

        public AccountInterest(BankAccount account)
        {
            Account = account;
        }

        public double InterestRate
        {
            get { return Account.CalculateInterestRate(); }
        }

        public bool IntroductoryRate
        {
            get { return Account.CalculateInterestRate() < 0.05; }
        }
    } 
}

namespace Reconstution.After
{
    
    /**
        修改以后,AccountInterest专门用来计算信息的类
        将合适的方法放到合适的位置当中,实现职责单一
    **/
    public class BankAccount
    {
        public BankAccount(int accountAge,int creditScore)
        {
            AccountAge = accountAge;
            CreditScore = creditScore;
        }

        public int AccountAge {get; private set;}
        public int CreditScore {get; private set;}
    }

    public class AccountInterest
    {
        public BankAccount BankAccount { get; private set; }
        public AccountInterest(BankAccount bankAccount)
        {
            this.BankAccount = bankAccount;
        }
 
        public double InterestRate
        {
            get
            {
                return CalculateInterestRate();
            }
        }
 
        public bool IntroductoryRate
        {
            get
            {
                return CalculateInterestRate() < 0.05;
            }
        }
 
        public double CalculateInterestRate()
        {
            if (BankAccount.CreditScore > 800)
            {
                return 0.02;
            }
            if (BankAccount.CreditScore > 10)
            {
                return 0.03;
            }
 
            return 0.05;
        }
    }
}