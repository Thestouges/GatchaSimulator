﻿namespace GatchaSimulator
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
            this.label4 = new System.Windows.Forms.Label();
            this.displayInfoTextBox = new System.Windows.Forms.TextBox();
            this.unitInfoTextBox = new System.Windows.Forms.TextBox();
            this.rollBtn = new System.Windows.Forms.Button();
            this.rollListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rollDelRadioBtn = new System.Windows.Forms.RadioButton();
            this.rollNormRadioBtn = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.historyTxtBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // unitListBox
            // 
            this.unitListBox.FormattingEnabled = true;
            this.unitListBox.Location = new System.Drawing.Point(12, 29);
            this.unitListBox.Name = "unitListBox";
            this.unitListBox.Size = new System.Drawing.Size(120, 199);
            this.unitListBox.TabIndex = 0;
            this.unitListBox.SelectedIndexChanged += new System.EventHandler(this.unitListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Items";
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
            this.addUnitBtn.Text = "Add Item";
            this.addUnitBtn.UseVisualStyleBackColor = true;
            this.addUnitBtn.Click += new System.EventHandler(this.addUnitBtn_Click);
            // 
            // delUnitBtn
            // 
            this.delUnitBtn.Location = new System.Drawing.Point(12, 287);
            this.delUnitBtn.Name = "delUnitBtn";
            this.delUnitBtn.Size = new System.Drawing.Size(58, 23);
            this.delUnitBtn.TabIndex = 7;
            this.delUnitBtn.Text = "Del Item";
            this.delUnitBtn.UseVisualStyleBackColor = true;
            this.delUnitBtn.Click += new System.EventHandler(this.delUnitBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Item Info";
            // 
            // displayInfoTextBox
            // 
            this.displayInfoTextBox.Location = new System.Drawing.Point(138, 29);
            this.displayInfoTextBox.Multiline = true;
            this.displayInfoTextBox.Name = "displayInfoTextBox";
            this.displayInfoTextBox.ReadOnly = true;
            this.displayInfoTextBox.Size = new System.Drawing.Size(228, 199);
            this.displayInfoTextBox.TabIndex = 8;
            // 
            // unitInfoTextBox
            // 
            this.unitInfoTextBox.Location = new System.Drawing.Point(138, 233);
            this.unitInfoTextBox.Multiline = true;
            this.unitInfoTextBox.Name = "unitInfoTextBox";
            this.unitInfoTextBox.Size = new System.Drawing.Size(134, 48);
            this.unitInfoTextBox.TabIndex = 10;
            // 
            // rollBtn
            // 
            this.rollBtn.Location = new System.Drawing.Point(278, 287);
            this.rollBtn.Name = "rollBtn";
            this.rollBtn.Size = new System.Drawing.Size(88, 23);
            this.rollBtn.TabIndex = 11;
            this.rollBtn.Text = "Roll";
            this.rollBtn.UseVisualStyleBackColor = true;
            this.rollBtn.Click += new System.EventHandler(this.rollBtn_Click);
            // 
            // rollListBox
            // 
            this.rollListBox.FormattingEnabled = true;
            this.rollListBox.Location = new System.Drawing.Point(372, 237);
            this.rollListBox.Name = "rollListBox";
            this.rollListBox.Size = new System.Drawing.Size(80, 69);
            this.rollListBox.TabIndex = 12;
            this.rollListBox.SelectedIndexChanged += new System.EventHandler(this.rollListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rollDelRadioBtn);
            this.groupBox1.Controls.Add(this.rollNormRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(278, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 56);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // rollDelRadioBtn
            // 
            this.rollDelRadioBtn.AutoSize = true;
            this.rollDelRadioBtn.Location = new System.Drawing.Point(3, 34);
            this.rollDelRadioBtn.Name = "rollDelRadioBtn";
            this.rollDelRadioBtn.Size = new System.Drawing.Size(83, 17);
            this.rollDelRadioBtn.TabIndex = 16;
            this.rollDelRadioBtn.TabStop = true;
            this.rollDelRadioBtn.Text = "Roll and Del";
            this.rollDelRadioBtn.UseVisualStyleBackColor = true;
            // 
            // rollNormRadioBtn
            // 
            this.rollNormRadioBtn.AutoSize = true;
            this.rollNormRadioBtn.Checked = true;
            this.rollNormRadioBtn.Location = new System.Drawing.Point(3, 11);
            this.rollNormRadioBtn.Name = "rollNormRadioBtn";
            this.rollNormRadioBtn.Size = new System.Drawing.Size(79, 17);
            this.rollNormRadioBtn.TabIndex = 15;
            this.rollNormRadioBtn.TabStop = true;
            this.rollNormRadioBtn.Text = "Normal Roll";
            this.rollNormRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Roll History";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Clear History";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // historyTxtBox
            // 
            this.historyTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.historyTxtBox.Location = new System.Drawing.Point(372, 29);
            this.historyTxtBox.Name = "historyTxtBox";
            this.historyTxtBox.ReadOnly = true;
            this.historyTxtBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.historyTxtBox.Size = new System.Drawing.Size(80, 169);
            this.historyTxtBox.TabIndex = 19;
            this.historyTxtBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.historyTxtBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rollListBox);
            this.Controls.Add(this.rollBtn);
            this.Controls.Add(this.unitInfoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.displayInfoTextBox);
            this.Controls.Add(this.delUnitBtn);
            this.Controls.Add(this.addUnitBtn);
            this.Controls.Add(this.unitNameTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rarityComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unitListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Gatcha Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox displayInfoTextBox;
        private System.Windows.Forms.TextBox unitInfoTextBox;
        private System.Windows.Forms.Button rollBtn;
        private System.Windows.Forms.ListBox rollListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rollDelRadioBtn;
        private System.Windows.Forms.RadioButton rollNormRadioBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox historyTxtBox;
    }
}

