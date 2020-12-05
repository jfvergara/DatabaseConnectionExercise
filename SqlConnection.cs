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
            if (isValid == true && sqlConnection == false)
            {
                System.Console.WriteLine("Sql connection open!");
                sqlConnection = true;
            }
            else if (isValid == true && sqlConnection == true)
            {
                System.Console.WriteLine("The Sql connection is already open");
            }

        }
        public override void CloseConnection()
        {
            if (isValid == true && sqlConnection == true)
            {
                System.Console.WriteLine("Sql connection closed");
                sqlConnection = false;
            }
            else if (isValid == true && sqlConnection == false)
            {
                System.Console.WriteLine("There is no a Sql connection to close");
            }
        }
    }
}
