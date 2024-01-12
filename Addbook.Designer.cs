namespace Hameed
{
    partial class Addbook
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Bname = new TextBox();
            Bauthor = new TextBox();
            bisbn = new TextBox();
            Add = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 90);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Book Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 145);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 1;
            label2.Text = "Book Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.OliveDrab;
            label3.Location = new Point(173, 191);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 191);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "ISBN";
            // 
            // Bname
            // 
            Bname.Location = new Point(238, 90);
            Bname.Name = "Bname";
            Bname.Size = new Size(280, 27);
            Bname.TabIndex = 4;
            // 
            // Bauthor
            // 
            Bauthor.Location = new Point(238, 142);
            Bauthor.Name = "Bauthor";
            Bauthor.Size = new Size(280, 27);
            Bauthor.TabIndex = 5;
            // 
            // bisbn
            // 
            bisbn.Location = new Point(238, 188);
            bisbn.Name = "bisbn";
            bisbn.Size = new Size(280, 27);
            bisbn.TabIndex = 6;
            // 
            // Add
            // 
            Add.Location = new Point(315, 245);
            Add.Name = "Add";
            Add.Size = new Size(144, 36);
            Add.TabIndex = 7;
            Add.Text = "Add Book";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Addbook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(660, 381);
            Controls.Add(Add);
            Controls.Add(bisbn);
            Controls.Add(Bauthor);
            Controls.Add(Bname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Addbook";
            Text = "Addbook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Bname;
        private TextBox Bauthor;
        private TextBox bisbn;
        private Button Add;
    }
}