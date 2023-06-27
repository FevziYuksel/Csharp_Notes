using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Notes
{
    interface MyInterface<T, D, E>
    where T : class, new()
    where D : struct
    where E : class, IComparable<E>, INullable
    { }

    class Base<T> where T : class , new(){ }

    class Comp : IComparable<Comp>
    {
        public int CompareTo(Comp? other)
        {
            throw new NotImplementedException();
        }
    }

    struct Value2 { } 

    class MyClass : Base<MyClass>, MyInterface<MyClass, Value2, Comp>
    { }

}
