using System.Text.Json;

namespace WinFormsApp_GameTracker
{
    /// <summary>
    /// Класс, представляющий основную логику взаимодействия с играми.
    /// Выполняет функцию сервиса при репозитории
    /// </summary>
    public class DataManager
    {
        /// <summary> Репозиторий с играми </summary>
        private GameRepository _repository;
        
        /// <summary> Путь к информации с игровой статистикой </summary>
        private string _dataPath = Path.Combine(Application.StartupPath, "game_stats.json");
        
        /// <summary> Словарь для быстрого поиска игр </summary>
        private Dictionary<string, GameStats> _gamesStats; // Dictionary для быстрого поиска

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public DataManager()
        {
            _repository = new GameRepository();
            _gamesStats = [];
            LoadData();
            SyncWithRepository();
        }

        /// <summary>
        /// Метод для загрузки игр
        /// </summary>
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

        /// <summary>
        /// Метод для синхронизации данных с репозиторием.
        /// Когда статистика игры обновляется, необходимо занести изменения в репозиторий
        /// </summary>
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

        /// <summary>
        /// Метод для сохранения данных об игре в json
        /// </summary>
        public void SaveData()
        {
            string json = JsonSerializer.Serialize(_gamesStats, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_dataPath, json);
        }

        /// <summary>
        /// Метод для обновления информации об игровых сессиях
        /// </summary>
        /// <param name="gameName"> Название игры </param>
        /// <param name="sessionTime"> Время последней сессии </param>
        public void UpdateGameTime(string gameName, TimeSpan sessionTime)
        {
            if (_gamesStats.ContainsKey(gameName))
            {
                _gamesStats[gameName].AllSessionTime += sessionTime;
                _gamesStats[gameName].LastSessionTime = sessionTime;
                SaveData();
            }
        }

        /// <summary>
        /// Метод для получения игровой статистики.
        /// Нужен для формы отображения статистики
        /// </summary>
        /// <param name="gameName"> Название игры </param>
        /// <returns> Статистика игры </returns>
        public GameStats? GetGameStats(string gameName)
        {
            return _gamesStats.GetValueOrDefault(gameName);
        }

        /// <summary>
        /// Метод для получения основной информации об игре.
        /// Нужен для формы отображения статистики
        /// </summary>
        /// <param name="gameName"> Название игры </param>
        /// <returns> Информация об игре </returns>
        public GameInfo? GetGameInfo(string gameName)
        {
            return _repository.GetGameInfo(gameName);
        }

        /// <summary>
        /// Метод для получения информации обо всех играх репозитория.
        /// Нужен для формы отображения статистики
        /// </summary>
        /// <returns> Список всех игр </returns>
        public List<GameInfo> GetAllGames()
        {
            return _repository.Games;
        }
    }
}
