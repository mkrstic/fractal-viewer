namespace FractalViewer
{
    partial class FractalsForm
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FractalsForm));
        	this.menu = new System.Windows.Forms.MenuStrip();
        	this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
        	this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        	this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        	this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.zoomInMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.zoomOutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
        	this.showToolbarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.fullScreenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.jezikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.englishMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.serbianMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.optionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.pictureBoxContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.zoomInContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.zoomOutContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.resetContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.contextMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        	this.saveAsContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolbar = new System.Windows.Forms.ToolStrip();
        	this.newToolbarButton = new System.Windows.Forms.ToolStripButton();
        	this.saveToolbarButton = new System.Windows.Forms.ToolStripButton();
        	this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
        	this.printToolbarButton = new System.Windows.Forms.ToolStripButton();
        	this.printPreviewToolbarButton = new System.Windows.Forms.ToolStripButton();
        	this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
        	this.zoomInToolbarButton = new System.Windows.Forms.ToolStripButton();
        	this.zoomOutToolbarButton = new System.Windows.Forms.ToolStripButton();
        	this.printDialog = new System.Windows.Forms.PrintDialog();
        	this.printDocument = new System.Drawing.Printing.PrintDocument();
        	this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
        	this.pictureBox = new System.Windows.Forms.PictureBox();
        	this.menu.SuspendLayout();
        	this.pictureBoxContextMenu.SuspendLayout();
        	this.toolbar.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// menu
        	// 
        	resources.ApplyResources(this.menu, "menu");
        	this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.fileToolStripMenuItem,
        	        	        	this.viewToolStripMenuItem,
        	        	        	this.toolsToolStripMenuItem,
        	        	        	this.helpToolStripMenuItem});
        	this.menu.Name = "menu";
        	// 
        	// fileToolStripMenuItem
        	// 
        	resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
        	this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.newToolStripMenuItem,
        	        	        	this.toolStripSeparator,
        	        	        	this.saveAsMenuItem,
        	        	        	this.toolStripSeparator1,
        	        	        	this.printToolStripMenuItem,
        	        	        	this.printPreviewToolStripMenuItem,
        	        	        	this.toolStripSeparator2,
        	        	        	this.exitToolStripMenuItem});
        	this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        	// 
        	// newToolStripMenuItem
        	// 
        	resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
        	this.newToolStripMenuItem.Image = global::FractalViewer.Properties.Resources.icon_new_file;
        	this.newToolStripMenuItem.Name = "newToolStripMenuItem";
        	this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
        	// 
        	// toolStripSeparator
        	// 
        	resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
        	this.toolStripSeparator.Name = "toolStripSeparator";
        	// 
        	// saveAsMenuItem
        	// 
        	resources.ApplyResources(this.saveAsMenuItem, "saveAsMenuItem");
        	this.saveAsMenuItem.Image = global::FractalViewer.Properties.Resources.icon_save_file;
        	this.saveAsMenuItem.Name = "saveAsMenuItem";
        	this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
        	// 
        	// toolStripSeparator1
        	// 
        	resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
        	this.toolStripSeparator1.Name = "toolStripSeparator1";
        	// 
        	// printToolStripMenuItem
        	// 
        	resources.ApplyResources(this.printToolStripMenuItem, "printToolStripMenuItem");
        	this.printToolStripMenuItem.Name = "printToolStripMenuItem";
        	this.printToolStripMenuItem.Click += new System.EventHandler(this.printMenuItem_Click);
        	// 
        	// printPreviewToolStripMenuItem
        	// 
        	resources.ApplyResources(this.printPreviewToolStripMenuItem, "printPreviewToolStripMenuItem");
        	this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
        	this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewMenuItem_Click);
        	// 
        	// toolStripSeparator2
        	// 
        	resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
        	this.toolStripSeparator2.Name = "toolStripSeparator2";
        	// 
        	// exitToolStripMenuItem
        	// 
        	resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
        	this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        	this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
        	// 
        	// viewToolStripMenuItem
        	// 
        	resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
        	this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.zoomInMenuItem,
        	        	        	this.zoomOutMenuItem,
        	        	        	this.toolStripMenuItem1,
        	        	        	this.showToolbarMenuItem,
        	        	        	this.fullScreenMenuItem,
        	        	        	this.jezikToolStripMenuItem});
        	this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
        	// 
        	// zoomInMenuItem
        	// 
        	resources.ApplyResources(this.zoomInMenuItem, "zoomInMenuItem");
        	this.zoomInMenuItem.Image = global::FractalViewer.Properties.Resources.icon_zoom_in;
        	this.zoomInMenuItem.Name = "zoomInMenuItem";
        	this.zoomInMenuItem.Click += new System.EventHandler(this.zoomInMenuItem_Click);
        	// 
        	// zoomOutMenuItem
        	// 
        	resources.ApplyResources(this.zoomOutMenuItem, "zoomOutMenuItem");
        	this.zoomOutMenuItem.Image = global::FractalViewer.Properties.Resources.icon_zoom_out;
        	this.zoomOutMenuItem.Name = "zoomOutMenuItem";
        	this.zoomOutMenuItem.Click += new System.EventHandler(this.zoomOutMenuItem_Click);
        	// 
        	// toolStripMenuItem1
        	// 
        	resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
        	this.toolStripMenuItem1.Name = "toolStripMenuItem1";
        	// 
        	// showToolbarMenuItem
        	// 
        	resources.ApplyResources(this.showToolbarMenuItem, "showToolbarMenuItem");
        	this.showToolbarMenuItem.Checked = true;
        	this.showToolbarMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.showToolbarMenuItem.Name = "showToolbarMenuItem";
        	this.showToolbarMenuItem.Click += new System.EventHandler(this.showToolbarMenuItem_Click);
        	// 
        	// fullScreenMenuItem
        	// 
        	resources.ApplyResources(this.fullScreenMenuItem, "fullScreenMenuItem");
        	this.fullScreenMenuItem.Name = "fullScreenMenuItem";
        	this.fullScreenMenuItem.Click += new System.EventHandler(this.fullScreenMenuItem_Click);
        	// 
        	// jezikToolStripMenuItem
        	// 
        	resources.ApplyResources(this.jezikToolStripMenuItem, "jezikToolStripMenuItem");
        	this.jezikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.englishMenuItem,
        	        	        	this.serbianMenuItem});
        	this.jezikToolStripMenuItem.Name = "jezikToolStripMenuItem";
        	// 
        	// englishMenuItem
        	// 
        	resources.ApplyResources(this.englishMenuItem, "englishMenuItem");
        	this.englishMenuItem.Image = global::FractalViewer.Properties.Resources.unitedkingdom;
        	this.englishMenuItem.Name = "englishMenuItem";
        	this.englishMenuItem.Click += new System.EventHandler(this.englishMenuItem_Click);
        	// 
        	// serbianMenuItem
        	// 
        	resources.ApplyResources(this.serbianMenuItem, "serbianMenuItem");
        	this.serbianMenuItem.Image = global::FractalViewer.Properties.Resources.serbia;
        	this.serbianMenuItem.Name = "serbianMenuItem";
        	this.serbianMenuItem.Click += new System.EventHandler(this.serbianMenuItem_Click);
        	// 
        	// toolsToolStripMenuItem
        	// 
        	resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
        	this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.optionsMenuItem});
        	this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
        	// 
        	// optionsMenuItem
        	// 
        	resources.ApplyResources(this.optionsMenuItem, "optionsMenuItem");
        	this.optionsMenuItem.Name = "optionsMenuItem";
        	this.optionsMenuItem.Click += new System.EventHandler(this.optionsMenuItem_Click);
        	// 
        	// helpToolStripMenuItem
        	// 
        	resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
        	this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.aboutMenuItem});
        	this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        	// 
        	// aboutMenuItem
        	// 
        	resources.ApplyResources(this.aboutMenuItem, "aboutMenuItem");
        	this.aboutMenuItem.Name = "aboutMenuItem";
        	this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
        	// 
        	// pictureBoxContextMenu
        	// 
        	resources.ApplyResources(this.pictureBoxContextMenu, "pictureBoxContextMenu");
        	this.pictureBoxContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.zoomInContextMenuItem,
        	        	        	this.zoomOutContextMenuItem,
        	        	        	this.resetContextMenuItem,
        	        	        	this.contextMenuSeparator1,
        	        	        	this.saveAsContextMenuItem});
        	this.pictureBoxContextMenu.Name = "pictureBoxContextMenu";
        	// 
        	// zoomInContextMenuItem
        	// 
        	resources.ApplyResources(this.zoomInContextMenuItem, "zoomInContextMenuItem");
        	this.zoomInContextMenuItem.Image = global::FractalViewer.Properties.Resources.icon_zoom_in;
        	this.zoomInContextMenuItem.Name = "zoomInContextMenuItem";
        	this.zoomInContextMenuItem.Click += new System.EventHandler(this.zoomInContextMenuItem_Click);
        	// 
        	// zoomOutContextMenuItem
        	// 
        	resources.ApplyResources(this.zoomOutContextMenuItem, "zoomOutContextMenuItem");
        	this.zoomOutContextMenuItem.Image = global::FractalViewer.Properties.Resources.icon_zoom_out;
        	this.zoomOutContextMenuItem.Name = "zoomOutContextMenuItem";
        	this.zoomOutContextMenuItem.Click += new System.EventHandler(this.zoomOutContextMenuItem_Click);
        	// 
        	// resetContextMenuItem
        	// 
        	resources.ApplyResources(this.resetContextMenuItem, "resetContextMenuItem");
        	this.resetContextMenuItem.Name = "resetContextMenuItem";
        	this.resetContextMenuItem.Click += new System.EventHandler(this.resetContextMenuItem_Click);
        	// 
        	// contextMenuSeparator1
        	// 
        	resources.ApplyResources(this.contextMenuSeparator1, "contextMenuSeparator1");
        	this.contextMenuSeparator1.Name = "contextMenuSeparator1";
        	// 
        	// saveAsContextMenuItem
        	// 
        	resources.ApplyResources(this.saveAsContextMenuItem, "saveAsContextMenuItem");
        	this.saveAsContextMenuItem.Image = global::FractalViewer.Properties.Resources.icon_save_file;
        	this.saveAsContextMenuItem.Name = "saveAsContextMenuItem";
        	this.saveAsContextMenuItem.Click += new System.EventHandler(this.saveAsContextMenuItem_Click);
        	// 
        	// toolbar
        	// 
        	resources.ApplyResources(this.toolbar, "toolbar");
        	this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.newToolbarButton,
        	        	        	this.saveToolbarButton,
        	        	        	this.toolStripSeparator3,
        	        	        	this.printToolbarButton,
        	        	        	this.printPreviewToolbarButton,
        	        	        	this.toolStripSeparator4,
        	        	        	this.zoomInToolbarButton,
        	        	        	this.zoomOutToolbarButton});
        	this.toolbar.Name = "toolbar";
        	this.toolbar.Stretch = true;
        	// 
        	// newToolbarButton
        	// 
        	resources.ApplyResources(this.newToolbarButton, "newToolbarButton");
        	this.newToolbarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.newToolbarButton.Image = global::FractalViewer.Properties.Resources.icon_new_file;
        	this.newToolbarButton.Name = "newToolbarButton";
        	this.newToolbarButton.Click += new System.EventHandler(this.newToolbarButton_Click);
        	// 
        	// saveToolbarButton
        	// 
        	resources.ApplyResources(this.saveToolbarButton, "saveToolbarButton");
        	this.saveToolbarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.saveToolbarButton.Image = global::FractalViewer.Properties.Resources.icon_save_file;
        	this.saveToolbarButton.Name = "saveToolbarButton";
        	this.saveToolbarButton.Click += new System.EventHandler(this.saveToolbarButton_Click);
        	// 
        	// toolStripSeparator3
        	// 
        	resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
        	this.toolStripSeparator3.Name = "toolStripSeparator3";
        	// 
        	// printToolbarButton
        	// 
        	resources.ApplyResources(this.printToolbarButton, "printToolbarButton");
        	this.printToolbarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.printToolbarButton.Image = global::FractalViewer.Properties.Resources.PrintHS;
        	this.printToolbarButton.Name = "printToolbarButton";
        	this.printToolbarButton.Click += new System.EventHandler(this.printToolbarButton_Click);
        	// 
        	// printPreviewToolbarButton
        	// 
        	resources.ApplyResources(this.printPreviewToolbarButton, "printPreviewToolbarButton");
        	this.printPreviewToolbarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.printPreviewToolbarButton.Image = global::FractalViewer.Properties.Resources.PrintPreviewHS;
        	this.printPreviewToolbarButton.Name = "printPreviewToolbarButton";
        	this.printPreviewToolbarButton.Click += new System.EventHandler(this.printPreviewToolbarButton_Click);
        	// 
        	// toolStripSeparator4
        	// 
        	resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
        	this.toolStripSeparator4.Name = "toolStripSeparator4";
        	// 
        	// zoomInToolbarButton
        	// 
        	resources.ApplyResources(this.zoomInToolbarButton, "zoomInToolbarButton");
        	this.zoomInToolbarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.zoomInToolbarButton.Image = global::FractalViewer.Properties.Resources.icon_zoom_in;
        	this.zoomInToolbarButton.Name = "zoomInToolbarButton";
        	this.zoomInToolbarButton.Click += new System.EventHandler(this.zoomInToolbarButton_Click);
        	// 
        	// zoomOutToolbarButton
        	// 
        	resources.ApplyResources(this.zoomOutToolbarButton, "zoomOutToolbarButton");
        	this.zoomOutToolbarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.zoomOutToolbarButton.Image = global::FractalViewer.Properties.Resources.icon_zoom_out;
        	this.zoomOutToolbarButton.Name = "zoomOutToolbarButton";
        	this.zoomOutToolbarButton.Click += new System.EventHandler(this.zoomOutToolbarButton_Click);
        	// 
        	// printDialog
        	// 
        	this.printDialog.UseEXDialog = true;
        	// 
        	// printDocument
        	// 
        	this.printDocument.DocumentName = "Fractal";
        	this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
        	// 
        	// printPreviewDialog
        	// 
        	resources.ApplyResources(this.printPreviewDialog, "printPreviewDialog");
        	this.printPreviewDialog.Document = this.printDocument;
        	this.printPreviewDialog.Name = "printPreviewDialog";
        	// 
        	// pictureBox
        	// 
        	resources.ApplyResources(this.pictureBox, "pictureBox");
        	this.pictureBox.Name = "pictureBox";
        	this.pictureBox.TabStop = false;
        	this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
        	this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
        	this.pictureBox.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
        	this.pictureBox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
        	this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
        	this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
        	// 
        	// FractalsForm
        	// 
        	resources.ApplyResources(this, "$this");
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.Controls.Add(this.pictureBox);
        	this.Controls.Add(this.toolbar);
        	this.Controls.Add(this.menu);
        	this.MainMenuStrip = this.menu;
        	this.Name = "FractalsForm";
        	this.ResizeEnd += new System.EventHandler(this.FractalsFormResizeEnd);
        	this.SizeChanged += new System.EventHandler(this.FractalsFormSizeChanged);
        	this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FractalsForm_KeyDown);
        	this.menu.ResumeLayout(false);
        	this.menu.PerformLayout();
        	this.pictureBoxContextMenu.ResumeLayout(false);
        	this.toolbar.ResumeLayout(false);
        	this.toolbar.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showToolbarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ContextMenuStrip pictureBoxContextMenu;
        private System.Windows.Forms.ToolStripMenuItem zoomInContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator contextMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveAsContextMenuItem;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripButton newToolbarButton;
        private System.Windows.Forms.ToolStripButton saveToolbarButton;
        private System.Windows.Forms.ToolStripButton zoomInToolbarButton;
        private System.Windows.Forms.ToolStripButton zoomOutToolbarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem resetContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jezikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serbianMenuItem;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.ToolStripButton printToolbarButton;
        private System.Windows.Forms.ToolStripButton printPreviewToolbarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

