namespace Hameed
{
    partial class borrow
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
            borrowname = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            available = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 125);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Book Name";
            // 
            // borrowname
            // 
            borrowname.Location = new Point(246, 122);
            borrowname.Name = "borrowname";
            borrowname.Size = new Size(267, 27);
            borrowname.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(393, 221);
            button1.Name = "button1";
            button1.Size = new Size(163, 56);
            button1.TabIndex = 2;
            button1.Text = "Borrow Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(129, 221);
            button2.Name = "button2";
            button2.Size = new Size(163, 56);
            button2.TabIndex = 3;
            button2.Text = "Check Availability";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 165);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 4;
            label2.Text = "Available";
            // 
            // available
            // 
            available.Location = new Point(246, 167);
            available.Name = "available";
            available.ReadOnly = true;
            available.Size = new Size(267, 27);
            available.TabIndex = 5;
            // 
            // borrow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(800, 450);
            Controls.Add(available);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(borrowname);
            Controls.Add(label1);
            Name = "borrow";
            Text = "borrow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox borrowname;
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox available;
    }
}