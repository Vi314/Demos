using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Demonstrations {
    public class StackDemo : IDemonstration {
        public void Run() {

            var stackExample = new Stack<int>();
            stackExample.Push(15);
            stackExample.Push(20);
            stackExample.Push(30);
            stackExample.Push(50);

            stackExample.DumpStack();
        }
            
    }

    public static class StackExtensions {
        public static void DumpStack(this Stack<int> st) {
            Console.WriteLine("************");
            for(int i = st.Count - 1; i >= 0; i--) {
                Console.Write($"{st.ElementAt(i)} ");
            }
            Console.WriteLine();
            Console.WriteLine("************");
        }
    }
}
