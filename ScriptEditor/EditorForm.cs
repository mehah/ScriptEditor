using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace ScriptEditor
{
    public partial class scriptEditorForm : Form
    {
        List<Script> scripts = new List<Script>();

        String title = "Editor de Script";

        Int32 qntNovo = 0;

        FindAndReplaceForm findForm = new FindAndReplaceForm();

        public scriptEditorForm()
        {
            InitializeComponent();
            Text = title;
        }

        public String Title { get { return title; } }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (scripts.Count == tabControl.TabCount && tabControl.SelectedIndex > -1)
            {
                Script script = getSelectedScript();

                Text = title + " - " + script.Patch;

                undo.Enabled = script.canUndo();
                redo.Enabled = script.canRedo();

                findForm.Script = script;
                findAndReplace.Enabled = true;

                script.checkRedoUndoPos();
            }
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = currentPatch;

            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                for (Int32 i = 0, c = openFileDialog.SafeFileNames.Length; i < c; i++)
                {
                    String safeFileName = openFileDialog.SafeFileNames[i];
                    String fileName = openFileDialog.FileNames[i];

                    TabPage newPage = new TabPage(safeFileName);
                    Script script = new Script(fileName, this);

                    script.SafePatch = safeFileName;

                    script.loadScriptCommands(newPage);

                    tabControl.TabPages.Add(newPage);
                    tabControl.SelectedTab = newPage;

                    script.loadFile();
                    script.Modified = false;
                    scripts.Add(script);
                }
                tabControl_Selected(null, null);
            }
            openFileDialog.Dispose();
            openFileDialog = null;
        }

        private void newDocumment_Click(object sender, EventArgs e)
        {
            TabPage newPage = new TabPage("Novo " + ++qntNovo);
            Script script = new Script("Novo " + qntNovo, this);

            script.SafePatch = "Novo " + qntNovo;
            script.IsNew = true;
            script.loadScriptCommands(newPage);

            tabControl.TabPages.Add(newPage);
            tabControl.SelectedTab = newPage;

            scripts.Add(script);

            tabControl_Selected(null, null);
            if (tabControl.TabPages.Count > 1)
            {
                closeAllScript.Enabled = true;
                closeScript.Enabled = true;
            }
            else
            {
                closeScript.Enabled = true;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex > -1)
            {
                Script script = getSelectedScript();
                if (script.save())
                {
                    tabControl.SelectedTab.Text = script.SafePatch;
                    tabControl_Selected(null, null);
                }
            }
        }

        private void saveAll_Click(object sender, EventArgs e)
        {
            for (Int32 i = 0; i < scripts.Count; i++)
            {
                tabControl.SelectedIndex = i;

                Script script = scripts[i];
                if (script.save())
                    tabControl.TabPages[i].Text = script.SafePatch;
            }
        }

        private void closeScript_Click(object sender, EventArgs e)
        {
            if (scripts.Count > 0 && tabControl.SelectedTab != null)
            {
                Script script = scripts[tabControl.SelectedIndex];

                if (script.Modified)
                {
                    DialogResult result = MessageBox.Show("O arquivo \"" + script.SafePatch + "\" foi modificado! Deseja salva-lo?", "Salvar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (!script.save())
                            return;
                    }
                    else if (result == System.Windows.Forms.DialogResult.Cancel)
                        return;
                }

                script.clear();
                scripts.RemoveAt(tabControl.SelectedIndex);

                TabPage page = tabControl.SelectedTab;
                tabControl.TabPages.Remove(page);
                page.Dispose();
                page = null;

                if (tabControl.TabPages.Count > 0)
                    tabControl.SelectedTab = tabControl.TabPages[tabControl.TabPages.Count - 1];
                else
                {
                    undo.Enabled = false;
                    redo.Enabled = false;
                    findAndReplace.Enabled = false;
                    closeAllScript.Enabled = false;
                    closeScript.Enabled = false;
                    Text = title;
                    findForm.Hide();
                }
            }

            if (tabControl.TabPages.Count <= 1)
                closeAllScript.Enabled = false;
        }

        private void closeAllScript_Click(object sender, EventArgs e)
        {
            for(Int32 i = 0, c = tabControl.TabPages.Count-1; c >= i; --c)
            {
                Script script = scripts[c];
                if (script.Modified)
                {
                    DialogResult result = MessageBox.Show("O arquivo \"" + script.SafePatch + "\" foi modificado! Deseja salva-lo?", "Salvar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (!script.save())
                            return;
                    }
                    else if (result == System.Windows.Forms.DialogResult.Cancel)
                        return;
                }

                script.clear();
                scripts.RemoveAt(c);

                TabPage page = tabControl.TabPages[c];
                tabControl.TabPages.Remove(page);
                page.Dispose();
                page = null;

                if (tabControl.TabPages.Count > 0)
                    tabControl.SelectedTab = tabControl.TabPages[tabControl.TabPages.Count - 1];
            }

            undo.Enabled = false;
            redo.Enabled = false;
            findAndReplace.Enabled = false;
            closeAllScript.Enabled = false;
            closeScript.Enabled = false;
            Text = title;
            findForm.Hide();
        }

        private void scriptEditor_Resize(object sender, EventArgs e)
        {
            tabControl.Width = Width - 32;
            tabControl.Height = Height - 77;
        }

        private void scriptEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeAllScript_Click(null, null);
            if (tabControl.TabPages.Count > 0)
                e.Cancel = true;
        }

        private void undo_Click(object sender, EventArgs e) { getSelectedScript().undo(); }
        private void redo_Click(object sender, EventArgs e) { getSelectedScript().redo(); }

        private Script getSelectedScript() { return scripts[tabControl.SelectedIndex]; }

        public void openSearchDialog() { findAndReplace_Click(null, null); }
        private void findAndReplace_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex > -1)
            {
                if (findForm.Created)
                    findForm.Hide();
                findForm.Show(this);
            }
        }

        private void sobre_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog(this);
            sobre.Dispose();
            sobre = null;
        }
    }
}
