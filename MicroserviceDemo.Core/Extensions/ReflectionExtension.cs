using System.Reflection;

namespace MicroserviceDemo.Core.Extensions
{
    public static class ReflectionExtension
    {
        public static List<string> GetPropNames<T>(this List<T> source)
        {
            List<string> names = new List<string>();
            foreach (var sourceItem in source)
            {
                foreach (PropertyInfo item2 in sourceItem.GetType().GetProperties())
                {
                    names.Add(item2.Name);
                }
            }

            return names;
        }

        public static List<object> GetPropValues<T>(this List<T> source)
        {
            List<object> list = new List<object>();
            foreach (var sourceItem in source)
            {
                foreach (var item in sourceItem.GetType().GetProperties())
                {
                    object value = item.GetValue(item, null);
                    list.Add(value);
                }
            }

            return list;
        }
    }
}
