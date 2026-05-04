using System.Text.Json;

namespace WinFormsApp_GameTracker
{
    public class DataManager
    {
        private GameRepository _repository;
        private string _dataPath = Path.Combine(Application.StartupPath, "game_stats.json");
        private Dictionary<string, GameStats> _gamesStats; // Dictionary для быстрого поиска

        public DataManager()
        {
            _repository = new GameRepository();
            _gamesStats = [];
            LoadData();
            SyncWithRepository();
        }

        private void LoadData()
        {
            if (File.Exists(_dataPath))
            {
                string json = File.ReadAllText(_dataPath);
                _gamesStats = JsonSerializer.Deserialize<Dictionary<string, GameStats>>(json)
                    ?? new Dictionary<string, GameStats>();
            }
            else
            {
                _gamesStats = new Dictionary<string, GameStats>();
                SaveData();
            }
        }

        private void SyncWithRepository()
        {
            foreach (var game in _repository.Games)
            {
                if (!_gamesStats.ContainsKey(game.Name!))
                {
                    _gamesStats[game.Name!] = new GameStats
                    {
                        Name = game.Name,
                        AllSessionTime = TimeSpan.Zero,
                        LastSessionTime = TimeSpan.Zero
                    };
                }
            }
            SaveData();
        }

        public void SaveData()
        {
            string json = JsonSerializer.Serialize(_gamesStats, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_dataPath, json);
        }

        public void UpdateGameTime(string gameName, TimeSpan sessionTime)
        {
            if (_gamesStats.ContainsKey(gameName))
            {
                _gamesStats[gameName].AllSessionTime += sessionTime;
                _gamesStats[gameName].LastSessionTime = sessionTime;
                SaveData();
            }
        }

        public GameStats? GetGameStats(string gameName)
        {
            return _gamesStats.GetValueOrDefault(gameName);
        }

        public GameInfo? GetGameInfo(string gameName)
        {
            return _repository.GetGameInfo(gameName);
        }

        // Возвращаем List для формы
        public List<GameInfo> GetAllGames()
        {
            return _repository.Games;
        }
    }
}
