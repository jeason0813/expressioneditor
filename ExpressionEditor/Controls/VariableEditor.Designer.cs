// <auto-generated/>

namespace Konesans.Dts.ExpressionEditor.Controls
{
    partial class VariableEditor
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
                if (variable != null) variable.Dispose();

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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.comboBoxValue = new System.Windows.Forms.ComboBox();
            this.numericUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerValue = new System.Windows.Forms.DateTimePicker();
            this.labelNamespace = new System.Windows.Forms.Label();
            this.textBoxNamespace = new System.Windows.Forms.TextBox();
            this.line3D1 = new Konesans.Dts.ExpressionEditor.Controls.Line3D();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(319, 223);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(211, 224);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 30);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 17);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(112, 26);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(304, 22);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextKeyDown);
            // 
            // labelType
            // 
            this.labelType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(17, 116);
            this.labelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(44, 17);
            this.labelType.TabIndex = 7;
            this.labelType.Text = "Type:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(113, 114);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(304, 24);
            this.comboBoxType.TabIndex = 3;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxType_SelectedIndexChanged);
            // 
            // textBoxValue
            // 
            this.textBoxValue.AcceptsReturn = true;
            this.textBoxValue.AcceptsTab = true;
            this.textBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxValue.Location = new System.Drawing.Point(113, 159);
            this.textBoxValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxValue.Multiline = true;
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxValue.Size = new System.Drawing.Size(304, 20);
            this.textBoxValue.TabIndex = 4;
            this.textBoxValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextKeyDown);
            // 
            // labelValue
            // 
            this.labelValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(17, 160);
            this.labelValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(48, 17);
            this.labelValue.TabIndex = 10;
            this.labelValue.Text = "Value:";
            // 
            // comboBoxValue
            // 
            this.comboBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxValue.FormattingEnabled = true;
            this.comboBoxValue.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboBoxValue.Location = new System.Drawing.Point(113, 159);
            this.comboBoxValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxValue.Name = "comboBoxValue";
            this.comboBoxValue.Size = new System.Drawing.Size(304, 24);
            this.comboBoxValue.TabIndex = 12;
            // 
            // numericUpDownValue
            // 
            this.numericUpDownValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownValue.Location = new System.Drawing.Point(113, 159);
            this.numericUpDownValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownValue.Name = "numericUpDownValue";
            this.numericUpDownValue.Size = new System.Drawing.Size(304, 22);
            this.numericUpDownValue.TabIndex = 4;
            // 
            // dateTimePickerValue
            // 
            this.dateTimePickerValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerValue.CustomFormat = "dd MMM yyyy HH:mm:ss";
            this.dateTimePickerValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerValue.Location = new System.Drawing.Point(113, 159);
            this.dateTimePickerValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerValue.Name = "dateTimePickerValue";
            this.dateTimePickerValue.Size = new System.Drawing.Size(304, 22);
            this.dateTimePickerValue.TabIndex = 4;
            this.dateTimePickerValue.Value = new System.DateTime(2005, 12, 11, 0, 10, 0, 0);
            // 
            // labelNamespace
            // 
            this.labelNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNamespace.AutoSize = true;
            this.labelNamespace.Location = new System.Drawing.Point(17, 74);
            this.labelNamespace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNamespace.Name = "labelNamespace";
            this.labelNamespace.Size = new System.Drawing.Size(87, 17);
            this.labelNamespace.TabIndex = 16;
            this.labelNamespace.Text = "Namespace:";
            // 
            // textBoxNamespace
            // 
            this.textBoxNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNamespace.Location = new System.Drawing.Point(112, 70);
            this.textBoxNamespace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNamespace.Name = "textBoxNamespace";
            this.textBoxNamespace.Size = new System.Drawing.Size(304, 22);
            this.textBoxNamespace.TabIndex = 2;
            this.textBoxNamespace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextKeyDown);
            // 
            // line3D1
            // 
            this.line3D1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.line3D1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.line3D1.Location = new System.Drawing.Point(0, 206);
            this.line3D1.Margin = new System.Windows.Forms.Padding(4);
            this.line3D1.MaximumSize = new System.Drawing.Size(16533, 2);
            this.line3D1.MinimumSize = new System.Drawing.Size(363, 2);
            this.line3D1.Name = "line3D1";
            this.line3D1.Size = new System.Drawing.Size(445, 2);
            this.line3D1.TabIndex = 11;
            // 
            // VariableEditor
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(435, 276);
            this.Controls.Add(this.labelNamespace);
            this.Controls.Add(this.textBoxNamespace);
            this.Controls.Add(this.line3D1);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxValue);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.dateTimePickerValue);
            this.Controls.Add(this.numericUpDownValue);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(443, 302);
            this.Name = "VariableEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Variable Editor";
            this.Shown += new System.EventHandler(this.VariableEditor_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label labelValue;
        private Konesans.Dts.ExpressionEditor.Controls.Line3D line3D1;
        private System.Windows.Forms.ComboBox comboBoxValue;
        private System.Windows.Forms.NumericUpDown numericUpDownValue;
        private System.Windows.Forms.DateTimePicker dateTimePickerValue;
        private System.Windows.Forms.Label labelNamespace;
        private System.Windows.Forms.TextBox textBoxNamespace;
    }
}