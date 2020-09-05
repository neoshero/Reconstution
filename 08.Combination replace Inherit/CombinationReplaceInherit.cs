namespace Reconstution.Before
{ 
    
    /* 组合替换继承
       当两个类没有直接的继承关系,又需要相互配合的时候,我们使用组合而不是继承关系
    */
    public class Common
    {
       public void WashHands(){}
    }

    public class People:Common {}
}

namespace Reconstution.After
{
   public class Common
    {
       public void WashHands(){}
    }
    //这种方式常用语IOC场景
    public class People 
    {
        private Common _common;
        public People()
        {
            _common = new Common();
        }

        public void WashHands()
        {
            _common.WashHands();
        }
    }
}