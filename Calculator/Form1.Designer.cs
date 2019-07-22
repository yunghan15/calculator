namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonAddition = new System.Windows.Forms.Button();
            this.buttonSubstration = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonAC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.postorderLabel = new System.Windows.Forms.Label();
            this.preorderLabel = new System.Windows.Forms.Label();
            this.binaryLabel = new System.Windows.Forms.Label();
            this.decimalLabel = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.inputText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputText.Font = new System.Drawing.Font("Consolas", 18F);
            this.inputText.Location = new System.Drawing.Point(43, 52);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(550, 58);
            this.inputText.TabIndex = 0;
            this.inputText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(43, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(112, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BtnClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(182, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.BtnClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(43, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.BtnClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(112, 225);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.BtnClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(182, 225);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.BtnClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(43, 145);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.BtnClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(112, 145);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.BtnClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(182, 145);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.BtnClick);
            // 
            // buttonAddition
            // 
            this.buttonAddition.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonAddition.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddition.Location = new System.Drawing.Point(254, 145);
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.Size = new System.Drawing.Size(50, 50);
            this.buttonAddition.TabIndex = 10;
            this.buttonAddition.Text = "+";
            this.buttonAddition.UseVisualStyleBackColor = false;
            this.buttonAddition.Click += new System.EventHandler(this.OpClick);
            // 
            // buttonSubstration
            // 
            this.buttonSubstration.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSubstration.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubstration.Location = new System.Drawing.Point(254, 225);
            this.buttonSubstration.Name = "buttonSubstration";
            this.buttonSubstration.Size = new System.Drawing.Size(50, 50);
            this.buttonSubstration.TabIndex = 11;
            this.buttonSubstration.Text = "-";
            this.buttonSubstration.UseVisualStyleBackColor = false;
            this.buttonSubstration.Click += new System.EventHandler(this.OpClick);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonMultiplication.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplication.Location = new System.Drawing.Point(254, 299);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(50, 50);
            this.buttonMultiplication.TabIndex = 12;
            this.buttonMultiplication.Text = "*";
            this.buttonMultiplication.UseVisualStyleBackColor = false;
            this.buttonMultiplication.Click += new System.EventHandler(this.OpClick);
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonDivision.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivision.Location = new System.Drawing.Point(254, 373);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(50, 50);
            this.buttonDivision.TabIndex = 13;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.OpClick);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button0.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(43, 373);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(189, 50);
            this.button0.TabIndex = 14;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.BtnClick);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBackspace.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackspace.Location = new System.Drawing.Point(326, 145);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(50, 130);
            this.buttonBackspace.TabIndex = 15;
            this.buttonBackspace.Text = "←";
            this.buttonBackspace.UseVisualStyleBackColor = false;
            this.buttonBackspace.Click += new System.EventHandler(this.backspaceClick);
            // 
            // buttonAC
            // 
            this.buttonAC.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonAC.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAC.Location = new System.Drawing.Point(326, 299);
            this.buttonAC.Name = "buttonAC";
            this.buttonAC.Size = new System.Drawing.Size(50, 124);
            this.buttonAC.TabIndex = 16;
            this.buttonAC.Text = "AC";
            this.buttonAC.UseVisualStyleBackColor = false;
            this.buttonAC.Click += new System.EventHandler(this.restartClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 40);
            this.label1.TabIndex = 17;
            this.label1.Text = "POSTORDER:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 40);
            this.label2.TabIndex = 18;
            this.label2.Text = "REORDER:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 40);
            this.label4.TabIndex = 20;
            this.label4.Text = "DECIMAL:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 40);
            this.label5.TabIndex = 21;
            this.label5.Text = "BINARY:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // postorderLabel
            // 
            this.postorderLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.postorderLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postorderLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postorderLabel.Location = new System.Drawing.Point(488, 150);
            this.postorderLabel.Name = "postorderLabel";
            this.postorderLabel.Size = new System.Drawing.Size(222, 40);
            this.postorderLabel.TabIndex = 22;
            this.postorderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // preorderLabel
            // 
            this.preorderLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.preorderLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preorderLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preorderLabel.Location = new System.Drawing.Point(488, 230);
            this.preorderLabel.Name = "preorderLabel";
            this.preorderLabel.Size = new System.Drawing.Size(222, 40);
            this.preorderLabel.TabIndex = 23;
            this.preorderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // binaryLabel
            // 
            this.binaryLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.binaryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.binaryLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryLabel.Location = new System.Drawing.Point(488, 378);
            this.binaryLabel.Name = "binaryLabel";
            this.binaryLabel.Size = new System.Drawing.Size(222, 40);
            this.binaryLabel.TabIndex = 24;
            this.binaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // decimalLabel
            // 
            this.decimalLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.decimalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decimalLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalLabel.Location = new System.Drawing.Point(488, 304);
            this.decimalLabel.Name = "decimalLabel";
            this.decimalLabel.Size = new System.Drawing.Size(222, 40);
            this.decimalLabel.TabIndex = 25;
            this.decimalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonEnter.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnter.Location = new System.Drawing.Point(610, 52);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(100, 58);
            this.buttonEnter.TabIndex = 0;
            this.buttonEnter.Text = "ENTER";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.enterClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(750, 454);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.decimalLabel);
            this.Controls.Add(this.binaryLabel);
            this.Controls.Add(this.preorderLabel);
            this.Controls.Add(this.postorderLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAC);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonSubstration);
            this.Controls.Add(this.buttonAddition);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyInput);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label inputText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonAddition;
        private System.Windows.Forms.Button buttonSubstration;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonAC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label postorderLabel;
        private System.Windows.Forms.Label preorderLabel;
        private System.Windows.Forms.Label binaryLabel;
        private System.Windows.Forms.Label decimalLabel;
        private System.Windows.Forms.Button buttonEnter;
    }
}

