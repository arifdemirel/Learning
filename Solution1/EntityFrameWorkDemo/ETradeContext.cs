using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameWorkDemo
{
    public class ETradeContext : DbContext  //entity framework'ün DbContext'inden inherit edilmesi gerekir ve bunun içinde "Using System.Data.Entity;"
    {
        public DbSet<Product> Products  /* tablo adı*/  { get; set; }

    }

    /* <connectionStrings>
		<add name = "ETradeContext" connectionString="server=DESKTOP-KVIRVD3;initial catalog=ETrade;integrated security=true"
			 providerName="System.Data.SqlClient"/>
	</connectionStrings>
    */
}
