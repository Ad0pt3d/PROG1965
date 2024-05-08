namespace BodyMassIndex
{
    partial class MainForm
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
            this.heightLbl = new System.Windows.Forms.Label();
            this.weightLbl = new System.Windows.Forms.Label();
            this.metersLbl = new System.Windows.Forms.Label();
            this.kgLbl = new System.Windows.Forms.Label();
            this.bmiLbl = new System.Windows.Forms.Label();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.weightInput = new System.Windows.Forms.TextBox();
            this.bmiOutput = new System.Windows.Forms.TextBox();
            this.CalcBMIBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // heightLbl
            // 
            this.heightLbl.AutoSize = true;
            this.heightLbl.Location = new System.Drawing.Point(80, 80);
            this.heightLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(63, 20);
            this.heightLbl.TabIndex = 0;
            this.heightLbl.Text = "Height:";
            // 
            // weightLbl
            // 
            this.weightLbl.AutoSize = true;
            this.weightLbl.Location = new System.Drawing.Point(80, 160);
            this.weightLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(66, 20);
            this.weightLbl.TabIndex = 1;
            this.weightLbl.Text = "Weight:";
            // 
            // metersLbl
            // 
            this.metersLbl.AutoSize = true;
            this.metersLbl.Location = new System.Drawing.Point(300, 80);
            this.metersLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metersLbl.Name = "metersLbl";
            this.metersLbl.Size = new System.Drawing.Size(61, 20);
            this.metersLbl.TabIndex = 2;
            this.metersLbl.Text = "Meters";
            // 
            // kgLbl
            // 
            this.kgLbl.AutoSize = true;
            this.kgLbl.Location = new System.Drawing.Point(300, 160);
            this.kgLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kgLbl.Name = "kgLbl";
            this.kgLbl.Size = new System.Drawing.Size(29, 20);
            this.kgLbl.TabIndex = 3;
            this.kgLbl.Text = "Kg";
            // 
            // bmiLbl
            // 
            this.bmiLbl.AutoSize = true;
            this.bmiLbl.Location = new System.Drawing.Point(80, 320);
            this.bmiLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bmiLbl.Name = "bmiLbl";
            this.bmiLbl.Size = new System.Drawing.Size(44, 20);
            this.bmiLbl.TabIndex = 4;
            this.bmiLbl.Text = "BMI:";
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(160, 78);
            this.heightInput.Margin = new System.Windows.Forms.Padding(4);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(120, 26);
            this.heightInput.TabIndex = 5;
            // 
            // weightInput
            // 
            this.weightInput.Location = new System.Drawing.Point(160, 158);
            this.weightInput.Margin = new System.Windows.Forms.Padding(4);
            this.weightInput.Name = "weightInput";
            this.weightInput.Size = new System.Drawing.Size(120, 26);
            this.weightInput.TabIndex = 5;
            // 
            // bmiOutput
            // 
            this.bmiOutput.Location = new System.Drawing.Point(160, 318);
            this.bmiOutput.Margin = new System.Windows.Forms.Padding(4);
            this.bmiOutput.Name = "bmiOutput";
            this.bmiOutput.Size = new System.Drawing.Size(201, 26);
            this.bmiOutput.TabIndex = 5;
            // 
            // CalcBMIBtn
            // 
            this.CalcBMIBtn.Location = new System.Drawing.Point(80, 240);
            this.CalcBMIBtn.Name = "CalcBMIBtn";
            this.CalcBMIBtn.Size = new System.Drawing.Size(200, 30);
            this.CalcBMIBtn.TabIndex = 6;
            this.CalcBMIBtn.Text = "Calculate BMI";
            this.CalcBMIBtn.UseVisualStyleBackColor = true;
            this.CalcBMIBtn.Click += new System.EventHandler(this.CalcBMIBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(80, 400);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(200, 30);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 525);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.CalcBMIBtn);
            this.Controls.Add(this.bmiOutput);
            this.Controls.Add(this.weightInput);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.bmiLbl);
            this.Controls.Add(this.kgLbl);
            this.Controls.Add(this.metersLbl);
            this.Controls.Add(this.weightLbl);
            this.Controls.Add(this.heightLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.Label weightLbl;
        private System.Windows.Forms.Label metersLbl;
        private System.Windows.Forms.Label kgLbl;
        private System.Windows.Forms.Label bmiLbl;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.TextBox weightInput;
        private System.Windows.Forms.TextBox bmiOutput;
        private System.Windows.Forms.Button CalcBMIBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}