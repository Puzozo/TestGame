namespace TestGame
{
    partial class gameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameForm));
            this.btnTurn = new System.Windows.Forms.Button();
            this.tbChosenNumberOfSticksByPlayer = new System.Windows.Forms.TextBox();
            this.lblRemainSticks = new System.Windows.Forms.Label();
            this.lblEntireAmount = new System.Windows.Forms.Label();
            this.lblAIPoints = new System.Windows.Forms.Label();
            this.lblInfoAIPoints = new System.Windows.Forms.Label();
            this.lblPlayerPoints = new System.Windows.Forms.Label();
            this.lblInfoPlayerPoints = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.pbStick = new System.Windows.Forms.PictureBox();
            this.pbAIWin = new System.Windows.Forms.PictureBox();
            this.pbAILose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbStick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAIWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAILose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTurn
            // 
            this.btnTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTurn.Location = new System.Drawing.Point(169, 331);
            this.btnTurn.Name = "btnTurn";
            this.btnTurn.Size = new System.Drawing.Size(128, 28);
            this.btnTurn.TabIndex = 0;
            this.btnTurn.Text = "Get Sticks";
            this.btnTurn.UseVisualStyleBackColor = false;
            this.btnTurn.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // tbChosenNumberOfSticksByPlayer
            // 
            this.tbChosenNumberOfSticksByPlayer.Location = new System.Drawing.Point(80, 336);
            this.tbChosenNumberOfSticksByPlayer.Name = "tbChosenNumberOfSticksByPlayer";
            this.tbChosenNumberOfSticksByPlayer.Size = new System.Drawing.Size(74, 20);
            this.tbChosenNumberOfSticksByPlayer.TabIndex = 1;
            this.tbChosenNumberOfSticksByPlayer.Text = "1";
            // 
            // lblRemainSticks
            // 
            this.lblRemainSticks.AutoSize = true;
            this.lblRemainSticks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRemainSticks.ForeColor = System.Drawing.Color.White;
            this.lblRemainSticks.Location = new System.Drawing.Point(26, 29);
            this.lblRemainSticks.Name = "lblRemainSticks";
            this.lblRemainSticks.Size = new System.Drawing.Size(252, 31);
            this.lblRemainSticks.TabIndex = 2;
            this.lblRemainSticks.Text = "Осталось палочек:";
           
            // 
            // lblEntireAmount
            // 
            this.lblEntireAmount.AutoSize = true;
            this.lblEntireAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEntireAmount.ForeColor = System.Drawing.Color.White;
            this.lblEntireAmount.Location = new System.Drawing.Point(370, 35);
            this.lblEntireAmount.Name = "lblEntireAmount";
            this.lblEntireAmount.Size = new System.Drawing.Size(24, 25);
            this.lblEntireAmount.TabIndex = 3;
            this.lblEntireAmount.Text = "_";
           
            // 
            // lblAIPoints
            // 
            this.lblAIPoints.AutoSize = true;
            this.lblAIPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAIPoints.ForeColor = System.Drawing.Color.White;
            this.lblAIPoints.Location = new System.Drawing.Point(284, 122);
            this.lblAIPoints.Name = "lblAIPoints";
            this.lblAIPoints.Size = new System.Drawing.Size(24, 25);
            this.lblAIPoints.TabIndex = 5;
            this.lblAIPoints.Text = "_";
           
            // 
            // lblInfoAIPoints
            // 
            this.lblInfoAIPoints.AutoSize = true;
            this.lblInfoAIPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoAIPoints.ForeColor = System.Drawing.Color.White;
            this.lblInfoAIPoints.Location = new System.Drawing.Point(26, 122);
            this.lblInfoAIPoints.Name = "lblInfoAIPoints";
            this.lblInfoAIPoints.Size = new System.Drawing.Size(198, 31);
            this.lblInfoAIPoints.TabIndex = 4;
            this.lblInfoAIPoints.Text = "Палочек у ИИ:";
          
            // 
            // lblPlayerPoints
            // 
            this.lblPlayerPoints.AutoSize = true;
            this.lblPlayerPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayerPoints.ForeColor = System.Drawing.Color.White;
            this.lblPlayerPoints.Location = new System.Drawing.Point(284, 213);
            this.lblPlayerPoints.Name = "lblPlayerPoints";
            this.lblPlayerPoints.Size = new System.Drawing.Size(24, 25);
            this.lblPlayerPoints.TabIndex = 7;
            this.lblPlayerPoints.Text = "_";
           
            // 
            // lblInfoPlayerPoints
            // 
            this.lblInfoPlayerPoints.AutoSize = true;
            this.lblInfoPlayerPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoPlayerPoints.ForeColor = System.Drawing.Color.White;
            this.lblInfoPlayerPoints.Location = new System.Drawing.Point(26, 207);
            this.lblInfoPlayerPoints.Name = "lblInfoPlayerPoints";
            this.lblInfoPlayerPoints.Size = new System.Drawing.Size(242, 31);
            this.lblInfoPlayerPoints.TabIndex = 6;
            this.lblInfoPlayerPoints.Text = "Палочек у игрока:";
            
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWinner.Location = new System.Drawing.Point(163, 254);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 31);
            this.lblWinner.TabIndex = 8;
            // 
            // pbStick
            // 
            this.pbStick.BackColor = System.Drawing.Color.Transparent;
            this.pbStick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbStick.BackgroundImage")));
            this.pbStick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbStick.Location = new System.Drawing.Point(289, 12);
            this.pbStick.Name = "pbStick";
            this.pbStick.Size = new System.Drawing.Size(75, 75);
            this.pbStick.TabIndex = 9;
            this.pbStick.TabStop = false;
            // 
            // pbAIWin
            // 
            this.pbAIWin.BackColor = System.Drawing.Color.Transparent;
            this.pbAIWin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAIWin.BackgroundImage")));
            this.pbAIWin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAIWin.Location = new System.Drawing.Point(44, 241);
            this.pbAIWin.Name = "pbAIWin";
            this.pbAIWin.Size = new System.Drawing.Size(75, 75);
            this.pbAIWin.TabIndex = 10;
            this.pbAIWin.TabStop = false;
            this.pbAIWin.Visible = false;
            // 
            // pbAILose
            // 
            this.pbAILose.BackColor = System.Drawing.Color.Transparent;
            this.pbAILose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAILose.BackgroundImage")));
            this.pbAILose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAILose.Location = new System.Drawing.Point(44, 241);
            this.pbAILose.Name = "pbAILose";
            this.pbAILose.Size = new System.Drawing.Size(75, 75);
            this.pbAILose.TabIndex = 11;
            this.pbAILose.TabStop = false;
            this.pbAILose.Visible = false;
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(492, 412);
            this.Controls.Add(this.pbAILose);
            this.Controls.Add(this.pbAIWin);
            this.Controls.Add(this.pbStick);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblPlayerPoints);
            this.Controls.Add(this.lblInfoPlayerPoints);
            this.Controls.Add(this.lblAIPoints);
            this.Controls.Add(this.lblInfoAIPoints);
            this.Controls.Add(this.lblEntireAmount);
            this.Controls.Add(this.lblRemainSticks);
            this.Controls.Add(this.tbChosenNumberOfSticksByPlayer);
            this.Controls.Add(this.btnTurn);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "gameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitaiskiy Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.gameForm_FormClosing);
            
            ((System.ComponentModel.ISupportInitialize)(this.pbStick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAIWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAILose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTurn;
        private System.Windows.Forms.TextBox tbChosenNumberOfSticksByPlayer;
        private System.Windows.Forms.Label lblRemainSticks;
        private System.Windows.Forms.Label lblEntireAmount;
        private System.Windows.Forms.Label lblAIPoints;
        private System.Windows.Forms.Label lblInfoAIPoints;
        private System.Windows.Forms.Label lblPlayerPoints;
        private System.Windows.Forms.Label lblInfoPlayerPoints;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.PictureBox pbStick;
        private System.Windows.Forms.PictureBox pbAIWin;
        private System.Windows.Forms.PictureBox pbAILose;
    }
}

