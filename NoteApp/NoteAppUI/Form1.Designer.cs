namespace NoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxChoosing = new System.Windows.Forms.GroupBox();
            this.ListBoxNotes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelCategoryChoose = new System.Windows.Forms.Label();
            this.ComboBoxCategory = new System.Windows.Forms.ComboBox();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.GroupBoxShow = new System.Windows.Forms.GroupBox();
            this.DateTimePickerModified = new System.Windows.Forms.DateTimePicker();
            this.LabelCategoryShow = new System.Windows.Forms.Label();
            this.LabelModified = new System.Windows.Forms.Label();
            this.LabelCreated = new System.Windows.Forms.Label();
            this.DateTimePickerCreated = new System.Windows.Forms.DateTimePicker();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TextBoxText = new System.Windows.Forms.TextBox();
            this.groupBoxText = new System.Windows.Forms.GroupBox();
            this.menuStripMain.SuspendLayout();
            this.GroupBoxChoosing.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            this.GroupBoxShow.SuspendLayout();
            this.groupBoxText.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNoteToolStripMenuItem.Image")));
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.addNoteToolStripMenuItem.Text = "Add note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editNoteToolStripMenuItem.Image")));
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.editNoteToolStripMenuItem.Text = "Edit note";
            // 
            // removeNoteToolStripMenuItem
            // 
            this.removeNoteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeNoteToolStripMenuItem.Image")));
            this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            this.removeNoteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.removeNoteToolStripMenuItem.Text = "Remove note";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abotToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // abotToolStripMenuItem
            // 
            this.abotToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abotToolStripMenuItem.Image")));
            this.abotToolStripMenuItem.Name = "abotToolStripMenuItem";
            this.abotToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.abotToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.abotToolStripMenuItem.Text = "Abot";
            // 
            // GroupBoxChoosing
            // 
            this.GroupBoxChoosing.Controls.Add(this.ListBoxNotes);
            this.GroupBoxChoosing.Controls.Add(this.groupBox1);
            this.GroupBoxChoosing.Controls.Add(this.groupBoxButtons);
            this.GroupBoxChoosing.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupBoxChoosing.Location = new System.Drawing.Point(0, 28);
            this.GroupBoxChoosing.Name = "GroupBoxChoosing";
            this.GroupBoxChoosing.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.GroupBoxChoosing.Size = new System.Drawing.Size(317, 422);
            this.GroupBoxChoosing.TabIndex = 1;
            this.GroupBoxChoosing.TabStop = false;
            // 
            // ListBoxNotes
            // 
            this.ListBoxNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxNotes.FormattingEnabled = true;
            this.ListBoxNotes.ItemHeight = 16;
            this.ListBoxNotes.Location = new System.Drawing.Point(6, 69);
            this.ListBoxNotes.Name = "ListBoxNotes";
            this.ListBoxNotes.Size = new System.Drawing.Size(305, 289);
            this.ListBoxNotes.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelCategoryChoose);
            this.groupBox1.Controls.Add(this.ComboBoxCategory);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(6, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 54);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // LabelCategoryChoose
            // 
            this.LabelCategoryChoose.AutoSize = true;
            this.LabelCategoryChoose.Location = new System.Drawing.Point(9, 23);
            this.LabelCategoryChoose.Name = "LabelCategoryChoose";
            this.LabelCategoryChoose.Size = new System.Drawing.Size(104, 16);
            this.LabelCategoryChoose.TabIndex = 0;
            this.LabelCategoryChoose.Text = "Show Category: ";
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.Location = new System.Drawing.Point(130, 20);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(166, 24);
            this.ComboBoxCategory.TabIndex = 1;
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.ButtonAdd);
            this.groupBoxButtons.Controls.Add(this.ButtonRemove);
            this.groupBoxButtons.Controls.Add(this.ButtonEdit);
            this.groupBoxButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxButtons.Location = new System.Drawing.Point(6, 358);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(305, 64);
            this.groupBoxButtons.TabIndex = 6;
            this.groupBoxButtons.TabStop = false;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonAdd.BackgroundImage")));
            this.ButtonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonAdd.Location = new System.Drawing.Point(6, 21);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(30, 30);
            this.ButtonAdd.TabIndex = 3;
            this.ButtonAdd.UseVisualStyleBackColor = true;
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonRemove.BackgroundImage")));
            this.ButtonRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonRemove.Location = new System.Drawing.Point(78, 21);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(30, 30);
            this.ButtonRemove.TabIndex = 5;
            this.ButtonRemove.UseVisualStyleBackColor = true;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEdit.BackgroundImage")));
            this.ButtonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonEdit.Location = new System.Drawing.Point(42, 21);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(30, 30);
            this.ButtonEdit.TabIndex = 4;
            this.ButtonEdit.UseVisualStyleBackColor = true;
            // 
            // GroupBoxShow
            // 
            this.GroupBoxShow.Controls.Add(this.DateTimePickerModified);
            this.GroupBoxShow.Controls.Add(this.LabelCategoryShow);
            this.GroupBoxShow.Controls.Add(this.LabelModified);
            this.GroupBoxShow.Controls.Add(this.LabelCreated);
            this.GroupBoxShow.Controls.Add(this.DateTimePickerCreated);
            this.GroupBoxShow.Controls.Add(this.LabelTitle);
            this.GroupBoxShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxShow.Location = new System.Drawing.Point(317, 28);
            this.GroupBoxShow.Name = "GroupBoxShow";
            this.GroupBoxShow.Size = new System.Drawing.Size(483, 114);
            this.GroupBoxShow.TabIndex = 2;
            this.GroupBoxShow.TabStop = false;
            // 
            // DateTimePickerModified
            // 
            this.DateTimePickerModified.Enabled = false;
            this.DateTimePickerModified.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerModified.Location = new System.Drawing.Point(302, 83);
            this.DateTimePickerModified.Name = "DateTimePickerModified";
            this.DateTimePickerModified.Size = new System.Drawing.Size(109, 22);
            this.DateTimePickerModified.TabIndex = 5;
            // 
            // LabelCategoryShow
            // 
            this.LabelCategoryShow.AutoSize = true;
            this.LabelCategoryShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCategoryShow.Location = new System.Drawing.Point(6, 47);
            this.LabelCategoryShow.Name = "LabelCategoryShow";
            this.LabelCategoryShow.Size = new System.Drawing.Size(98, 25);
            this.LabelCategoryShow.TabIndex = 1;
            this.LabelCategoryShow.Text = "Category:";
            // 
            // LabelModified
            // 
            this.LabelModified.AutoSize = true;
            this.LabelModified.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelModified.Location = new System.Drawing.Point(214, 83);
            this.LabelModified.Name = "LabelModified";
            this.LabelModified.Size = new System.Drawing.Size(82, 20);
            this.LabelModified.TabIndex = 4;
            this.LabelModified.Text = "Modified: ";
            // 
            // LabelCreated
            // 
            this.LabelCreated.AutoSize = true;
            this.LabelCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCreated.Location = new System.Drawing.Point(6, 83);
            this.LabelCreated.Name = "LabelCreated";
            this.LabelCreated.Size = new System.Drawing.Size(73, 20);
            this.LabelCreated.TabIndex = 2;
            this.LabelCreated.Text = "Created:";
            // 
            // DateTimePickerCreated
            // 
            this.DateTimePickerCreated.Enabled = false;
            this.DateTimePickerCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerCreated.Location = new System.Drawing.Point(85, 83);
            this.DateTimePickerCreated.Name = "DateTimePickerCreated";
            this.DateTimePickerCreated.Size = new System.Drawing.Size(109, 22);
            this.DateTimePickerCreated.TabIndex = 3;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTitle.Location = new System.Drawing.Point(6, 18);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(157, 29);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Не выбрано";
            // 
            // TextBoxText
            // 
            this.TextBoxText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxText.Location = new System.Drawing.Point(3, 18);
            this.TextBoxText.Multiline = true;
            this.TextBoxText.Name = "TextBoxText";
            this.TextBoxText.Size = new System.Drawing.Size(477, 287);
            this.TextBoxText.TabIndex = 6;
            // 
            // groupBoxText
            // 
            this.groupBoxText.Controls.Add(this.TextBoxText);
            this.groupBoxText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxText.Location = new System.Drawing.Point(317, 142);
            this.groupBoxText.Name = "groupBoxText";
            this.groupBoxText.Size = new System.Drawing.Size(483, 308);
            this.groupBoxText.TabIndex = 3;
            this.groupBoxText.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxText);
            this.Controls.Add(this.GroupBoxShow);
            this.Controls.Add(this.GroupBoxChoosing);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.GroupBoxChoosing.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxButtons.ResumeLayout(false);
            this.GroupBoxShow.ResumeLayout(false);
            this.GroupBoxShow.PerformLayout();
            this.groupBoxText.ResumeLayout(false);
            this.groupBoxText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abotToolStripMenuItem;
        private System.Windows.Forms.GroupBox GroupBoxChoosing;
        private System.Windows.Forms.ComboBox ComboBoxCategory;
        private System.Windows.Forms.Label LabelCategoryChoose;
        private System.Windows.Forms.GroupBox GroupBoxShow;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.ListBox ListBoxNotes;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Label LabelCreated;
        private System.Windows.Forms.Label LabelCategoryShow;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.DateTimePicker DateTimePickerModified;
        private System.Windows.Forms.Label LabelModified;
        private System.Windows.Forms.DateTimePicker DateTimePickerCreated;
        private System.Windows.Forms.TextBox TextBoxText;
        private System.Windows.Forms.GroupBox groupBoxText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxButtons;
    }
}

