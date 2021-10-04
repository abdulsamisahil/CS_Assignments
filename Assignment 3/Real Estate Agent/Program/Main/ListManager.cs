using System;

using System.Collections.Generic;

using System.Linq;

namespace Real_Estate_Agent.Program.Main
{
    class ListManager<T> : IListManager<T>
    {
        // Instance 
        //private List<T> my_List;

        private List<T> list = new List<T>();

        public readonly Observable<List<T>> observable;

        public ListManager()
        {

            observable = new Observable<List<T>>(list);
        }

        public int Count 
        {
            get { return list.Count;  }
            
        }

        public bool Add(T obj)
        {
            try
            {
                list.Add(obj);

                observable.value = list;
              
                return true; 

            }
            catch(Exception)
            {

                return false; 
            }
        }

        public bool ChangeAt(T obj, int index)
        {
            try
            {
                if (CheckIndex(index) && obj != null)
                {
                    list[index] = obj;

                    observable.value = list;

                    return true; 
                }
                return false; 
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CheckIndex(int index)
        {
            return index >= 0 && index < list.Count(); 
        }

        public void DeleteAll()
        {
            list.Clear();

            observable.value = list;
        }

        public bool DeleteAt(int index)
        {
            try 
            {
                if (CheckIndex(index))
                {
                    list.RemoveAt(index);

                    observable.value = list;

                    return true; 
                }
                return false; 
            }
            catch(Exception )
            {
                return false; 
            }
        }

        public T GetAt(int index)
        {
            if (CheckIndex(index))
                return list.ElementAt(index);

            return default(T); 
        }

        public string [] ToStringArray()
        {

            string [] listInString = new string[list.Count];

            for(int i = 0; i < list.Count; i++)
            {
                listInString[i] = list.ElementAt(i).ToString(); 
            }

            return listInString; 
        }

        public List<string> ToStringList()
        {
            List<string> coll = new List<string>();
            
            coll = list.Select(x => x.ToString()).ToList();

            return coll; 
        }
    }
}
