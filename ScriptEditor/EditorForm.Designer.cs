namespace ScriptEditor
{
    partial class scriptEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scriptEditorForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openFile = new System.Windows.Forms.ToolStripButton();
            this.newDocumment = new System.Windows.Forms.ToolStripButton();
            this.save = new System.Windows.Forms.ToolStripButton();
            this.saveAll = new System.Windows.Forms.ToolStripButton();
            this.closeScript = new System.Windows.Forms.ToolStripButton();
            this.closeAllScript = new System.Windows.Forms.ToolStripButton();
            this.undo = new System.Windows.Forms.ToolStripButton();
            this.redo = new System.Windows.Forms.ToolStripButton();
            this.findAndReplace = new System.Windows.Forms.ToolStripButton();
            this.sobre = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(12, 38);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(689, 401);
            this.tabControl.TabIndex = 2;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.newDocumment,
            this.save,
            this.saveAll,
            this.closeScript,
            this.closeAllScript,
            this.undo,
            this.redo,
            this.findAndReplace,
            this.sobre});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(713, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openFile
            // 
            this.openFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFile.Image = global::ScriptEditor.Properties.Resources.OpenFolder;
            this.openFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(23, 22);
            this.openFile.Text = "Abrir Script";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // newDocumment
            // 
            this.newDocumment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newDocumment.Image = global::ScriptEditor.Properties.Resources.NewDocument;
            this.newDocumment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newDocumment.Name = "newDocumment";
            this.newDocumment.Size = new System.Drawing.Size(23, 22);
            this.newDocumment.Text = "Novo Script";
            this.newDocumment.Click += new System.EventHandler(this.newDocumment_Click);
            // 
            // save
            // 
            this.save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.save.Enabled = false;
            this.save.Image = global::ScriptEditor.Properties.Resources.Save;
            this.save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(23, 22);
            this.save.Text = "Salvar";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // saveAll
            // 
            this.saveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAll.Enabled = false;
            this.saveAll.Image = global::ScriptEditor.Properties.Resources.SaveAll;
            this.saveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAll.Name = "saveAll";
            this.saveAll.Size = new System.Drawing.Size(23, 22);
            this.saveAll.Text = "Salvar todos";
            this.saveAll.Click += new System.EventHandler(this.saveAll_Click);
            // 
            // closeScript
            // 
            this.closeScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeScript.Enabled = false;
            this.closeScript.Image = global::ScriptEditor.Properties.Resources.closeFile;
            this.closeScript.ImageTransparentColor = System.Drawing.Color.Silver;
            this.closeScript.Name = "closeScript";
            this.closeScript.Size = new System.Drawing.Size(23, 22);
            this.closeScript.Text = "Fechar";
            this.closeScript.Click += new System.EventHandler(this.closeScript_Click);
            // 
            // closeAllScript
            // 
            this.closeAllScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeAllScript.Enabled = false;
            this.closeAllScript.Image = global::ScriptEditor.Properties.Resources.closeAll;
            this.closeAllScript.ImageTransparentColor = System.Drawing.Color.Silver;
            this.closeAllScript.Name = "closeAllScript";
            this.closeAllScript.Size = new System.Drawing.Size(23, 22);
            this.closeAllScript.Text = "Fechar todos";
            this.closeAllScript.Click += new System.EventHandler(this.closeAllScript_Click);
            // 
            // undo
            // 
            this.undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undo.Enabled = false;
            this.undo.Image = global::ScriptEditor.Properties.Resources.undo;
            this.undo.ImageTransparentColor = System.Drawing.Color.Silver;
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(23, 22);
            this.undo.Text = "Desfazer";
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // redo
            // 
            this.redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redo.Enabled = false;
            this.redo.Image = global::ScriptEditor.Properties.Resources.redo;
            this.redo.ImageTransparentColor = System.Drawing.Color.Silver;
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(23, 22);
            this.redo.Text = "Refazer";
            this.redo.Click += new System.EventHandler(this.redo_Click);
            // 
            // findAndReplace
            // 
            this.findAndReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.findAndReplace.Enabled = false;
            this.findAndReplace.Image = global::ScriptEditor.Properties.Resources.Search;
            this.findAndReplace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findAndReplace.Name = "findAndReplace";
            this.findAndReplace.Size = new System.Drawing.Size(23, 22);
            this.findAndReplace.Text = "Localizar e substituir";
            this.findAndReplace.ToolTipText = "Localizar e substituir";
            this.findAndReplace.Click += new System.EventHandler(this.findAndReplace_Click);
            // 
            // sobre
            // 
            this.sobre.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sobre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sobre.Image = global::ScriptEditor.Properties.Resources.Help;
            this.sobre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sobre.Name = "sobre";
            this.sobre.Size = new System.Drawing.Size(23, 22);
            this.sobre.Text = "Sobre";
            this.sobre.ToolTipText = "Sobre";
            this.sobre.Click += new System.EventHandler(this.sobre_Click);
            // 
            // scriptEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 451);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "scriptEditorForm";
            this.Text = "scriptEditor";
            this.TransparencyKey = System.Drawing.Color.Wheat;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.scriptEditor_FormClosing);
            this.Resize += new System.EventHandler(this.scriptEditor_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openFile;
        private System.Windows.Forms.ToolStripButton newDocumment;
        private System.Windows.Forms.ToolStripButton closeScript;
        private System.Windows.Forms.ToolStripButton closeAllScript;
        public System.Windows.Forms.ToolStripButton save;
        public System.Windows.Forms.ToolStripButton saveAll;
        public System.Windows.Forms.ToolStripButton undo;
        public System.Windows.Forms.ToolStripButton redo;
        private System.Windows.Forms.ToolStripButton findAndReplace;
        private System.Windows.Forms.ToolStripButton sobre;
    }
}