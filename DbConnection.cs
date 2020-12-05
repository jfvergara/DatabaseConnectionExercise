using System;

namespace DatabaseConnectionExercise
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }


        public DbConnection(string connectionString)            
        {
            if (connectionString == null || connectionString == "")
            {
                throw new InvalidOperationException("The connectionString should not be empty or null");
            }
            else
            {
                ConnectionString = connectionString;
            }
        }

        public abstract string OpenConnection(string connectionString);
        public abstract string CloseConnection();
    }
}
