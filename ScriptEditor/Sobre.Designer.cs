namespace ScriptEditor
{
    partial class Sobre
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
            this.developer = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.textEditor = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // developer
            // 
            this.developer.AutoSize = true;
            this.developer.Location = new System.Drawing.Point(12, 9);
            this.developer.Name = "developer";
            this.developer.Size = new System.Drawing.Size(85, 13);
            this.developer.TabIndex = 0;
            this.developer.Text = "Desenvolvedor: ";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(12, 32);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(46, 13);
            this.version.TabIndex = 1;
            this.version.Text = "Versão: ";
            // 
            // textEditor
            // 
            this.textEditor.AutoSize = true;
            this.textEditor.Location = new System.Drawing.Point(12, 55);
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(122, 13);
            this.textEditor.TabIndex = 2;
            this.textEditor.Text = "TextEditor baseado em: ";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(136, 86);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 25);
            this.exit.TabIndex = 4;
            this.exit.Text = "OK";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 123);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.textEditor);
            this.Controls.Add(this.version);
            this.Controls.Add(this.developer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sobre";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações do Editor de Script";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label developer;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label textEditor;
        private System.Windows.Forms.Button exit;
    }
}