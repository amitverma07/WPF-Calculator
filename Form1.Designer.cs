namespace CalculatorApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.Addition = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Digit0 = new System.Windows.Forms.Button();
            this.Digit9 = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.Digit3 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.ClearEntry = new System.Windows.Forms.Button();
            this.Digit6 = new System.Windows.Forms.Button();
            this.Digit2 = new System.Windows.Forms.Button();
            this.Digit8 = new System.Windows.Forms.Button();
            this.Digit7 = new System.Windows.Forms.Button();
            this.Digit5 = new System.Windows.Forms.Button();
            this.Digit1 = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.inputLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConvertNum = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.enterNum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(280, 262);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.labelResult);
            this.tabPage1.Controls.Add(this.ResultLabel);
            this.tabPage1.Controls.Add(this.Addition);
            this.tabPage1.Controls.Add(this.Dot);
            this.tabPage1.Controls.Add(this.Digit0);
            this.tabPage1.Controls.Add(this.Digit9);
            this.tabPage1.Controls.Add(this.Equal);
            this.tabPage1.Controls.Add(this.Division);
            this.tabPage1.Controls.Add(this.button13);
            this.tabPage1.Controls.Add(this.Digit3);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.Subtract);
            this.tabPage1.Controls.Add(this.Multiply);
            this.tabPage1.Controls.Add(this.ClearEntry);
            this.tabPage1.Controls.Add(this.Digit6);
            this.tabPage1.Controls.Add(this.Digit2);
            this.tabPage1.Controls.Add(this.Digit8);
            this.tabPage1.Controls.Add(this.Digit7);
            this.tabPage1.Controls.Add(this.Digit5);
            this.tabPage1.Controls.Add(this.Digit1);
            this.tabPage1.Controls.Add(this.textBox_Result);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(272, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Standard";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(57, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 35);
            this.button2.TabIndex = 24;
            this.button2.Text = "(";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(108, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 35);
            this.button1.TabIndex = 23;
            this.button1.Text = ")";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelResult.Location = new System.Drawing.Point(6, 3);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 24);
            this.labelResult.TabIndex = 22;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.BackColor = System.Drawing.Color.White;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(6, 5);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 24);
            this.ResultLabel.TabIndex = 21;
            // 
            // Addition
            // 
            this.Addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addition.Location = new System.Drawing.Point(160, 195);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(45, 35);
            this.Addition.TabIndex = 20;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.operator_Click);
            // 
            // Dot
            // 
            this.Dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dot.Location = new System.Drawing.Point(210, 154);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(55, 35);
            this.Dot.TabIndex = 19;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.button_Click);
            // 
            // Digit0
            // 
            this.Digit0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digit0.Location = new System.Drawing.Point(6, 195);
            this.Digit0.Name = "Digit0";
            this.Digit0.Size = new System.Drawing.Size(45, 35);
            this.Digit0.TabIndex = 18;
            this.Digit0.Text = "0";
            this.Digit0.UseVisualStyleBackColor = true;
            this.Digit0.Click += new System.EventHandler(this.button_Click);
            // 
            // Digit9
            // 
            this.Digit9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digit9.Location = new System.Drawing.Point(108, 72);
            this.Digit9.Name = "Digit9";
            this.Digit9.Size = new System.Drawing.Size(45, 35);
            this.Digit9.TabIndex = 17;
            this.Digit9.Text = "9";
            this.Digit9.UseVisualStyleBackColor = true;
            this.Digit9.Click += new System.EventHandler(this.button_Click);
            // 
            // Equal
            // 
            this.Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal.Location = new System.Drawing.Point(210, 195);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(55, 35);
            this.Equal.TabIndex = 16;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Division
            // 
            this.Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division.Location = new System.Drawing.Point(159, 72);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(45, 35);
            this.Division.TabIndex = 15;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.operator_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(6, 113);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(45, 35);
            this.button13.TabIndex = 13;
            this.button13.Text = "4";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button_Click);
            // 
            // Digit3
            // 
            this.Digit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digit3.Location = new System.Drawing.Point(6, 154);
            this.Digit3.Name = "Digit3";
            this.Digit3.Size = new System.Drawing.Size(45, 35);
            this.Digit3.TabIndex = 12;
            this.Digit3.Text = "3";
            this.Digit3.UseVisualStyleBackColor = true;
            this.Digit3.Click += new System.EventHandler(this.button_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(210, 113);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(55, 35);
            this.button10.TabIndex = 10;
            this.button10.Text = "C";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Subtract
            // 
            this.Subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract.Location = new System.Drawing.Point(160, 154);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(45, 35);
            this.Subtract.TabIndex = 9;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.operator_Click);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply.Location = new System.Drawing.Point(160, 113);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(45, 35);
            this.Multiply.TabIndex = 8;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.operator_Click);
            // 
            // ClearEntry
            // 
            this.ClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearEntry.Location = new System.Drawing.Point(210, 72);
            this.ClearEntry.Name = "ClearEntry";
            this.ClearEntry.Size = new System.Drawing.Size(55, 35);
            this.ClearEntry.TabIndex = 7;
            this.ClearEntry.Text = "CE";
            this.ClearEntry.UseVisualStyleBackColor = true;
            this.ClearEntry.Click += new System.EventHandler(this.ClearEntry_Click);
            // 
            // Digit6
            // 
            this.Digit6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digit6.Location = new System.Drawing.Point(108, 113);
            this.Digit6.Name = "Digit6";
            this.Digit6.Size = new System.Drawing.Size(45, 35);
            this.Digit6.TabIndex = 6;
            this.Digit6.Text = "6";
            this.Digit6.UseVisualStyleBackColor = true;
            this.Digit6.Click += new System.EventHandler(this.button_Click);
            // 
            // Digit2
            // 
            this.Digit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digit2.Location = new System.Drawing.Point(57, 154);
            this.Digit2.Name = "Digit2";
            this.Digit2.Size = new System.Drawing.Size(45, 35);
            this.Digit2.TabIndex = 5;
            this.Digit2.Text = "2";
            this.Digit2.UseVisualStyleBackColor = true;
            this.Digit2.Click += new System.EventHandler(this.button_Click);
            // 
            // Digit8
            // 
            this.Digit8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digit8.Location = new System.Drawing.Point(57, 72);
            this.Digit8.Name = "Digit8";
            this.Digit8.Size = new System.Drawing.Size(45, 35);
            this.Digit8.TabIndex = 4;
            this.Digit8.Text = "8";
            this.Digit8.UseVisualStyleBackColor = true;
            this.Digit8.Click += new System.EventHandler(this.button_Click);
            // 
            // Digit7
            // 
            this.Digit7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digit7.Location = new System.Drawing.Point(6, 72);
            this.Digit7.Name = "Digit7";
            this.Digit7.Size = new System.Drawing.Size(45, 35);
            this.Digit7.TabIndex = 3;
            this.Digit7.Text = "7";
            this.Digit7.UseVisualStyleBackColor = true;
            this.Digit7.Click += new System.EventHandler(this.button_Click);
            // 
            // Digit5
            // 
            this.Digit5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digit5.Location = new System.Drawing.Point(57, 113);
            this.Digit5.Name = "Digit5";
            this.Digit5.Size = new System.Drawing.Size(45, 35);
            this.Digit5.TabIndex = 2;
            this.Digit5.Text = "5";
            this.Digit5.UseVisualStyleBackColor = true;
            this.Digit5.Click += new System.EventHandler(this.button_Click);
            // 
            // Digit1
            // 
            this.Digit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digit1.Location = new System.Drawing.Point(108, 154);
            this.Digit1.Name = "Digit1";
            this.Digit1.Size = new System.Drawing.Size(45, 35);
            this.Digit1.TabIndex = 1;
            this.Digit1.Text = "1";
            this.Digit1.UseVisualStyleBackColor = true;
            this.Digit1.Click += new System.EventHandler(this.button_Click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.Location = new System.Drawing.Point(6, 30);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(259, 36);
            this.textBox_Result.TabIndex = 1;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Result.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox_Result.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Result_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.inputLabel);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.ConvertNum);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.enterNum);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(272, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Binary";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(148, 106);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(0, 16);
            this.inputLabel.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Result  :";
            // 
            // ConvertNum
            // 
            this.ConvertNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertNum.Location = new System.Drawing.Point(20, 201);
            this.ConvertNum.Name = "ConvertNum";
            this.ConvertNum.Size = new System.Drawing.Size(230, 29);
            this.ConvertNum.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(159, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "Convert";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Number :";
            // 
            // enterNum
            // 
            this.enterNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNum.Location = new System.Drawing.Point(20, 134);
            this.enterNum.Name = "enterNum";
            this.enterNum.Size = new System.Drawing.Size(230, 29);
            this.enterNum.TabIndex = 2;
            this.enterNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Binary_Key_Press);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Converter";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Binary",
            "Decimal"});
            this.comboBox2.Location = new System.Drawing.Point(103, 59);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Text = "Select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "To";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Binary",
            "Decimal"});
            this.comboBox1.Location = new System.Drawing.Point(103, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Select";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 289);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button Digit3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button ClearEntry;
        private System.Windows.Forms.Button Digit6;
        private System.Windows.Forms.Button Digit2;
        private System.Windows.Forms.Button Digit8;
        private System.Windows.Forms.Button Digit7;
        private System.Windows.Forms.Button Digit5;
        private System.Windows.Forms.Button Digit1;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button Digit0;
        private System.Windows.Forms.Button Digit9;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox enterNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConvertNum;
        private System.Windows.Forms.Label inputLabel;
    }
}

