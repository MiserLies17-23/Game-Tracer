namespace WinFormsApp_GameTracker
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string dataFile = Path.Combine(Application.StartupPath, "game_stats.json");
            bool isFirstRun = !File.Exists(dataFile);

            if (isFirstRun)
            {
                MessageBox.Show("Добро пожаловать! Приложение будет отслеживать ваши игры.",
                              "Первый запуск", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Application.Run(new MainForm());
        }
    }
}