namespace ExampleFormBuilder
{
    partial class ScriptInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptInputForm));
            this.ScriptInput = new System.Windows.Forms.TextBox();
            this.BuildCommand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScriptInput
            // 
            this.ScriptInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptInput.Location = new System.Drawing.Point(13, 13);
            this.ScriptInput.Multiline = true;
            this.ScriptInput.Name = "ScriptInput";
            this.ScriptInput.Size = new System.Drawing.Size(535, 256);
            this.ScriptInput.TabIndex = 0;
            this.ScriptInput.Text = resources.GetString("ScriptInput.Text");
            // 
            // BuildCommand
            // 
            this.BuildCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BuildCommand.Location = new System.Drawing.Point(13, 269);
            this.BuildCommand.Name = "BuildCommand";
            this.BuildCommand.Size = new System.Drawing.Size(535, 23);
            this.BuildCommand.TabIndex = 1;
            this.BuildCommand.Text = "Build!";
            this.BuildCommand.UseVisualStyleBackColor = true;
            this.BuildCommand.Click += new System.EventHandler(this.BuildCommand_Click);
            // 
            // ScriptInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 304);
            this.Controls.Add(this.BuildCommand);
            this.Controls.Add(this.ScriptInput);
            this.Name = "ScriptInputForm";
            this.Text = "Script Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ScriptInput;
        private System.Windows.Forms.Button BuildCommand;
    }
}

