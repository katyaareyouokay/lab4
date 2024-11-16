using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_responsibility_chain
{
    internal class LipProductHandler : IHandler
    {
        private IHandler _nextHandler;

        public void HandleRequest(ProductRequest request)
        {
            if (request.Category == ProductCategory.Lips)
            {
                Console.WriteLine($"LipProductHandler: Handled {request.ProductName} for lips.");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }

        public void SetNextHandler(IHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }
    }
}
