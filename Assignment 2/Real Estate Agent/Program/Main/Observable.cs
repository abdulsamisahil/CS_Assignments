using System;
using System.Collections.Generic;

namespace Real_Estate_Agent.Program.Main
{
    class Observable<T>
    {
        private T _value;

        public Action<T> listener;

        public Observable(T value) {

            _value = value;

            excuteListeners(_value);
        }

        public Observable()
        {
        }

        public Observable(List<T> my_List)
        {
            My_List = my_List;
        }

        private void excuteListeners(T value)
        {
            if (listener != null)
            {
                listener.Invoke(value);
            }
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

                excuteListeners(_value);
            }
        }

        public List<T> My_List { get; }
    }
}
