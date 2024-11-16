using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_responsibility_chain
{
    internal class FaceProductHandler : IHandler
    {
        private IHandler _nextHandler;

        public void HandleRequest(ProductRequest request)
        {
            if (request.Category == ProductCategory.Face)
            {
                Console.WriteLine($"FaceProductHandler: Handled {request.ProductName} for face.");
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
