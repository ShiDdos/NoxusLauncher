namespace NoxusLauncher
{
    partial class LoginScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.btn_girisyap = new Guna.UI2.WinForms.Guna2Button();
            this.kullaniciadi = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.telif = new System.Windows.Forms.Label();
            this.sifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btn_girisyap
            // 
            this.btn_girisyap.AutoRoundedCorners = true;
            this.btn_girisyap.BackColor = System.Drawing.Color.Transparent;
            this.btn_girisyap.BorderRadius = 24;
            this.btn_girisyap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_girisyap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_girisyap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_girisyap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_girisyap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(45)))), ((int)(((byte)(52)))));
            this.btn_girisyap.Font = new System.Drawing.Font("Lilita One", 14.25F);
            this.btn_girisyap.ForeColor = System.Drawing.Color.White;
            this.btn_girisyap.Location = new System.Drawing.Point(476, 456);
            this.btn_girisyap.Name = "btn_girisyap";
            this.btn_girisyap.Size = new System.Drawing.Size(298, 50);
            this.btn_girisyap.TabIndex = 0;
            this.btn_girisyap.Text = "Giris Yap";
            this.btn_girisyap.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.AutoRoundedCorners = true;
            this.kullaniciadi.BackColor = System.Drawing.Color.Transparent;
            this.kullaniciadi.BorderColor = System.Drawing.Color.Black;
            this.kullaniciadi.BorderRadius = 23;
            this.kullaniciadi.BorderThickness = 2;
            this.kullaniciadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kullaniciadi.DefaultText = "";
            this.kullaniciadi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.kullaniciadi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.kullaniciadi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kullaniciadi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kullaniciadi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kullaniciadi.Font = new System.Drawing.Font("Lilita One", 14.25F);
            this.kullaniciadi.ForeColor = System.Drawing.Color.Black;
            this.kullaniciadi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kullaniciadi.IconLeft = ((System.Drawing.Image)(resources.GetObject("kullaniciadi.IconLeft")));
            this.kullaniciadi.IconLeftSize = new System.Drawing.Size(30, 30);
            this.kullaniciadi.IconRightSize = new System.Drawing.Size(40, 20);
            this.kullaniciadi.Location = new System.Drawing.Point(476, 314);
            this.kullaniciadi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kullaniciadi.MaxLength = 16;
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.PasswordChar = '\0';
            this.kullaniciadi.PlaceholderForeColor = System.Drawing.Color.Black;
            this.kullaniciadi.PlaceholderText = "Kullanıcı Adı";
            this.kullaniciadi.SelectedText = "";
            this.kullaniciadi.Size = new System.Drawing.Size(298, 49);
            this.kullaniciadi.TabIndex = 1;
            this.kullaniciadi.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // telif
            // 
            this.telif.AutoSize = true;
            this.telif.BackColor = System.Drawing.Color.Transparent;
            this.telif.Font = new System.Drawing.Font("Lilita One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telif.Location = new System.Drawing.Point(1111, 727);
            this.telif.Name = "telif";
            this.telif.Size = new System.Drawing.Size(127, 14);
            this.telif.TabIndex = 2;
            this.telif.Text = "© 2023 Noxus Launcher";
            // 
            // sifre
            // 
            this.sifre.AutoRoundedCorners = true;
            this.sifre.BackColor = System.Drawing.Color.Transparent;
            this.sifre.BorderColor = System.Drawing.Color.Black;
            this.sifre.BorderRadius = 23;
            this.sifre.BorderThickness = 2;
            this.sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sifre.DefaultText = "";
            this.sifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sifre.Font = new System.Drawing.Font("Lilita One", 14.25F);
            this.sifre.ForeColor = System.Drawing.Color.Black;
            this.sifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sifre.IconLeft = ((System.Drawing.Image)(resources.GetObject("sifre.IconLeft")));
            this.sifre.IconLeftSize = new System.Drawing.Size(30, 30);
            this.sifre.IconRightSize = new System.Drawing.Size(40, 20);
            this.sifre.Location = new System.Drawing.Point(476, 384);
            this.sifre.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.sifre.MaxLength = 27;
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '*';
            this.sifre.PlaceholderForeColor = System.Drawing.Color.Black;
            this.sifre.PlaceholderText = "Sifre";
            this.sifre.SelectedText = "";
            this.sifre.Size = new System.Drawing.Size(298, 49);
            this.sifre.TabIndex = 3;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Lilita One", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1221, -1);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(30, 30);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "X";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_2);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Black;
            this.guna2Button2.Font = new System.Drawing.Font("Lilita One", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(1185, -1);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(30, 30);
            this.guna2Button2.TabIndex = 12;
            this.guna2Button2.Text = "_";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1250, 750);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.telif);
            this.Controls.Add(this.kullaniciadi);
            this.Controls.Add(this.btn_girisyap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_girisyap;
        private Guna.UI2.WinForms.Guna2TextBox kullaniciadi;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox sifre;
        private System.Windows.Forms.Label telif;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}