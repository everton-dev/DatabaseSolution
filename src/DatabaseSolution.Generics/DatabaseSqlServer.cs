using System.Data;
using System.Data.SqlClient;
using DatabaseSolution.Generics.Enums;

namespace DatabaseSolution.Generics
{
    public class DatabaseSqlServer : Database
    {
        private readonly SqlConnection _connection;
        private readonly SqlCommand _command;
        private readonly SqlDataAdapter _dataAdapter;

        public DatabaseSqlServer(string connectionString) : base(connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _command = new SqlCommand();
            _dataAdapter = new SqlDataAdapter(_command);
        }

        public override void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }
        public override void OpenConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public override void AddParameter(string parameterName, object value)
        {
            _command.Parameters.Add(new SqlParameter(parameterName, value));
        }
        public override void Execute(string textCommand, eExecutionType executionType)
        {
            var commandType = executionType == eExecutionType.StoredProcedure ? 
                System.Data.CommandType.StoredProcedure : System.Data.CommandType.Text;

            this.OpenConnection();
            _command.Connection = _connection;
            _command.CommandText = textCommand;
            _command.CommandType = commandType;
            _command.ExecuteNonQuery();
            this.CloseConnection();
        }
        public override DataTable Query(string textCommand, eExecutionType executionType)
        {
            DataTable result = new DataTable();
            var commandType = executionType == eExecutionType.StoredProcedure ?
                System.Data.CommandType.StoredProcedure : System.Data.CommandType.Text;

            this.OpenConnection();
            _command.Connection = _connection;
            _command.CommandText = textCommand;
            _command.CommandType = commandType;

            _dataAdapter.Fill(result);
            this.CloseConnection();
            _dataAdapter.Dispose();

            return result;
        }

        public override void ExecuteProcedureWithoutReturn(string procedureName) =>
            this.Execute(procedureName, eExecutionType.StoredProcedure);

        public override DataTable ExecuteProcedure(string procedureName) => 
            this.Query(procedureName, eExecutionType.StoredProcedure);
    }
}