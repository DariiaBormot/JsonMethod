using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Json_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("John","Wick","Student", 90);

            var myJString = GetJsonString(student1);
            Console.WriteLine(myJString);

            var myDeserializedString = JsonConvert.DeserializeObject(myJString);
            Console.WriteLine(myDeserializedString);
            Console.ReadKey();
        }
        public static string GetJsonString(object obj)
        {
            var type = obj.GetType();
            var properties = type.GetProperties();
            var result = string.Empty;

            foreach (var property in properties)
            {
                var attribute = property.GetCustomAttribute(typeof(IgnorePropertyAttribute));

                    if (attribute == null)
                    {
                        var value = property.GetValue(obj);
                        if (value is string)
                        {
                            result += $"\"{property.Name}\":\"{value}\",";
                        }
                        else
                        {
                            result += $"\"{property.Name}\":{value}";
                        }
                    }
                            
            }
            return $"{{{result}}}";
        }
    }
}
