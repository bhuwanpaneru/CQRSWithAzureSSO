using CQRSWithAzureSSO.Application.Commands;
using CQRSWithAzureSSO.Application.Handlers;
using CQRSWithAzureSSO.Application.Queries;
using CQRSWithAzureSSO.Domain;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace CQRSWithAzureSSO.Controllers
{
    [Authorize]
        [ApiController]
        [Route("api/[controller]")]
        public class ProductController : ControllerBase
        {
            private readonly IMediator _mediator;

            public ProductController(IMediator mediator)
            {
                _mediator = mediator;
            }

            [HttpGet]
            public async Task<IEnumerable<ProductDto>> Get()
            {
                return await _mediator.Send(new GetAllProductsQuery());
            }

            [HttpPost]
            public async Task<IActionResult> Create(CreateProductCommand command)
            {
                var id = await _mediator.Send(command);
                return Ok(id);
            }
        }
    

}

