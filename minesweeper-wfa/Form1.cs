namespace minesweeper_wfa
{
    public partial class mainWindow : Form
    {
        //general parameters:
        List<Button> buttons = new List<Button>();
        List<int> mineIndexes = new List<int>();

        Label minesLeftValueLabel;
        Label timeLeftValueLabel;

        int timerIndex0 = 0;
        int timerIndex1 = 0;
        int timerIndex3 = 0;
        int timerIndex4 = 0;

        bool gameIsStarted = false;

        public mainWindow()
        {
            InitializeComponent();
        }


        private void GameplayManager()
        {
            timer.Start();
        }

        private void InitializeMinefield(bool UIAndMinesAreSet)
        {
            if (UIAndMinesAreSet)
            {
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
                        button.UseVisualStyleBackColor = false;
                        button.MouseUp += mineButton_MouseUp;

                        if (mineIndexes.Contains(button.TabIndex))
                        {
                            button.Text = "";
                        }
                        else button.Text = "E";

                        minefield.Controls.Add(button);

                        buttons.Add(button);

                        tabIndexCount++;
                        xPosModifier += 39;
                    }
                    xPosModifier = 0;
                    yPosModifier += 39;
                }

            }
        }

        private bool SetMinesAndUI()
        {

            int numOfMines;
            bool mineValueIsInt = int.TryParse(minesValueTextbox.Text, out numOfMines);
            bool mineIntervalIsCorrect = numOfMines < 100 && 0 < numOfMines;

            int timerIndex2 = 0;

            bool timerValueIsCorrect = false;

            try
            {
                if ((int.TryParse(timerValueTextbox.Text.Substring(0, 1), out timerIndex0) && int.TryParse(timerValueTextbox.Text.Substring(1, 1), out timerIndex1) && !int.TryParse(timerValueTextbox.Text.Substring(2, 1), out timerIndex2) && int.TryParse(timerValueTextbox.Text.Substring(3, 1), out timerIndex3) && int.TryParse(timerValueTextbox.Text.Substring(4, 1), out timerIndex4)) && (((int.Parse(timerValueTextbox.Text.Substring(0, 1)) * 600) + (int.Parse(timerValueTextbox.Text.Substring(1, 1)) * 60) + (int.Parse(timerValueTextbox.Text.Substring(3, 1)) * 10) + (int.Parse(timerValueTextbox.Text.Substring(4, 1)) * 1)) >= 30))
                {
                    timerValueIsCorrect = true;
                }
            }
            catch
            {
                timerValueIsCorrect = false;
            }

            Random rnd = new Random();

            if (mineValueIsInt && mineIntervalIsCorrect && timerValueIsCorrect)
            {
                for (int i = 0; i < numOfMines; i++)
                {
                    int temp = rnd.Next(100);

                    if (!mineIndexes.Contains(temp))
                    {
                        mineIndexes.Add(temp);
                    }
                    else i--;

                }

                //Ek detay: Textboxlarý labellar ile deðiþtir.

                minesLeftValueLabel = new Label();
                minesLeftValueLabel.AutoSize = true;
                minesLeftValueLabel.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point);
                minesLeftValueLabel.ForeColor = Color.Black;
                //minesLeftValueLabel.BackColor = Color.Black;
                minesLeftValueLabel.Location = new Point(305, 12);
                minesLeftValueLabel.Name = "minesLeftValueLabel";
                minesLeftValueLabel.Text = $"0 / {numOfMines}";

                this.Controls.Add(minesLeftValueLabel);

                timeLeftValueLabel = new Label();
                timeLeftValueLabel.AutoSize = true;
                timeLeftValueLabel.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point);
                timeLeftValueLabel.ForeColor = Color.Black;
                //timeLeftValueLabel.BackColor = Color.Black;
                timeLeftValueLabel.Location = new Point(305, 41);
                timeLeftValueLabel.Name = "timeLeftValueLabel";
                timeLeftValueLabel.Text = $"{timerIndex0}{timerIndex1}:{timerIndex3}{timerIndex4}";

                this.Controls.Add(timeLeftValueLabel);

                minesLabel.Text = "Mines Left:";
                minesLabel.Location = new Point(215, 12);

                timerLabel.Text = "Time Left:";
                timerLabel.Location = new Point(222, 41);

                timerValueTextbox.Visible = false;
                minesValueTextbox.Visible = false;

                timerValueTextbox.ReadOnly = true;
                minesValueTextbox.ReadOnly = true;

                startButton.Text = "Reset";

                gameIsStarted = !gameIsStarted;

                return true;
            }
            else
            {
                if (!(mineValueIsInt && mineIntervalIsCorrect))
                {
                    MessageBox.Show("Please enter a valid number to set the mines.");
                }
                else
                {
                    MessageBox.Show("Please enter a valid timer value. Min: 30.");
                }

                return false;
            }

        }

        private void Reset()
        {
            foreach (Button button in buttons)
            {
                minefield.Controls.Remove(button);
            }

            this.Controls.Remove(timeLeftValueLabel);
            this.Controls.Remove(minesLeftValueLabel);

            timerValueTextbox.ReadOnly = false;
            minesValueTextbox.ReadOnly = false;

            timerValueTextbox.Visible = true;
            minesValueTextbox.Visible = true;

            timerValueTextbox.Text = string.Empty;
            minesValueTextbox.Text = string.Empty;

            startButton.Text = "Start";

            timer.Stop();

            gameIsStarted = false;

        }

        private void timer_Tick(object sender, EventArgs e)
        {

            if (timerIndex4 > 0)
            {
                timerIndex4--;
            }
            else
            {
                if (timerIndex3 > 0)
                {
                    timerIndex4 = 9;
                    timerIndex3--;
                }
                else
                {
                    if (timerIndex1 > 0)
                    {
                        timerIndex3 = 5;
                        timerIndex4 = 9;
                        timerIndex1--;
                    }
                    else
                    {
                        if (timerIndex0 > 0)
                        {
                            timerIndex3 = 5;
                            timerIndex4 = 9;
                            timerIndex1 = 9;
                            timerIndex0--;
                        }
                    }
                }
            }

            timeLeftValueLabel.Text = $"{timerIndex0}{timerIndex1}:{timerIndex3}{timerIndex4}";

            if (timerIndex0 == 0 && timerIndex1 == 0 && timerIndex3 == 0 && timerIndex4 == 0)
            {
                timer.Stop();
                MessageBox.Show("Time's up!");
                Reset();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!gameIsStarted)
            {
                InitializeMinefield(SetMinesAndUI());
                if (gameIsStarted) GameplayManager();


            }
            else
            {
                Reset();

            }
        }

        private void mineButton_MouseUp(object sender, MouseEventArgs e)
        {
            Button fieldPiece = (Button)sender;

            if(e.Button == MouseButtons.Left) 
            {
                if (mineIndexes.Contains(fieldPiece.TabIndex))
                {
                    fieldPiece.Text = "B";

                    foreach (Button button in buttons)
                    {
                        if (mineIndexes.Contains(button.TabIndex))
                        {
                            button.Text = "B";
                        }
                    }

                    timer.Stop();

                    MessageBox.Show("Boom!");

                    Reset();
                }
                else
                {
                    //tarama index-1,index+1,index+3,index-3,index-2,index+2,index+4,index-4
                }
            }
            else if(e.Button == MouseButtons.Right)
            {
                if (fieldPiece.Text == string.Empty)
                {
                    fieldPiece.Text = "F";
                }
                else fieldPiece.Text = string.Empty;

            }

            
        }
    }
}