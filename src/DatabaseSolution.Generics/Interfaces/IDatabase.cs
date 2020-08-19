using DatabaseSolution.Generics.Enums;
using System.Data;

namespace DatabaseSolution.Generics.Interfaces
{
    public interface IDatabase
    {
        void OpenConnection();
        void CloseConnection();
        void AddParameter(string parameterName, object value);
        void ExecuteProcedureWithoutReturn(string procedureName);
        DataTable ExecuteProcedure(string procedureName);
        void Execute(string textCommand, eExecutionType executionType);
        DataTable Query(string textCommand, eExecutionType executionType);
    }
}