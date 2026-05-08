namespace WinFormsApp_GameTracker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            GamesDataGridView = new DataGridView();
            GameNameColumn = new DataGridViewTextBoxColumn();
            ProcessNameColumn = new DataGridViewTextBoxColumn();
            PathColumn = new DataGridViewTextBoxColumn();
            StartGameColumn = new DataGridViewButtonColumn();
            ViewStatisticsColumn = new DataGridViewButtonColumn();
            ExitButton = new Button();
            HeaderLabel = new Label();
            GameInfoPanel = new Panel();
            GameListLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)GamesDataGridView).BeginInit();
            GameInfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // GamesDataGridView
            // 
            GamesDataGridView.AllowUserToAddRows = false;
            GamesDataGridView.AllowUserToDeleteRows = false;
            GamesDataGridView.AllowUserToResizeColumns = false;
            GamesDataGridView.AllowUserToResizeRows = false;
            GamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GamesDataGridView.Columns.AddRange(new DataGridViewColumn[] { GameNameColumn, ProcessNameColumn, PathColumn, StartGameColumn, ViewStatisticsColumn });
            GamesDataGridView.Location = new Point(0, 35);
            GamesDataGridView.Name = "GamesDataGridView";
            GamesDataGridView.RowHeadersVisible = false;
            GamesDataGridView.RowHeadersWidth = 51;
            GamesDataGridView.Size = new Size(978, 188);
            GamesDataGridView.TabIndex = 0;
            GamesDataGridView.CellContentClick += GamesDataGridView_CellContentClick;
            // 
            // GameNameColumn
            // 
            GameNameColumn.HeaderText = "Название";
            GameNameColumn.MinimumWidth = 6;
            GameNameColumn.Name = "GameNameColumn";
            GameNameColumn.Width = 200;
            // 
            // ProcessNameColumn
            // 
            ProcessNameColumn.HeaderText = "Процесс";
            ProcessNameColumn.MinimumWidth = 6;
            ProcessNameColumn.Name = "ProcessNameColumn";
            ProcessNameColumn.Width = 125;
            // 
            // PathColumn
            // 
            PathColumn.HeaderText = "Расположение";
            PathColumn.MinimumWidth = 6;
            PathColumn.Name = "PathColumn";
            PathColumn.Width = 400;
            // 
            // StartGameColumn
            // 
            StartGameColumn.HeaderText = "Запустить";
            StartGameColumn.MinimumWidth = 6;
            StartGameColumn.Name = "StartGameColumn";
            StartGameColumn.Width = 125;
            // 
            // ViewStatisticsColumn
            // 
            ViewStatisticsColumn.HeaderText = "Статистика";
            ViewStatisticsColumn.MinimumWidth = 6;
            ViewStatisticsColumn.Name = "ViewStatisticsColumn";
            ViewStatisticsColumn.Width = 125;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(12, 287);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            HeaderLabel.Location = new Point(331, 9);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(319, 25);
            HeaderLabel.TabIndex = 2;
            HeaderLabel.Text = "Отслеживание игрвоой статистики";
            // 
            // GameInfoPanel
            // 
            GameInfoPanel.BorderStyle = BorderStyle.FixedSingle;
            GameInfoPanel.Controls.Add(GameListLabel);
            GameInfoPanel.Controls.Add(GamesDataGridView);
            GameInfoPanel.Location = new Point(1, 37);
            GameInfoPanel.Name = "GameInfoPanel";
            GameInfoPanel.Size = new Size(981, 244);
            GameInfoPanel.TabIndex = 3;
            // 
            // GameListLabel
            // 
            GameListLabel.AutoSize = true;
            GameListLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GameListLabel.Location = new Point(422, 9);
            GameListLabel.Name = "GameListLabel";
            GameListLabel.Size = new Size(100, 23);
            GameListLabel.TabIndex = 1;
            GameListLabel.Text = "Список игр";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 328);
            Controls.Add(GameInfoPanel);
            Controls.Add(HeaderLabel);
            Controls.Add(ExitButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game-Tracker";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)GamesDataGridView).EndInit();
            GameInfoPanel.ResumeLayout(false);
            GameInfoPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GamesDataGridView;
        private DataGridViewTextBoxColumn GameNameColumn;
        private DataGridViewTextBoxColumn ProcessNameColumn;
        private DataGridViewTextBoxColumn PathColumn;
        private DataGridViewButtonColumn StartGameColumn;
        private DataGridViewButtonColumn ViewStatisticsColumn;
        private Button ExitButton;
        private Label HeaderLabel;
        private Panel GameInfoPanel;
        private Label GameListLabel;
    }
}
