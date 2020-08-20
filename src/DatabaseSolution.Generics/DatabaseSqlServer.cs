using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using DatabaseSolution.Generics.Enums;

namespace DatabaseSolution.Generics
{
    public class DatabaseSqlServer : Database
    {
        private readonly SqlConnection _connection;
        private readonly SqlCommand _command;
        private readonly SqlDataAdapter _dataAdapter;
        private readonly DynamicParameters _parameters;

        public DatabaseSqlServer(string connectionString) : base(connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _command = new SqlCommand();
            _dataAdapter = new SqlDataAdapter(_command);
            _parameters = new DynamicParameters();
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
            _parameters.AddParameter(parameterName, value);
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
        public override void ExecuteProcedureWithoutReturn(string procedureName) =>
            this.Execute(procedureName, eExecutionType.StoredProcedure);
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
        public override IEnumerable<T> Query<T>(string textCommand, eExecutionType executionType)
        {
            IEnumerable<T> result = default(IEnumerable<T>);
            var commandType = executionType == eExecutionType.StoredProcedure ?
                System.Data.CommandType.StoredProcedure : System.Data.CommandType.Text;

            if (_parameters.ParameterNames.Count() > 0)
            {
                result = _connection.Query<T>(textCommand, param: _parameters, commandType: commandType);
            }
            else
            {
                result = _connection.Query<T>(textCommand, commandType: commandType);
            }

            return result;
        }
        public override DataTable ExecuteProcedure(string procedureName) =>
            this.Query(procedureName, eExecutionType.StoredProcedure);
        public override IEnumerable<T> ExecuteProcedure<T>(string procedureName) =>
            this.Query<T>(procedureName, eExecutionType.StoredProcedure);
    }
}