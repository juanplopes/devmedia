using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExampleExpressionCompiler
{
    public partial class ScriptInputForm : Form
    {
        public ScriptInputForm()
        {
            InitializeComponent();
        }

        private void BuildCommand_Click(object sender, EventArgs e)
        {
            //try
            //{
            var compiler = new ExpressionCompiler();
            var function = compiler.Compile(ScriptInput.Text);
            var input = compiler.LastExpressionParams.ToDictionary(x => x, x => 0m);
            var form = new ValuesInputForm(input);
            form.ShowDialog();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
