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
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Minefield
            // 
            Minefield.BackColor = Color.DarkGray;
            Minefield.Location = new Point(263, 12);
            Minefield.Name = "Minefield";
            Minefield.Size = new Size(393, 393);
            Minefield.TabIndex = 1;
            // 
            // StartButton
            // 
            StartButton.AutoSize = true;
            StartButton.BackColor = Color.Gainsboro;
            StartButton.FlatStyle = FlatStyle.Popup;
            StartButton.Font = new Font("Unispace", 15F, FontStyle.Bold, GraphicsUnit.Point);
            StartButton.Location = new Point(92, 45);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(80, 38);
            StartButton.TabIndex = 2;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Unispace", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(195, 366);
            label1.Name = "label1";
            label1.Size = new Size(57, 39);
            label1.TabIndex = 5;
            label1.Text = "30";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.Location = new Point(157, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 22);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(4, 128);
            label3.Name = "label3";
            label3.Size = new Size(147, 14);
            label3.TabIndex = 4;
            label3.Text = "The Number of Mines:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Unispace", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(89, 365);
            label4.Name = "label4";
            label4.Size = new Size(57, 39);
            label4.TabIndex = 5;
            label4.Text = "30";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Unispace", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(152, 365);
            label5.Name = "label5";
            label5.Size = new Size(37, 39);
            label5.TabIndex = 5;
            label5.Text = "/";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(102, 156);
            label6.Name = "label6";
            label6.Size = new Size(49, 14);
            label6.TabIndex = 4;
            label6.Text = "Timer:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Gainsboro;
            textBox2.Location = new Point(157, 153);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "mm:ss";
            textBox2.Size = new Size(100, 22);
            textBox2.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.Font = new Font("Unispace", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Brown;
            label7.Location = new Point(140, 208);
            label7.Name = "label7";
            label7.Size = new Size(117, 39);
            label7.TabIndex = 5;
            label7.Text = "00:00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 217);
            label2.Name = "label2";
            label2.Size = new Size(49, 14);
            label2.TabIndex = 4;
            label2.Text = "Timer:";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(668, 417);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
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
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private Label label2;
    }
}