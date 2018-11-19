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
            this.startCommandBtn = new DevExpress.XtraEditors.SimpleButton();
            this.messageEdit = new DevExpress.XtraEditors.MemoEdit();
            this.commandTypeEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.commandControlEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idPlcEdit = new DevExpress.XtraEditors.TextEdit();
            this.idDbEdit = new DevExpress.XtraEditors.TextEdit();
            this.textMessageEdit = new DevExpress.XtraEditors.TextEdit();
            this.disconnectServerBtn = new DevExpress.XtraEditors.SimpleButton();
            this.checkControlEdit = new DevExpress.XtraEditors.CheckEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.namePlcEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameDbEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.serverIpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandTypeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandControlEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idPlcEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idDbEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMessageEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkControlEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namePlcEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameDbEdit.Properties)).BeginInit();
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
            this.connectServerBtn.Location = new System.Drawing.Point(458, 10);
            this.connectServerBtn.Name = "connectServerBtn";
            this.connectServerBtn.Size = new System.Drawing.Size(104, 23);
            this.connectServerBtn.TabIndex = 2;
            this.connectServerBtn.Text = "Подключиться";
            this.connectServerBtn.Click += new System.EventHandler(this.connectServerBtn_Click);
            // 
            // startCommandBtn
            // 
            this.startCommandBtn.Location = new System.Drawing.Point(458, 68);
            this.startCommandBtn.Name = "startCommandBtn";
            this.startCommandBtn.Size = new System.Drawing.Size(207, 102);
            this.startCommandBtn.TabIndex = 5;
            this.startCommandBtn.Text = "Выполнить ";
            this.startCommandBtn.Click += new System.EventHandler(this.startCommandBtn_Click);
            // 
            // messageEdit
            // 
            this.messageEdit.Location = new System.Drawing.Point(15, 176);
            this.messageEdit.Name = "messageEdit";
            this.messageEdit.Size = new System.Drawing.Size(653, 292);
            this.messageEdit.TabIndex = 6;
            // 
            // commandTypeEdit
            // 
            this.commandTypeEdit.Location = new System.Drawing.Point(12, 40);
            this.commandTypeEdit.Name = "commandTypeEdit";
            this.commandTypeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.commandTypeEdit.Size = new System.Drawing.Size(440, 22);
            this.commandTypeEdit.TabIndex = 4;
            this.commandTypeEdit.EditValueChanged += new System.EventHandler(this.commandEdit_EditValueChanged);
            // 
            // commandControlEdit
            // 
            this.commandControlEdit.Location = new System.Drawing.Point(12, 68);
            this.commandControlEdit.Name = "commandControlEdit";
            this.commandControlEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.commandControlEdit.Size = new System.Drawing.Size(440, 22);
            this.commandControlEdit.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id PLC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Id DB:";
            // 
            // idPlcEdit
            // 
            this.idPlcEdit.Location = new System.Drawing.Point(104, 94);
            this.idPlcEdit.Name = "idPlcEdit";
            this.idPlcEdit.Size = new System.Drawing.Size(107, 22);
            this.idPlcEdit.TabIndex = 10;
            // 
            // idDbEdit
            // 
            this.idDbEdit.Location = new System.Drawing.Point(280, 94);
            this.idDbEdit.Name = "idDbEdit";
            this.idDbEdit.Size = new System.Drawing.Size(172, 22);
            this.idDbEdit.TabIndex = 11;
            // 
            // textMessageEdit
            // 
            this.textMessageEdit.Location = new System.Drawing.Point(15, 148);
            this.textMessageEdit.Name = "textMessageEdit";
            this.textMessageEdit.Size = new System.Drawing.Size(437, 22);
            this.textMessageEdit.TabIndex = 12;
            // 
            // disconnectServerBtn
            // 
            this.disconnectServerBtn.Location = new System.Drawing.Point(568, 10);
            this.disconnectServerBtn.Name = "disconnectServerBtn";
            this.disconnectServerBtn.Size = new System.Drawing.Size(97, 23);
            this.disconnectServerBtn.TabIndex = 13;
            this.disconnectServerBtn.Text = "Отключиться";
            this.disconnectServerBtn.Click += new System.EventHandler(this.disconnectServerBtn_Click);
            // 
            // checkControlEdit
            // 
            this.checkControlEdit.Location = new System.Drawing.Point(458, 42);
            this.checkControlEdit.Name = "checkControlEdit";
            this.checkControlEdit.Properties.Caption = "Использовать проверку";
            this.checkControlEdit.Size = new System.Drawing.Size(207, 20);
            this.checkControlEdit.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Имя PLC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Имя DB:";
            // 
            // namePlcEdit
            // 
            this.namePlcEdit.Location = new System.Drawing.Point(104, 122);
            this.namePlcEdit.Name = "namePlcEdit";
            this.namePlcEdit.Size = new System.Drawing.Size(107, 22);
            this.namePlcEdit.TabIndex = 17;
            // 
            // nameDbEdit
            // 
            this.nameDbEdit.Location = new System.Drawing.Point(280, 120);
            this.nameDbEdit.Name = "nameDbEdit";
            this.nameDbEdit.Size = new System.Drawing.Size(172, 22);
            this.nameDbEdit.TabIndex = 18;
            // 
            // MainFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 480);
            this.Controls.Add(this.nameDbEdit);
            this.Controls.Add(this.namePlcEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkControlEdit);
            this.Controls.Add(this.disconnectServerBtn);
            this.Controls.Add(this.textMessageEdit);
            this.Controls.Add(this.idDbEdit);
            this.Controls.Add(this.idPlcEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commandControlEdit);
            this.Controls.Add(this.messageEdit);
            this.Controls.Add(this.startCommandBtn);
            this.Controls.Add(this.commandTypeEdit);
            this.Controls.Add(this.connectServerBtn);
            this.Controls.Add(this.serverIpEdit);
            this.Name = "MainFm";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.serverIpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandTypeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandControlEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idPlcEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idDbEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMessageEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkControlEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namePlcEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameDbEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit serverIpEdit;
        private DevExpress.XtraEditors.SimpleButton connectServerBtn;
        private DevExpress.XtraEditors.SimpleButton startCommandBtn;
        private DevExpress.XtraEditors.MemoEdit messageEdit;
        private DevExpress.XtraEditors.LookUpEdit commandTypeEdit;
        private DevExpress.XtraEditors.LookUpEdit commandControlEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit idPlcEdit;
        private DevExpress.XtraEditors.TextEdit idDbEdit;
        private DevExpress.XtraEditors.TextEdit textMessageEdit;
        private DevExpress.XtraEditors.SimpleButton disconnectServerBtn;
        private DevExpress.XtraEditors.CheckEdit checkControlEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit namePlcEdit;
        private DevExpress.XtraEditors.TextEdit nameDbEdit;
    }
}