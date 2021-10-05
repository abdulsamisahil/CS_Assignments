using System;

namespace RealEstateBLL
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

        public static bool isValidStr(string str)
        {

            return str != null && str != "";
        }

        public static bool isSubTypeResidential(SubTypes subType)
        {
            return (
                SubTypes.Rental == subType
                || SubTypes.Rental == subType
                || SubTypes.Rowhouse == subType
                || SubTypes.Tenement == subType
            );
        }

        public static bool isSubTypeInstitutional(SubTypes subType)
        {
            return (
                SubTypes.School == subType
                || SubTypes.University == subType
            );
        }

        public static bool isSubTypeCommercial(SubTypes subType)
        {
            return (
                SubTypes.Shop == subType
                || SubTypes.Warehouse == subType
            );
        }
    }
}
