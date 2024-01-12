namespace Hameed
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            usenamebox = new TextBox();
            passwordbox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(125, 182);
            button1.Name = "button1";
            button1.Size = new Size(145, 29);
            button1.TabIndex = 0;
            button1.Text = "Log-In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 51);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 108);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // usenamebox
            // 
            usenamebox.Location = new Point(99, 78);
            usenamebox.Name = "usenamebox";
            usenamebox.Size = new Size(205, 27);
            usenamebox.TabIndex = 3;
            // 
            // passwordbox
            // 
            passwordbox.ImeMode = ImeMode.Hiragana;
            passwordbox.Location = new Point(101, 133);
            passwordbox.Name = "passwordbox";
            passwordbox.Size = new Size(203, 27);
            passwordbox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(584, 325);
            Controls.Add(passwordbox);
            Controls.Add(usenamebox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Log_in";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox usenamebox;
        private TextBox passwordbox;
    }
}
