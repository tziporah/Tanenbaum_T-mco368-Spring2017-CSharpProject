using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationDBClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example of querying database
            /* string sql = "SELECT * FROM ACCOUNT";

            var rs = SingletonConnection.Instance.GetReader(sql);

            while (rs.Read())
            {
                Console.WriteLine(rs.GetString(0) + " " + rs.GetString(1));
            }

            Console.ReadKey();
            */

            //Example of using linq to sql
            /* using (LinqToSqlDataContext context = new LinqToSqlDataContext())
            {
                var gila =  context.Accounts.Where(a => a.Customer.firstName == "Gila");
            }
            */
        }
    }
}
