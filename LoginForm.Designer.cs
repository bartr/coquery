namespace coquery
{
    partial class frmLogin
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCollection = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.chkSaveLoginInfo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(8, 10);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(56, 18);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(108, 8);
            this.txtServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(420, 25);
            this.txtServer.TabIndex = 1;
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtKey.Location = new System.Drawing.Point(108, 39);
            this.txtKey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(420, 25);
            this.txtKey.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Key";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabase.Location = new System.Drawing.Point(108, 71);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(420, 25);
            this.txtDatabase.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Database";
            // 
            // txtCollection
            // 
            this.txtCollection.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtCollection.Location = new System.Drawing.Point(108, 101);
            this.txtCollection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCollection.Name = "txtCollection";
            this.txtCollection.Size = new System.Drawing.Size(420, 25);
            this.txtCollection.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Collection";
            // 
            // cmdLogin
            // 
            this.cmdLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdLogin.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.Location = new System.Drawing.Point(108, 177);
            this.cmdLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(100, 35);
            this.cmdLogin.TabIndex = 8;
            this.cmdLogin.Text = "Login";
            this.cmdLogin.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(427, 177);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(100, 35);
            this.cmdCancel.TabIndex = 9;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // chkSaveLoginInfo
            // 
            this.chkSaveLoginInfo.AutoSize = true;
            this.chkSaveLoginInfo.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSaveLoginInfo.Location = new System.Drawing.Point(108, 138);
            this.chkSaveLoginInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSaveLoginInfo.Name = "chkSaveLoginInfo";
            this.chkSaveLoginInfo.Size = new System.Drawing.Size(147, 22);
            this.chkSaveLoginInfo.TabIndex = 8;
            this.chkSaveLoginInfo.Text = "Save Login Info";
            this.chkSaveLoginInfo.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.cmdLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(546, 272);
            this.ControlBox = false;
            this.Controls.Add(this.chkSaveLoginInfo);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.txtCollection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmLogin_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.TextBox txtServer;
        public System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCollection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.CheckBox chkSaveLoginInfo;
    }
}