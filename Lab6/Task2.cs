using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    abstract class Instument
    {
        public string name;
        public Instument(string name)
        {
            this.name = name;
        }
        abstract public void Play();
    }
}
