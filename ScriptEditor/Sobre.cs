using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class Sobre : Form
    {
        public Sobre()
        {
            InitializeComponent();
            developer.Text += "Mehah";
            version.Text += "1.0.2";
            textEditor.Text += "ICSharpCode (http://www.icsharpcode.net/)";
        }
        private void exit_Click(object sender, EventArgs e) { Close(); }
    }
}
