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
        public readonly Observable<List<Estate>> observableList;


        //Constructor
        public ListManager()
        {
            my_List = new List<T>();
          //  observableList = new Observable<List<Estate>>();
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
              //  observableList.value = my_List;
                return true; 

            }catch(Exception)
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
            catch (Exception)
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
            catch(Exception )
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

        public string [] ToStringArray()
        {
            string [] listInString = new string[my_List.Count];

            for(int i = 0; i < my_List.Count; i++)
            {
                listInString[i] = my_List.ElementAt(i).ToString(); 
            }

            return listInString; 
        }

        public List<string> ToStringList()
        {
            List<string> coll = new List<string>();
            coll = my_List.Select(x => x.ToString()).ToList();

            
            // List<String> list = ((IEnumerable)obj).Cast<Object>().Select(x => x.ToString());
            return coll; 
        }
    }
}
