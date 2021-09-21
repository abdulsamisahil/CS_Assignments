using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Agent.Program.Main
{
    class ListManager<T> : IListManager<T>
    {
        // Instance 
        private List<T> my_List; 

        //Constructor
        public ListManager()
        {
            my_List = new List<T>(); 
        }

        public int Count 
        {
            get { return my_List.Count;  }
            
        }

        public bool Add(T obj)
        {
            try
            {
                my_List.Add(obj);
                return true; 

            }catch(Exception e)
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
                    my_List[index] = obj;
                    return true; 
                }
                return false; 
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool CheckIndex(int index)
        {
            return index >= 0 && index < my_List.Count(); 
        }

        public void DeleteAll()
        {
            my_List.Clear(); 
        }

        public bool DeleteAt(int index)
        {
            try 
            {
                if (CheckIndex(index))
                {
                    my_List.RemoveAt(index);
                    return true; 
                }
                return false; 
            }
            catch(Exception e)
            {
                return false; 
            }
        }

        public T GetAt(int index)
        {

            if (CheckIndex(index))
                return my_List.ElementAt<T>(index);

            return default(T); 
        }

        public string[] ToStringArray()
        {
            throw new NotImplementedException();
        }

        public List<string> ToStringList()
        {
            throw new NotImplementedException();
        }
    }
}
