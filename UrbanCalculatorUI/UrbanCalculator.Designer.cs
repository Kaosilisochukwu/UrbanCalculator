namespace UrbanCalculatorUI
{
    partial class UrbanCalculator
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
            this.visDisplay = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.NegationBtn = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.additionBtn = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.subtractionBtn = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.multiplicationBtn = new System.Windows.Forms.Button();
            this.period = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.equaltoBtn = new System.Windows.Forms.Button();
            this.divisionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // visDisplay
            // 
            this.visDisplay.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.visDisplay.Location = new System.Drawing.Point(12, 12);
            this.visDisplay.Multiline = true;
            this.visDisplay.Name = "visDisplay";
            this.visDisplay.Size = new System.Drawing.Size(334, 54);
            this.visDisplay.TabIndex = 0;
            this.visDisplay.Text = "0";
            this.visDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.Location = new System.Drawing.Point(12, 82);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(79, 84);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "← ";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetBtn.Location = new System.Drawing.Point(97, 82);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(79, 84);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "CE";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearBtn.Location = new System.Drawing.Point(182, 82);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(79, 84);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // NegationBtn
            // 
            this.NegationBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NegationBtn.Location = new System.Drawing.Point(267, 82);
            this.NegationBtn.Name = "NegationBtn";
            this.NegationBtn.Size = new System.Drawing.Size(79, 84);
            this.NegationBtn.TabIndex = 1;
            this.NegationBtn.Text = "±";
            this.NegationBtn.UseVisualStyleBackColor = true;
            this.NegationBtn.Click += new System.EventHandler(this.NegationBtn_Click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.seven.Location = new System.Drawing.Point(13, 172);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(79, 84);
            this.seven.TabIndex = 1;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.numbers);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eight.Location = new System.Drawing.Point(98, 172);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(79, 84);
            this.eight.TabIndex = 1;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.numbers);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nine.Location = new System.Drawing.Point(183, 172);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(79, 84);
            this.nine.TabIndex = 1;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.numbers);
            // 
            // additionBtn
            // 
            this.additionBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.additionBtn.Location = new System.Drawing.Point(268, 172);
            this.additionBtn.Name = "additionBtn";
            this.additionBtn.Size = new System.Drawing.Size(79, 84);
            this.additionBtn.TabIndex = 1;
            this.additionBtn.Text = "+";
            this.additionBtn.UseVisualStyleBackColor = true;
            this.additionBtn.Click += new System.EventHandler(this.operators);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.four.Location = new System.Drawing.Point(13, 262);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(79, 84);
            this.four.TabIndex = 1;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.numbers);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.five.Location = new System.Drawing.Point(98, 262);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(79, 84);
            this.five.TabIndex = 1;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.numbers);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.six.Location = new System.Drawing.Point(183, 262);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(79, 84);
            this.six.TabIndex = 1;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.numbers);
            // 
            // subtractionBtn
            // 
            this.subtractionBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subtractionBtn.Location = new System.Drawing.Point(268, 262);
            this.subtractionBtn.Name = "subtractionBtn";
            this.subtractionBtn.Size = new System.Drawing.Size(79, 84);
            this.subtractionBtn.TabIndex = 1;
            this.subtractionBtn.Text = "-";
            this.subtractionBtn.UseVisualStyleBackColor = true;
            this.subtractionBtn.Click += new System.EventHandler(this.operators);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.one.Location = new System.Drawing.Point(13, 352);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(79, 84);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.numbers);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.two.Location = new System.Drawing.Point(98, 352);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(79, 84);
            this.two.TabIndex = 1;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.numbers);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.three.Location = new System.Drawing.Point(183, 352);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(79, 84);
            this.three.TabIndex = 1;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.numbers);
            // 
            // multiplicationBtn
            // 
            this.multiplicationBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.multiplicationBtn.Location = new System.Drawing.Point(268, 352);
            this.multiplicationBtn.Name = "multiplicationBtn";
            this.multiplicationBtn.Size = new System.Drawing.Size(79, 84);
            this.multiplicationBtn.TabIndex = 1;
            this.multiplicationBtn.Text = "x";
            this.multiplicationBtn.UseVisualStyleBackColor = true;
            this.multiplicationBtn.Click += new System.EventHandler(this.operators);
            // 
            // period
            // 
            this.period.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.period.Location = new System.Drawing.Point(12, 442);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(79, 84);
            this.period.TabIndex = 1;
            this.period.Text = ".";
            this.period.UseVisualStyleBackColor = true;
            this.period.Click += new System.EventHandler(this.numbers);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zero.Location = new System.Drawing.Point(97, 442);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(79, 84);
            this.zero.TabIndex = 1;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.numbers);
            // 
            // equaltoBtn
            // 
            this.equaltoBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.equaltoBtn.Location = new System.Drawing.Point(182, 442);
            this.equaltoBtn.Name = "equaltoBtn";
            this.equaltoBtn.Size = new System.Drawing.Size(79, 84);
            this.equaltoBtn.TabIndex = 1;
            this.equaltoBtn.Text = "=";
            this.equaltoBtn.UseVisualStyleBackColor = true;
            this.equaltoBtn.Click += new System.EventHandler(this.equaltoBtn_Click);
            // 
            // divisionBtn
            // 
            this.divisionBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.divisionBtn.Location = new System.Drawing.Point(267, 442);
            this.divisionBtn.Name = "divisionBtn";
            this.divisionBtn.Size = new System.Drawing.Size(79, 84);
            this.divisionBtn.TabIndex = 1;
            this.divisionBtn.Text = "÷";
            this.divisionBtn.UseVisualStyleBackColor = true;
            this.divisionBtn.Click += new System.EventHandler(this.operators);
            // 
            // UrbanCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(359, 553);
            this.Controls.Add(this.divisionBtn);
            this.Controls.Add(this.multiplicationBtn);
            this.Controls.Add(this.equaltoBtn);
            this.Controls.Add(this.three);
            this.Controls.Add(this.subtractionBtn);
            this.Controls.Add(this.six);
            this.Controls.Add(this.additionBtn);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.two);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.five);
            this.Controls.Add(this.NegationBtn);
            this.Controls.Add(this.period);
            this.Controls.Add(this.one);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.four);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.visDisplay);
            this.MaximumSize = new System.Drawing.Size(377, 610);
            this.MinimumSize = new System.Drawing.Size(377, 600);
            this.Name = "UrbanCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrbanCalculator";
           // this.Load += new System.EventHandler(this.UrbanCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox visDisplay;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button NegationBtn;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button additionBtn;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button subtractionBtn;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button multiplicationBtn;
        private System.Windows.Forms.Button period;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button equaltoBtn;
        private System.Windows.Forms.Button divisionBtn;
    }
}