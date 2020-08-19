using System;

namespace DatabaseSolution.Generics.Factory
{
    public sealed class DatabaseFactory : DatabaseAbstractFactory
    {
        private readonly string _connectionString;

        public DatabaseFactory()
        {
            _connectionString = "";
        }

        public override Database CreateDatabaseMySql()
        {
            return new DatabaseMySql(_connectionString);
        }

        public override Database CreateDatabaseOracle()
        {
            return new DatabaseOracle(_connectionString);
        }

        public override Database CreateDatabaseSqlServer()
        {
            return new DatabaseSqlServer(_connectionString);
        }
    }
}