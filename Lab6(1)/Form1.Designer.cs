namespace Lab6_1_
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
            this.txtSquareSide = new System.Windows.Forms.TextBox();
            this.txtCircleRadius = new System.Windows.Forms.TextBox();
            this.txtCircleArea = new System.Windows.Forms.TextBox();
            this.txtSquareArea = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtSquareSide
            // 
            this.txtSquareSide.Location = new System.Drawing.Point(226, 59);
            this.txtSquareSide.Name = "txtSquareSide";
            this.txtSquareSide.Size = new System.Drawing.Size(121, 26);
            this.txtSquareSide.TabIndex = 0;
            // 
            // txtCircleRadius
            // 
            this.txtCircleRadius.Location = new System.Drawing.Point(226, 98);
            this.txtCircleRadius.Name = "txtCircleRadius";
            this.txtCircleRadius.Size = new System.Drawing.Size(121, 26);
            this.txtCircleRadius.TabIndex = 2;
            // 
            // txtCircleArea
            // 
            this.txtCircleArea.Location = new System.Drawing.Point(226, 245);
            this.txtCircleArea.Name = "txtCircleArea";
            this.txtCircleArea.ReadOnly = true;
            this.txtCircleArea.Size = new System.Drawing.Size(121, 26);
            this.txtCircleArea.TabIndex = 4;
            // 
            // txtSquareArea
            // 
            this.txtSquareArea.Location = new System.Drawing.Point(226, 203);
            this.txtSquareArea.Name = "txtSquareArea";
            this.txtSquareArea.ReadOnly = true;
            this.txtSquareArea.Size = new System.Drawing.Size(121, 26);
            this.txtSquareArea.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(124, 144);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(146, 36);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Розрахувати";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Радіус кола";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сторона квадрата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Площа квадрата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Площа кола";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 353);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtCircleArea);
            this.Controls.Add(this.txtSquareArea);
            this.Controls.Add(this.txtCircleRadius);
            this.Controls.Add(this.txtSquareSide);
            this.Name = "Form1";
            this.Text = "Лабораторна 6(1)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSquareSide;
        private System.Windows.Forms.TextBox txtCircleRadius;
        private System.Windows.Forms.TextBox txtCircleArea;
        private System.Windows.Forms.TextBox txtSquareArea;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

