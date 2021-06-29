
namespace _022_CheckBox_RadioButton
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioOrdinary = new System.Windows.Forms.RadioButton();
            this.radioBadWealth = new System.Windows.Forms.RadioButton();
            this.radioPlay = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkPower = new System.Windows.Forms.CheckBox();
            this.checkHandsome = new System.Windows.Forms.CheckBox();
            this.checKMoney = new System.Windows.Forms.CheckBox();
            this.CheckGoodness = new System.Windows.Forms.CheckBox();
            this.btnChoice = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioOrdinary);
            this.groupBox1.Controls.Add(this.radioBadWealth);
            this.groupBox1.Controls.Add(this.radioPlay);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "당신이 되고 싶은 사람은?";
            // 
            // radioOrdinary
            // 
            this.radioOrdinary.AutoSize = true;
            this.radioOrdinary.Location = new System.Drawing.Point(17, 200);
            this.radioOrdinary.Name = "radioOrdinary";
            this.radioOrdinary.Size = new System.Drawing.Size(171, 34);
            this.radioOrdinary.TabIndex = 2;
            this.radioOrdinary.TabStop = true;
            this.radioOrdinary.Text = "평범한 소시민";
            this.radioOrdinary.UseVisualStyleBackColor = true;
            this.radioOrdinary.CheckedChanged += new System.EventHandler(this.radioOrdinary_CheckedChanged);
            // 
            // radioBadWealth
            // 
            this.radioBadWealth.AutoSize = true;
            this.radioBadWealth.Location = new System.Drawing.Point(17, 124);
            this.radioBadWealth.Name = "radioBadWealth";
            this.radioBadWealth.Size = new System.Drawing.Size(332, 34);
            this.radioBadWealth.TabIndex = 1;
            this.radioBadWealth.TabStop = true;
            this.radioBadWealth.Text = "엄청 부자, 다만 성격이 이상함";
            this.radioBadWealth.UseVisualStyleBackColor = true;
            this.radioBadWealth.CheckedChanged += new System.EventHandler(this.radioBadWealth_CheckedChanged);
            // 
            // radioPlay
            // 
            this.radioPlay.AutoSize = true;
            this.radioPlay.Location = new System.Drawing.Point(17, 50);
            this.radioPlay.Name = "radioPlay";
            this.radioPlay.Size = new System.Drawing.Size(223, 34);
            this.radioPlay.TabIndex = 0;
            this.radioPlay.TabStop = true;
            this.radioPlay.Text = "평생 놀다가는 사람";
            this.radioPlay.UseVisualStyleBackColor = true;
            this.radioPlay.CheckedChanged += new System.EventHandler(this.radioPlay_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkPower);
            this.groupBox2.Controls.Add(this.checkHandsome);
            this.groupBox2.Controls.Add(this.checKMoney);
            this.groupBox2.Controls.Add(this.CheckGoodness);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(14, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "당신이 갖고 싶은 것은?";
            // 
            // checkPower
            // 
            this.checkPower.AutoSize = true;
            this.checkPower.Location = new System.Drawing.Point(675, 119);
            this.checkPower.Name = "checkPower";
            this.checkPower.Size = new System.Drawing.Size(54, 34);
            this.checkPower.TabIndex = 10;
            this.checkPower.Text = "힘";
            this.checkPower.UseVisualStyleBackColor = true;
            this.checkPower.CheckedChanged += new System.EventHandler(this.checkPower_CheckedChanged);
            // 
            // checkHandsome
            // 
            this.checkHandsome.AutoSize = true;
            this.checkHandsome.Location = new System.Drawing.Point(469, 119);
            this.checkHandsome.Name = "checkHandsome";
            this.checkHandsome.Size = new System.Drawing.Size(76, 34);
            this.checkHandsome.TabIndex = 5;
            this.checkHandsome.Text = "외모";
            this.checkHandsome.UseVisualStyleBackColor = true;
            this.checkHandsome.CheckedChanged += new System.EventHandler(this.checkHandsome_CheckedChanged);
            // 
            // checKMoney
            // 
            this.checKMoney.AutoSize = true;
            this.checKMoney.Location = new System.Drawing.Point(295, 119);
            this.checKMoney.Name = "checKMoney";
            this.checKMoney.Size = new System.Drawing.Size(54, 34);
            this.checKMoney.TabIndex = 4;
            this.checKMoney.Text = "돈";
            this.checKMoney.UseVisualStyleBackColor = true;
            this.checKMoney.CheckedChanged += new System.EventHandler(this.checKMoney_CheckedChanged);
            // 
            // CheckGoodness
            // 
            this.CheckGoodness.AutoSize = true;
            this.CheckGoodness.Location = new System.Drawing.Point(40, 119);
            this.CheckGoodness.Name = "CheckGoodness";
            this.CheckGoodness.Size = new System.Drawing.Size(128, 34);
            this.CheckGoodness.TabIndex = 3;
            this.CheckGoodness.Text = "착한 성품";
            this.CheckGoodness.UseVisualStyleBackColor = true;
            this.CheckGoodness.CheckedChanged += new System.EventHandler(this.CheckGoodness_CheckedChanged);
            // 
            // btnChoice
            // 
            this.btnChoice.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChoice.Location = new System.Drawing.Point(127, 580);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(480, 72);
            this.btnChoice.TabIndex = 9;
            this.btnChoice.Text = "당신의 선택은?";
            this.btnChoice.UseVisualStyleBackColor = true;
            this.btnChoice.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 761);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnChoice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioOrdinary;
        private System.Windows.Forms.RadioButton radioBadWealth;
        private System.Windows.Forms.RadioButton radioPlay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkHandsome;
        private System.Windows.Forms.Button btnChoice;
        private System.Windows.Forms.CheckBox checKMoney;
        private System.Windows.Forms.CheckBox CheckGoodness;
        private System.Windows.Forms.CheckBox checkPower;
    }
}

