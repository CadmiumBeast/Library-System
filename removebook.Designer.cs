namespace Hameed
{
    partial class removebook
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
            label1 = new Label();
            removename = new TextBox();
            Remove = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 134);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Book Name";
            // 
            // removename
            // 
            removename.Location = new Point(262, 134);
            removename.Name = "removename";
            removename.Size = new Size(237, 27);
            removename.TabIndex = 1;
            // 
            // Remove
            // 
            Remove.Location = new Point(307, 204);
            Remove.Name = "Remove";
            Remove.Size = new Size(158, 54);
            Remove.TabIndex = 2;
            Remove.Text = "Remove Book";
            Remove.UseVisualStyleBackColor = true;
            Remove.Click += Remove_Click;
            // 
            // removebook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(800, 450);
            Controls.Add(Remove);
            Controls.Add(removename);
            Controls.Add(label1);
            Name = "removebook";
            Text = "removebook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox removename;
        private Button Remove;
    }
}