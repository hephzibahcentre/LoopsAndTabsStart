namespace LoopsAndTabsStart
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (tabControl1.SelectedTab == tabPage1)
            {
                tabPage1.BackColor = Color.Green;
            } else if (tabControl1.SelectedTab == tabPage2)
            {
                tabPage2.BackColor = Color.Red;
            }*/


            string s = "";

            if (tabControl1.SelectedIndex == 0)
            {
                //tabPage1.BackColor = Color.Blue;
                for (int i = 65; i <= 90; i++)
                {
                    char c = (char)i;
                    s = s+c.ToString();
                }
                lblCharacters.Text = s;
                //lblCharacters.ForeColor = Color.White;
            } else if (tabControl1.SelectedIndex == 1)
            {
                //tabPage2.BackColor= Color.Yellow;
                int count = 1;
                Random rnd = new Random();
                while (count <= 100)
                {
                    int num = rnd.Next();

                    if (num % 2 == 0)
                    {
                        lstEven.Items.Add(num);
                    }
                    else
                    {
                        lstOdd.Items.Add(num);
                    }
                    count++;
                }
            } else if (tabControl1.SelectedIndex == 2)
            {

            } else if (tabControl1.SelectedIndex == 3)
            {
                
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            /*for (int i = 65; i < 90; i++)
            {
                char c = (char)i;
                //lblCharacters.Text = c.ToString();
                string s = "";
                lblCharacters.Text = s;
                lblCharacters.Text += i.ToString();
                //lblCharacters.Text.Append(i.ToString());
                //lblCharacters.Text.Concat(i.ToString());
            }*/
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            int factorialInput = Convert.ToInt32(txtFactorial.Text);

            int factorialfactorial = factorialInput;

            int nextCalc = 0;

            int[] calcFactorial = new int[factorialInput];
            calcFactorial[0] = factorialInput;

            int calculatedFactorial;

            //Loop through to get all figures for calculating Factorial
            int facCount = factorialfactorial;

            for (int i = 1; i < facCount; i++)
            {
                nextCalc = factorialInput - 1;
                calcFactorial[i] = nextCalc;

                factorialInput = nextCalc;
            }
            
            //Calculate Factorial
            //Assign default Calculated factorian
            calculatedFactorial = calcFactorial[0];
            int count = calcFactorial.Length;
            for (int i = 1; i < count; i++)
            {
                calculatedFactorial = calculatedFactorial * calcFactorial[i];
            }

            //Output calculated factorial
            lblFactorial.Text = "Factorial = " + calculatedFactorial.ToString();
        }

        private void btnQ3_Click(object sender, EventArgs e)
        {
            lstForLoop.Items.Clear();
            int step = Convert.ToInt32(trkStep.Value);
            int count = 1;
            for (int i = Convert.ToInt32(trkStart.Value); i < Convert.ToInt32(trkEnd.Value); i++)
            {
                if (count == step)
                {
                    lstForLoop.Items.Add(i);
                    count = 1;
                }
                count++;
            }
        }

        string currentOperation = "";
        Random random = new Random();
        int countCorrect = 0;
        int countIncorrect = 0;
        int correctAnswer;
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int firstnum = random.Next(1, 101);
            int secondnum = random.Next(1, 101);

            if (rdoAdd.Checked)
            {
                currentOperation = " + ";
                lblQuestion.Text = "Question: " + firstnum + currentOperation + secondnum;
                correctAnswer = firstnum + secondnum;
            } else if (rdoSub.Checked)
            {
                currentOperation = " - ";
                lblQuestion.Text = "Question: " + firstnum + currentOperation + secondnum;
                correctAnswer = firstnum - secondnum;
            } else if (rdoMult.Checked)
            {
                currentOperation = " * ";
                lblQuestion.Text = "Question: " + firstnum + currentOperation + secondnum;
                correctAnswer = firstnum * secondnum;
            } else if (rdoDiv.Checked)
            {
                currentOperation = " / ";
                lblQuestion.Text = "Question: " + firstnum + currentOperation + secondnum;
                correctAnswer = firstnum / secondnum;
            }
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int answerInput = Convert.ToInt32(txtAnswer.Text);
            if (answerInput == correctAnswer)
            {
                countCorrect++;
                lstCorrect.Items.Add(answerInput);
                lblCorrect.Text = "Correct answers total: " + countCorrect.ToString();
            } else
            {
                countIncorrect++;
                lstIncorrect.Items.Add(answerInput);
                lblIncorrect.Text = "Incorrect answers total: " + countIncorrect.ToString();
            }
        }
    }
}