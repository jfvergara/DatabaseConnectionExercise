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
            System.Console.WriteLine(oracle.OpenConnection(stringConnection));
            System.Console.WriteLine(oracle.CloseConnection());
        }
    }
}
