using DatabaseSolution.Generics.Enums;

namespace DatabaseSolution.Generics.Factory
{
    public abstract class DatabaseAbstractFactory
    {
        public abstract Database CreateDatabaseMySql();
        public abstract Database CreateDatabaseOracle();
        public abstract Database CreateDatabaseSqlServer();
        public abstract Database GetInstance(eConnectionType connectionType);
    }
}