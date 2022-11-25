
namespace hci_1._2
{
    partial class Form1
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
            this.help = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.file = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.message = new System.Windows.Forms.ToolStripMenuItem();
            this.check = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.format = new System.Windows.Forms.MenuStrip();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.help.SuspendLayout();
            this.file.SuspendLayout();
            this.format.SuspendLayout();
            this.SuspendLayout();
            // 
            // help
            // 
            this.help.AutoSize = false;
            this.help.BackColor = System.Drawing.Color.LightBlue;
            this.help.Dock = System.Windows.Forms.DockStyle.None;
            this.help.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.help.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.help.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.help.Location = new System.Drawing.Point(188, 9);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(77, 37);
            this.help.TabIndex = 0;
            this.help.Text = "Help";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(67, 33);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.LightBlue;
            this.about.Image = global::hci_1._2.Properties.Resources._2948037;
            this.about.Name = "about";
            this.about.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.about.Size = new System.Drawing.Size(223, 32);
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // file
            // 
            this.file.AutoSize = false;
            this.file.BackColor = System.Drawing.Color.LightBlue;
            this.file.Dock = System.Windows.Forms.DockStyle.None;
            this.file.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.file.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.file.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.file.Location = new System.Drawing.Point(6, 9);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(70, 37);
            this.file.TabIndex = 1;
            this.file.Text = "File";
            this.file.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.File_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.message,
            this.check,
            this.exit});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 33);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.Color.LightBlue;
            this.message.Image = global::hci_1._2.Properties.Resources._4638921;
            this.message.Name = "message";
            this.message.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.message.Size = new System.Drawing.Size(249, 32);
            this.message.Text = "Message";
            this.message.Click += new System.EventHandler(this.message_Click);
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.LightBlue;
            this.check.Image = global::hci_1._2.Properties.Resources._4429894;
            this.check.Name = "check";
            this.check.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.check.Size = new System.Drawing.Size(249, 32);
            this.check.Text = "Check";
            this.check.Click += new System.EventHandler(this.text_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.LightBlue;
            this.exit.Image = global::hci_1._2.Properties.Resources._4503993;
            this.exit.Name = "exit";
            this.exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exit.Size = new System.Drawing.Size(249, 32);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // format
            // 
            this.format.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.format.AutoSize = false;
            this.format.BackColor = System.Drawing.Color.LightBlue;
            this.format.Dock = System.Windows.Forms.DockStyle.None;
            this.format.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.format.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatToolStripMenuItem});
            this.format.Location = new System.Drawing.Point(76, 9);
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(111, 37);
            this.format.TabIndex = 3;
            this.format.Text = "format";
            this.format.Visible = false;
            this.format.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(89, 33);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1123, 673);
            this.Controls.Add(this.help);
            this.Controls.Add(this.file);
            this.Controls.Add(this.format);
            this.MainMenuStrip = this.help;
            this.Name = "Form1";
            this.Text = "Form1";
            this.help.ResumeLayout(false);
            this.help.PerformLayout();
            this.file.ResumeLayout(false);
            this.file.PerformLayout();
            this.format.ResumeLayout(false);
            this.format.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip help;
        private System.Windows.Forms.MenuStrip file;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStripMenuItem check;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem message;
        private System.Windows.Forms.MenuStrip format;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

