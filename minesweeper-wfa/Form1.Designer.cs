namespace minesweeper_wfa
{
    partial class mainWindow
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            minefield = new Panel();
            startButton = new Button();
            minesValueTextbox = new TextBox();
            minesLabel = new Label();
            timerLabel = new Label();
            timerValueTextbox = new TextBox();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // minefield
            // 
            minefield.BackColor = Color.DarkGray;
            minefield.Location = new Point(12, 68);
            minefield.Name = "minefield";
            minefield.Size = new Size(393, 393);
            minefield.TabIndex = 1;
            // 
            // startButton
            // 
            startButton.AutoSize = true;
            startButton.BackColor = Color.Gainsboro;
            startButton.FlatAppearance.BorderColor = Color.Brown;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Unispace", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.ForeColor = Color.Brown;
            startButton.Location = new Point(12, 9);
            startButton.Name = "startButton";
            startButton.Size = new Size(133, 52);
            startButton.TabIndex = 2;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // minesValueTextbox
            // 
            minesValueTextbox.BackColor = Color.Gainsboro;
            minesValueTextbox.Location = new Point(305, 9);
            minesValueTextbox.MaxLength = 2;
            minesValueTextbox.Name = "minesValueTextbox";
            minesValueTextbox.PlaceholderText = "min: 1";
            minesValueTextbox.Size = new Size(100, 22);
            minesValueTextbox.TabIndex = 6;
            // 
            // minesLabel
            // 
            minesLabel.AutoSize = true;
            minesLabel.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point);
            minesLabel.ForeColor = Color.Brown;
            minesLabel.Location = new Point(152, 12);
            minesLabel.Name = "minesLabel";
            minesLabel.Size = new Size(147, 14);
            minesLabel.TabIndex = 4;
            minesLabel.Text = "The Number of Mines:";
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point);
            timerLabel.ForeColor = Color.Brown;
            timerLabel.Location = new Point(250, 41);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(49, 14);
            timerLabel.TabIndex = 4;
            timerLabel.Text = "Timer:";
            // 
            // timerValueTextbox
            // 
            timerValueTextbox.BackColor = Color.Gainsboro;
            timerValueTextbox.ForeColor = SystemColors.WindowText;
            timerValueTextbox.Location = new Point(305, 38);
            timerValueTextbox.MaxLength = 5;
            timerValueTextbox.Name = "timerValueTextbox";
            timerValueTextbox.PlaceholderText = "mm:ss";
            timerValueTextbox.Size = new Size(100, 22);
            timerValueTextbox.TabIndex = 6;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // mainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(417, 473);
            Controls.Add(timerValueTextbox);
            Controls.Add(minesValueTextbox);
            Controls.Add(timerLabel);
            Controls.Add(minesLabel);
            Controls.Add(startButton);
            Controls.Add(minefield);
            Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "mainWindow";
            Text = "Minesweeper";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel minefield;
        private Button startButton;
        public TextBox minesValueTextbox;
        public Label minesLabel;
        public Label timerLabel;
        public TextBox timerValueTextbox;
        private System.Windows.Forms.Timer timer;
    }
}