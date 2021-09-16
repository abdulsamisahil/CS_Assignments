using System;

namespace Real_Estate_Agent.Program.Main
{
    class Utilis
    {
        public static string[] enumToStrArr<T>()
        {
            enumValidator<T>();

            Type type = typeof(T);

            return type.GetEnumNames();
        }

        public static T strToEnumValue<T>(string str)
        {
            enumValidator<T>();

            if (str == "" || str == null)
            {
                throw new Exception("cannot parse empty string");
            }

            return (T)Enum.Parse(typeof(T), str);
        }

        private static void enumValidator<T>()
        {
            Type type = typeof(T);

            if (!type.IsEnum)
            {
                throw new Exception("enumType argument must be a enum");
            }
        }
    }
}
