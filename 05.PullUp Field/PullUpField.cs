namespace Reconstution.Before
{ 
    
    /* 提升字段
       如果多个子类中存在相同的字段或者方法时,那么需要将这个字段提升到基类方法中
    */

    public  class Account {}

    public class CheckingAccout : Account {private decimal _minimumCheckingBalance = 5m;}

    public class SavingAccount : Account {private decimal _minimumCheckingBalance = 5m;}

}

namespace Reconstution.After
{
    public  class Account {protected decimal _minimumCheckingBalance = 5m;}

    public class CheckingAccout : Account {}

    public class SavingAccount : Account {}
}