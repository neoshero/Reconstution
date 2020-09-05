namespace Reconstution.Before
{ 
    
    /* 提取接口(依赖倒置原则)
       当一个类作为另一个类使用时,如果存在变化,那么将该类抽象成接口提供给另一个类
    */
    public class ClassRegistration
    {
        public void Create()
        {
            // create registration code
        }

        public void Transfer()
        {
            // class transfer code
        }

        public decimal Total { get; private set; }
    }

    public class RegistrationProcessor
    {
        public decimal ProcessRegistration(ClassRegistration registration)
        {
            registration.Create();
            return registration.Total;
        }
    }
}

namespace Reconstution.After
{
    public interface IClassRegistration
    {
        void Create();
        decimal Total { get; }
    }

    public class ClassRegistration : IClassRegistration
    {
        public void Create()
        {
            // create registration code
        }

        public void Transfer()
        {
            // class transfer code
        }

        public decimal Total { get; private set; }
    }

    public class RegistrationProcessor
    {
        //DIP原则
        public decimal ProcessRegistration(IClassRegistration registration)
        {
            registration.Create();
            return registration.Total;
        }
    }
}