
namespace _38_DB_Student
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
            this.lv_table = new System.Windows.Forms.ListView();
            this.columnHeader_cnt = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_name = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_age = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_score = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Age = new System.Windows.Forms.TextBox();
            this.tb_Score = new System.Windows.Forms.TextBox();
            this.btn_DBConnect = new System.Windows.Forms.Button();
            this.btn_DBDisconnect = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lb_Log = new System.Windows.Forms.ListBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_table
            // 
            this.lv_table.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_cnt,
            this.columnHeader_name,
            this.columnHeader_age,
            this.columnHeader_score});
            this.lv_table.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_table.FullRowSelect = true;
            this.lv_table.GridLines = true;
            this.lv_table.HideSelection = false;
            this.lv_table.Location = new System.Drawing.Point(19, 16);
            this.lv_table.Name = "lv_table";
            this.lv_table.Size = new System.Drawing.Size(826, 711);
            this.lv_table.TabIndex = 0;
            this.lv_table.UseCompatibleStateImageBehavior = false;
            this.lv_table.View = System.Windows.Forms.View.Details;
            this.lv_table.SelectedIndexChanged += new System.EventHandler(this.lv_table_SelectedIndexChanged);
            // 
            // columnHeader_cnt
            // 
            this.columnHeader_cnt.Text = "cnt";
            this.columnHeader_cnt.Width = 100;
            // 
            // columnHeader_name
            // 
            this.columnHeader_name.Text = "name";
            this.columnHeader_name.Width = 300;
            // 
            // columnHeader_age
            // 
            this.columnHeader_age.Text = "age";
            this.columnHeader_age.Width = 200;
            // 
            // columnHeader_score
            // 
            this.columnHeader_score.Text = "score";
            this.columnHeader_score.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(977, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(977, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(977, 672);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 45);
            this.label3.TabIndex = 1;
            this.label3.Text = "Score";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Name.Location = new System.Drawing.Point(1121, 456);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(264, 50);
            this.tb_Name.TabIndex = 2;
            // 
            // tb_Age
            // 
            this.tb_Age.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Age.Location = new System.Drawing.Point(1121, 562);
            this.tb_Age.Name = "tb_Age";
            this.tb_Age.Size = new System.Drawing.Size(264, 50);
            this.tb_Age.TabIndex = 2;
            // 
            // tb_Score
            // 
            this.tb_Score.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Score.Location = new System.Drawing.Point(1121, 667);
            this.tb_Score.Name = "tb_Score";
            this.tb_Score.Size = new System.Drawing.Size(264, 50);
            this.tb_Score.TabIndex = 2;
            // 
            // btn_DBConnect
            // 
            this.btn_DBConnect.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DBConnect.Location = new System.Drawing.Point(19, 766);
            this.btn_DBConnect.Name = "btn_DBConnect";
            this.btn_DBConnect.Size = new System.Drawing.Size(239, 64);
            this.btn_DBConnect.TabIndex = 3;
            this.btn_DBConnect.Text = "DB Connect";
            this.btn_DBConnect.UseVisualStyleBackColor = true;
            this.btn_DBConnect.Click += new System.EventHandler(this.btn_DBConnect_Click);
            // 
            // btn_DBDisconnect
            // 
            this.btn_DBDisconnect.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DBDisconnect.Location = new System.Drawing.Point(277, 766);
            this.btn_DBDisconnect.Name = "btn_DBDisconnect";
            this.btn_DBDisconnect.Size = new System.Drawing.Size(295, 64);
            this.btn_DBDisconnect.TabIndex = 3;
            this.btn_DBDisconnect.Text = "DB Disconnect";
            this.btn_DBDisconnect.UseVisualStyleBackColor = true;
            this.btn_DBDisconnect.Click += new System.EventHandler(this.btn_DBDisconnect_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Select.Location = new System.Drawing.Point(590, 766);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(140, 64);
            this.btn_Select.TabIndex = 3;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Delete.Location = new System.Drawing.Point(1251, 766);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(134, 64);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lb_Log
            // 
            this.lb_Log.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Log.FormattingEnabled = true;
            this.lb_Log.ItemHeight = 45;
            this.lb_Log.Location = new System.Drawing.Point(868, 17);
            this.lb_Log.Name = "lb_Log";
            this.lb_Log.Size = new System.Drawing.Size(516, 364);
            this.lb_Log.TabIndex = 4;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Insert.Location = new System.Drawing.Point(753, 766);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(211, 64);
            this.btn_Insert.TabIndex = 3;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Update.Location = new System.Drawing.Point(1001, 766);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(211, 64);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 863);
            this.Controls.Add(this.lb_Log);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_DBDisconnect);
            this.Controls.Add(this.btn_DBConnect);
            this.Controls.Add(this.tb_Score);
            this.Controls.Add(this.tb_Age);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_table);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_table;
        private System.Windows.Forms.ColumnHeader columnHeader_cnt;
        private System.Windows.Forms.ColumnHeader columnHeader_name;
        private System.Windows.Forms.ColumnHeader columnHeader_age;
        private System.Windows.Forms.ColumnHeader columnHeader_score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Age;
        private System.Windows.Forms.TextBox tb_Score;
        private System.Windows.Forms.Button btn_DBConnect;
        private System.Windows.Forms.Button btn_DBDisconnect;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ListBox lb_Log;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
    }
}

