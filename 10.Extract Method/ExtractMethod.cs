namespace Reconstution.Before
{ 
    
    /* 提取方法(职责单一)
       当一个方法里面的方法比较负责的时候,我们需要将各个抽离出职责单一的方法
    */
    public class SalesOrder
    {
        private List<decimal> _inCome;
        private List<decimal> _expenses;
        public decimal CalculateTotal()
        {
            var cost = 0m;
            foreach(var item in _inCome)
            {
                cost += item;
            }

            foreach(var item in _expenses)
            {
                cost -= item;
            }

            decimal tax = cost * 0.075;
            cost -= tax;
            return cost;
        }
    }

}

namespace Reconstution.After
{
    public class SalesOrder
    {
        private List<decimal> _inCome;
        private List<decimal> _expenses;
        public decimal CalculateTotal()
        {
            var subTotal = Total();
            subTotal = Expenses(subTotal);
            subTotal = Tax(subTotal); 

            decimal tax = cost * 0.075;
            cost -= tax;
            return cost;
        }

        public decimal Total()
        {
            var cost = 0m;
            foreach(var item in _inCome)
            {
                cost += item;
            }
            return cost;
        }

        public decimal Expenses(decimal subTotal)
        {
           
            foreach(var item in _inCome)
            {
                subTotal -= item;
            }
            return subTotal;
        }

        public decimal Tax(decimal cost)
        {
            decimal tax = 0.075;
            return cost - cost * tax;
        }
    }
}