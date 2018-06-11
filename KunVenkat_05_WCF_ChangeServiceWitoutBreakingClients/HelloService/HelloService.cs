namespace HelloService
{
  public class HelloService : IHelloServiceChange
  {
    public string GetMessage(string name)
    {
      return "Hello " + name;
    }
  }
}