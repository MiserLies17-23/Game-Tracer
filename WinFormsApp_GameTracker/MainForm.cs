using System.Diagnostics;

namespace WinFormsApp_GameTracker
{
    public partial class MainForm : Form
    {
        private readonly DataManager _dataManager;
        public MainForm()
        {
            InitializeComponent();
            _dataManager = new DataManager();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllGames();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void GamesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

                var gameName = (string)GamesDataGridView.Rows[e.RowIndex].Cells[0].Value;
                if (e.RowIndex >= 0 && e.ColumnIndex == 3)
                {
                    string gamePath = (string)GamesDataGridView.Rows[e.RowIndex].Cells[2].Value;
                    LaunchGame(gamePath, gameName);
                }
                else if (e.RowIndex >= 0 && e.ColumnIndex == 4)
                {
                    var gameInfo = _dataManager.GetGameInfo(gameName);
                    var gameStats = _dataManager.GetGameStats(gameName);
                    var gameInfoForm = new GameInfoForm(gameInfo!, gameStats!);

                    gameInfoForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка работы с файлом", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LaunchGame(string executablePath, string gameName)
        {
            try
            {
                if (!System.IO.File.Exists(executablePath))
                {
                    MessageBox.Show("Файл игры не найден");
                    return;
                }

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                await Task.Run(() =>
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = executablePath,
                        UseShellExecute = true
                    };

                    using Process? process = Process.Start(startInfo);
                    process!.WaitForExit();
                });
                stopwatch.Stop();

                TimeSpan timeSpan = stopwatch.Elapsed;

                _dataManager.UpdateGameTime(gameName, timeSpan);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка запуска: {ex.Message}");
            }
        }

        private void LoadAllGames()
        {
            var games = _dataManager.GetAllGames();
            GamesDataGridView.Rows.Clear();

            foreach (var game in games)
            {
                int rowIndex = GamesDataGridView.Rows.Add();
                GamesDataGridView.Rows[rowIndex].Cells[0].Value = game.Name;
                GamesDataGridView.Rows[rowIndex].Cells[1].Value = game.ProcessName;
                GamesDataGridView.Rows[rowIndex].Cells[2].Value = game.ExecutablePath;
                GamesDataGridView.Rows[rowIndex].Cells[3].Value = "Запустить";
                GamesDataGridView.Rows[rowIndex].Cells[4].Value = "Статистика";
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
