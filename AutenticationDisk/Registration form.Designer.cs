namespace AutenticationDisk
{
    partial class Form2
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
            this.BtnR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxUserR = new System.Windows.Forms.TextBox();
            this.BoxPassR = new System.Windows.Forms.TextBox();
            this.BoxPass2R = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnR
            // 
            this.BtnR.Location = new System.Drawing.Point(15, 139);
            this.BtnR.Name = "BtnR";
            this.BtnR.Size = new System.Drawing.Size(117, 27);
            this.BtnR.TabIndex = 0;
            this.BtnR.Text = "REGISTER";
            this.BtnR.UseVisualStyleBackColor = true;
            this.BtnR.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "REPEAT PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "PASSWORD";
            // 
            // BoxUserR
            // 
            this.BoxUserR.Location = new System.Drawing.Point(15, 35);
            this.BoxUserR.Name = "BoxUserR";
            this.BoxUserR.Size = new System.Drawing.Size(241, 20);
            this.BoxUserR.TabIndex = 5;
            // 
            // BoxPassR
            // 
            this.BoxPassR.Location = new System.Drawing.Point(15, 74);
            this.BoxPassR.Name = "BoxPassR";
            this.BoxPassR.Size = new System.Drawing.Size(241, 20);
            this.BoxPassR.TabIndex = 7;
            // 
            // BoxPass2R
            // 
            this.BoxPass2R.Location = new System.Drawing.Point(15, 113);
            this.BoxPass2R.Name = "BoxPass2R";
            this.BoxPass2R.Size = new System.Drawing.Size(241, 20);
            this.BoxPass2R.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "RETURN TO LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 205);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BoxPass2R);
            this.Controls.Add(this.BoxPassR);
            this.Controls.Add(this.BoxUserR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnR);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BoxUserR;
        private System.Windows.Forms.TextBox BoxPassR;
        private System.Windows.Forms.TextBox BoxPass2R;
        private System.Windows.Forms.Button button1;
    }
}