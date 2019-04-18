using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class TypeInfo
    {
        public static void ShowTypeInfo<T>(T obj) where T : class
        {
            Type type = typeof(T);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" *** Type info about {type.Name} class *** ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" --- List of fields --- ");
            Console.ResetColor();
            FieldInfo[] fields = type.GetFields();
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine(" --- " + field.FieldType + " \t" + field.Name);
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" --- List of constructors --- ");
            Console.ResetColor();
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.Write(" --- " + constructor.Name + "(");
                ParameterInfo[] constructorParameters = constructor.GetParameters();
                for (int i = 0; i < constructorParameters.Length; i++)
                {
                    Console.Write(constructorParameters[i].ParameterType.Name + " " + constructorParameters[i].Name);
                    if (i + 1 < constructorParameters.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" --- List of methods --- ");
            Console.ResetColor();
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.Write(" --- " + method.ReturnType.Name + " \t" + method.Name + "(");
                ParameterInfo[] methodParameters = method.GetParameters();
                for (int i = 0; i < methodParameters.Length; i++)
                {
                    Console.Write(methodParameters[i].ParameterType.Name + " " + methodParameters[i].Name);
                    if (i + 1 < methodParameters.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }
        }
    }
}
