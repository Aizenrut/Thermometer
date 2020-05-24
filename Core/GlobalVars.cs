namespace Core
{
    public static class GlobalVars
    {
        private static string _serverUsername;
        private static string _serverPassword;
        private static string _connectionString;
        private static string _defaultTemperatureMU;
        private static string _defaultHumidityMU;
        private static bool _continuePost = true;
        private static int _defaultShowAmount;

        public static string ServerUsername { get => _serverUsername; set => _serverUsername = value; }
        public static string ServerPassword { get => _serverPassword; set => _serverPassword = value; }

        public static string ConnectionString
        {
            get
            {
                return "Server=localhost;Database=master;Trusted_Connection=True;";
                //return $"Server=tcp:ieisenhut.database.windows.net,1433;Initial Catalog=test;Persist Security Info=False;User ID=igor.eisenhut;Password=@BEnner2018;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            }
            set
            {
                _connectionString = value;
            }
        }

        public static string DefaultTemperatureMU { get => _defaultTemperatureMU; set => _defaultTemperatureMU = value; }
        public static string DefaultHumidityMU { get => _defaultHumidityMU; set => _defaultHumidityMU = value; }
        public static bool ContinuePost { get => _continuePost; set => _continuePost = value; }
        public static int DefaultShowAmount { get => _defaultShowAmount; set => _defaultShowAmount = value; }
    }
}