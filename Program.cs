using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringConnection = "ThisIsAValidConnectionString";
            var oracle = new OracleConnection(stringConnection);
            oracle.OpenConnection(stringConnection);

            System.Console.WriteLine("-------------------------------------");

            
            var sql = new OracleConnection(stringConnection);
            sql.OpenConnection(stringConnection);
            sql.OpenConnection(stringConnection);
            sql.CloseConnection();
        }
    }
}
