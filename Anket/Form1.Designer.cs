using System.Drawing;
using System.Windows.Forms;

namespace Anket
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BirthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.changeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(146, 71);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(260, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(146, 106);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(260, 22);
            this.surnameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "&Surname:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(146, 142);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(260, 22);
            this.emailTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "&Email:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(146, 177);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(260, 22);
            this.phoneTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "&Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "&Birthday:";
            // 
            // BirthdayPicker
            // 
            this.BirthdayPicker.Location = new System.Drawing.Point(156, 212);
            this.BirthdayPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BirthdayPicker.Name = "BirthdayPicker";
            this.BirthdayPicker.Size = new System.Drawing.Size(250, 22);
            this.BirthdayPicker.TabIndex = 10;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.White;
            this.changeButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.changeButton.ForeColor = System.Drawing.Color.Black;
            this.changeButton.Location = new System.Drawing.Point(303, 277);
            this.changeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(103, 39);
            this.changeButton.TabIndex = 11;
            this.changeButton.Text = "&Change";
            this.changeButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(156, 277);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(103, 39);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(741, 333);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(135, 25);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.White;
            this.loadButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.loadButton.ForeColor = System.Drawing.Color.Black;
            this.loadButton.Location = new System.Drawing.Point(583, 333);
            this.loadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(135, 25);
            this.loadButton.TabIndex = 20;
            this.loadButton.Text = "load";
            this.loadButton.UseVisualStyleBackColor = false;
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(583, 301);
            this.fileNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(293, 22);
            this.fileNameTextBox.TabIndex = 19;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(583, 21);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(293, 276);
            this.listBox1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(411, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 41);
            this.label1.TabIndex = 17;
            this.label1.Text = "ANket";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(900, 370);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.BirthdayPicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private TextBox nameTextBox;
        private TextBox surnameTextBox;
        private Label label3;
        private TextBox emailTextBox;
        private Label label4;
        private TextBox phoneTextBox;
        private Label label5;
        private Label label6;
        private DateTimePicker BirthdayPicker;
        private Button changeButton;
        private Button addButton;
        private Button saveButton;
        private Button loadButton;
        private TextBox fileNameTextBox;
        private ListBox listBox1;
        private Label label1;
    }
}

