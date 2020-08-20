using System;
using System.Collections.Generic;
using System.Data;
using DatabaseSolution.Generics.Enums;

namespace DatabaseSolution.Generics
{
    public class DatabaseOracle : Database
    {
        public DatabaseOracle(string connectionString) : base(connectionString)
        {
        }

        public override void AddParameter(string parameterName, object value)
        {
            throw new NotImplementedException();
        }

        public override void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public override void Execute(string textCommand, eExecutionType executionType)
        {
            throw new NotImplementedException();
        }

        public override DataTable ExecuteProcedure(string procedureName)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<T> ExecuteProcedure<T>(string procedureName)
        {
            throw new NotImplementedException();
        }

        public override void ExecuteProcedureWithoutReturn(string procedureName)
        {
            throw new NotImplementedException();
        }

        public override void OpenConnection()
        {
            throw new NotImplementedException();
        }

        public override DataTable Query(string textCommand, eExecutionType executionType)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<T> Query<T>(string textCommand, eExecutionType executionType)
        {
            throw new NotImplementedException();
        }
    }
}