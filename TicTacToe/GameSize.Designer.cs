
namespace TicTacToe {
    partial class GameSize {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSize));
            this.GameInfo = new System.Windows.Forms.Label();
            this.GameSizeLabel1 = new System.Windows.Forms.Label();
            this.GameSizeLabel2 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.GameSizeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GameInfo
            // 
            this.GameInfo.AutoSize = true;
            this.GameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameInfo.Location = new System.Drawing.Point(144, 9);
            this.GameInfo.Name = "GameInfo";
            this.GameInfo.Size = new System.Drawing.Size(181, 24);
            this.GameInfo.TabIndex = 0;
            this.GameInfo.Text = "Крестики-Нолики";
            // 
            // GameSizeLabel1
            // 
            this.GameSizeLabel1.AutoSize = true;
            this.GameSizeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameSizeLabel1.Location = new System.Drawing.Point(12, 44);
            this.GameSizeLabel1.Name = "GameSizeLabel1";
            this.GameSizeLabel1.Size = new System.Drawing.Size(444, 24);
            this.GameSizeLabel1.TabIndex = 1;
            this.GameSizeLabel1.Text = "Введите размерность игрового поля (от 3 до 5)";
            // 
            // GameSizeLabel2
            // 
            this.GameSizeLabel2.AutoSize = true;
            this.GameSizeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameSizeLabel2.Location = new System.Drawing.Point(12, 79);
            this.GameSizeLabel2.Name = "GameSizeLabel2";
            this.GameSizeLabel2.Size = new System.Drawing.Size(271, 24);
            this.GameSizeLabel2.TabIndex = 2;
            this.GameSizeLabel2.Text = "Размерность игрового поля:";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(148, 109);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(177, 43);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Начать игру";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // GameSizeTextBox
            // 
            this.GameSizeTextBox.Location = new System.Drawing.Point(353, 84);
            this.GameSizeTextBox.Name = "GameSizeTextBox";
            this.GameSizeTextBox.Size = new System.Drawing.Size(101, 20);
            this.GameSizeTextBox.TabIndex = 4;
            this.GameSizeTextBox.Text = "3";
            this.GameSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GameSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(466, 164);
            this.Controls.Add(this.GameSizeTextBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.GameSizeLabel2);
            this.Controls.Add(this.GameSizeLabel1);
            this.Controls.Add(this.GameInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameSize";
            this.Text = "Размер игрового поля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameInfo;
        private System.Windows.Forms.Label GameSizeLabel1;
        private System.Windows.Forms.Label GameSizeLabel2;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox GameSizeTextBox;
    }
}

