using Insight.Database;
using System;
using System.Data.SqlClient;

namespace InsightNet50Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var conn = new SqlConnection("Server=(local);Database=master;Trusted_Connection=true;");

            Insight.Database.Providers.MsSqlClient.SqlInsightDbProvider.RegisterProvider();

            foreach (string field in conn.QuerySql<string>("SELECT 'Hello' UNION SELECT 'World'"))
            {
                Console.WriteLine(field);
            }

            Console.Read();
        }
    }
}
