namespace AntWorldCSharp
{
    partial class MainForm
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
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.DropDownMenu = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.renderControl = new AntWorldCSharp.RenderControl();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.DropDownMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 25;
            this.Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DropDownMenu
            // 
            this.DropDownMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.DropDownMenu.Location = new System.Drawing.Point(0, 0);
            this.DropDownMenu.Name = "DropDownMenu";
            this.DropDownMenu.Size = new System.Drawing.Size(784, 24);
            this.DropDownMenu.TabIndex = 0;
            this.DropDownMenu.Text = "menuStrip1";
            this.DropDownMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.DropDownMenu_ItemClicked);
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(50, 20);
            this.Menu.Text = "Menu";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.renderControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 515);
            this.panel1.TabIndex = 21;
            // 
            // renderControl
            // 
            this.renderControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renderControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.renderControl.Location = new System.Drawing.Point(0, 0);
            this.renderControl.Name = "renderControl";
            this.renderControl.Size = new System.Drawing.Size(784, 515);
            this.renderControl.TabIndex = 20;
            this.renderControl.Load += new System.EventHandler(this.renderControl_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DropDownMenu);
            this.MainMenuStrip = this.DropDownMenu;
            this.MinimumSize = new System.Drawing.Size(200, 150);
            this.Name = "MainForm";
            this.Text = "AntWorld";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DropDownMenu.ResumeLayout(false);
            this.DropDownMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.MenuStrip DropDownMenu;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private RenderControl renderControl;
        private System.Windows.Forms.Panel panel1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}

