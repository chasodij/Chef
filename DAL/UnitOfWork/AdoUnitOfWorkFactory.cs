using chef.BLL.UnitOfWork;
using System.Data.SqlClient;

namespace chef.DAL.UnitOfWork
{
    public class AdoUnitOfWorkFactory : IUnitOfWorkFactory
    {
        public IUnitOfWork Create()
        {
            var connectionString = "Data Source=DESKTOP-MM9MS8C\\SQLEXPRESS;Initial Catalog=chef_db;Integrated Security=True";
            var con = new SqlConnection(connectionString);
            return new AdoUnitOfWork(con);
        }
    }
}
