using Microsoft.EntityFrameworkCore;
using USS.ProjectTemplate.Web.Model;

namespace USS.ProjectTemplate.Web.Data
{
    public class MainDBContext : DbContext
    {
        public MainDBContext(DbContextOptions<MainDBContext> options)
            : base(options)
        {

        }


    }
}
