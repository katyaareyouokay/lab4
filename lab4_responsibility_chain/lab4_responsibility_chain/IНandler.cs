using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_responsibility_chain
{
    internal interface IHandler
    {
        void HandleRequest(ProductRequest request);
        void SetNextHandler(IHandler nextHandler);
    }
}
