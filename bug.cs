public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that hasn't been initialized will throw a NullReferenceException.
        Console.WriteLine(MyProperty.ToString()); 
    }
}