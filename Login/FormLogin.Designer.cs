﻿namespace Login
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.TableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.VerificacionUsuarioCont = new System.Windows.Forms.ErrorProvider(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblErrorUserPass = new System.Windows.Forms.Label();
            this.LblIcoError = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblInicioSesion = new System.Windows.Forms.Label();
            this.TxtUsuario = new Controles.NSTextBox();
            this.BtnIniciar = new Controles.NSButton();
            this.TxtPassword = new Controles.NSTextBox();
            this.RBtnRecordarUsuario = new Controles.NSRadioButton();
            this.TableLayoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerificacionUsuarioCont)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutMain
            // 
            this.TableLayoutMain.ColumnCount = 2;
            this.TableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TableLayoutMain.Controls.Add(this.PicBox, 0, 0);
            this.TableLayoutMain.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.TableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutMain.Margin = new System.Windows.Forms.Padding(4);
            this.TableLayoutMain.Name = "TableLayoutMain";
            this.TableLayoutMain.RowCount = 1;
            this.TableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutMain.Size = new System.Drawing.Size(780, 457);
            this.TableLayoutMain.TabIndex = 0;
            // 
            // PicBox
            // 
            this.PicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicBox.Image = global::Login.Properties.Resources.Santa_Giulia_Logo;
            this.PicBox.Location = new System.Drawing.Point(14, 143);
            this.PicBox.Margin = new System.Windows.Forms.Padding(4);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(205, 170);
            this.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox.TabIndex = 0;
            this.PicBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblInicioSesion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblUsuario, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtUsuario, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnIniciar, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.TxtPassword, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.LblPassword, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.RBtnRecordarUsuario, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(252, 19);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(18, 19, 18, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(510, 419);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LblUsuario
            // 
            this.LblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(120, 57);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(120, 8, 8, 4);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(92, 23);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblPassword
            // 
            this.LblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(120, 187);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(120, 8, 8, 4);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(133, 23);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Contraseña";
            // 
            // VerificacionUsuarioCont
            // 
            this.VerificacionUsuarioCont.ContainerControl = this;
            this.VerificacionUsuarioCont.Icon = ((System.Drawing.Icon)(resources.GetObject("VerificacionUsuarioCont.Icon")));
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.LblIcoError);
            this.flowLayoutPanel1.Controls.Add(this.LblErrorUserPass);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 341);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(504, 100);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // LblErrorUserPass
            // 
            this.LblErrorUserPass.AutoSize = true;
            this.LblErrorUserPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblErrorUserPass.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorUserPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.LblErrorUserPass.Location = new System.Drawing.Point(107, 8);
            this.LblErrorUserPass.Margin = new System.Windows.Forms.Padding(8);
            this.LblErrorUserPass.Name = "LblErrorUserPass";
            this.LblErrorUserPass.Size = new System.Drawing.Size(330, 23);
            this.LblErrorUserPass.TabIndex = 6;
            this.LblErrorUserPass.Text = "Usuario o Contraseña Incorrectas";
            this.LblErrorUserPass.Visible = false;
            // 
            // LblIcoError
            // 
            this.LblIcoError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblIcoError.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIcoError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.LblIcoError.ImageIndex = 1;
            this.LblIcoError.ImageList = this.imageList1;
            this.LblIcoError.Location = new System.Drawing.Point(64, 0);
            this.LblIcoError.Margin = new System.Windows.Forms.Padding(64, 0, 3, 0);
            this.LblIcoError.Name = "LblIcoError";
            this.LblIcoError.Size = new System.Drawing.Size(32, 39);
            this.LblIcoError.TabIndex = 7;
            this.LblIcoError.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "check32");
            this.imageList1.Images.SetKeyName(1, "cross32");
            this.imageList1.Images.SetKeyName(2, "info32");
            this.imageList1.Images.SetKeyName(3, "question32");
            this.imageList1.Images.SetKeyName(4, "warning32");
            // 
            // lblInicioSesion
            // 
            this.lblInicioSesion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInicioSesion.AutoSize = true;
            this.lblInicioSesion.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioSesion.Location = new System.Drawing.Point(156, 8);
            this.lblInicioSesion.Margin = new System.Windows.Forms.Padding(8, 8, 8, 16);
            this.lblInicioSesion.Name = "lblInicioSesion";
            this.lblInicioSesion.Size = new System.Drawing.Size(198, 25);
            this.lblInicioSesion.TabIndex = 6;
            this.lblInicioSesion.Text = "Inicio de Sesion";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.TxtUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TxtUsuario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.TxtUsuario.BorderSize = 2;
            this.TxtUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtUsuario.Location = new System.Drawing.Point(118, 92);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(8, 8, 8, 4);
            this.TxtUsuario.Multiline = false;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Padding = new System.Windows.Forms.Padding(8);
            this.TxtUsuario.PasswordChar = false;
            this.TxtUsuario.Size = new System.Drawing.Size(273, 36);
            this.TxtUsuario.TabIndex = 1;
            this.TxtUsuario.UnderLinesStyle = false;
            this.TxtUsuario._TextChanged += new System.EventHandler(this.TxtUsuario__TextChanged);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.BtnIniciar.BackGroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.BtnIniciar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.BtnIniciar.BorderRadius = 12;
            this.BtnIniciar.BorderSize = 2;
            this.BtnIniciar.Enabled = false;
            this.BtnIniciar.FlatAppearance.BorderSize = 0;
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.ForeColor = System.Drawing.Color.White;
            this.BtnIniciar.Location = new System.Drawing.Point(142, 282);
            this.BtnIniciar.Margin = new System.Windows.Forms.Padding(8);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(225, 48);
            this.BtnIniciar.TabIndex = 4;
            this.BtnIniciar.Text = "Iniciar Sesion";
            this.BtnIniciar.TextColor = System.Drawing.Color.White;
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.EnabledChanged += new System.EventHandler(this.BtnIniciar_EnabledChanged);
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.TxtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.TxtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.TxtPassword.BorderSize = 2;
            this.TxtPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtPassword.Location = new System.Drawing.Point(118, 222);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(8, 8, 8, 16);
            this.TxtPassword.Multiline = false;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Padding = new System.Windows.Forms.Padding(8);
            this.TxtPassword.PasswordChar = true;
            this.TxtPassword.Size = new System.Drawing.Size(273, 36);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.UnderLinesStyle = false;
            this.TxtPassword._TextChanged += new System.EventHandler(this.TxtPassword__TextChanged);
            // 
            // RBtnRecordarUsuario
            // 
            this.RBtnRecordarUsuario.AutoSize = true;
            this.RBtnRecordarUsuario.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.RBtnRecordarUsuario.Location = new System.Drawing.Point(128, 140);
            this.RBtnRecordarUsuario.Margin = new System.Windows.Forms.Padding(128, 8, 8, 16);
            this.RBtnRecordarUsuario.MinimumSize = new System.Drawing.Size(0, 21);
            this.RBtnRecordarUsuario.Name = "RBtnRecordarUsuario";
            this.RBtnRecordarUsuario.Size = new System.Drawing.Size(161, 23);
            this.RBtnRecordarUsuario.TabIndex = 2;
            this.RBtnRecordarUsuario.TabStop = true;
            this.RBtnRecordarUsuario.Text = "Recordar Usuario";
            this.RBtnRecordarUsuario.UncheckedColor1 = System.Drawing.Color.DimGray;
            this.RBtnRecordarUsuario.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.Controls.Add(this.TableLayoutMain);
            this.Font = new System.Drawing.Font("SUSE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.Text = "NicoS92 Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TableLayoutMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerificacionUsuarioCont)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutMain;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblPassword;
        private Controles.NSTextBox TxtUsuario;
        private Controles.NSTextBox TxtPassword;
        private Controles.NSButton BtnIniciar;
        private Controles.NSRadioButton RBtnRecordarUsuario;
        private System.Windows.Forms.ErrorProvider VerificacionUsuarioCont;
        private System.Windows.Forms.Label lblInicioSesion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LblIcoError;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label LblErrorUserPass;
    }
}

