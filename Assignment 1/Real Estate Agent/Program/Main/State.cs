using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Agent.Program.Main
{
    class State<T>
    {
        private T _value;

        public State(T value) {

            _value = value;
        }

        public T value
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
            }
        }
    }
}
