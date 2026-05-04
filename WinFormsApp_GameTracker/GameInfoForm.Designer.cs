namespace WinFormsApp_GameTracker
{
    partial class GameInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HeaderLabel = new Label();
            GameNameLabel = new Label();
            ProcessNameHeaderLabel = new Label();
            GamePathHeaderLabel = new Label();
            AllGameTimeHeaderLabel = new Label();
            LastSessionTimeHeaderLabel = new Label();
            BackButton = new Button();
            ProcessNameValueLabel = new Label();
            GamePathValueLabel = new Label();
            AllGameTimeValueLabel = new Label();
            LastSessionTimeValueLabel = new Label();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            HeaderLabel.Location = new Point(156, 9);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(224, 28);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "Информация об игре";
            // 
            // GameNameLabel
            // 
            GameNameLabel.AutoSize = true;
            GameNameLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GameNameLabel.Location = new Point(193, 52);
            GameNameLabel.Name = "GameNameLabel";
            GameNameLabel.Size = new Size(141, 25);
            GameNameLabel.TabIndex = 1;
            GameNameLabel.Text = "Название игры";
            // 
            // ProcessNameHeaderLabel
            // 
            ProcessNameHeaderLabel.AutoSize = true;
            ProcessNameHeaderLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ProcessNameHeaderLabel.Location = new Point(12, 87);
            ProcessNameHeaderLabel.Name = "ProcessNameHeaderLabel";
            ProcessNameHeaderLabel.Size = new Size(176, 25);
            ProcessNameHeaderLabel.TabIndex = 2;
            ProcessNameHeaderLabel.Text = "Название процесса:";
            // 
            // GamePathHeaderLabel
            // 
            GamePathHeaderLabel.AutoSize = true;
            GamePathHeaderLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GamePathHeaderLabel.Location = new Point(12, 122);
            GamePathHeaderLabel.Name = "GamePathHeaderLabel";
            GamePathHeaderLabel.Size = new Size(150, 25);
            GamePathHeaderLabel.TabIndex = 3;
            GamePathHeaderLabel.Text = "Путь к процессу:";
            // 
            // AllGameTimeHeaderLabel
            // 
            AllGameTimeHeaderLabel.AutoSize = true;
            AllGameTimeHeaderLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AllGameTimeHeaderLabel.Location = new Point(12, 158);
            AllGameTimeHeaderLabel.Name = "AllGameTimeHeaderLabel";
            AllGameTimeHeaderLabel.Size = new Size(176, 25);
            AllGameTimeHeaderLabel.TabIndex = 4;
            AllGameTimeHeaderLabel.Text = "Общее время игры:";
            // 
            // LastSessionTimeHeaderLabel
            // 
            LastSessionTimeHeaderLabel.AutoSize = true;
            LastSessionTimeHeaderLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LastSessionTimeHeaderLabel.Location = new Point(12, 195);
            LastSessionTimeHeaderLabel.Name = "LastSessionTimeHeaderLabel";
            LastSessionTimeHeaderLabel.Size = new Size(217, 25);
            LastSessionTimeHeaderLabel.TabIndex = 5;
            LastSessionTimeHeaderLabel.Text = "Время последней сессии:";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(212, 233);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 6;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ProcessNameValueLabel
            // 
            ProcessNameValueLabel.AutoSize = true;
            ProcessNameValueLabel.Location = new Point(278, 92);
            ProcessNameValueLabel.Name = "ProcessNameValueLabel";
            ProcessNameValueLabel.Size = new Size(75, 20);
            ProcessNameValueLabel.TabIndex = 7;
            ProcessNameValueLabel.Text = "значение";
            // 
            // GamePathValueLabel
            // 
            GamePathValueLabel.AutoSize = true;
            GamePathValueLabel.Location = new Point(278, 126);
            GamePathValueLabel.Name = "GamePathValueLabel";
            GamePathValueLabel.Size = new Size(75, 20);
            GamePathValueLabel.TabIndex = 8;
            GamePathValueLabel.Text = "значение";
            // 
            // AllGameTimeValueLabel
            // 
            AllGameTimeValueLabel.AutoSize = true;
            AllGameTimeValueLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AllGameTimeValueLabel.Location = new Point(278, 162);
            AllGameTimeValueLabel.Name = "AllGameTimeValueLabel";
            AllGameTimeValueLabel.Size = new Size(76, 20);
            AllGameTimeValueLabel.TabIndex = 9;
            AllGameTimeValueLabel.Text = "значение";
            // 
            // LastSessionTimeValueLabel
            // 
            LastSessionTimeValueLabel.AutoSize = true;
            LastSessionTimeValueLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LastSessionTimeValueLabel.Location = new Point(278, 199);
            LastSessionTimeValueLabel.Name = "LastSessionTimeValueLabel";
            LastSessionTimeValueLabel.Size = new Size(76, 20);
            LastSessionTimeValueLabel.TabIndex = 10;
            LastSessionTimeValueLabel.Text = "значение";
            // 
            // GameInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 266);
            Controls.Add(LastSessionTimeValueLabel);
            Controls.Add(AllGameTimeValueLabel);
            Controls.Add(GamePathValueLabel);
            Controls.Add(ProcessNameValueLabel);
            Controls.Add(BackButton);
            Controls.Add(LastSessionTimeHeaderLabel);
            Controls.Add(AllGameTimeHeaderLabel);
            Controls.Add(GamePathHeaderLabel);
            Controls.Add(ProcessNameHeaderLabel);
            Controls.Add(GameNameLabel);
            Controls.Add(HeaderLabel);
            Name = "GameInfoForm";
            Text = "GameInfoForm";
            Load += GameInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label GameNameLabel;
        private Label ProcessNameHeaderLabel;
        private Label GamePathHeaderLabel;
        private Label AllGameTimeHeaderLabel;
        private Label LastSessionTimeHeaderLabel;
        private Button BackButton;
        private Label ProcessNameValueLabel;
        private Label GamePathValueLabel;
        private Label AllGameTimeValueLabel;
        private Label LastSessionTimeValueLabel;
    }
}