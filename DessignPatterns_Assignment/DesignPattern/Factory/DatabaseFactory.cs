namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType databaseType)
        {
            return databaseType == DatabaseType.SqlServer ? new SqlServerDatabase() : new OracleDatabase();
        }
    }
}
