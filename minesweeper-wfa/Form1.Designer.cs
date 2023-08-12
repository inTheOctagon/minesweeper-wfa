namespace minesweeper_wfa
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            Minefield = new Panel();
            StartButton = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // Minefield
            // 
            Minefield.BackColor = Color.DarkGray;
            Minefield.Location = new Point(12, 68);
            Minefield.Name = "Minefield";
            Minefield.Size = new Size(393, 393);
            Minefield.TabIndex = 1;
            // 
            // StartButton
            // 
            StartButton.AutoSize = true;
            StartButton.BackColor = Color.Gainsboro;
            StartButton.FlatStyle = FlatStyle.Popup;
            StartButton.Font = new Font("Unispace", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            StartButton.ForeColor = Color.Brown;
            StartButton.Location = new Point(12, 9);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(133, 52);
            StartButton.TabIndex = 2;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.Location = new Point(305, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 22);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(152, 12);
            label3.Name = "label3";
            label3.Size = new Size(147, 14);
            label3.TabIndex = 4;
            label3.Text = "The Number of Mines:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Brown;
            label6.Location = new Point(250, 41);
            label6.Name = "label6";
            label6.Size = new Size(49, 14);
            label6.TabIndex = 4;
            label6.Text = "Timer:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Gainsboro;
            textBox2.ForeColor = Color.Brown;
            textBox2.Location = new Point(305, 38);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "mm:ss";
            textBox2.Size = new Size(100, 22);
            textBox2.TabIndex = 6;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(417, 473);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(StartButton);
            Controls.Add(Minefield);
            Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "Minesweeper";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel Minefield;
        private Button StartButton;
        private TextBox textBox1;
        private Label label3;
        private Label label6;
        private TextBox textBox2;
    }
}