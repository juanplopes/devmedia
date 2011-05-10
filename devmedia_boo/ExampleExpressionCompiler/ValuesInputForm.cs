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
    public partial class ValuesInputForm : Form
    {
        IList<KeyValuePair<string, decimal>> values;

        public ValuesInputForm(IDictionary<string, decimal> values)
        {
            InitializeComponent();
            this.values = values.ToList();
            Grid.DataSource = this.values;
        }
    }
}
