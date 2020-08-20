using DatabaseSolution.Generics.Enums;
using Microsoft.Extensions.Configuration;

namespace DatabaseSolution.Generics.Factory
{
    public class DatabaseFactory : DatabaseAbstractFactory
    {
        private readonly string _connectionString;

        public DatabaseFactory(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
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

        public override Database GetInstance(eConnectionType connectionType)
        {
            Database result = null;

            switch (connectionType)
            {
                case eConnectionType.SqlServer:
                    result = CreateDatabaseSqlServer();
                    break;
                case eConnectionType.Oracle:
                    result = CreateDatabaseOracle();
                    break;
                case eConnectionType.MySql:
                    result = CreateDatabaseMySql();
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}