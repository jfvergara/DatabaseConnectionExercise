namespace DatabaseConnectionExercise
{
    public class OracleConnection : DbConnection        
    {
        private bool _oracleConnection;

        public OracleConnection(string connectionString)
            : base(connectionString)
        {

        }
        public override void OpenConnection(string connectionString)            
        {
            if (_isValid == true && _oracleConnection == false)
            {
                System.Console.WriteLine("Oracle connection open!");
                _oracleConnection = true;
            }
            else if(_isValid == true && _oracleConnection == true)
            {
                System.Console.WriteLine("The Oracle connection is already open");
            }
            
        }
        public override void CloseConnection()
        {
            if (_isValid == true && _oracleConnection == true)
            {
                System.Console.WriteLine("Oracle connection closed");
                _oracleConnection = false;
            }
            else if (_isValid == true && _oracleConnection == false)
            {
                System.Console.WriteLine("There is no a Oracle connection to close");
            }
        }
    }
}
