namespace callendar
{
    partial class cal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonreg = new System.Windows.Forms.Button();
            this.buttonlog = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonreg);
            this.panel1.Controls.Add(this.buttonlog);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.log);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(341, 409);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // buttonreg
            // 
            this.buttonreg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(184)))));
            this.buttonreg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonreg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(184)))));
            this.buttonreg.FlatAppearance.BorderSize = 0;
            this.buttonreg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonreg.Location = new System.Drawing.Point(121, 302);
            this.buttonreg.Name = "buttonreg";
            this.buttonreg.Size = new System.Drawing.Size(120, 25);
            this.buttonreg.TabIndex = 8;
            this.buttonreg.Text = "Зарегистрироваться";
            this.buttonreg.UseVisualStyleBackColor = false;
            // 
            // buttonlog
            // 
            this.buttonlog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(184)))));
            this.buttonlog.FlatAppearance.BorderSize = 0;
            this.buttonlog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonlog.Location = new System.Drawing.Point(132, 271);
            this.buttonlog.Name = "buttonlog";
            this.buttonlog.Size = new System.Drawing.Size(100, 25);
            this.buttonlog.TabIndex = 7;
            this.buttonlog.Text = "Авторизация";
            this.buttonlog.UseVisualStyleBackColor = false;
            this.buttonlog.Click += new System.EventHandler(this.buttonlog_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.Location = new System.Drawing.Point(323, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(15, 16);
            this.close.TabIndex = 6;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(133, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(133, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(137, 218);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(120, 20);
            this.pass.TabIndex = 3;
            this.pass.UseSystemPasswordChar = true;
            this.pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(137, 137);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(120, 25);
            this.log.TabIndex = 2;
            this.log.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::callendar.Properties.Resources.l;
            this.pictureBox2.Location = new System.Drawing.Point(60, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::callendar.Properties.Resources.p;
            this.pictureBox1.Location = new System.Drawing.Point(60, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 409);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cal";
            this.Text = "cal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonreg;
        private System.Windows.Forms.Button buttonlog;
    }
}