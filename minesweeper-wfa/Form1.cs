namespace minesweeper_wfa
{
    public partial class MainWindow : Form
    {
        List<Button> buttons = new List<Button>();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitializeMinefield();
        }

        // TimeLeftLabelTime
        // 
        //TimeLeftLabelTime.AutoSize = true;
        //    TimeLeftLabelTime.BackColor = Color.Black;
        //    TimeLeftLabelTime.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
        //TimeLeftLabelTime.ForeColor = Color.Brown;
        //    TimeLeftLabelTime.Location = new Point(335, 12);
        //TimeLeftLabelTime.Name = "TimeLeftLabelTime";
        //    TimeLeftLabelTime.Size = new Size(70, 23);
        //TimeLeftLabelTime.TabIndex = 5;
        //    TimeLeftLabelTime.Text = "00:00";
        //    TimeLeftLabelTime.Visible = false;
        // 
        // TimeLeftLabel
        // 
        //    TimeLeftLabel.AutoSize = true;
        //    TimeLeftLabel.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point);
        //TimeLeftLabel.ForeColor = Color.Brown;
        //    TimeLeftLabel.Location = new Point(252, 19);
        //TimeLeftLabel.Name = "TimeLeftLabel";
        //    TimeLeftLabel.Size = new Size(77, 14);
        //TimeLeftLabel.TabIndex = 4;
        //    TimeLeftLabel.Text = "Time Left:";
        //    TimeLeftLabel.Visible = false;

        private void InitializeMinefield()
        {
            StartButton.Enabled = false;


            int xPosModifier = 0;
            int yPosModifier = 0;

            int tabIndexCount = 0;

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Button button = new Button();

                    button.BackColor = Color.LightGray;
                    button.FlatStyle = FlatStyle.Popup;
                    button.Location = new Point(3 + xPosModifier, 3 + yPosModifier);
                    button.Name = "button1";
                    button.Size = new Size(35, 35);
                    button.TabIndex = tabIndexCount;
                    button.Text = "button1";
                    button.UseVisualStyleBackColor = false;

                    Minefield.Controls.Add(button);

                    buttons.Add(button);

                    tabIndexCount++;
                    xPosModifier += 39;
                }
                xPosModifier = 0;
                yPosModifier += 39;
            }
        }
    }
}