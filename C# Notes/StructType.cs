namespace Cs_Notes
{

    /*
     readonly struct ?

    Properties -> get set init; 

    Struct -> default 0 

    object init  ->  new Obj() {x = 5, y = 3} -> setter syntax sugar if wanted to be immutable init used instead set

    Enum  ->  enum.GetValue(typeof(x)) */

    internal readonly struct Struct
    {

        public int IValue { get; init; }

        public string Name { get; init; }


        public Struct(int value, string name)
        {
            this.IValue = value;
            this.Name = name;
        }

        //Struct cannot have destructor
        //~StructC()
        //{
        //}
    }
}
