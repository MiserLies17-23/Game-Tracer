namespace WinFormsApp_GameTracker
{
    public partial class GameInfoForm : Form
    {
        private readonly GameInfo _gameInfo;
        private readonly GameStats _gameStats;

        public GameInfoForm(GameInfo gameInfo, GameStats gameStats)
        {
            InitializeComponent();
            _gameInfo = gameInfo;
            _gameStats = gameStats;
        }

        private void GameInfoForm_Load(object sender, EventArgs e)
        {
            GameNameLabel.Text = _gameInfo.Name;
            ProcessNameValueLabel.Text = _gameInfo.ProcessName;
            GamePathValueLabel.Text = _gameInfo.ExecutablePath;
            AllGameTimeValueLabel.Text = _gameStats?.AllSessionTime.ToString(@"hh\:mm\:ss") ?? "00:00:00";
            LastSessionTimeValueLabel.Text = _gameStats?.LastSessionTime.ToString(@"hh\:mm\:ss") ?? "00:00:00";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
