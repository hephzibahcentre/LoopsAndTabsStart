namespace LoopsAndTabsStart
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCharacters = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstOdd = new System.Windows.Forms.ListBox();
            this.lstEven = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstForLoop = new System.Windows.Forms.ListBox();
            this.btnQ3 = new System.Windows.Forms.Button();
            this.trkStep = new System.Windows.Forms.TrackBar();
            this.trkEnd = new System.Windows.Forms.TrackBar();
            this.trkStart = new System.Windows.Forms.TrackBar();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFactorial = new System.Windows.Forms.TextBox();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.lblFactorial = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lstIncorrect = new System.Windows.Forms.ListBox();
            this.lstCorrect = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.rdoDiv = new System.Windows.Forms.RadioButton();
            this.rdoMult = new System.Windows.Forms.RadioButton();
            this.rdoSub = new System.Windows.Forms.RadioButton();
            this.rdoAdd = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkStart)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(22, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(753, 398);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblCharacters);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(745, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Page 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblCharacters
            // 
            this.lblCharacters.AutoSize = true;
            this.lblCharacters.Location = new System.Drawing.Point(24, 17);
            this.lblCharacters.Name = "lblCharacters";
            this.lblCharacters.Size = new System.Drawing.Size(60, 20);
            this.lblCharacters.TabIndex = 0;
            this.lblCharacters.Text = "Answer:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstOdd);
            this.tabPage2.Controls.Add(this.lstEven);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(745, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Page 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstOdd
            // 
            this.lstOdd.FormattingEnabled = true;
            this.lstOdd.ItemHeight = 20;
            this.lstOdd.Location = new System.Drawing.Point(162, 6);
            this.lstOdd.Name = "lstOdd";
            this.lstOdd.Size = new System.Drawing.Size(150, 104);
            this.lstOdd.TabIndex = 1;
            // 
            // lstEven
            // 
            this.lstEven.FormattingEnabled = true;
            this.lstEven.ItemHeight = 20;
            this.lstEven.Location = new System.Drawing.Point(6, 6);
            this.lstEven.Name = "lstEven";
            this.lstEven.Size = new System.Drawing.Size(150, 104);
            this.lstEven.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.lstForLoop);
            this.tabPage3.Controls.Add(this.btnQ3);
            this.tabPage3.Controls.Add(this.trkStep);
            this.tabPage3.Controls.Add(this.trkEnd);
            this.tabPage3.Controls.Add(this.trkStart);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(745, 365);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Page 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Step";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "End";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start";
            // 
            // lstForLoop
            // 
            this.lstForLoop.FormattingEnabled = true;
            this.lstForLoop.ItemHeight = 20;
            this.lstForLoop.Location = new System.Drawing.Point(440, 19);
            this.lstForLoop.Name = "lstForLoop";
            this.lstForLoop.Size = new System.Drawing.Size(150, 104);
            this.lstForLoop.TabIndex = 4;
            // 
            // btnQ3
            // 
            this.btnQ3.Location = new System.Drawing.Point(27, 193);
            this.btnQ3.Name = "btnQ3";
            this.btnQ3.Size = new System.Drawing.Size(94, 29);
            this.btnQ3.TabIndex = 3;
            this.btnQ3.Text = "Run Loop";
            this.btnQ3.UseVisualStyleBackColor = true;
            this.btnQ3.Click += new System.EventHandler(this.btnQ3_Click);
            // 
            // trkStep
            // 
            this.trkStep.Location = new System.Drawing.Point(290, 19);
            this.trkStep.Maximum = 100;
            this.trkStep.Minimum = -100;
            this.trkStep.Name = "trkStep";
            this.trkStep.Size = new System.Drawing.Size(130, 56);
            this.trkStep.TabIndex = 2;
            // 
            // trkEnd
            // 
            this.trkEnd.Location = new System.Drawing.Point(154, 19);
            this.trkEnd.Maximum = 100;
            this.trkEnd.Minimum = -100;
            this.trkEnd.Name = "trkEnd";
            this.trkEnd.Size = new System.Drawing.Size(130, 56);
            this.trkEnd.TabIndex = 1;
            // 
            // trkStart
            // 
            this.trkStart.Location = new System.Drawing.Point(18, 19);
            this.trkStart.Maximum = 100;
            this.trkStart.Minimum = -100;
            this.trkStart.Name = "trkStart";
            this.trkStart.Size = new System.Drawing.Size(130, 56);
            this.trkStart.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.txtFactorial);
            this.tabPage4.Controls.Add(this.btnFactorial);
            this.tabPage4.Controls.Add(this.lblFactorial);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(745, 365);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Page 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(92, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Factorial Calculator";
            // 
            // txtFactorial
            // 
            this.txtFactorial.Location = new System.Drawing.Point(46, 90);
            this.txtFactorial.Name = "txtFactorial";
            this.txtFactorial.Size = new System.Drawing.Size(116, 27);
            this.txtFactorial.TabIndex = 2;
            // 
            // btnFactorial
            // 
            this.btnFactorial.Location = new System.Drawing.Point(129, 149);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(94, 29);
            this.btnFactorial.TabIndex = 1;
            this.btnFactorial.Text = "Calculate";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // lblFactorial
            // 
            this.lblFactorial.AutoSize = true;
            this.lblFactorial.Location = new System.Drawing.Point(201, 96);
            this.lblFactorial.Name = "lblFactorial";
            this.lblFactorial.Size = new System.Drawing.Size(83, 20);
            this.lblFactorial.TabIndex = 0;
            this.lblFactorial.Text = "Factorial = ";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.textBox1);
            this.tabPage5.Controls.Add(this.lblIncorrect);
            this.tabPage5.Controls.Add(this.lblCorrect);
            this.tabPage5.Controls.Add(this.lstIncorrect);
            this.tabPage5.Controls.Add(this.lstCorrect);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.txtAnswer);
            this.tabPage5.Controls.Add(this.lblQuestion);
            this.tabPage5.Controls.Add(this.btnSubmit);
            this.tabPage5.Controls.Add(this.btnGenerate);
            this.tabPage5.Controls.Add(this.rdoDiv);
            this.tabPage5.Controls.Add(this.rdoMult);
            this.tabPage5.Controls.Add(this.rdoSub);
            this.tabPage5.Controls.Add(this.rdoAdd);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(745, 365);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Page 5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(283, 134);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(2, 200);
            this.textBox1.TabIndex = 13;
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Location = new System.Drawing.Point(310, 216);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(173, 20);
            this.lblIncorrect.TabIndex = 12;
            this.lblIncorrect.Text = "incorrect answers total: 0";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(310, 176);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(163, 20);
            this.lblCorrect.TabIndex = 11;
            this.lblCorrect.Text = "Correct answers total: 0";
            // 
            // lstIncorrect
            // 
            this.lstIncorrect.FormattingEnabled = true;
            this.lstIncorrect.ItemHeight = 20;
            this.lstIncorrect.Location = new System.Drawing.Point(555, 151);
            this.lstIncorrect.Name = "lstIncorrect";
            this.lstIncorrect.Size = new System.Drawing.Size(150, 104);
            this.lstIncorrect.TabIndex = 10;
            // 
            // lstCorrect
            // 
            this.lstCorrect.FormattingEnabled = true;
            this.lstCorrect.ItemHeight = 20;
            this.lstCorrect.Location = new System.Drawing.Point(555, 23);
            this.lstCorrect.Name = "lstCorrect";
            this.lstCorrect.Size = new System.Drawing.Size(150, 104);
            this.lstCorrect.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Your answer";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(142, 192);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(125, 27);
            this.txtAnswer.TabIndex = 7;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(35, 151);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(75, 20);
            this.lblQuestion.TabIndex = 6;
            this.lblQuestion.Text = "Question: ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(35, 243);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(157, 29);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(205, 76);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(157, 29);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate Question";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // rdoDiv
            // 
            this.rdoDiv.AutoSize = true;
            this.rdoDiv.Location = new System.Drawing.Point(401, 23);
            this.rdoDiv.Name = "rdoDiv";
            this.rdoDiv.Size = new System.Drawing.Size(83, 24);
            this.rdoDiv.TabIndex = 3;
            this.rdoDiv.TabStop = true;
            this.rdoDiv.Text = "Division";
            this.rdoDiv.UseVisualStyleBackColor = true;
            // 
            // rdoMult
            // 
            this.rdoMult.AutoSize = true;
            this.rdoMult.Location = new System.Drawing.Point(273, 23);
            this.rdoMult.Name = "rdoMult";
            this.rdoMult.Size = new System.Drawing.Size(122, 24);
            this.rdoMult.TabIndex = 2;
            this.rdoMult.TabStop = true;
            this.rdoMult.Text = "Multiplication";
            this.rdoMult.UseVisualStyleBackColor = true;
            // 
            // rdoSub
            // 
            this.rdoSub.AutoSize = true;
            this.rdoSub.Location = new System.Drawing.Point(161, 23);
            this.rdoSub.Name = "rdoSub";
            this.rdoSub.Size = new System.Drawing.Size(106, 24);
            this.rdoSub.TabIndex = 1;
            this.rdoSub.TabStop = true;
            this.rdoSub.Text = "Subtraction";
            this.rdoSub.UseVisualStyleBackColor = true;
            // 
            // rdoAdd
            // 
            this.rdoAdd.AutoSize = true;
            this.rdoAdd.Location = new System.Drawing.Point(67, 23);
            this.rdoAdd.Name = "rdoAdd";
            this.rdoAdd.Size = new System.Drawing.Size(88, 24);
            this.rdoAdd.TabIndex = 0;
            this.rdoAdd.TabStop = true;
            this.rdoAdd.Text = "Addition";
            this.rdoAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkStart)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label lblCharacters;
        private ListBox lstOdd;
        private ListBox lstEven;
        private TrackBar trkStep;
        private TrackBar trkEnd;
        private TrackBar trkStart;
        private ListBox lstForLoop;
        private Button btnQ3;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtFactorial;
        private Button btnFactorial;
        private Label lblFactorial;
        private Label label5;
        private TextBox textBox1;
        private Label lblIncorrect;
        private Label lblCorrect;
        private ListBox lstIncorrect;
        private ListBox lstCorrect;
        private Label label4;
        private TextBox txtAnswer;
        private Label lblQuestion;
        private Button btnSubmit;
        private Button btnGenerate;
        private RadioButton rdoDiv;
        private RadioButton rdoMult;
        private RadioButton rdoSub;
        private RadioButton rdoAdd;
    }
}