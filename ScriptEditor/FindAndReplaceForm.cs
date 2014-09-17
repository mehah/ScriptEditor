using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ICSharpCode.TextEditor;
using ICSharpCode.TextEditor.Document;

namespace ScriptEditor
{
    public partial class FindAndReplaceForm : Form
    {
        Script script = null;
        StringComparison type;


        internal Script Script
        {
            get { return script; }
            set { script = value; }
        }

        Int32 pos = 0;

        public FindAndReplaceForm()
        {
            InitializeComponent();
        }

        protected void setConfigs()
        {
            if (pos + textFind.Text.Length > script.TextBox.Text.Length)
                pos = 0;

            if (checkCase.Checked)
                type = StringComparison.Ordinal;
            else
                type = StringComparison.OrdinalIgnoreCase;
        }

        public static void SelectText(TextEditorControl textArea, int offset, int endOffset)
        {
            int textLength = textArea.ActiveTextAreaControl.Document.TextLength;
            if (textLength < endOffset)
            {
                endOffset = textLength - 1;
            }
            textArea.ActiveTextAreaControl.Caret.Position = textArea.Document.OffsetToPosition(endOffset);
            textArea.ActiveTextAreaControl.TextArea.SelectionManager.ClearSelection();
            textArea.ActiveTextAreaControl.TextArea.SelectionManager.SetSelection(new DefaultSelection(textArea.Document, textArea.Document.OffsetToPosition(offset),
                                                                                                       textArea.Document.OffsetToPosition(endOffset)));
            textArea.Refresh();
        }

        private Int32 find() { return find(true); }
        private Int32 find(Boolean selectText)
        {
            Int32 _pos = 0;
            String txt = textFind.Text;
            if (txt.Trim().Length != 0)
            {
                setConfigs();
                do
                {
                    _pos = script.TextBox.Document.TextContent.IndexOf(txt, pos, type);

                    if (_pos == -1)
                    {
                        if (pos == 0)
                            return -1;

                        pos = 0;
                    }
                } while (_pos == -1);

                pos = _pos + (txt.Length == 1 ? 0 : txt.Length);

                if(selectText)
                    SelectText(script.TextBox, _pos, pos);
            }

            return _pos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (find() == -1)
                MessageBox.Show("Não foi possivel achar a palavra!", "Localizar", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 result = find();
            if (result != -1)
            {
                script.TextBox.Document.Replace(result, textFind.Text.Trim().Length, textReplace.Text);
                script.TextBox.ActiveTextAreaControl.SelectionManager.ClearSelection();
            }else
                MessageBox.Show("Não foi possivel achar a palavra!", "", MessageBoxButtons.OK, MessageBoxIcon.None);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int32 cnt = 0;
            Int32 _pos = 0;
            String txt = textFind.Text;

            if (txt.Trim().Length != 0)
            {
                setConfigs();
                while(true)
                {
                    _pos = script.TextBox.Document.TextContent.IndexOf(txt, pos, type);
                    if(_pos != -1)
                    {
                        script.TextBox.Document.Replace(_pos, txt.Trim().Length, textReplace.Text);
                        pos = _pos + (txt.Length == 1 ? 0 : txt.Length);
                    }else
                        break;
                    cnt++;
                }
            }
            pos = 0;
            MessageBox.Show("Foram substituidos "+ cnt +" palavras.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void FindAndReplace_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void textFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(null, null);
        }
    }
}
