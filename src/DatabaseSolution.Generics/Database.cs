using DatabaseSolution.Generics.Enums;
using DatabaseSolution.Generics.Interfaces;
using System.Collections.Generic;
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
        public abstract IEnumerable<T> ExecuteProcedure<T>(string procedureName) where T : class;
        public abstract void Execute(string textCommand, eExecutionType executionType);
        public abstract DataTable Query(string textCommand, eExecutionType executionType);
        public abstract IEnumerable<T> Query<T>(string textCommand, eExecutionType executionType) where T : class;
    }
}