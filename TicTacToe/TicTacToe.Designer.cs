
namespace TicTacToe {
    partial class TicTacToe {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.TurnLabel = new System.Windows.Forms.Label();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TurnLabel
            // 
            this.TurnLabel.AutoSize = true;
            this.TurnLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TurnLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TurnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TurnLabel.Location = new System.Drawing.Point(85, 333);
            this.TurnLabel.Name = "TurnLabel";
            this.TurnLabel.Size = new System.Drawing.Size(135, 24);
            this.TurnLabel.TabIndex = 0;
            this.TurnLabel.Text = "Ход игрока: X";
            // 
            // NewGameButton
            // 
            this.NewGameButton.Enabled = false;
            this.NewGameButton.Location = new System.Drawing.Point(89, 376);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(120, 40);
            this.NewGameButton.TabIndex = 1;
            this.NewGameButton.Text = "Начать новую игру";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 428);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.TurnLabel);
            this.Name = "TicTacToe";
            this.Text = "Крестики-Нолики";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TurnLabel;
        private System.Windows.Forms.Button NewGameButton;
    }
}