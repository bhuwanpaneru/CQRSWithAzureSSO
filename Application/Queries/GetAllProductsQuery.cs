using CQRSWithAzureSSO.Application.Dto;
using CQRSWithAzureSSO.Application.Handlers;
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
