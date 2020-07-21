namespace TestGame
{
    partial class settingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.tbMaxPerTurn = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lblMaxPerTurn = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.gbGameMode = new System.Windows.Forms.GroupBox();
            this.rbDefault = new System.Windows.Forms.RadioButton();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.pbAI = new System.Windows.Forms.PictureBox();
            this.bt_start = new System.Windows.Forms.Button();
            this.cbFirstTurnAI = new System.Windows.Forms.CheckBox();
            this.gbSettings.SuspendLayout();
            this.gbGameMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAI)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSettings
            // 
            this.gbSettings.BackColor = System.Drawing.Color.Transparent;
            this.gbSettings.Controls.Add(this.cbFirstTurnAI);
            this.gbSettings.Controls.Add(this.tbMaxPerTurn);
            this.gbSettings.Controls.Add(this.tbAmount);
            this.gbSettings.Controls.Add(this.lblMaxPerTurn);
            this.gbSettings.Controls.Add(this.lblAmount);
            this.gbSettings.Controls.Add(this.gbGameMode);
            this.gbSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSettings.ForeColor = System.Drawing.Color.White;
            this.gbSettings.Location = new System.Drawing.Point(12, 40);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(295, 328);
            this.gbSettings.TabIndex = 0;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // tbMaxPerTurn
            // 
            this.tbMaxPerTurn.Location = new System.Drawing.Point(15, 235);
            this.tbMaxPerTurn.Name = "tbMaxPerTurn";
            this.tbMaxPerTurn.Size = new System.Drawing.Size(70, 31);
            this.tbMaxPerTurn.TabIndex = 6;
            this.tbMaxPerTurn.Text = "4";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(15, 181);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(70, 31);
            this.tbAmount.TabIndex = 5;
            this.tbAmount.Text = "21";
            // 
            // lblMaxPerTurn
            // 
            this.lblMaxPerTurn.AutoSize = true;
            this.lblMaxPerTurn.Location = new System.Drawing.Point(88, 238);
            this.lblMaxPerTurn.Name = "lblMaxPerTurn";
            this.lblMaxPerTurn.Size = new System.Drawing.Size(200, 25);
            this.lblMaxPerTurn.TabIndex = 4;
            this.lblMaxPerTurn.Text = "-max sticks per turn";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(86, 184);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(182, 25);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "- number of sticks";
            // 
            // gbGameMode
            // 
            this.gbGameMode.Controls.Add(this.rbDefault);
            this.gbGameMode.Controls.Add(this.rbCustom);
            this.gbGameMode.ForeColor = System.Drawing.Color.White;
            this.gbGameMode.Location = new System.Drawing.Point(15, 40);
            this.gbGameMode.Name = "gbGameMode";
            this.gbGameMode.Size = new System.Drawing.Size(161, 121);
            this.gbGameMode.TabIndex = 2;
            this.gbGameMode.TabStop = false;
            this.gbGameMode.Text = "Game Mode";
            // 
            // rbDefault
            // 
            this.rbDefault.AutoSize = true;
            this.rbDefault.Location = new System.Drawing.Point(7, 29);
            this.rbDefault.Name = "rbDefault";
            this.rbDefault.Size = new System.Drawing.Size(98, 29);
            this.rbDefault.TabIndex = 0;
            this.rbDefault.TabStop = true;
            this.rbDefault.Text = "Default";
            this.rbDefault.UseVisualStyleBackColor = true;
            this.rbDefault.CheckedChanged += new System.EventHandler(this.rbDefault_CheckedChanged);
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(6, 74);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(103, 29);
            this.rbCustom.TabIndex = 1;
            this.rbCustom.TabStop = true;
            this.rbCustom.Text = "Custom";
            this.rbCustom.UseVisualStyleBackColor = true;
            // 
            // pbAI
            // 
            this.pbAI.BackColor = System.Drawing.Color.Transparent;
            this.pbAI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAI.BackgroundImage")));
            this.pbAI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAI.Location = new System.Drawing.Point(372, 26);
            this.pbAI.Name = "pbAI";
            this.pbAI.Size = new System.Drawing.Size(357, 456);
            this.pbAI.TabIndex = 1;
            this.pbAI.TabStop = false;
            // 
            // bt_start
            // 
            this.bt_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_start.Location = new System.Drawing.Point(34, 374);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(251, 94);
            this.bt_start.TabIndex = 2;
            this.bt_start.Text = "Start Game";
            this.bt_start.UseVisualStyleBackColor = false;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // cbFirstTurnAI
            // 
            this.cbFirstTurnAI.AutoSize = true;
            this.cbFirstTurnAI.ForeColor = System.Drawing.Color.White;
            this.cbFirstTurnAI.Location = new System.Drawing.Point(58, 281);
            this.cbFirstTurnAI.Name = "cbFirstTurnAI";
            this.cbFirstTurnAI.Size = new System.Drawing.Size(141, 29);
            this.cbFirstTurnAI.TabIndex = 7;
            this.cbFirstTurnAI.Text = "First turn AI";
            this.cbFirstTurnAI.UseVisualStyleBackColor = true;
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 483);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.pbAI);
            this.Controls.Add(this.gbSettings);
            this.DoubleBuffered = true;
            this.Name = "settingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "settingsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.settingsForm_FormClosing);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbGameMode.ResumeLayout(false);
            this.gbGameMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.TextBox tbMaxPerTurn;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lblMaxPerTurn;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.GroupBox gbGameMode;
        private System.Windows.Forms.RadioButton rbDefault;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.PictureBox pbAI;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.CheckBox cbFirstTurnAI;
    }
}