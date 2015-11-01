namespace NumGame
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.enter = new System.Windows.Forms.Button();
            this.resultList = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rndNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(128, 49);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 23);
            this.enter.TabIndex = 0;
            this.enter.Text = "確認";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // resultList
            // 
            this.resultList.AutoSize = true;
            this.resultList.Location = new System.Drawing.Point(12, 111);
            this.resultList.Name = "resultList";
            this.resultList.Size = new System.Drawing.Size(53, 12);
            this.resultList.TabIndex = 1;
            this.resultList.Text = "結果清單";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 51);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // rndNum
            // 
            this.rndNum.AutoSize = true;
            this.rndNum.Location = new System.Drawing.Point(12, 22);
            this.rndNum.Name = "rndNum";
            this.rndNum.Size = new System.Drawing.Size(53, 12);
            this.rndNum.TabIndex = 3;
            this.rndNum.Text = "隨機數字";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 477);
            this.Controls.Add(this.rndNum);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.resultList);
            this.Controls.Add(this.enter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label resultList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label rndNum;
    }
}

