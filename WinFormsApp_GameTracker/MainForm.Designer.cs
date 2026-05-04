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
            GamesDataGridView = new DataGridView();
            GameNameColumn = new DataGridViewTextBoxColumn();
            ProcessNameColumn = new DataGridViewTextBoxColumn();
            PathColumn = new DataGridViewTextBoxColumn();
            StartGameColumn = new DataGridViewButtonColumn();
            ViewStatisticsColumn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)GamesDataGridView).BeginInit();
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
            GamesDataGridView.Location = new Point(-1, 80);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(GamesDataGridView);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)GamesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GamesDataGridView;
        private DataGridViewTextBoxColumn GameNameColumn;
        private DataGridViewTextBoxColumn ProcessNameColumn;
        private DataGridViewTextBoxColumn PathColumn;
        private DataGridViewButtonColumn StartGameColumn;
        private DataGridViewButtonColumn ViewStatisticsColumn;
    }
}
