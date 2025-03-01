using CQRSWithAzureSSO.Domain;
using MediatR;

namespace CQRSWithAzureSSO.Application.Commands
//{
//    public class CreateProductCommand : IRequest<Product>
//    {
//        public string Name { get; set; }
//        public decimal Price { get; set; }
//    }
//}

{
    public class CreateProductCommand : IRequest<int>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
