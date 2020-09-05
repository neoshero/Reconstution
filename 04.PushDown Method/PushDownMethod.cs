namespace Reconstution.Before
{ 
    
    /* 降低方法
       在基类中存在某些属于子类的方法,我们就需要将它从基类中移动到子类
    */

    public abstract class Animal
    {
        //Bark属于Dog子类的方法,我们将它移动到子类中
        public void Bark()
        {
            // code to bark
        }
    }

    public class Dog : Animal {}

    public class Cat : Animal {}

}

namespace Reconstution.After
{
    public abstract class Animal {}

    public class Dog : Animal
    {
        public void Bark()
        {
            //do something
        }
    }

    public class Cat : Animal {}   
}