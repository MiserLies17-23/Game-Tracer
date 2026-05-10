namespace WinFormsApp_GameTracker
{
    /// <summary>
    /// Класс модели отображения статистики игр
    /// </summary>
    public class GameStats
    {
        /// <summary>
        /// Название игры
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Общее время всех игровых сессий
        /// </summary>
        public TimeSpan AllSessionTime { get; set; }

        /// <summary>
        /// Время последней игровой сессии
        /// </summary>
        public TimeSpan LastSessionTime { get; set; }
    }
}
