namespace DatabaseConnectionExercise
{
    public class SqlConnection : DbConnection
    {
        private bool sqlConnection;

        public SqlConnection(string connectionString)
            : base(connectionString)
        {

        }
        public override void OpenConnection(string connectionString)
        {
            if (_isValid == true && sqlConnection == false)
            {
                System.Console.WriteLine("Sql connection open!");
                sqlConnection = true;
            }
            else if (_isValid == true && sqlConnection == true)
            {
                System.Console.WriteLine("The Sql connection is already open");
            }

        }
        public override void CloseConnection()
        {
            if (_isValid == true && sqlConnection == true)
            {
                System.Console.WriteLine("Sql connection closed");
                sqlConnection = false;
            }
            else if (_isValid == true && sqlConnection == false)
            {
                System.Console.WriteLine("There is no a Sql connection to close");
            }
        }
    }
}
