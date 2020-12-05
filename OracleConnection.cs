namespace DatabaseConnectionExercise
{
    public class OracleConnection : DbConnection        
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {

        }
        public override string OpenConnection(string connectionString)            
        {

            return "Oracle Connection Opened";
        }
        public override string CloseConnection()
        {
            return "Oracle Connection Closed";
        }
    }
}
