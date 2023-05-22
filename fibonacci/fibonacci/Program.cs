using System.Text;
using System.Globalization;
namespace Fibonacci
{
    class program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("До якого числа лічити ряд?");
            int number = Convert.ToInt32(Console.ReadLine());
            int first = 1;
            Console.Write("{0}", first);
            int second = 1;
            Console.Write("{0}", second);
            int sum = 0;
            while (number >= sum)
            {
                sum = first + second;
                Console.Write("{0}", sum);
                first = second;
                second = sum;
            }
        }
    }
}