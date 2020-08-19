namespace DatabaseSolution.Generics.Factory
{
    public abstract class DatabaseAbstractFactory
    {
        public abstract Database CreateDatabaseMySql();
        public abstract Database CreateDatabaseOracle();
        public abstract Database CreateDatabaseSqlServer();
    }
}