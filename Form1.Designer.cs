namespace DelegateCalculator
{
    partial class CalculatorApp
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
            this.lb_FirstNum = new System.Windows.Forms.Label();
            this.lb_SecondNum = new System.Windows.Forms.Label();
            this.lb_AnsStatic = new System.Windows.Forms.Label();
            this.txtBox_SecondNum = new System.Windows.Forms.TextBox();
            this.txtBox_FirstNum = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lb_TotalAns = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.drop_Operations = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_FirstNum
            // 
            this.lb_FirstNum.AutoSize = true;
            this.lb_FirstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FirstNum.Location = new System.Drawing.Point(53, 12);
            this.lb_FirstNum.Name = "lb_FirstNum";
            this.lb_FirstNum.Size = new System.Drawing.Size(208, 29);
            this.lb_FirstNum.TabIndex = 0;
            this.lb_FirstNum.Text = "Enter first number:";
            // 
            // lb_SecondNum
            // 
            this.lb_SecondNum.AutoSize = true;
            this.lb_SecondNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SecondNum.Location = new System.Drawing.Point(12, 156);
            this.lb_SecondNum.Name = "lb_SecondNum";
            this.lb_SecondNum.Size = new System.Drawing.Size(249, 29);
            this.lb_SecondNum.TabIndex = 1;
            this.lb_SecondNum.Text = "Enter second number:";
            // 
            // lb_AnsStatic
            // 
            this.lb_AnsStatic.AutoSize = true;
            this.lb_AnsStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AnsStatic.Location = new System.Drawing.Point(162, 221);
            this.lb_AnsStatic.Name = "lb_AnsStatic";
            this.lb_AnsStatic.Size = new System.Drawing.Size(99, 29);
            this.lb_AnsStatic.TabIndex = 2;
            this.lb_AnsStatic.Text = "Answer:";
            // 
            // txtBox_SecondNum
            // 
            this.txtBox_SecondNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_SecondNum.Location = new System.Drawing.Point(267, 153);
            this.txtBox_SecondNum.Name = "txtBox_SecondNum";
            this.txtBox_SecondNum.Size = new System.Drawing.Size(292, 34);
            this.txtBox_SecondNum.TabIndex = 4;
            // 
            // txtBox_FirstNum
            // 
            this.txtBox_FirstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_FirstNum.Location = new System.Drawing.Point(267, 9);
            this.txtBox_FirstNum.Name = "txtBox_FirstNum";
            this.txtBox_FirstNum.Size = new System.Drawing.Size(292, 34);
            this.txtBox_FirstNum.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 337);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(564, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lb_TotalAns
            // 
            this.lb_TotalAns.AutoSize = true;
            this.lb_TotalAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalAns.Location = new System.Drawing.Point(267, 221);
            this.lb_TotalAns.Name = "lb_TotalAns";
            this.lb_TotalAns.Size = new System.Drawing.Size(119, 29);
            this.lb_TotalAns.TabIndex = 7;
            this.lb_TotalAns.Text = "<answer>";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.Location = new System.Drawing.Point(272, 283);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(152, 51);
            this.btn_Calculate.TabIndex = 9;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // drop_Operations
            // 
            this.drop_Operations.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_Operations.FormattingEnabled = true;
            this.drop_Operations.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.drop_Operations.Location = new System.Drawing.Point(267, 80);
            this.drop_Operations.Name = "drop_Operations";
            this.drop_Operations.Size = new System.Drawing.Size(121, 37);
            this.drop_Operations.TabIndex = 10;
            this.drop_Operations.Text = "---";
            // 
            // CalculatorApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 359);
            this.Controls.Add(this.drop_Operations);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.lb_TotalAns);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtBox_FirstNum);
            this.Controls.Add(this.txtBox_SecondNum);
            this.Controls.Add(this.lb_AnsStatic);
            this.Controls.Add(this.lb_SecondNum);
            this.Controls.Add(this.lb_FirstNum);
            this.Name = "CalculatorApp";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_FirstNum;
        private System.Windows.Forms.Label lb_SecondNum;
        private System.Windows.Forms.Label lb_AnsStatic;
        private System.Windows.Forms.TextBox txtBox_SecondNum;
        private System.Windows.Forms.TextBox txtBox_FirstNum;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lb_TotalAns;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.ComboBox drop_Operations;
    }
}

