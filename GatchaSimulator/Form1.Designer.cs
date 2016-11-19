namespace GatchaSimulator
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
            this.unitListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rarityComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.unitNameTxtBox = new System.Windows.Forms.TextBox();
            this.addUnitBtn = new System.Windows.Forms.Button();
            this.delUnitBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // unitListBox
            // 
            this.unitListBox.FormattingEnabled = true;
            this.unitListBox.Location = new System.Drawing.Point(12, 29);
            this.unitListBox.Name = "unitListBox";
            this.unitListBox.Size = new System.Drawing.Size(120, 199);
            this.unitListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Units";
            // 
            // rarityComboBox
            // 
            this.rarityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rarityComboBox.FormattingEnabled = true;
            this.rarityComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.rarityComboBox.Location = new System.Drawing.Point(54, 233);
            this.rarityComboBox.Name = "rarityComboBox";
            this.rarityComboBox.Size = new System.Drawing.Size(78, 21);
            this.rarityComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rarity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // unitNameTxtBox
            // 
            this.unitNameTxtBox.Location = new System.Drawing.Point(54, 261);
            this.unitNameTxtBox.Name = "unitNameTxtBox";
            this.unitNameTxtBox.Size = new System.Drawing.Size(78, 20);
            this.unitNameTxtBox.TabIndex = 5;
            // 
            // addUnitBtn
            // 
            this.addUnitBtn.Location = new System.Drawing.Point(76, 287);
            this.addUnitBtn.Name = "addUnitBtn";
            this.addUnitBtn.Size = new System.Drawing.Size(58, 23);
            this.addUnitBtn.TabIndex = 6;
            this.addUnitBtn.Text = "Add Unit";
            this.addUnitBtn.UseVisualStyleBackColor = true;
            this.addUnitBtn.Click += new System.EventHandler(this.addUnitBtn_Click);
            // 
            // delUnitBtn
            // 
            this.delUnitBtn.Location = new System.Drawing.Point(12, 287);
            this.delUnitBtn.Name = "delUnitBtn";
            this.delUnitBtn.Size = new System.Drawing.Size(58, 23);
            this.delUnitBtn.TabIndex = 7;
            this.delUnitBtn.Text = "Del Unit";
            this.delUnitBtn.UseVisualStyleBackColor = true;
            this.delUnitBtn.Click += new System.EventHandler(this.delUnitBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 29);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(314, 199);
            this.textBox2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Unit Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.delUnitBtn);
            this.Controls.Add(this.addUnitBtn);
            this.Controls.Add(this.unitNameTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rarityComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unitListBox);
            this.Name = "Form1";
            this.Text = "Gatcha Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox unitListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rarityComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox unitNameTxtBox;
        private System.Windows.Forms.Button addUnitBtn;
        private System.Windows.Forms.Button delUnitBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
    }
}

