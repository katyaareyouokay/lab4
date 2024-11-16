using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_responsibility_chain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем обработчики
            IHandler faceHandler = new FaceProductHandler();
            IHandler lipHandler = new LipProductHandler();
            IHandler eyeHandler = new EyeProductHandler();

            // Устанавливаем цепочку ответственности
            faceHandler.SetNextHandler(lipHandler);
            lipHandler.SetNextHandler(eyeHandler);

            // Примеры запросов
            var request1 = new ProductRequest("Highlighter", ProductCategory.Face);
            var request2 = new ProductRequest("Lipstick", ProductCategory.Lips);
            var request3 = new ProductRequest("Mascara", ProductCategory.Eyes);
            // Попадет в FaceProductHandler
            var request4 = new ProductRequest("Unknown Product", ProductCategory.Face);

            // Обработка запросов
            faceHandler.HandleRequest(request1);
            faceHandler.HandleRequest(request2);
            faceHandler.HandleRequest(request3);
            faceHandler.HandleRequest(request4);
            Console.ReadKey();
        }
    }
}

