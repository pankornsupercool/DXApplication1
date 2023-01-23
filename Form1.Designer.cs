namespace DXApplication1
{
    partial class Form1
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
            this._radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this._textBox2 = new DevExpress.XtraEditors.TextEdit();
            this._labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this._lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this._textBox3 = new DevExpress.XtraEditors.TextEdit();
            this._lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this._simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this._listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this._radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._textBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._textBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._listBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // _radioGroup1
            // 
            this._radioGroup1.Location = new System.Drawing.Point(12, 73);
            this._radioGroup1.Name = "_radioGroup1";
            this._radioGroup1.Properties.Columns = 2;
            this._radioGroup1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this._radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem('N', "No specific", true, "No specific"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem('0', "Today", true, "Today"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem('2', "Spot", true, "Spot"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem('1', "Tomorrow", true, "Tomorrow")});
            this._radioGroup1.Size = new System.Drawing.Size(608, 193);
            this._radioGroup1.TabIndex = 0;
            this._radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // _textBox2
            // 
            this._textBox2.Location = new System.Drawing.Point(81, 47);
            this._textBox2.Name = "_textBox2";
            this._textBox2.Size = new System.Drawing.Size(153, 20);
            this._textBox2.TabIndex = 1;
            // 
            // _labelControl1
            // 
            this._labelControl1.Location = new System.Drawing.Point(27, 50);
            this._labelControl1.Name = "_labelControl1";
            this._labelControl1.Size = new System.Drawing.Size(31, 13);
            this._labelControl1.TabIndex = 2;
            this._labelControl1.Text = "Range";
            // 
            // _lookUpEdit1
            // 
            this._lookUpEdit1.Location = new System.Drawing.Point(240, 47);
            this._lookUpEdit1.Name = "_lookUpEdit1";
            this._lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._lookUpEdit1.Size = new System.Drawing.Size(108, 20);
            this._lookUpEdit1.TabIndex = 3;
            // 
            // _textBox3
            // 
            this._textBox3.Location = new System.Drawing.Point(354, 47);
            this._textBox3.Name = "_textBox3";
            this._textBox3.Size = new System.Drawing.Size(153, 20);
            this._textBox3.TabIndex = 4;
            // 
            // _lookUpEdit2
            // 
            this._lookUpEdit2.Location = new System.Drawing.Point(513, 47);
            this._lookUpEdit2.Name = "_lookUpEdit2";
            this._lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._lookUpEdit2.Size = new System.Drawing.Size(108, 20);
            this._lookUpEdit2.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Ticket";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(81, 21);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(426, 20);
            this.textEdit3.TabIndex = 7;
            // 
            // _simpleButton1
            // 
            this._simpleButton1.Location = new System.Drawing.Point(513, 20);
            this._simpleButton1.Name = "_simpleButton1";
            this._simpleButton1.Size = new System.Drawing.Size(107, 21);
            this._simpleButton1.TabIndex = 8;
            this._simpleButton1.Text = "Save";
            // 
            // _listBoxControl1
            // 
            this._listBoxControl1.Location = new System.Drawing.Point(645, 73);
            this._listBoxControl1.Name = "_listBoxControl1";
            this._listBoxControl1.Size = new System.Drawing.Size(502, 193);
            this._listBoxControl1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 273);
            this.Controls.Add(this._listBoxControl1);
            this.Controls.Add(this._simpleButton1);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this._lookUpEdit2);
            this.Controls.Add(this._textBox3);
            this.Controls.Add(this._lookUpEdit1);
            this.Controls.Add(this._labelControl1);
            this.Controls.Add(this._textBox2);
            this.Controls.Add(this._radioGroup1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._textBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._textBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._listBoxControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup _radioGroup1;
        private DevExpress.XtraEditors.TextEdit _textBox2;
        private DevExpress.XtraEditors.LabelControl _labelControl1;
        private DevExpress.XtraEditors.LookUpEdit _lookUpEdit1;
        private DevExpress.XtraEditors.TextEdit _textBox3;
        private DevExpress.XtraEditors.LookUpEdit _lookUpEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.SimpleButton _simpleButton1;
        private DevExpress.XtraEditors.ListBoxControl _listBoxControl1;
    }
}

