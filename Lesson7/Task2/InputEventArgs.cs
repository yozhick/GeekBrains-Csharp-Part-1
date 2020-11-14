using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class InputEventArgs : EventArgs
    {
        readonly int number;
        public int Number => number;

        public InputEventArgs(int number)
        {
            this.number = number;
        }

    }
}
