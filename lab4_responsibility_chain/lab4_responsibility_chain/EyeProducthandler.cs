using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_responsibility_chain
{
    internal class EyeProductHandler : IHandler
    {
        private IHandler _nextHandler;

        public void HandleRequest(ProductRequest request)
        {
            if (request.Category == ProductCategory.Eyes)
            {
                Console.WriteLine($"EyeProductHandler: Handled {request.ProductName} for eyes.");
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
