using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    abstract class Instrument
    {
        public string name;
        public Instrument(string name)
        {
            this.name = name;
        }
        abstract public void Play();
    }
    class Guitar : Instrument
    {
        public Guitar(string name) : base(name)
        {
        }
        public override void Play()
        {
            Console.WriteLine($"{name} грає мелодію");
        }
    }
    class Piano : Instrument
    {
        public Piano(string name) : base(name)
        {
        }
        public override void Play()
        {
            Console.WriteLine($"{name} грає мелодію");
        }
    }
    class Drums : Instrument
    {
        public Drums(string name) : base(name)
        {
        }
        public override void Play()
        {
            Console.WriteLine($"{name} грає ритм");
        }
    }
}
