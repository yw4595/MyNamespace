using System;

namespace MyNamespace
{
    // This interface defines a single method called MyMethod()
    public interface IMyInterface
    {
        void MyMethod();
    }

    // This class implements the IMyInterface interface and provides its own implementation of MyMethod()
    public class MyClassA : IMyInterface
    {
        // Purpose: Implement the MyMethod() method from the IMyInterface interface
        // Restrictions: None
        // Other: None
        public void MyMethod()
        {
            Console.WriteLine("This is MyClassA implementing MyMethod()");
        }
    }

    // This class also implements the IMyInterface interface, but provides a different implementation of MyMethod()
    public class MyClassB : IMyInterface
    {
        // Purpose: Implement the MyMethod() method from the IMyInterface interface
        // Restrictions: None
        // Other: None
        public void MyMethod()
        {
            Console.WriteLine("This is MyClassB implementing MyMethod()");
        }
    }

    // This class contains the Main() method and demonstrates the usage of the IMyInterface interface
    public class Program
    {
        // Purpose: Entry point for the console application
        // Restrictions: None
        // Other: None
        public static void Main()
        {
            // Create an instance of MyClassA and call MyMethod() on it
            MyClassA classA = new MyClassA();
            MyMethod(classA);

            // Create an instance of MyClassB and call MyMethod() on it
            MyClassB classB = new MyClassB();
            MyMethod(classB);
        }

        // Purpose: Call the MyMethod() method on an object that implements the IMyInterface interface
        // Restrictions: The passed-in object must implement the IMyInterface interface
        // Other: None
        public static void MyMethod(object myObject)
        {
            // Cast the object to an IMyInterface instance and call its MyMethod() method
            if (myObject is IMyInterface myInterfaceObj)
            {
                myInterfaceObj.MyMethod();
            }
        }
    }
}
