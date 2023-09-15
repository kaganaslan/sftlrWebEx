using sftlareWebEx.Data.Base;
using sftlareWebEx.Models;

namespace sftlareWebEx.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
