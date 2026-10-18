using Microsoft.EntityFrameworkCore;
using USS.ProjectTemplate.Web.Model;

namespace USS.ProjectTemplate.Web.Data
{
    public class USSKanakkeduDBContext : DbContext
    {
        public USSKanakkeduDBContext(DbContextOptions<USSKanakkeduDBContext> options)
            : base(options)
        {

        }


    }
}
