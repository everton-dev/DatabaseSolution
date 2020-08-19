using DatabaseSolution.Generics.Enums;
using DatabaseSolution.Generics.Interfaces;
using System.Data;

namespace DatabaseSolution.Generics
{
    public abstract class Database : IDatabase
    {
        protected readonly string _connectionString;

        public Database(string connectionString)
        {
            _connectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
        public abstract void AddParameter(string parameterName, object value);
        public abstract void ExecuteProcedureWithoutReturn(string procedureName);
        public abstract DataTable ExecuteProcedure(string procedureName);
        public abstract void Execute(string textCommand, eExecutionType executionType);
        public abstract DataTable Query(string textCommand, eExecutionType executionType);
    }
}