namespace Reconstution.Before
{
    /*  方法提升
        如果子类中都存在某个方法,我们将方法提到基类中
        如果子类中部分存在某个方法,我们将方法提到接口中
    */
    public abstract class Language {}
    public class Man:Language
    {
        public void Say(){}
    }

    public class Woman:Language
    {
        public void Say() {}
    }

}

namespace Reconstution.After
{
    public abstract class Language
    {
        public void  Say(){}
    }  

    public class Man:Language {}
    public class Woman:Language{}
}