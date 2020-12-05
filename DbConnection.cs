using System;

namespace DatabaseConnectionExercise
{
    public abstract class DbConnection
    {
        public bool _isValid;
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
                _isValid = true;
            }
        }

        public abstract void OpenConnection(string connectionString);
        public abstract void CloseConnection();
    }
}
