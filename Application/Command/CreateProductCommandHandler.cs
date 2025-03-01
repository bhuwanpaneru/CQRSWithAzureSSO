using CQRSWithAzureSSO.Application.Commands;
using CQRSWithAzureSSO.Domain;
using CQRSWithAzureSSO.Persistence;
using MediatR;
using System.Threading;
using System.Threading.Tasks;


namespace CQRSWithAzureSSO.Application.Commands
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly ApplicationDbContext _context;

        public CreateProductHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = request.Name,
                Price = request.Price
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product.Id;
        }
    }
}
