namespace Reconstution.Before
{ 
    
    /* 降低字段
       如果基类中的字段值应用于某个子类,那么我们就需要将字段放入子类中
    */

    public  class Animals {protected string _wing;}

    public class BigDog : Animals {}

    public class SmallBird : Animals {}

}

namespace Reconstution.After
{
    public  class Animals {}

    public class BigDog : Animal {}

    public class SmallBird : Animal {private string _wing;}
}