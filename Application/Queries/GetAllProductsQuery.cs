using CQRSWithAzureSSO.Application.Handlers;
using CQRSWithAzureSSO.Domain;
using MediatR;

namespace CQRSWithAzureSSO.Application.Queries
{
    public class GetAllProductsQuery : IRequest<IEnumerable<ProductDto>> { }
}


//using MediatR;
//using System.Collections.Generic;

//namespace YourNamespace.Application.Queries
//{
//    public class GetAllProductsQuery : IRequest<IEnumerable<ProductDto>> { }
//}
