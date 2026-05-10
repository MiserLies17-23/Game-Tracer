using IWshRuntimeLibrary;

namespace WinFormsApp_GameTracker
{
    /// <summary>
    /// Класс, представляющий репозиторий с играми.
    /// Содержит дирректорию с играми, управляет доступом к играм
    /// </summary>
    public class GameRepository
    {
        /// <summary> Путь к играм (по умолчанию) </summary>
        private static readonly string _defaultPath = @"C:\GOG Games";
        
        /// <summary> Список игр </summary>
        private List<GameInfo> _games;

        /// <summary>
        /// Свойство для списка игр.
        /// Только возвращает список всех игр
        /// </summary>
        public List<GameInfo> Games => _games;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public GameRepository()
        {
            _games = FindAllGames();
        }

        /// <summary>
        /// Метод для получения исполняемого файла игры по ярлыку
        /// </summary>
        /// <param name="shortcutPath"> Путь к ярлыку игры </param>
        /// <returns> Путь к исполняемому файлу игры </returns>
        private string? GetExecutablePathFromShortcut(string shortcutPath)
        {
            try
            {
                WshShell shell = new WshShell();
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);
                return shortcut.TargetPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка чтения ярлыка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Метод для поиска всех игр в директории
        /// </summary>
        /// <returns> Список всех найденных игр </returns>
        private List<GameInfo> FindAllGames()
        {
            var games = new List<GameInfo>();

            foreach (string gameFolder in Directory.GetDirectories(_defaultPath))
            {
                var lnkFiles = Directory.GetFiles(gameFolder, "*.lnk", SearchOption.AllDirectories);

                foreach (var lnkFile in lnkFiles)
                {
                    string? exePath = GetExecutablePathFromShortcut(lnkFile);

                    if (!string.IsNullOrEmpty(exePath) && System.IO.File.Exists(exePath))
                    {
                        games.Add(new GameInfo
                        {
                            Name = new DirectoryInfo(gameFolder).Name,
                            ProcessName = Path.GetFileNameWithoutExtension(exePath),
                            ExecutablePath = exePath,
                        });
                        break;
                    }
                }
            }

            return games;
        }

        /// <summary>
        /// Метод для получения информации об игре по названию
        /// </summary>
        /// <param name="gameName"> Навание игры </param>
        /// <returns> Информация об игре </returns>
        public GameInfo? GetGameInfo(string gameName)
        {
            return _games.FirstOrDefault(g => g.Name == gameName);
        }
    }
}
