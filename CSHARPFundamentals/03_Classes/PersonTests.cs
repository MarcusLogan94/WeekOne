using System;

namespace _03_Classes
{
    class PersonTests
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person("Howard", "Stefanopoulous", new DateTime(1785, 02, 14), new Vehicle());
            Console.WriteLine("Hello World!");
            Console.WriteLine(firstPerson);
            Console.WriteLine(firstPerson.Age);
            
            //assertion from unit test project type
            //Assert.AreEqual("Howard Stefanopoulous", firstPerson.FullName);
        }
    }
}
