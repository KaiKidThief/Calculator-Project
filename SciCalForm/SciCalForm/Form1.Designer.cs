namespace SciCalForm
{
    partial class CALCULATOR
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonModulo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonGreaterThan = new System.Windows.Forms.Button();
            this.buttonLessThan = new System.Windows.Forms.Button();
            this.buttonGreaterEqual = new System.Windows.Forms.Button();
            this.buttonLessEqual = new System.Windows.Forms.Button();
            this.buttonNotEqual = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAND = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOR = new System.Windows.Forms.Button();
            this.buttonNOT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSimpleAss = new System.Windows.Forms.Button();
            this.buttonAddAss = new System.Windows.Forms.Button();
            this.buttonSubtractAss = new System.Windows.Forms.Button();
            this.buttonMultiplyAdd = new System.Windows.Forms.Button();
            this.buttonDivisionAss = new System.Windows.Forms.Button();
            this.buttonModuloAss = new System.Windows.Forms.Button();
            this.buttonLeftShiftAss = new System.Windows.Forms.Button();
            this.buttonRightShiftAss = new System.Windows.Forms.Button();
            this.buttonBitwiseAndAss = new System.Windows.Forms.Button();
            this.buttonBitwiseExclusiveAss = new System.Windows.Forms.Button();
            this.buttonBitwiseInclusiveOrAss = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonMaxClass = new System.Windows.Forms.Button();
            this.buttonMinClass = new System.Windows.Forms.Button();
            this.buttonSquareRootAss = new System.Windows.Forms.Button();
            this.buttonAbsolutePower = new System.Windows.Forms.Button();
            this.buttonRound = new System.Windows.Forms.Button();
            this.buttonCosine = new System.Windows.Forms.Button();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonTangent = new System.Windows.Forms.Button();
            this.buttonAsin = new System.Windows.Forms.Button();
            this.buttonAcos = new System.Windows.Forms.Button();
            this.buttonAtan = new System.Windows.Forms.Button();
            this.buttonFLoor = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonLog10 = new System.Windows.Forms.Button();
            this.buttonPI = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonExponent = new System.Windows.Forms.Button();
            this.timerColor = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(135, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 48);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(276, 77);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 48);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(403, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxResult.Location = new System.Drawing.Point(452, 77);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(121, 48);
            this.textBoxResult.TabIndex = 3;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Turquoise;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(133, 166);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(65, 42);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Swis721 Blk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(133, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Basic Arithmetic Operator :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(222, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.Turquoise;
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMultiply.ForeColor = System.Drawing.Color.White;
            this.buttonMultiply.Location = new System.Drawing.Point(306, 166);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(57, 43);
            this.buttonMultiply.TabIndex = 7;
            this.buttonMultiply.Text = "X";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.Turquoise;
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDivide.ForeColor = System.Drawing.Color.White;
            this.buttonDivide.Location = new System.Drawing.Point(384, 166);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(62, 43);
            this.buttonDivide.TabIndex = 8;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonModulo
            // 
            this.buttonModulo.BackColor = System.Drawing.Color.Turquoise;
            this.buttonModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonModulo.ForeColor = System.Drawing.Color.White;
            this.buttonModulo.Location = new System.Drawing.Point(461, 166);
            this.buttonModulo.Name = "buttonModulo";
            this.buttonModulo.Size = new System.Drawing.Size(63, 42);
            this.buttonModulo.TabIndex = 9;
            this.buttonModulo.Text = "%";
            this.buttonModulo.UseVisualStyleBackColor = false;
            this.buttonModulo.Click += new System.EventHandler(this.buttonModulo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Swis721 Blk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(133, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Relational Operator :";
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.Turquoise;
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEqual.ForeColor = System.Drawing.Color.White;
            this.buttonEqual.Location = new System.Drawing.Point(133, 260);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(65, 51);
            this.buttonEqual.TabIndex = 11;
            this.buttonEqual.Text = "==";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonGreaterThan
            // 
            this.buttonGreaterThan.BackColor = System.Drawing.Color.Turquoise;
            this.buttonGreaterThan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGreaterThan.ForeColor = System.Drawing.Color.White;
            this.buttonGreaterThan.Location = new System.Drawing.Point(222, 260);
            this.buttonGreaterThan.Name = "buttonGreaterThan";
            this.buttonGreaterThan.Size = new System.Drawing.Size(60, 51);
            this.buttonGreaterThan.TabIndex = 12;
            this.buttonGreaterThan.Text = ">";
            this.buttonGreaterThan.UseVisualStyleBackColor = false;
            this.buttonGreaterThan.Click += new System.EventHandler(this.buttonGreaterThan_Click);
            // 
            // buttonLessThan
            // 
            this.buttonLessThan.BackColor = System.Drawing.Color.Turquoise;
            this.buttonLessThan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLessThan.ForeColor = System.Drawing.Color.White;
            this.buttonLessThan.Location = new System.Drawing.Point(306, 260);
            this.buttonLessThan.Name = "buttonLessThan";
            this.buttonLessThan.Size = new System.Drawing.Size(57, 51);
            this.buttonLessThan.TabIndex = 13;
            this.buttonLessThan.Text = "<";
            this.buttonLessThan.UseVisualStyleBackColor = false;
            this.buttonLessThan.Click += new System.EventHandler(this.buttonLessThan_Click);
            // 
            // buttonGreaterEqual
            // 
            this.buttonGreaterEqual.BackColor = System.Drawing.Color.Turquoise;
            this.buttonGreaterEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGreaterEqual.ForeColor = System.Drawing.Color.White;
            this.buttonGreaterEqual.Location = new System.Drawing.Point(384, 260);
            this.buttonGreaterEqual.Name = "buttonGreaterEqual";
            this.buttonGreaterEqual.Size = new System.Drawing.Size(62, 51);
            this.buttonGreaterEqual.TabIndex = 14;
            this.buttonGreaterEqual.Text = ">=";
            this.buttonGreaterEqual.UseVisualStyleBackColor = false;
            this.buttonGreaterEqual.Click += new System.EventHandler(this.buttonGreaterEqual_Click);
            // 
            // buttonLessEqual
            // 
            this.buttonLessEqual.BackColor = System.Drawing.Color.Turquoise;
            this.buttonLessEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLessEqual.ForeColor = System.Drawing.Color.White;
            this.buttonLessEqual.Location = new System.Drawing.Point(461, 260);
            this.buttonLessEqual.Name = "buttonLessEqual";
            this.buttonLessEqual.Size = new System.Drawing.Size(63, 51);
            this.buttonLessEqual.TabIndex = 15;
            this.buttonLessEqual.Text = "<=";
            this.buttonLessEqual.UseVisualStyleBackColor = false;
            this.buttonLessEqual.Click += new System.EventHandler(this.buttonLessEqual_Click);
            // 
            // buttonNotEqual
            // 
            this.buttonNotEqual.BackColor = System.Drawing.Color.Turquoise;
            this.buttonNotEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNotEqual.ForeColor = System.Drawing.Color.White;
            this.buttonNotEqual.Location = new System.Drawing.Point(543, 260);
            this.buttonNotEqual.Name = "buttonNotEqual";
            this.buttonNotEqual.Size = new System.Drawing.Size(64, 51);
            this.buttonNotEqual.TabIndex = 16;
            this.buttonNotEqual.Text = "!=";
            this.buttonNotEqual.UseVisualStyleBackColor = false;
            this.buttonNotEqual.Click += new System.EventHandler(this.buttonNotEqual_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Swis721 Blk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(133, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Logical Operator :";
            // 
            // buttonAND
            // 
            this.buttonAND.BackColor = System.Drawing.Color.Turquoise;
            this.buttonAND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAND.ForeColor = System.Drawing.Color.White;
            this.buttonAND.Location = new System.Drawing.Point(133, 365);
            this.buttonAND.Name = "buttonAND";
            this.buttonAND.Size = new System.Drawing.Size(65, 51);
            this.buttonAND.TabIndex = 18;
            this.buttonAND.Text = "AND";
            this.buttonAND.UseVisualStyleBackColor = false;
            this.buttonAND.Click += new System.EventHandler(this.buttonAND_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Swis721 Blk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(294, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "USE TRUE OR FALSE";
            // 
            // buttonOR
            // 
            this.buttonOR.BackColor = System.Drawing.Color.Turquoise;
            this.buttonOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOR.ForeColor = System.Drawing.Color.White;
            this.buttonOR.Location = new System.Drawing.Point(222, 365);
            this.buttonOR.Name = "buttonOR";
            this.buttonOR.Size = new System.Drawing.Size(60, 51);
            this.buttonOR.TabIndex = 20;
            this.buttonOR.Text = "OR";
            this.buttonOR.UseVisualStyleBackColor = false;
            this.buttonOR.Click += new System.EventHandler(this.buttonOR_Click);
            // 
            // buttonNOT
            // 
            this.buttonNOT.BackColor = System.Drawing.Color.Turquoise;
            this.buttonNOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNOT.ForeColor = System.Drawing.Color.White;
            this.buttonNOT.Location = new System.Drawing.Point(306, 365);
            this.buttonNOT.Name = "buttonNOT";
            this.buttonNOT.Size = new System.Drawing.Size(57, 51);
            this.buttonNOT.TabIndex = 21;
            this.buttonNOT.Text = "NOT";
            this.buttonNOT.UseVisualStyleBackColor = false;
            this.buttonNOT.Click += new System.EventHandler(this.buttonNOT_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Swis721 Blk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(133, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Assignment Operator :";
            // 
            // buttonSimpleAss
            // 
            this.buttonSimpleAss.BackColor = System.Drawing.Color.Turquoise;
            this.buttonSimpleAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSimpleAss.ForeColor = System.Drawing.Color.White;
            this.buttonSimpleAss.Location = new System.Drawing.Point(133, 474);
            this.buttonSimpleAss.Name = "buttonSimpleAss";
            this.buttonSimpleAss.Size = new System.Drawing.Size(65, 56);
            this.buttonSimpleAss.TabIndex = 23;
            this.buttonSimpleAss.Text = "=";
            this.buttonSimpleAss.UseVisualStyleBackColor = false;
            this.buttonSimpleAss.Click += new System.EventHandler(this.buttonSimpleAss_Click);
            // 
            // buttonAddAss
            // 
            this.buttonAddAss.BackColor = System.Drawing.Color.Turquoise;
            this.buttonAddAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddAss.ForeColor = System.Drawing.Color.White;
            this.buttonAddAss.Location = new System.Drawing.Point(222, 474);
            this.buttonAddAss.Name = "buttonAddAss";
            this.buttonAddAss.Size = new System.Drawing.Size(60, 56);
            this.buttonAddAss.TabIndex = 24;
            this.buttonAddAss.Text = "+=";
            this.buttonAddAss.UseVisualStyleBackColor = false;
            this.buttonAddAss.Click += new System.EventHandler(this.buttonAddAss_Click);
            // 
            // buttonSubtractAss
            // 
            this.buttonSubtractAss.BackColor = System.Drawing.Color.Turquoise;
            this.buttonSubtractAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSubtractAss.ForeColor = System.Drawing.Color.White;
            this.buttonSubtractAss.Location = new System.Drawing.Point(306, 474);
            this.buttonSubtractAss.Name = "buttonSubtractAss";
            this.buttonSubtractAss.Size = new System.Drawing.Size(57, 56);
            this.buttonSubtractAss.TabIndex = 25;
            this.buttonSubtractAss.Text = "-=";
            this.buttonSubtractAss.UseVisualStyleBackColor = false;
            this.buttonSubtractAss.Click += new System.EventHandler(this.buttonSubtractAss_Click);
            // 
            // buttonMultiplyAdd
            // 
            this.buttonMultiplyAdd.BackColor = System.Drawing.Color.Turquoise;
            this.buttonMultiplyAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMultiplyAdd.ForeColor = System.Drawing.Color.White;
            this.buttonMultiplyAdd.Location = new System.Drawing.Point(384, 474);
            this.buttonMultiplyAdd.Name = "buttonMultiplyAdd";
            this.buttonMultiplyAdd.Size = new System.Drawing.Size(62, 56);
            this.buttonMultiplyAdd.TabIndex = 26;
            this.buttonMultiplyAdd.Text = "*=";
            this.buttonMultiplyAdd.UseVisualStyleBackColor = false;
            this.buttonMultiplyAdd.Click += new System.EventHandler(this.buttonMultiplyAdd_Click);
            // 
            // buttonDivisionAss
            // 
            this.buttonDivisionAss.BackColor = System.Drawing.Color.Turquoise;
            this.buttonDivisionAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDivisionAss.ForeColor = System.Drawing.Color.White;
            this.buttonDivisionAss.Location = new System.Drawing.Point(461, 474);
            this.buttonDivisionAss.Name = "buttonDivisionAss";
            this.buttonDivisionAss.Size = new System.Drawing.Size(63, 56);
            this.buttonDivisionAss.TabIndex = 27;
            this.buttonDivisionAss.Text = "/=";
            this.buttonDivisionAss.UseVisualStyleBackColor = false;
            this.buttonDivisionAss.Click += new System.EventHandler(this.buttonDivisionAss_Click);
            // 
            // buttonModuloAss
            // 
            this.buttonModuloAss.BackColor = System.Drawing.Color.Turquoise;
            this.buttonModuloAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonModuloAss.ForeColor = System.Drawing.Color.White;
            this.buttonModuloAss.Location = new System.Drawing.Point(543, 474);
            this.buttonModuloAss.Name = "buttonModuloAss";
            this.buttonModuloAss.Size = new System.Drawing.Size(64, 56);
            this.buttonModuloAss.TabIndex = 28;
            this.buttonModuloAss.Text = "%=";
            this.buttonModuloAss.UseVisualStyleBackColor = false;
            this.buttonModuloAss.Click += new System.EventHandler(this.buttonModuloAss_Click);
            // 
            // buttonLeftShiftAss
            // 
            this.buttonLeftShiftAss.BackColor = System.Drawing.Color.Turquoise;
            this.buttonLeftShiftAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLeftShiftAss.ForeColor = System.Drawing.Color.White;
            this.buttonLeftShiftAss.Location = new System.Drawing.Point(133, 555);
            this.buttonLeftShiftAss.Name = "buttonLeftShiftAss";
            this.buttonLeftShiftAss.Size = new System.Drawing.Size(65, 56);
            this.buttonLeftShiftAss.TabIndex = 29;
            this.buttonLeftShiftAss.Text = "<<=";
            this.buttonLeftShiftAss.UseVisualStyleBackColor = false;
            this.buttonLeftShiftAss.Click += new System.EventHandler(this.buttonLeftShiftAss_Click);
            // 
            // buttonRightShiftAss
            // 
            this.buttonRightShiftAss.BackColor = System.Drawing.Color.Turquoise;
            this.buttonRightShiftAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRightShiftAss.ForeColor = System.Drawing.Color.White;
            this.buttonRightShiftAss.Location = new System.Drawing.Point(222, 555);
            this.buttonRightShiftAss.Name = "buttonRightShiftAss";
            this.buttonRightShiftAss.Size = new System.Drawing.Size(60, 56);
            this.buttonRightShiftAss.TabIndex = 30;
            this.buttonRightShiftAss.Text = ">>=";
            this.buttonRightShiftAss.UseVisualStyleBackColor = false;
            this.buttonRightShiftAss.Click += new System.EventHandler(this.buttonRightShiftAss_Click);
            // 
            // buttonBitwiseAndAss
            // 
            this.buttonBitwiseAndAss.BackColor = System.Drawing.Color.Turquoise;
            this.buttonBitwiseAndAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBitwiseAndAss.ForeColor = System.Drawing.Color.White;
            this.buttonBitwiseAndAss.Location = new System.Drawing.Point(306, 555);
            this.buttonBitwiseAndAss.Name = "buttonBitwiseAndAss";
            this.buttonBitwiseAndAss.Size = new System.Drawing.Size(57, 56);
            this.buttonBitwiseAndAss.TabIndex = 31;
            this.buttonBitwiseAndAss.Text = "&=";
            this.buttonBitwiseAndAss.UseVisualStyleBackColor = false;
            this.buttonBitwiseAndAss.Click += new System.EventHandler(this.buttonBitwiseAndAss_Click);
            // 
            // buttonBitwiseExclusiveAss
            // 
            this.buttonBitwiseExclusiveAss.BackColor = System.Drawing.Color.Turquoise;
            this.buttonBitwiseExclusiveAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBitwiseExclusiveAss.ForeColor = System.Drawing.Color.White;
            this.buttonBitwiseExclusiveAss.Location = new System.Drawing.Point(384, 555);
            this.buttonBitwiseExclusiveAss.Name = "buttonBitwiseExclusiveAss";
            this.buttonBitwiseExclusiveAss.Size = new System.Drawing.Size(62, 56);
            this.buttonBitwiseExclusiveAss.TabIndex = 32;
            this.buttonBitwiseExclusiveAss.Text = "^=";
            this.buttonBitwiseExclusiveAss.UseVisualStyleBackColor = false;
            this.buttonBitwiseExclusiveAss.Click += new System.EventHandler(this.buttonBitwiseExclusiveAss_Click);
            // 
            // buttonBitwiseInclusiveOrAss
            // 
            this.buttonBitwiseInclusiveOrAss.BackColor = System.Drawing.Color.Turquoise;
            this.buttonBitwiseInclusiveOrAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBitwiseInclusiveOrAss.ForeColor = System.Drawing.Color.White;
            this.buttonBitwiseInclusiveOrAss.Location = new System.Drawing.Point(461, 555);
            this.buttonBitwiseInclusiveOrAss.Name = "buttonBitwiseInclusiveOrAss";
            this.buttonBitwiseInclusiveOrAss.Size = new System.Drawing.Size(63, 56);
            this.buttonBitwiseInclusiveOrAss.TabIndex = 33;
            this.buttonBitwiseInclusiveOrAss.Text = "|=";
            this.buttonBitwiseInclusiveOrAss.UseVisualStyleBackColor = false;
            this.buttonBitwiseInclusiveOrAss.Click += new System.EventHandler(this.buttonBitwiseInclusiveOrAss_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Swis721 Blk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(133, 630);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "Math Class Operator :";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // buttonMaxClass
            // 
            this.buttonMaxClass.BackColor = System.Drawing.Color.Turquoise;
            this.buttonMaxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMaxClass.ForeColor = System.Drawing.Color.White;
            this.buttonMaxClass.Location = new System.Drawing.Point(306, 661);
            this.buttonMaxClass.Name = "buttonMaxClass";
            this.buttonMaxClass.Size = new System.Drawing.Size(65, 49);
            this.buttonMaxClass.TabIndex = 35;
            this.buttonMaxClass.Text = "Max()";
            this.buttonMaxClass.UseVisualStyleBackColor = false;
            this.buttonMaxClass.Click += new System.EventHandler(this.buttonMaxClass_Click);
            // 
            // buttonMinClass
            // 
            this.buttonMinClass.BackColor = System.Drawing.Color.Turquoise;
            this.buttonMinClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMinClass.ForeColor = System.Drawing.Color.White;
            this.buttonMinClass.Location = new System.Drawing.Point(386, 661);
            this.buttonMinClass.Name = "buttonMinClass";
            this.buttonMinClass.Size = new System.Drawing.Size(60, 49);
            this.buttonMinClass.TabIndex = 36;
            this.buttonMinClass.Text = "Min()";
            this.buttonMinClass.UseVisualStyleBackColor = false;
            this.buttonMinClass.Click += new System.EventHandler(this.buttonMinClass_Click);
            // 
            // buttonSquareRootAss
            // 
            this.buttonSquareRootAss.BackColor = System.Drawing.Color.Turquoise;
            this.buttonSquareRootAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSquareRootAss.ForeColor = System.Drawing.Color.White;
            this.buttonSquareRootAss.Location = new System.Drawing.Point(461, 661);
            this.buttonSquareRootAss.Name = "buttonSquareRootAss";
            this.buttonSquareRootAss.Size = new System.Drawing.Size(57, 49);
            this.buttonSquareRootAss.TabIndex = 37;
            this.buttonSquareRootAss.Text = "Sqrt()";
            this.buttonSquareRootAss.UseVisualStyleBackColor = false;
            this.buttonSquareRootAss.Click += new System.EventHandler(this.buttonSquareRootAss_Click);
            // 
            // buttonAbsolutePower
            // 
            this.buttonAbsolutePower.BackColor = System.Drawing.Color.Turquoise;
            this.buttonAbsolutePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAbsolutePower.ForeColor = System.Drawing.Color.White;
            this.buttonAbsolutePower.Location = new System.Drawing.Point(545, 661);
            this.buttonAbsolutePower.Name = "buttonAbsolutePower";
            this.buttonAbsolutePower.Size = new System.Drawing.Size(62, 49);
            this.buttonAbsolutePower.TabIndex = 38;
            this.buttonAbsolutePower.Text = "Abs()";
            this.buttonAbsolutePower.UseVisualStyleBackColor = false;
            this.buttonAbsolutePower.Click += new System.EventHandler(this.buttonAbsolutePower_Click);
            // 
            // buttonRound
            // 
            this.buttonRound.BackColor = System.Drawing.Color.Turquoise;
            this.buttonRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRound.ForeColor = System.Drawing.Color.White;
            this.buttonRound.Location = new System.Drawing.Point(135, 727);
            this.buttonRound.Name = "buttonRound";
            this.buttonRound.Size = new System.Drawing.Size(63, 49);
            this.buttonRound.TabIndex = 39;
            this.buttonRound.Text = "Round()";
            this.buttonRound.UseVisualStyleBackColor = false;
            this.buttonRound.Click += new System.EventHandler(this.buttonRound_Click);
            // 
            // buttonCosine
            // 
            this.buttonCosine.BackColor = System.Drawing.Color.Turquoise;
            this.buttonCosine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCosine.ForeColor = System.Drawing.Color.White;
            this.buttonCosine.Location = new System.Drawing.Point(222, 727);
            this.buttonCosine.Name = "buttonCosine";
            this.buttonCosine.Size = new System.Drawing.Size(64, 49);
            this.buttonCosine.TabIndex = 40;
            this.buttonCosine.Text = "Cos()";
            this.buttonCosine.UseVisualStyleBackColor = false;
            this.buttonCosine.Click += new System.EventHandler(this.buttonCosine_Click);
            // 
            // buttonSin
            // 
            this.buttonSin.BackColor = System.Drawing.Color.Turquoise;
            this.buttonSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSin.ForeColor = System.Drawing.Color.White;
            this.buttonSin.Location = new System.Drawing.Point(306, 727);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(64, 49);
            this.buttonSin.TabIndex = 41;
            this.buttonSin.Text = "Sin()";
            this.buttonSin.UseVisualStyleBackColor = false;
            this.buttonSin.Click += new System.EventHandler(this.buttonSin_Click);
            // 
            // buttonTangent
            // 
            this.buttonTangent.BackColor = System.Drawing.Color.Turquoise;
            this.buttonTangent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTangent.ForeColor = System.Drawing.Color.White;
            this.buttonTangent.Location = new System.Drawing.Point(382, 727);
            this.buttonTangent.Name = "buttonTangent";
            this.buttonTangent.Size = new System.Drawing.Size(64, 49);
            this.buttonTangent.TabIndex = 42;
            this.buttonTangent.Text = "Tan()";
            this.buttonTangent.UseVisualStyleBackColor = false;
            this.buttonTangent.Click += new System.EventHandler(this.buttonTangent_Click);
            // 
            // buttonAsin
            // 
            this.buttonAsin.BackColor = System.Drawing.Color.Turquoise;
            this.buttonAsin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAsin.ForeColor = System.Drawing.Color.White;
            this.buttonAsin.Location = new System.Drawing.Point(460, 727);
            this.buttonAsin.Name = "buttonAsin";
            this.buttonAsin.Size = new System.Drawing.Size(64, 49);
            this.buttonAsin.TabIndex = 43;
            this.buttonAsin.Text = "ASin()";
            this.buttonAsin.UseVisualStyleBackColor = false;
            this.buttonAsin.Click += new System.EventHandler(this.buttonAsin_Click);
            // 
            // buttonAcos
            // 
            this.buttonAcos.BackColor = System.Drawing.Color.Turquoise;
            this.buttonAcos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAcos.ForeColor = System.Drawing.Color.White;
            this.buttonAcos.Location = new System.Drawing.Point(543, 727);
            this.buttonAcos.Name = "buttonAcos";
            this.buttonAcos.Size = new System.Drawing.Size(64, 49);
            this.buttonAcos.TabIndex = 44;
            this.buttonAcos.Text = "Acos()";
            this.buttonAcos.UseVisualStyleBackColor = false;
            this.buttonAcos.Click += new System.EventHandler(this.buttonAcos_Click);
            // 
            // buttonAtan
            // 
            this.buttonAtan.BackColor = System.Drawing.Color.Turquoise;
            this.buttonAtan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAtan.ForeColor = System.Drawing.Color.White;
            this.buttonAtan.Location = new System.Drawing.Point(134, 799);
            this.buttonAtan.Name = "buttonAtan";
            this.buttonAtan.Size = new System.Drawing.Size(64, 49);
            this.buttonAtan.TabIndex = 45;
            this.buttonAtan.Text = "Atan()";
            this.buttonAtan.UseVisualStyleBackColor = false;
            this.buttonAtan.Click += new System.EventHandler(this.buttonAtan_Click);
            // 
            // buttonFLoor
            // 
            this.buttonFLoor.BackColor = System.Drawing.Color.Turquoise;
            this.buttonFLoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFLoor.ForeColor = System.Drawing.Color.White;
            this.buttonFLoor.Location = new System.Drawing.Point(222, 799);
            this.buttonFLoor.Name = "buttonFLoor";
            this.buttonFLoor.Size = new System.Drawing.Size(64, 49);
            this.buttonFLoor.TabIndex = 46;
            this.buttonFLoor.Text = "Floor()";
            this.buttonFLoor.UseVisualStyleBackColor = false;
            this.buttonFLoor.Click += new System.EventHandler(this.buttonFLoor_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.Turquoise;
            this.buttonLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLog.ForeColor = System.Drawing.Color.White;
            this.buttonLog.Location = new System.Drawing.Point(306, 799);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(64, 49);
            this.buttonLog.TabIndex = 47;
            this.buttonLog.Text = "log()";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonLog10
            // 
            this.buttonLog10.BackColor = System.Drawing.Color.Turquoise;
            this.buttonLog10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLog10.ForeColor = System.Drawing.Color.White;
            this.buttonLog10.Location = new System.Drawing.Point(384, 799);
            this.buttonLog10.Name = "buttonLog10";
            this.buttonLog10.Size = new System.Drawing.Size(73, 49);
            this.buttonLog10.TabIndex = 48;
            this.buttonLog10.Text = "log10()";
            this.buttonLog10.UseVisualStyleBackColor = false;
            this.buttonLog10.Click += new System.EventHandler(this.buttonLog10_Click);
            // 
            // buttonPI
            // 
            this.buttonPI.BackColor = System.Drawing.Color.Turquoise;
            this.buttonPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPI.ForeColor = System.Drawing.Color.White;
            this.buttonPI.Location = new System.Drawing.Point(135, 661);
            this.buttonPI.Name = "buttonPI";
            this.buttonPI.Size = new System.Drawing.Size(65, 49);
            this.buttonPI.TabIndex = 49;
            this.buttonPI.Text = "PI";
            this.buttonPI.UseVisualStyleBackColor = false;
            this.buttonPI.Click += new System.EventHandler(this.buttonPI_Click);
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.Color.Turquoise;
            this.buttonE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonE.ForeColor = System.Drawing.Color.White;
            this.buttonE.Location = new System.Drawing.Point(221, 661);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(65, 49);
            this.buttonE.TabIndex = 50;
            this.buttonE.Text = "e";
            this.buttonE.UseVisualStyleBackColor = false;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // buttonExponent
            // 
            this.buttonExponent.BackColor = System.Drawing.Color.Turquoise;
            this.buttonExponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExponent.ForeColor = System.Drawing.Color.White;
            this.buttonExponent.Location = new System.Drawing.Point(473, 799);
            this.buttonExponent.Name = "buttonExponent";
            this.buttonExponent.Size = new System.Drawing.Size(64, 49);
            this.buttonExponent.TabIndex = 51;
            this.buttonExponent.Text = "Exp()";
            this.buttonExponent.UseVisualStyleBackColor = false;
            this.buttonExponent.Click += new System.EventHandler(this.buttonExponent_Click);
            // 
            // timerColor
            // 
            this.timerColor.Tick += new System.EventHandler(this.timerColor_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Turquoise;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(777, 60);
            this.flowLayoutPanel1.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Swis721 Blk BT", 30.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(323, 49);
            this.label8.TabIndex = 53;
            this.label8.Text = "CALCULATOR";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CALCULATOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(775, 911);
            this.Controls.Add(this.buttonExponent);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonPI);
            this.Controls.Add(this.buttonLog10);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonFLoor);
            this.Controls.Add(this.buttonAtan);
            this.Controls.Add(this.buttonAcos);
            this.Controls.Add(this.buttonAsin);
            this.Controls.Add(this.buttonTangent);
            this.Controls.Add(this.buttonSin);
            this.Controls.Add(this.buttonCosine);
            this.Controls.Add(this.buttonRound);
            this.Controls.Add(this.buttonAbsolutePower);
            this.Controls.Add(this.buttonSquareRootAss);
            this.Controls.Add(this.buttonMinClass);
            this.Controls.Add(this.buttonMaxClass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonBitwiseInclusiveOrAss);
            this.Controls.Add(this.buttonBitwiseExclusiveAss);
            this.Controls.Add(this.buttonBitwiseAndAss);
            this.Controls.Add(this.buttonRightShiftAss);
            this.Controls.Add(this.buttonLeftShiftAss);
            this.Controls.Add(this.buttonModuloAss);
            this.Controls.Add(this.buttonDivisionAss);
            this.Controls.Add(this.buttonMultiplyAdd);
            this.Controls.Add(this.buttonSubtractAss);
            this.Controls.Add(this.buttonAddAss);
            this.Controls.Add(this.buttonSimpleAss);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonNOT);
            this.Controls.Add(this.buttonOR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAND);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonNotEqual);
            this.Controls.Add(this.buttonLessEqual);
            this.Controls.Add(this.buttonGreaterEqual);
            this.Controls.Add(this.buttonLessThan);
            this.Controls.Add(this.buttonGreaterThan);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonModulo);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CALCULATOR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULATOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBoxResult;
        private Button buttonAdd;
        private Label label2;
        private Button button1;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonModulo;
        private Label label3;
        private Button buttonEqual;
        private Button buttonGreaterThan;
        private Button buttonLessThan;
        private Button buttonGreaterEqual;
        private Button buttonLessEqual;
        private Button buttonNotEqual;
        private Label label4;
        private Button buttonAND;
        private Label label5;
        private Button buttonOR;
        private Button buttonNOT;
        private Label label7;
        private Button buttonSimpleAss;
        private Button buttonAddAss;
        private Button buttonSubtractAss;
        private Button buttonMultiplyAdd;
        private Button buttonDivisionAss;
        private Button buttonModuloAss;
        private Button buttonLeftShiftAss;
        private Button buttonRightShiftAss;
        private Button buttonBitwiseAndAss;
        private Button buttonBitwiseExclusiveAss;
        private Button buttonBitwiseInclusiveOrAss;
        private Label label6;
        private Button buttonMaxClass;
        private Button buttonMinClass;
        private Button buttonSquareRootAss;
        private Button buttonAbsolutePower;
        private Button buttonRound;
        private Button buttonCosine;
        private Button buttonSin;
        private Button buttonTangent;
        private Button buttonAsin;
        private Button buttonAcos;
        private Button buttonAtan;
        private Button buttonFLoor;
        private Button buttonLog;
        private Button buttonLog10;
        private Button buttonPI;
        private Button buttonE;
        private Button buttonExponent;
        private System.Windows.Forms.Timer timerColor;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label8;
    }
}