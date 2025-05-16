namespace pryGauna_Gestion
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLogIn = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.strConnectionStatus = new System.Windows.Forms.StatusStrip();
            this.tstrConnectioStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.strConnectionStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Location = new System.Drawing.Point(257, 44);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(35, 13);
            this.lblLogIn.TabIndex = 0;
            this.lblLogIn.Text = "label1";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(40, 103);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(457, 20);
            this.txtUser.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(39, 179);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(458, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(40, 163);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(35, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "label2";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(40, 84);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(35, 13);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "label3";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(422, 220);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "button1";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // strConnectionStatus
            // 
            this.strConnectionStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrConnectioStatus});
            this.strConnectionStatus.Location = new System.Drawing.Point(0, 273);
            this.strConnectionStatus.Name = "strConnectionStatus";
            this.strConnectionStatus.Size = new System.Drawing.Size(556, 22);
            this.strConnectionStatus.TabIndex = 6;
            this.strConnectionStatus.Text = "statusStrip1";
            // 
            // tstrConnectioStatus
            // 
            this.tstrConnectioStatus.Name = "tstrConnectioStatus";
            this.tstrConnectioStatus.Size = new System.Drawing.Size(118, 17);
            this.tstrConnectioStatus.Text = "toolStripStatusLabel1";
            this.tstrConnectioStatus.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(556, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 295);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.strConnectionStatus);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblLogIn);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.strConnectionStatus.ResumeLayout(false);
            this.strConnectionStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.StatusStrip strConnectionStatus;
        private System.Windows.Forms.ToolStripStatusLabel tstrConnectioStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

