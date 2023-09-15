using sftlareWebEx.Data.Base;
using sftlareWebEx.Models;

namespace sftlareWebEx.Data.Services
{
    public class CinemasService:EntityBaseRepository<Cinema>,ICinemasService
    {
        public CinemasService(AppDbContext context):base(context)
        {

        }
    }
}
