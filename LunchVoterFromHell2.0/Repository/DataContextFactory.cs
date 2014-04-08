namespace Repository
{
    public static class DataContextFactory
    {
        public static IDataContext CreateContext()
        {
            return new DataContext();
        }
    }
}