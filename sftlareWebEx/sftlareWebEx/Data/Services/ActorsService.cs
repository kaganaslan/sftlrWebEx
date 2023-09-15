using Microsoft.EntityFrameworkCore;
using sftlareWebEx.Data.Base;
using sftlareWebEx.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sftlareWebEx.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
       
        public ActorsService(AppDbContext context):base(context){ }


    }
}
