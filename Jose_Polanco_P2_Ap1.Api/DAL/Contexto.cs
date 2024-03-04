using Microsoft.EntityFrameworkCore;

namespace Jose_Polanco_P2_Ap1.Api.DAL
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> options):base(options)
        {
        }
    }
}
