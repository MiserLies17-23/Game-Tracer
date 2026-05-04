using IWshRuntimeLibrary;

namespace WinFormsApp_GameTracker
{
    public class GameRepository
    {
        private static readonly string _defaultPath = @"C:\GOG Games";
        private List<GameInfo> _games;

        public List<GameInfo> Games => _games;

        public GameRepository()
        {
            _games = FindAllGames();
        }

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

        public GameInfo? GetGameInfo(string gameName)
        {
            return _games.FirstOrDefault(g => g.Name == gameName);
        }
    }
}
