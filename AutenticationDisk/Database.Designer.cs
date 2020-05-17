namespace AutenticationDisk
{
    partial class scheda_database
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
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Serie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.moduscita = new System.Windows.Forms.TextBox();
            this.modepv = new System.Windows.Forms.TextBox();
            this.modep = new System.Windows.Forms.TextBox();
            this.modnome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Episodi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Episodi_Visti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(25, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Elimina Serie";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ordina per nome (crescente)",
            "Ordina per nome (decrescente)",
            "Ordina per episodi (crescente)",
            "Ordina per episodi (decrescente)"});
            this.comboBox1.Location = new System.Drawing.Point(12, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(431, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 27);
            this.button3.TabIndex = 15;
            this.button3.Text = "Salva";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(65, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "ESCI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Serie,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(232, 7);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(596, 285);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // Serie
            // 
            this.Serie.Text = "Serie";
            this.Serie.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data di uscita";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Episodi";
            this.columnHeader3.Width = 113;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Visti";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Stato";
            this.columnHeader4.Width = 115;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(431, 326);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 44);
            this.button4.TabIndex = 18;
            this.button4.Text = "Aggiorna";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 371);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 20);
            this.textBox2.TabIndex = 20;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(25, 298);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 54);
            this.button5.TabIndex = 21;
            this.button5.Text = "Aggiungi Serie";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(211, 357);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(214, 50);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(206, 24);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HOME";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.tabPage2.Controls.Add(this.moduscita);
            this.tabPage2.Controls.Add(this.modepv);
            this.tabPage2.Controls.Add(this.modep);
            this.tabPage2.Controls.Add(this.modnome);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(594, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MODIFICA";
            // 
            // moduscita
            // 
            this.moduscita.Location = new System.Drawing.Point(455, 160);
            this.moduscita.Name = "moduscita";
            this.moduscita.Size = new System.Drawing.Size(113, 20);
            this.moduscita.TabIndex = 62;
            // 
            // modepv
            // 
            this.modepv.Location = new System.Drawing.Point(455, 132);
            this.modepv.Name = "modepv";
            this.modepv.Size = new System.Drawing.Size(113, 20);
            this.modepv.TabIndex = 61;
            // 
            // modep
            // 
            this.modep.Location = new System.Drawing.Point(455, 105);
            this.modep.Name = "modep";
            this.modep.Size = new System.Drawing.Size(113, 20);
            this.modep.TabIndex = 57;
            // 
            // modnome
            // 
            this.modnome.Location = new System.Drawing.Point(455, 79);
            this.modnome.Name = "modnome";
            this.modnome.Size = new System.Drawing.Size(113, 20);
            this.modnome.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(386, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Uscita";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(386, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 58;
            this.label13.Text = "Episodi Visti";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(386, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Episodi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(386, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 52;
            this.label16.Text = "Nome";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.Location = new System.Drawing.Point(363, 217);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(205, 42);
            this.button9.TabIndex = 51;
            this.button9.Text = "Modifica";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOME DELLA SERIE";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(119, 20);
            this.textBox3.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(141, 47);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 20);
            this.button6.TabIndex = 1;
            this.button6.Text = "CERCA";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Episodi,
            this.Episodi_Visti,
            this.columnHeader8});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(16, 75);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(332, 184);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 72;
            // 
            // Episodi
            // 
            this.Episodi.Text = "Episodi";
            // 
            // Episodi_Visti
            // 
            this.Episodi_Visti.Text = "Episodi Visti";
            this.Episodi_Visti.Width = 79;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Uscita";
            this.columnHeader8.Width = 113;
            // 
            // scheda_database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::AutenticationDisk.Properties.Resources.Gli_architetti_Conti_e_Monti_Lobiettivo_di_questanno_A_cosa_stiamo_lavorando_I_nostri_servizi_Le_nos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 407);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "scheda_database";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.Database_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Serie;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TextBox moduscita;
        private System.Windows.Forms.TextBox modepv;
        private System.Windows.Forms.TextBox modep;
        private System.Windows.Forms.TextBox modnome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Episodi;
        private System.Windows.Forms.ColumnHeader Episodi_Visti;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}