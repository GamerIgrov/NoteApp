namespace NoteAppUI
{
    partial class FormAddEdit
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelCreated = new System.Windows.Forms.Label();
            this.LabelModified = new System.Windows.Forms.Label();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.TextBoxText = new System.Windows.Forms.TextBox();
            this.ComboBoxCategory = new System.Windows.Forms.ComboBox();
            this.DateTimePickerCreated = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.boxTitle = new System.Windows.Forms.GroupBox();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.boxTitle.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(38, 21);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(36, 16);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Title:";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(6, 48);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(68, 16);
            this.LabelCategory.TabIndex = 1;
            this.LabelCategory.Text = "Category: ";
            this.LabelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelCreated
            // 
            this.LabelCreated.AutoSize = true;
            this.LabelCreated.Location = new System.Drawing.Point(13, 80);
            this.LabelCreated.Name = "LabelCreated";
            this.LabelCreated.Size = new System.Drawing.Size(61, 16);
            this.LabelCreated.TabIndex = 2;
            this.LabelCreated.Text = "Created: ";
            this.LabelCreated.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelModified
            // 
            this.LabelModified.AutoSize = true;
            this.LabelModified.Location = new System.Drawing.Point(12, 109);
            this.LabelModified.Name = "LabelModified";
            this.LabelModified.Size = new System.Drawing.Size(62, 16);
            this.LabelModified.TabIndex = 3;
            this.LabelModified.Text = "Modified:";
            this.LabelModified.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Location = new System.Drawing.Point(93, 18);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(276, 22);
            this.TextBoxTitle.TabIndex = 4;
            this.TextBoxTitle.TextChanged += new System.EventHandler(this.TextBoxTitle_TextChanged);
            // 
            // TextBoxText
            // 
            this.TextBoxText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxText.Location = new System.Drawing.Point(0, 138);
            this.TextBoxText.Multiline = true;
            this.TextBoxText.Name = "TextBoxText";
            this.TextBoxText.Size = new System.Drawing.Size(800, 255);
            this.TextBoxText.TabIndex = 5;
            this.TextBoxText.TextChanged += new System.EventHandler(this.TextBoxText_TextChanged);
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.Location = new System.Drawing.Point(93, 45);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(276, 24);
            this.ComboBoxCategory.TabIndex = 6;
            this.ComboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategory_SelectedIndexChanged);
            // 
            // DateTimePickerCreated
            // 
            this.DateTimePickerCreated.Enabled = false;
            this.DateTimePickerCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerCreated.Location = new System.Drawing.Point(93, 75);
            this.DateTimePickerCreated.Name = "DateTimePickerCreated";
            this.DateTimePickerCreated.Size = new System.Drawing.Size(123, 22);
            this.DateTimePickerCreated.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(93, 103);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(123, 22);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // boxTitle
            // 
            this.boxTitle.Controls.Add(this.LabelTitle);
            this.boxTitle.Controls.Add(this.dateTimePicker2);
            this.boxTitle.Controls.Add(this.DateTimePickerCreated);
            this.boxTitle.Controls.Add(this.TextBoxTitle);
            this.boxTitle.Controls.Add(this.LabelModified);
            this.boxTitle.Controls.Add(this.LabelCategory);
            this.boxTitle.Controls.Add(this.ComboBoxCategory);
            this.boxTitle.Controls.Add(this.LabelCreated);
            this.boxTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxTitle.Location = new System.Drawing.Point(0, 0);
            this.boxTitle.Name = "boxTitle";
            this.boxTitle.Size = new System.Drawing.Size(800, 138);
            this.boxTitle.TabIndex = 9;
            this.boxTitle.TabStop = false;
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.ButtonOK);
            this.groupBoxButtons.Controls.Add(this.ButtonCancel);
            this.groupBoxButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxButtons.Location = new System.Drawing.Point(0, 393);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(800, 57);
            this.groupBoxButtons.TabIndex = 10;
            this.groupBoxButtons.TabStop = false;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonCancel.Location = new System.Drawing.Point(722, 18);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 36);
            this.ButtonCancel.TabIndex = 0;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonOK.Location = new System.Drawing.Point(647, 18);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 36);
            this.ButtonOK.TabIndex = 1;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // FormAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxText);
            this.Controls.Add(this.groupBoxButtons);
            this.Controls.Add(this.boxTitle);
            this.Name = "FormAddEdit";
            this.Text = "FormAddEdit";
            this.boxTitle.ResumeLayout(false);
            this.boxTitle.PerformLayout();
            this.groupBoxButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelCreated;
        private System.Windows.Forms.Label LabelModified;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.TextBox TextBoxText;
        private System.Windows.Forms.ComboBox ComboBoxCategory;
        private System.Windows.Forms.DateTimePicker DateTimePickerCreated;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox boxTitle;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
    }
}