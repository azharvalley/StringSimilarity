namespace TestWindowsFormApp
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
            this.string1txtBox = new System.Windows.Forms.TextBox();
            this.string2txtBox = new System.Windows.Forms.TextBox();
            this.levenstainTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.compute = new System.Windows.Forms.Button();
            this.jaroWinklerTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nGramTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.diceCoefficientTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // string1txtBox
            // 
            this.string1txtBox.Location = new System.Drawing.Point(157, 34);
            this.string1txtBox.Name = "string1txtBox";
            this.string1txtBox.Size = new System.Drawing.Size(354, 20);
            this.string1txtBox.TabIndex = 0;
            this.string1txtBox.TextChanged += new System.EventHandler(this.string1txtBox_TextChanged);
            // 
            // string2txtBox
            // 
            this.string2txtBox.Location = new System.Drawing.Point(157, 70);
            this.string2txtBox.Name = "string2txtBox";
            this.string2txtBox.Size = new System.Drawing.Size(354, 20);
            this.string2txtBox.TabIndex = 1;
            // 
            // levenstainTxtBox
            // 
            this.levenstainTxtBox.Location = new System.Drawing.Point(238, 106);
            this.levenstainTxtBox.Name = "levenstainTxtBox";
            this.levenstainTxtBox.Size = new System.Drawing.Size(67, 20);
            this.levenstainTxtBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "String 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "String 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Levenstain Similarity";
            // 
            // compute
            // 
            this.compute.Location = new System.Drawing.Point(101, 258);
            this.compute.Name = "compute";
            this.compute.Size = new System.Drawing.Size(204, 23);
            this.compute.TabIndex = 6;
            this.compute.Text = "Compute Levenstain";
            this.compute.UseVisualStyleBackColor = true;
            this.compute.Click += new System.EventHandler(this.compute_Click);
            // 
            // jaroWinklerTxtBox
            // 
            this.jaroWinklerTxtBox.Location = new System.Drawing.Point(238, 132);
            this.jaroWinklerTxtBox.Name = "jaroWinklerTxtBox";
            this.jaroWinklerTxtBox.Size = new System.Drawing.Size(67, 20);
            this.jaroWinklerTxtBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jaro-Winkler Similarity";
            // 
            // nGramTxtBox
            // 
            this.nGramTxtBox.Location = new System.Drawing.Point(238, 158);
            this.nGramTxtBox.Name = "nGramTxtBox";
            this.nGramTxtBox.Size = new System.Drawing.Size(67, 20);
            this.nGramTxtBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "nGrams Similarity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dice Coefficient";
            // 
            // diceCoefficientTxtBox
            // 
            this.diceCoefficientTxtBox.Location = new System.Drawing.Point(238, 184);
            this.diceCoefficientTxtBox.Name = "diceCoefficientTxtBox";
            this.diceCoefficientTxtBox.Size = new System.Drawing.Size(67, 20);
            this.diceCoefficientTxtBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.diceCoefficientTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nGramTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jaroWinklerTxtBox);
            this.Controls.Add(this.compute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.levenstainTxtBox);
            this.Controls.Add(this.string2txtBox);
            this.Controls.Add(this.string1txtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox string1txtBox;
        private System.Windows.Forms.TextBox string2txtBox;
        private System.Windows.Forms.TextBox levenstainTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button compute;
        private System.Windows.Forms.TextBox jaroWinklerTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nGramTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox diceCoefficientTxtBox;
    }
}

