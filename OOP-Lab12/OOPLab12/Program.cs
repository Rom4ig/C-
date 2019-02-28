using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace OOPLab12
{

    interface IShowMePls { }
    interface IMeToo { }

    abstract class SmartCreature
    {

        public string CreatureName { get; set; }
        public string OriginPlanet { get; set; }
        public string Race { get; set; }

    }

    class Human : SmartCreature, IShowMePls, IMeToo
    {

        public void ShowMePls(int firstValue, int secondValue)
        {

            Console.WriteLine("First parameter: " + firstValue);
            Console.WriteLine("Second parameter: " + secondValue);
            Console.WriteLine("MyLb ");
        }

        public override string ToString()
        {

            return $"{CreatureName} {OriginPlanet} {Race}";

        }

        public Human()
        {

            CreatureName = "Unknown.";
            OriginPlanet = "Unknown.";
            Race = "Unknown.";

        }

        public Human(string _CreatureName, string _OriginPlanet, string _Race)
        {

            CreatureName = _CreatureName;
            OriginPlanet = _OriginPlanet;
            Race = _Race;

        }

    }

    static class Reflector
    {

        public static void ToFile(string typeName)
        {
            Type myType = Type.GetType(typeName);

            using (StreamWriter streamWriter = new StreamWriter("ClassInfo.txt"))
            {

                streamWriter.WriteLine("Class: {0}", typeName);
                streamWriter.WriteLine();

                foreach (MemberInfo memberInfo in myType.GetMembers())
                    streamWriter.WriteLine(memberInfo.ToString());

                streamWriter.WriteLine("-------------------------------------------------------");

            }

        }

        public static MethodInfo[] GetPublicMethods(string typeName)
        {

            return Type.GetType(typeName).GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

        }

        public static FieldInfo[] GetFieldInfo(string typeName)
        {

            return Type.GetType(typeName).GetFields();

        }

        public static PropertyInfo[] GetPropertyInfo(string typeName)
        {

            return Type.GetType(typeName).GetProperties();

        }

        public static Type[] GetInterfaceMapping(string typeName)
        {

            return Type.GetType(typeName).GetInterfaces();

        }

        public static void SpecificMethods(string typeName, string parameterType)
        {

            foreach (MethodInfo methodInfo in Type.GetType(typeName).GetMethods())
            {

                if (methodInfo.ReturnType == Type.GetType(parameterType))
                    Console.WriteLine(methodInfo);
            }

        }

        public static void InvokeMethod(string typeName, string methodName)
        {

            Type myType = Type.GetType(typeName);
            MethodInfo methodInfo = Type.GetType(typeName).GetMethod(methodName);
            
            List<object> parameters = new List<object>();

            //using (StreamWriter streamWriter = new StreamWriter("InputParameters.txt"))
            //{

            //    streamWriter.WriteLine(1);
            //    streamWriter.WriteLine(2);

            //}

            using (StreamReader streamReader = new StreamReader("InputParameters.txt"))
            {

                string line;

                while ((line = streamReader.ReadLine()) != null)
                {
                    parameters.Add(Int32.Parse(line));
                }

            }

            methodInfo.Invoke(Activator.CreateInstance(myType), parameters.ToArray());

        }

    } 
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Human human = new Human();
            Reflector.ToFile("OOPLab12.Human");

            Console.WriteLine("$$$  Public methods  $$$");
            
            foreach (MethodInfo methodInfo in Reflector.GetPublicMethods("OOPLab12.Human"))
                Console.WriteLine(methodInfo.ToString());

            Console.WriteLine("----------------------------");

            Console.WriteLine("$$$  Fields  $$$");

            foreach (FieldInfo fieldInfo in Reflector.GetFieldInfo("OOPLab12.Human"))
                Console.WriteLine(fieldInfo.ToString());

            Console.WriteLine("----------------------------");

            Console.WriteLine("$$$  Properties  $$$");

            foreach (PropertyInfo property in Reflector.GetPropertyInfo("OOPLab12.Human"))
                Console.WriteLine(property.ToString());

            Console.WriteLine("----------------------------");

            Console.WriteLine("$$$  Interfaces  $$$");

            foreach (Type implementedInterfaces in Reflector.GetInterfaceMapping("OOPLab12.Human"))
                Console.WriteLine(implementedInterfaces.ToString());

            Console.WriteLine("----------------------------");

            Console.WriteLine("$$$  Specific methods  $$$");

            Reflector.SpecificMethods("OOPLab12.Human", "System.String");

            Console.WriteLine("----------------------------");

            Console.WriteLine("$$$  Reflection invoke  $$$");

            Reflector.InvokeMethod("OOPLab12.Human", "ShowMePls");

            Console.WriteLine("----------------------------");

        }

    }
}
