
namespace OOPS

{
    class Addition
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sum(float a, float b)
        {
            Console.WriteLine(a + b);
        }
        
    }
    class Multiplication : Addition
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }
}
