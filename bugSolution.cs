public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize MyProperty

    public void MyMethod()
    {
        // MyProperty is now initialized, preventing NullReferenceException.
        Console.WriteLine(MyProperty.ToString());
    }
}