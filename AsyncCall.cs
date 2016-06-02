using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async {
    public class AsyncCall<T,U> {
        public U firstFunctionResult;
        private delegate U AsyncCaller<T, U>(T arg);
        public AsyncCall() {
        }
        public void Call(Func<T,U> func, AsyncCallback callback, T firstFuncParam, object secondFuncParam) {
            AsyncCaller<T,U> caller = new AsyncCaller<T,U>(func);
            AsyncCallback callbackFunc = null;
            if (callback != null) {
                callbackFunc = new AsyncCallback(callback);
            }

            IAsyncResult result = caller.BeginInvoke(firstFuncParam, 
                callbackFunc,
                secondFuncParam);

            firstFunctionResult = caller.EndInvoke(result);
        }
    }
    
}
