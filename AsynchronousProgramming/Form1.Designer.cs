namespace AsynchronousProgramming
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
            lblBook1 = new Label();
            lblBook2 = new Label();
            txtBook1 = new TextBox();
            txtBook2 = new TextBox();
            btnBrowse1 = new Button();
            btnBrowse2 = new Button();
            btnSubmit = new Button();
            btnExit = new Button();
            lstBox1 = new ListBox();
            lstBox2 = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            SuspendLayout();
            // 
            // lblBook1
            // 
            lblBook1.AutoSize = true;
            lblBook1.Location = new Point(35, 24);
            lblBook1.Name = "lblBook1";
            lblBook1.Size = new Size(93, 32);
            lblBook1.TabIndex = 0;
            lblBook1.Text = "Book 1:";
            // 
            // lblBook2
            // 
            lblBook2.AutoSize = true;
            lblBook2.Location = new Point(621, 24);
            lblBook2.Name = "lblBook2";
            lblBook2.Size = new Size(93, 32);
            lblBook2.TabIndex = 1;
            lblBook2.Text = "Book 2:";
            // 
            // txtBook1
            // 
            txtBook1.Location = new Point(137, 17);
            txtBook1.Name = "txtBook1";
            txtBook1.Size = new Size(256, 39);
            txtBook1.TabIndex = 2;
            // 
            // txtBook2
            // 
            txtBook2.Location = new Point(729, 16);
            txtBook2.Name = "txtBook2";
            txtBook2.Size = new Size(249, 39);
            txtBook2.TabIndex = 3;
            // 
            // btnBrowse1
            // 
            btnBrowse1.Location = new Point(419, 13);
            btnBrowse1.Name = "btnBrowse1";
            btnBrowse1.Size = new Size(150, 46);
            btnBrowse1.TabIndex = 4;
            btnBrowse1.Text = "Browse";
            btnBrowse1.UseVisualStyleBackColor = true;
            btnBrowse1.Click += btnBrowse1_Click;
            // 
            // btnBrowse2
            // 
            btnBrowse2.Location = new Point(1005, 12);
            btnBrowse2.Name = "btnBrowse2";
            btnBrowse2.Size = new Size(150, 46);
            btnBrowse2.TabIndex = 5;
            btnBrowse2.Text = "Browse";
            btnBrowse2.UseVisualStyleBackColor = true;
            btnBrowse2.Click += btnBrowse2_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(419, 96);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 46);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(621, 96);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 46);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lstBox1
            // 
            lstBox1.FormattingEnabled = true;
            lstBox1.Location = new Point(35, 158);
            lstBox1.Name = "lstBox1";
            lstBox1.Size = new Size(534, 644);
            lstBox1.TabIndex = 8;
            // 
            // lstBox2
            // 
            lstBox2.FormattingEnabled = true;
            lstBox2.Location = new Point(621, 158);
            lstBox2.Name = "lstBox2";
            lstBox2.Size = new Size(552, 644);
            lstBox2.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 832);
            Controls.Add(lstBox2);
            Controls.Add(lstBox1);
            Controls.Add(btnExit);
            Controls.Add(btnSubmit);
            Controls.Add(btnBrowse2);
            Controls.Add(btnBrowse1);
            Controls.Add(txtBook2);
            Controls.Add(txtBook1);
            Controls.Add(lblBook2);
            Controls.Add(lblBook1);
            Name = "Form1";
            Text = "Dado Koundoul's Book Selection Tool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBook1;
        private Label lblBook2;
        private TextBox txtBook1;
        private TextBox txtBook2;
        private Button btnBrowse1;
        private Button btnBrowse2;
        private Button btnSubmit;
        private Button btnExit;
        private ListBox lstBox1;
        private ListBox lstBox2;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
    }
}
