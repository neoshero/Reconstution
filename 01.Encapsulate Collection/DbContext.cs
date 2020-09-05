using System.Collections.Generic;

//封装集合 对内部集合进行保护
namespace Reconstution.Before
{
    /**
        封装前 对外暴露的接口List继承了ICollection<T>
        它会对DbContext对象本身的_list进行修改(Remove,Add),会导致集合本身不安全
    **/
    public class DbContext
    {
        private  IList<string> _list;

        //IList 包含了ICollection接口 会对集合本身进行数据操作 Add Remove
        public IList<string> List
        {
            get {return _list;}
        }

        public void Add(string msg)
        {
            _list.Add(msg);
        }

        public void Remove(string msg)
        {
            _list.Remove(msg);
        }
    }

   
    
}

namespace Reconstution.After
{
     /**
        封装后 对外暴露IEnumerable结构
        它只包含对数据的访问,不能对本身的集合进行修改
    **/    
    public class DbContext
    {
        private  IList<string> _list;

        //IEnumerable 只能遍历搜索取值操作
        public IEnumerable<string> List
        {
            get {return _list;}
        }

        public void Add(string msg)
        {
            _list.Add(msg);
        }

        public void Remove(string msg)
        {
            _list.Remove(msg);
        }
    }
}