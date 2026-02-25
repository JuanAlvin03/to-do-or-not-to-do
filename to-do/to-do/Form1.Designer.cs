namespace to_do
{
    partial class Form1
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
            this.add_button = new System.Windows.Forms.Button();
            this.text_input = new System.Windows.Forms.TextBox();
            this.to_do_list = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(362, 19);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 40);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // text_input
            // 
            this.text_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_input.Location = new System.Drawing.Point(80, 24);
            this.text_input.Name = "text_input";
            this.text_input.Size = new System.Drawing.Size(276, 30);
            this.text_input.TabIndex = 1;
            this.text_input.TextChanged += new System.EventHandler(this.text_input_TextChanged);
            // 
            // to_do_list
            // 
            this.to_do_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_do_list.FormattingEnabled = true;
            this.to_do_list.Location = new System.Drawing.Point(12, 65);
            this.to_do_list.Name = "to_do_list";
            this.to_do_list.Size = new System.Drawing.Size(425, 279);
            this.to_do_list.TabIndex = 2;
            this.to_do_list.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.to_do_list_ItemCheck);
            this.to_do_list.SelectedIndexChanged += new System.EventHandler(this.to_do_list_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Task:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.to_do_list);
            this.Controls.Add(this.text_input);
            this.Controls.Add(this.add_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox text_input;
        private System.Windows.Forms.CheckedListBox to_do_list;
        private System.Windows.Forms.Label label1;
    }
}

