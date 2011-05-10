using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ExampleFormBuilder
{
    public class FormBuilder
    {
        Form form = new Form();
        TableLayoutPanel panel = new TableLayoutPanel()
        {
            ColumnCount = 1,
            Dock = DockStyle.Fill
        };

        public FormBuilder()
        {
            form.Controls.Add(panel);
        }

        public void Title(string title)
        {
            form.Text = title;
        }

        public void TextBox(string label)
        {
            AddLabel(label);
            Add(new TextBox());
        }

        public void Combo(string label, params string[] options)
        {
            AddLabel(label);
            Add(new ComboBox() { DataSource = options });
        }

        private void AddLabel(string label)
        {
            Add(new Label()
            {
                Text = label,
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            });
        }

        private void Add(Control control)
        {
            control.Dock = DockStyle.Top;

            panel.Controls.Add(control);
        }

        public void Show()
        {
            form.Show();
        }
    }
}
