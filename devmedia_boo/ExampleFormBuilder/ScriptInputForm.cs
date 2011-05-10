using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExampleFormBuilder
{
    public partial class ScriptInputForm : Form
    {
        public ScriptInputForm()
        {
            InitializeComponent();
        }

        private void BuildCommand_Click(object sender, EventArgs e)
        {
            try
            {
                var compiler = new DefinitionCompiler();
                var definition = compiler.Compile(ScriptInput.Text);

                var form = new FormBuilder();
                definition.Build(form);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
