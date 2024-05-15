namespace ListBoxEg1
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
            this.enterItemLbl = new System.Windows.Forms.Label();
            this.listItemsLbl = new System.Windows.Forms.Label();
            this.itemNameTxtBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.countBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.lstBoxSkiing = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // enterItemLbl
            // 
            this.enterItemLbl.AutoSize = true;
            this.enterItemLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.enterItemLbl.ForeColor = System.Drawing.Color.Black;
            this.enterItemLbl.Location = new System.Drawing.Point(67, 91);
            this.enterItemLbl.Name = "enterItemLbl";
            this.enterItemLbl.Size = new System.Drawing.Size(156, 20);
            this.enterItemLbl.TabIndex = 0;
            this.enterItemLbl.Text = "Enter Item Name:";
            // 
            // listItemsLbl
            // 
            this.listItemsLbl.AutoSize = true;
            this.listItemsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.listItemsLbl.ForeColor = System.Drawing.Color.Black;
            this.listItemsLbl.Location = new System.Drawing.Point(67, 135);
            this.listItemsLbl.Name = "listItemsLbl";
            this.listItemsLbl.Size = new System.Drawing.Size(121, 20);
            this.listItemsLbl.TabIndex = 1;
            this.listItemsLbl.Text = "List of Items:";
            // 
            // itemNameTxtBox
            // 
            this.itemNameTxtBox.Location = new System.Drawing.Point(264, 88);
            this.itemNameTxtBox.Name = "itemNameTxtBox";
            this.itemNameTxtBox.Size = new System.Drawing.Size(256, 26);
            this.itemNameTxtBox.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(599, 85);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(96, 32);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // countBtn
            // 
            this.countBtn.Location = new System.Drawing.Point(599, 123);
            this.countBtn.Name = "countBtn";
            this.countBtn.Size = new System.Drawing.Size(96, 32);
            this.countBtn.TabIndex = 4;
            this.countBtn.Text = "Count";
            this.countBtn.UseVisualStyleBackColor = true;
            this.countBtn.Click += new System.EventHandler(this.countBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(146, 414);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(96, 32);
            this.removeBtn.TabIndex = 5;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(554, 414);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(96, 32);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.BackColor = System.Drawing.Color.White;
            this.sortBtn.ForeColor = System.Drawing.Color.Black;
            this.sortBtn.Location = new System.Drawing.Point(352, 414);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(96, 32);
            this.sortBtn.TabIndex = 7;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = false;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // lstBoxSkiing
            // 
            this.lstBoxSkiing.FormattingEnabled = true;
            this.lstBoxSkiing.ItemHeight = 20;
            this.lstBoxSkiing.Location = new System.Drawing.Point(264, 135);
            this.lstBoxSkiing.Name = "lstBoxSkiing";
            this.lstBoxSkiing.Size = new System.Drawing.Size(256, 244);
            this.lstBoxSkiing.TabIndex = 8;
            this.lstBoxSkiing.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 488);
            this.Controls.Add(this.lstBoxSkiing);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.countBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.itemNameTxtBox);
            this.Controls.Add(this.listItemsLbl);
            this.Controls.Add(this.enterItemLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterItemLbl;
        private System.Windows.Forms.Label listItemsLbl;
        private System.Windows.Forms.TextBox itemNameTxtBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button countBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.ListBox lstBoxSkiing;
    }
}

