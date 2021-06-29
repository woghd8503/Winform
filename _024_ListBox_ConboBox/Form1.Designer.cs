
namespace _24_ListBox_ConboBox
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
            this.lb_Left = new System.Windows.Forms.ListBox();
            this.cb_Right = new System.Windows.Forms.ComboBox();
            this.btnComboToList = new System.Windows.Forms.Button();
            this.btnListToCombo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Left
            // 
            this.lb_Left.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Left.FormattingEnabled = true;
            this.lb_Left.ItemHeight = 45;
            this.lb_Left.Location = new System.Drawing.Point(35, 34);
            this.lb_Left.Name = "lb_Left";
            this.lb_Left.Size = new System.Drawing.Size(405, 364);
            this.lb_Left.TabIndex = 0;
            // 
            // cb_Right
            // 
            this.cb_Right.DropDownHeight = 200;
            this.cb_Right.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_Right.FormattingEnabled = true;
            this.cb_Right.IntegralHeight = false;
            this.cb_Right.Location = new System.Drawing.Point(504, 37);
            this.cb_Right.Name = "cb_Right";
            this.cb_Right.Size = new System.Drawing.Size(285, 45);
            this.cb_Right.TabIndex = 1;
            // 
            // btnComboToList
            // 
            this.btnComboToList.AccessibleName = "btnListToCombo";
            this.btnComboToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnComboToList.Location = new System.Drawing.Point(507, 283);
            this.btnComboToList.Name = "btnComboToList";
            this.btnComboToList.Size = new System.Drawing.Size(127, 56);
            this.btnComboToList.TabIndex = 3;
            this.btnComboToList.Text = "<<";
            this.btnComboToList.UseVisualStyleBackColor = true;
            this.btnComboToList.Click += new System.EventHandler(this.btnComboToList_Click);
            // 
            // btnListToCombo
            // 
            this.btnListToCombo.AccessibleName = "";
            this.btnListToCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListToCombo.Location = new System.Drawing.Point(505, 167);
            this.btnListToCombo.Name = "btnListToCombo";
            this.btnListToCombo.Size = new System.Drawing.Size(127, 58);
            this.btnListToCombo.TabIndex = 5;
            this.btnListToCombo.Text = ">>";
            this.btnListToCombo.UseVisualStyleBackColor = true;
            this.btnListToCombo.Click += new System.EventHandler(this.btnListToCombo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.btnListToCombo);
            this.Controls.Add(this.btnComboToList);
            this.Controls.Add(this.cb_Right);
            this.Controls.Add(this.lb_Left);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Left;
        private System.Windows.Forms.ComboBox cb_Right;
        private System.Windows.Forms.Button btnComboToList;
        private System.Windows.Forms.Button btnListToCombo;
    }
}

