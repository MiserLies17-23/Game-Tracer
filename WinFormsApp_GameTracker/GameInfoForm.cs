namespace WinFormsApp_GameTracker
{
    /// <summary>
    /// Форма для отображения статистики игр
    /// </summary>
    public partial class GameInfoForm : Form
    {
        /// <summary> Информация об игре </summary>
        private readonly GameInfo _gameInfo;

        /// <summary> Статистика игры </summary>
        private readonly GameStats _gameStats;

        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="gameInfo"> Информация об игре </param>
        /// <param name="gameStats"> Сатитистика игры </param>
        public GameInfoForm(GameInfo gameInfo, GameStats gameStats)
        {
            InitializeComponent();
            _gameInfo = gameInfo;
            _gameStats = gameStats;
        }

        /// <summary>
        /// Обработчик загрузки формы.
        /// Отображает данные об игре
        /// </summary>
        /// <param name="sender"> Объект-отправитель (форма) </param>
        /// <param name="e"> Аргументы событий </param>
        private void GameInfoForm_Load(object sender, EventArgs e)
        {
            GameNameLabel.Text = _gameInfo.Name;
            ProcessNameValueLabel.Text = _gameInfo.ProcessName;
            GamePathValueLabel.Text = _gameInfo.ExecutablePath;
            AllGameTimeValueLabel.Text = _gameStats?.AllSessionTime.ToString(@"hh\:mm\:ss") ?? "00:00:00";
            LastSessionTimeValueLabel.Text = _gameStats?.LastSessionTime.ToString(@"hh\:mm\:ss") ?? "00:00:00";
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Назад"
        /// </summary>
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Аргументы событий </param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
