namespace Reconstution.Before
{ 
    
    /* 重写属性、参数、方法
       当我们这几一个类的时候,很多属性参数方法名称难以读懂,所以需要合理的重写名称
    */
    public class Person
    {
        public string FN {get;set;}

        public decimal ClcHrlyPR() { return 0m;}
    }

}

namespace Reconstution.After
{
   public class Employee
   {
       public string FirstName {get;set;}
       public decimal CalculateHourlyPay() { return 0m; }
   }
}