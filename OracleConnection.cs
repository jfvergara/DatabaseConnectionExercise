namespace DatabaseConnectionExercise
{
    public class OracleConnection : DbConnection        
    {
        private bool oracleConnection;

        public OracleConnection(string connectionString)
            : base(connectionString)
        {

        }
        public override void OpenConnection(string connectionString)            
        {
            if (isValid == true && oracleConnection == false)
            {
                System.Console.WriteLine("Oracle connection open!");
                oracleConnection = true;
            }
            else if(isValid == true && oracleConnection == true)
            {
                System.Console.WriteLine("The Oracle connection is already open");
            }
            
        }
        public override void CloseConnection()
        {
            if (isValid == true && oracleConnection == true)
            {
                System.Console.WriteLine("Oracle connection closed");
                oracleConnection = false;
            }
            else if (isValid == true && oracleConnection == false)
            {
                System.Console.WriteLine("There is no a Oracle connection to close");
            }
        }
    }
}
