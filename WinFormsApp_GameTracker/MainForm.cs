using System.Diagnostics;

namespace WinFormsApp_GameTracker
{
    /// <summary>
    /// Класс, представляющий глувную форму приложения.
    /// Отображает найденные игры, позволяет запустить и посмотреть статистику игры
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary> Экземпляр DataManager для реализации взаимодействия с игрой </summary>
        private readonly DataManager _dataManager;
        
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _dataManager = new DataManager();
        }

        /// <summary>
        /// Обработчик загрузки формы
        /// </summary>
        /// <param name="sender"> Объект-отправитель (форма) </param>
        /// <param name="e"> Аргументы события </param>
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

        /// <summary>
        /// Обработчик событий для кнопок таблицы
        /// </summary>
        /// <param name="sender"> Объект отправитель (кнопка ячейки) </param>
        /// <param name="e"> Аргументы событий ячеек таблицы </param>
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

        /// <summary>
        /// Асинхронный метод запуска игр
        /// </summary>
        /// <param name="executablePath"> Путь исполняемого файла </param>
        /// <param name="gameName"> Название игры </param>
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

        /// <summary>
        /// Метод загрузки игр в таблицу
        /// </summary>
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

        /// <summary>
        /// Обработчик событий для кнопки "Выход"
        /// </summary>
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Аргументы событий </param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
