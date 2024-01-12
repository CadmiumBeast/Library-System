namespace Hameed
{
    partial class ReturnBooks
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
            button1 = new Button();
            Returnname = new Label();
            returnBook = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(324, 217);
            button1.Name = "button1";
            button1.Size = new Size(186, 62);
            button1.TabIndex = 0;
            button1.Text = "Return Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Returnname
            // 
            Returnname.AutoSize = true;
            Returnname.Location = new Point(177, 139);
            Returnname.Name = "Returnname";
            Returnname.Size = new Size(87, 20);
            Returnname.TabIndex = 1;
            Returnname.Text = "Book Name";
            // 
            // returnBook
            // 
            returnBook.Location = new Point(270, 136);
            returnBook.Name = "returnBook";
            returnBook.Size = new Size(298, 27);
            returnBook.TabIndex = 2;
            // 
            // ReturnBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(800, 450);
            Controls.Add(returnBook);
            Controls.Add(Returnname);
            Controls.Add(button1);
            Name = "ReturnBooks";
            Text = "ReturnBooks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label Returnname;
        private TextBox returnBook;
    }
}