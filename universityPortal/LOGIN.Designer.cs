
namespace universityPortal
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rolecombo = new System.Windows.Forms.ComboBox();
            this.btntxt = new System.Windows.Forms.Button();
            this.usertxt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-26, -28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(25)))), ((int)(((byte)(145)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(130, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "UNIVERSITY OF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(25)))), ((int)(((byte)(145)))));
            this.label2.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(95, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "MANCHESTER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(25)))), ((int)(((byte)(145)))));
            this.label3.Location = new System.Drawing.Point(56, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "USERNAME";
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(162, 363);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(162, 20);
            this.passtxt.TabIndex = 3;
            this.passtxt.TextChanged += new System.EventHandler(this.passtxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(25)))), ((int)(((byte)(145)))));
            this.label4.Location = new System.Drawing.Point(56, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "PASSWORD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(25)))), ((int)(((byte)(145)))));
            this.label5.Location = new System.Drawing.Point(53, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "SELECT TYPE";
            // 
            // rolecombo
            // 
            this.rolecombo.FormattingEnabled = true;
            this.rolecombo.Items.AddRange(new object[] {
            "ADMIN",
            "ADMISSION",
            "FEES"});
            this.rolecombo.Location = new System.Drawing.Point(162, 292);
            this.rolecombo.Name = "rolecombo";
            this.rolecombo.Size = new System.Drawing.Size(162, 21);
            this.rolecombo.TabIndex = 0;
            this.rolecombo.SelectedIndexChanged += new System.EventHandler(this.rolecombo_SelectedIndexChanged);
            this.rolecombo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rolecombo_MouseClick);
            // 
            // btntxt
            // 
            this.btntxt.Location = new System.Drawing.Point(162, 420);
            this.btntxt.Name = "btntxt";
            this.btntxt.Size = new System.Drawing.Size(85, 31);
            this.btntxt.TabIndex = 9;
            this.btntxt.Text = "LOGIN";
            this.btntxt.UseVisualStyleBackColor = true;
            this.btntxt.Click += new System.EventHandler(this.button1_Click);
            // 
            // usertxt
            // 
            this.usertxt.FormattingEnabled = true;
            this.usertxt.Location = new System.Drawing.Point(162, 328);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(162, 21);
            this.usertxt.TabIndex = 1;
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 505);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.btntxt);
            this.Controls.Add(this.rolecombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LOGIN";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox rolecombo;
        private System.Windows.Forms.Button btntxt;
        private System.Windows.Forms.ComboBox usertxt;
    }
}