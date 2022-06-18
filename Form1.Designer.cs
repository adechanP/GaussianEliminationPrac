namespace GaussianEliminationPrac
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
            this.dtGridView_Mtx = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtGridView_Ans = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Row = new System.Windows.Forms.TextBox();
            this.txtBox_Col = new System.Windows.Forms.TextBox();
            this.btn_Make = new System.Windows.Forms.Button();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Mtx)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Ans)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridView_Mtx
            // 
            this.dtGridView_Mtx.AllowUserToAddRows = false;
            this.dtGridView_Mtx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_Mtx.Location = new System.Drawing.Point(6, 96);
            this.dtGridView_Mtx.Name = "dtGridView_Mtx";
            this.dtGridView_Mtx.Size = new System.Drawing.Size(348, 263);
            this.dtGridView_Mtx.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Calc);
            this.groupBox1.Controls.Add(this.btn_Make);
            this.groupBox1.Controls.Add(this.dtGridView_Mtx);
            this.groupBox1.Controls.Add(this.txtBox_Col);
            this.groupBox1.Controls.Add(this.txtBox_Row);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 367);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // dtGridView_Ans
            // 
            this.dtGridView_Ans.AllowUserToAddRows = false;
            this.dtGridView_Ans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_Ans.Location = new System.Drawing.Point(9, 96);
            this.dtGridView_Ans.Name = "dtGridView_Ans";
            this.dtGridView_Ans.Size = new System.Drawing.Size(184, 263);
            this.dtGridView_Ans.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Row";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Column";
            // 
            // txtBox_Row
            // 
            this.txtBox_Row.Location = new System.Drawing.Point(75, 24);
            this.txtBox_Row.Name = "txtBox_Row";
            this.txtBox_Row.Size = new System.Drawing.Size(75, 20);
            this.txtBox_Row.TabIndex = 2;
            this.txtBox_Row.Text = "3";
            // 
            // txtBox_Col
            // 
            this.txtBox_Col.Location = new System.Drawing.Point(75, 53);
            this.txtBox_Col.Name = "txtBox_Col";
            this.txtBox_Col.Size = new System.Drawing.Size(75, 20);
            this.txtBox_Col.TabIndex = 3;
            this.txtBox_Col.Text = "3";
            // 
            // btn_Make
            // 
            this.btn_Make.Location = new System.Drawing.Point(228, 22);
            this.btn_Make.Name = "btn_Make";
            this.btn_Make.Size = new System.Drawing.Size(126, 23);
            this.btn_Make.TabIndex = 4;
            this.btn_Make.Text = "Make Input Grid";
            this.btn_Make.UseVisualStyleBackColor = true;
            this.btn_Make.Click += new System.EventHandler(this.btn_Make_Click);
            // 
            // btn_Calc
            // 
            this.btn_Calc.Location = new System.Drawing.Point(228, 51);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(126, 23);
            this.btn_Calc.TabIndex = 5;
            this.btn_Calc.Text = "Calculate";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtGridView_Ans);
            this.groupBox3.Location = new System.Drawing.Point(381, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 367);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 384);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Gaussian Elimination Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Mtx)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Ans)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridView_Mtx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Button btn_Make;
        private System.Windows.Forms.TextBox txtBox_Col;
        private System.Windows.Forms.DataGridView dtGridView_Ans;
        private System.Windows.Forms.TextBox txtBox_Row;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

