namespace WinFormsApp_GameTracker
{
    /// <summary>
    /// Класс, предоставляющий общуюю информацию об игре
    /// </summary>
    public class GameInfo
    {
        /// <summary>
        /// Название игры
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Название исполняемого файла
        /// </summary>
        public string? ProcessName { get; set; }

        /// <summary>
        /// Путь к исполняемому файлу
        /// </summary>
        public string? ExecutablePath { get; set; }
    }
}
