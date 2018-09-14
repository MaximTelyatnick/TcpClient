namespace TcpClient
{
    partial class MainFm
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
            this.serverIpEdit = new DevExpress.XtraEditors.TextEdit();
            this.connectServerBtn = new DevExpress.XtraEditors.SimpleButton();
            this.commandEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.startCommandBtn = new DevExpress.XtraEditors.SimpleButton();
            this.messageEdit = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.serverIpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // serverIpEdit
            // 
            this.serverIpEdit.Location = new System.Drawing.Point(12, 12);
            this.serverIpEdit.Name = "serverIpEdit";
            this.serverIpEdit.Size = new System.Drawing.Size(440, 22);
            this.serverIpEdit.TabIndex = 1;
            this.serverIpEdit.EditValueChanged += new System.EventHandler(this.serverIpEdit_EditValueChanged);
            // 
            // connectServerBtn
            // 
            this.connectServerBtn.Location = new System.Drawing.Point(458, 11);
            this.connectServerBtn.Name = "connectServerBtn";
            this.connectServerBtn.Size = new System.Drawing.Size(207, 23);
            this.connectServerBtn.TabIndex = 2;
            this.connectServerBtn.Text = "Подключиться";
            this.connectServerBtn.Click += new System.EventHandler(this.connectServerBtn_Click);
            // 
            // commandEdit
            // 
            this.commandEdit.Location = new System.Drawing.Point(12, 40);
            this.commandEdit.Name = "commandEdit";
            this.commandEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.commandEdit.Size = new System.Drawing.Size(440, 22);
            this.commandEdit.TabIndex = 4;
            this.commandEdit.EditValueChanged += new System.EventHandler(this.commandEdit_EditValueChanged);
            // 
            // startCommandBtn
            // 
            this.startCommandBtn.Location = new System.Drawing.Point(458, 39);
            this.startCommandBtn.Name = "startCommandBtn";
            this.startCommandBtn.Size = new System.Drawing.Size(207, 23);
            this.startCommandBtn.TabIndex = 5;
            this.startCommandBtn.Text = "Выполнить ";
            this.startCommandBtn.Click += new System.EventHandler(this.startCommandBtn_Click);
            // 
            // messageEdit
            // 
            this.messageEdit.Location = new System.Drawing.Point(12, 68);
            this.messageEdit.Name = "messageEdit";
            this.messageEdit.Size = new System.Drawing.Size(653, 400);
            this.messageEdit.TabIndex = 6;
            // 
            // MainFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 480);
            this.Controls.Add(this.messageEdit);
            this.Controls.Add(this.startCommandBtn);
            this.Controls.Add(this.commandEdit);
            this.Controls.Add(this.connectServerBtn);
            this.Controls.Add(this.serverIpEdit);
            this.Name = "MainFm";
            this.Text = "MainFm";
            ((System.ComponentModel.ISupportInitialize)(this.serverIpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit serverIpEdit;
        private DevExpress.XtraEditors.SimpleButton connectServerBtn;
        private DevExpress.XtraEditors.LookUpEdit commandEdit;
        private DevExpress.XtraEditors.SimpleButton startCommandBtn;
        private DevExpress.XtraEditors.MemoEdit messageEdit;
    }
}