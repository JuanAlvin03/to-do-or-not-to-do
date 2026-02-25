namespace to_do_new
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
            add_button = new Button();
            label1 = new Label();
            text_input = new TextBox();
            to_do_list = new CheckedListBox();
            SuspendLayout();
            // 
            // add_button
            // 
            add_button.Font = new Font("Segoe UI", 12F);
            add_button.Location = new Point(426, 13);
            add_button.Name = "add_button";
            add_button.Size = new Size(83, 50);
            add_button.TabIndex = 0;
            add_button.Text = "Add";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(52, 28);
            label1.TabIndex = 1;
            label1.Text = "Task:";
            // 
            // text_input
            // 
            text_input.Font = new Font("Segoe UI", 12F);
            text_input.Location = new Point(80, 21);
            text_input.Name = "text_input";
            text_input.Size = new Size(340, 34);
            text_input.TabIndex = 2;
            text_input.Enter += text_input_Enter;
            text_input.KeyDown += text_input_KeyDown;
            // 
            // to_do_list
            // 
            to_do_list.Font = new Font("Segoe UI", 12F);
            to_do_list.FormattingEnabled = true;
            to_do_list.Location = new Point(22, 77);
            to_do_list.Name = "to_do_list";
            to_do_list.Size = new Size(487, 323);
            to_do_list.TabIndex = 3;
            to_do_list.ItemCheck += to_do_list_ItemCheck;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 425);
            Controls.Add(to_do_list);
            Controls.Add(text_input);
            Controls.Add(label1);
            Controls.Add(add_button);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add_button;
        private Label label1;
        private TextBox text_input;
        private CheckedListBox to_do_list;
    }
}
