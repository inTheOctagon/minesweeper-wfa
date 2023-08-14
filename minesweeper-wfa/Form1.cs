using System.Collections.Generic;
using System.Numerics;

namespace minesweeper_wfa
{
    public partial class mainWindow : Form
    {
        //general parameters:
        List<Button> buttons = new List<Button>();
        List<int> flagIndexes = new List<int>();
        List<int> mineIndexes = new List<int>();

        Label minesLeftValueLabel;
        Label timeLeftValueLabel;

        int timerIndex0 = 0;
        int timerIndex1 = 0;
        int timerIndex3 = 0;
        int timerIndex4 = 0;

        int numOfMines = 0;
        int minesLeft = 0;

        bool gameIsStarted = false;

        public mainWindow()
        {
            InitializeComponent();
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
                minesLeftValueLabel.Text = $"{minesLeft} / {numOfMines}";

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

            buttons.Clear();

            mineIndexes.Clear();

            minesLeft = 0;

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

        private int ScanForMines(Button fieldPiece)
        {
            int mineCount = 0;

            Point p1 = new Point() { X = fieldPiece.Location.X, Y = fieldPiece.Location.Y };
            Point p2;

            for (int i = -11; i <= -9; i++)
            {
                if (mineIndexes.Contains(fieldPiece.TabIndex + i))
                {
                    p2 = new Point() { X = buttons[fieldPiece.TabIndex + i].Location.X, Y = buttons[fieldPiece.TabIndex + i].Location.Y };

                    if (Math.Sqrt((Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2))) < 56)
                    {
                        mineCount++;
                    }
                }
            }
            for (int i = -1; i <= 1; i++)
            {
                if (mineIndexes.Contains(fieldPiece.TabIndex + i))
                {
                    p2 = new Point() { X = buttons[fieldPiece.TabIndex + i].Location.X, Y = buttons[fieldPiece.TabIndex + i].Location.Y };

                    if (Math.Sqrt((Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2))) < 56)
                    {
                        mineCount++;
                    }
                }
            }
            for (int i = 9; i <= 11; i++)
            {

                if (mineIndexes.Contains(fieldPiece.TabIndex + i))
                {
                    p2 = new Point() { X = buttons[fieldPiece.TabIndex + i].Location.X, Y = buttons[fieldPiece.TabIndex + i].Location.Y };

                    if (Math.Sqrt((Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2))) < 56)
                    {
                        mineCount++;
                    }
                }
            }

            return mineCount;

        }

        private void CheckWinCon(int numOfMines)
        {
            int count = 0;

            foreach (int flagIndex in flagIndexes)
            {
                if (mineIndexes.Contains(flagIndex))
                {
                    count++;
                }
            }

            if (count == numOfMines)
            {
                timer.Stop();

                foreach (Button button in buttons)
                {
                    if (mineIndexes.Contains(button.TabIndex))
                    {
                        button.Image = Properties.Resources.mine_32;
                        button.BackColor = Color.Green;

                    }
                }

                DialogResult dialogResult = MessageBox.Show("Do you want to play again?", "Congrats!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Reset();
                }
                else this.Close();
            }
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
                DialogResult dialogResult = MessageBox.Show("Do you want to play again?", "Game Over: Time's up.", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Reset();
                }
                else this.Close();

            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!gameIsStarted)
            {
                InitializeMinefield(SetMinesAndUI());
                if (gameIsStarted) timer.Start();
            }
            else
            {
                Reset();
            }
        }

        private void mineButton_MouseUp(object sender, MouseEventArgs e)
        {
            Button fieldPiece = (Button)sender;

            if (e.Button == MouseButtons.Left)
            {
                if (mineIndexes.Contains(fieldPiece.TabIndex))
                {

                    foreach (Button button in buttons)
                    {
                        if (mineIndexes.Contains(button.TabIndex))
                        {
                            button.Image = Properties.Resources.mine_32;
                            button.BackColor = Color.Brown;

                        }
                    }

                    timer.Stop();

                    DialogResult dialogResult = MessageBox.Show("Do you want to play again?", "Game Over: Boom!", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        Reset();
                    }
                    else this.Close();

                }
                else
                {
                    int mineCount = ScanForMines(fieldPiece);

                    fieldPiece.Text = mineCount.ToString();
                    fieldPiece.BackColor = Color.Transparent;
                    if (fieldPiece.Image != null)
                    {
                        fieldPiece.Image = null;
                        minesLeft--;
                        minesLeftValueLabel.Text = $"{minesLeft} / {numOfMines}";
                    }
                    fieldPiece.BackColor = Color.LightGreen;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (fieldPiece.Image == null && fieldPiece.Text == string.Empty && minesLeft != numOfMines)
                {
                    fieldPiece.Image = Properties.Resources.flag_32;
                    flagIndexes.Add(fieldPiece.TabIndex);
                    minesLeft++;
                    minesLeftValueLabel.Text = $"{minesLeft} / {numOfMines}";


                }
                else if (fieldPiece.Image != null)
                {
                    fieldPiece.Image = null;
                    flagIndexes.Remove(fieldPiece.TabIndex);
                    minesLeft--;
                    minesLeftValueLabel.Text = $"{minesLeft} / {numOfMines}";
                }

            }

            CheckWinCon(numOfMines);

        }
    }
}