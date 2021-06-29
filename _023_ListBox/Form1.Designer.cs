
namespace _23_ListBox
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
            this.lb_text = new System.Windows.Forms.ListBox();
            this.tb_text = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_text
            // 
            this.lb_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_text.FormattingEnabled = true;
            this.lb_text.ItemHeight = 25;
            this.lb_text.Location = new System.Drawing.Point(28, 29);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(731, 329);
            this.lb_text.TabIndex = 2;
            this.lb_text.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_text_MouseDoubleClick);
            // 
            // tb_text
            // 
            this.tb_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_text.Location = new System.Drawing.Point(28, 386);
            this.tb_text.Name = "tb_text";
            this.tb_text.Size = new System.Drawing.Size(598, 31);
            this.tb_text.TabIndex = 0;
            this.tb_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_text_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(662, 373);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 57);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tb_text);
            this.Controls.Add(this.lb_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_text;
        private System.Windows.Forms.TextBox tb_text;
        private System.Windows.Forms.Button btnAdd;
    }
}

