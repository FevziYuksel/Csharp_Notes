using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cs_Notes

{
    interface IDoable
    {
        void Do();

        void Do2();
    }

    internal class Base : IDoable, IDisposable
    {
        private double amount;

        private readonly string price;

        public required string waw;
        public string? Name { get; set; }
        public string? Description { get; private set; }

        public override string ToString() => JsonSerializer.Serialize(this);

        public int Age { get; init; }

        
        public double Amount { 
            get
            {
                return Amount * 1 ;
            }
            set 
            {
                amount = value >= 0 ? value : 0;
            } 
        }

        public Base()
        {
            price = string.Empty;

        }
        public Base(string name) :this()
        { 
            this.Name = name;
            this.Description = "";
        }

        public Base(string name, string description) 
            : this(name)
        { 
            this.Description = description;
        }

        public virtual void MyMethod()
        {
            Console.WriteLine(this.Name);
        }

        public virtual void Do()
        {
            
        }

        public void Do2()
        {

        }

        public string MyString()
        {
            string a = @"adwa \n
            awdwaawd";
            return $"{Name} {a}";
        }

        public virtual void Dispose()
        {
            
        }

        ~Base()
        {
            this.Dispose();
        }
    }

    internal class Derived : Base, IDoable, IDisposable
    {
        private readonly string? _surname;

        public string Surname { get; init; } = "";


        public Derived() : base() { }


        public Derived(string name, string surname) 
            : base(name) 
        {
            this.Surname = surname;
        }

        public override void MyMethod()
        {
            base.MyMethod();
            Console.WriteLine(this.Name);
        }

        public override void Do()
        {

        }

        public override void Dispose()
        {
            base.Dispose();
        }

        ~Derived()
        {
            this.Dispose();
        }

    }

    internal class Test
    {
        static void Met()
        {
            Base a = new Derived { waw = "" };
            Derived c = (Derived) a; // exception when fail Derived 
            Derived? b = a as Derived; // return null when fail Derived? Nullable

            Derived d = new Derived { waw = "" }; ;

            Base e = d; // As all oop langs uppercast is unchecked

            // data loose check must be removed 
            const uint kuMaskHighBit = unchecked((uint)int.MinValue); 
            Console.WriteLine(kuMaskHighBit);

            IList<string> list = new List<string>
            {
                "fevzi",
                "yüksel",
                "aykut",
                "özdemir"
            };

            Derived first = new Derived() { waw = "" };
            Derived second = new Derived { waw = "" };
        }
    }
}
