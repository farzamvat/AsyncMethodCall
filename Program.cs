using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async {
    class Program {
        static void Main(string[] args) {

            object secondFuncParam;
            AsyncCall<int, string> instance = new AsyncCall<int, string>();
            instance.Call(test,
                delegate(IAsyncResult ar) {
                    Console.WriteLine( ar.AsyncState + " this is callback function.");
                }, 12345, secondFuncParam : "Hello");

            Thread.Sleep(1000);
            Console.WriteLine(instance.firstFunctionResult);

        }
        public static string test(int x) {
            return "First function to call asynchronously " + x.ToString();
        }

    }
}
