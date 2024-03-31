using System.Runtime.Intrinsics.X86;

namespace HW4
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            var s = new Stack();
            s.Add("a");
            s.Add("b");
            s.Add("c");
            s.Add("d");
            s.Add("e");
            s.Add("f");
            s.Pop();
            s.Pop();
            s.Pop();
            s.Add("f1");
        }
    }
}