using Microsoft.EntityFrameworkCore;

namespace WEB_API_Net_Core.DB
{
    public partial class DB_Demo_APIContext : DbContext
    {
      
        public DB_Demo_APIContext()
        {
        }

        public DB_Demo_APIContext(DbContextOptions<DB_Demo_APIContext> options)
            : base(options)
        {

        }

    }

}
