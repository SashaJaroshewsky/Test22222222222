
namespace ConsoleApp1
{
    class Class1 : Interface1
    {
        public int a;
        public string b;

        public  void Method1()
        {
            Console.WriteLine("Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Method2");
        }

        public void Method3()
        {
            throw new NotImplementedException();
        }
    }

}
