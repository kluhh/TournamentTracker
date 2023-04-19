namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          
            ApplicationConfiguration.Initialize();

            //Initial the database connections
            TrackerLibrary.GlobalConfig.InitializeConnections(TrackerLibrary.DatabaseType.Sql);
            //Application.Run(new tournamentDashboardForm());

            Application.Run(new createTournamentForm());

        }
    }
}