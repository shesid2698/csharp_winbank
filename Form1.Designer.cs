namespace winBank
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.la_name1 = new System.Windows.Forms.Label();
            this.tb_myaccount = new System.Windows.Forms.TextBox();
            this.tb_account = new System.Windows.Forms.TextBox();
            this.la_account = new System.Windows.Forms.Label();
            this.tb_money = new System.Windows.Forms.TextBox();
            this.la_money = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.la_list = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // la_name1
            // 
            this.la_name1.AutoSize = true;
            this.la_name1.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.la_name1.Location = new System.Drawing.Point(83, 69);
            this.la_name1.Name = "la_name1";
            this.la_name1.Size = new System.Drawing.Size(102, 23);
            this.la_name1.TabIndex = 1;
            this.la_name1.Text = "你的帳號";
            // 
            // tb_myaccount
            // 
            this.tb_myaccount.Location = new System.Drawing.Point(191, 62);
            this.tb_myaccount.Multiline = true;
            this.tb_myaccount.Name = "tb_myaccount";
            this.tb_myaccount.Size = new System.Drawing.Size(121, 30);
            this.tb_myaccount.TabIndex = 2;
            // 
            // tb_account
            // 
            this.tb_account.Location = new System.Drawing.Point(191, 123);
            this.tb_account.Multiline = true;
            this.tb_account.Name = "tb_account";
            this.tb_account.Size = new System.Drawing.Size(121, 30);
            this.tb_account.TabIndex = 4;
            // 
            // la_account
            // 
            this.la_account.AutoSize = true;
            this.la_account.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.la_account.Location = new System.Drawing.Point(83, 130);
            this.la_account.Name = "la_account";
            this.la_account.Size = new System.Drawing.Size(102, 23);
            this.la_account.TabIndex = 3;
            this.la_account.Text = "轉入帳號";
            // 
            // tb_money
            // 
            this.tb_money.Location = new System.Drawing.Point(556, 123);
            this.tb_money.Multiline = true;
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(121, 30);
            this.tb_money.TabIndex = 6;
            // 
            // la_money
            // 
            this.la_money.AutoSize = true;
            this.la_money.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.la_money.Location = new System.Drawing.Point(448, 130);
            this.la_money.Name = "la_money";
            this.la_money.Size = new System.Drawing.Size(102, 23);
            this.la_money.TabIndex = 5;
            this.la_money.Text = "轉入金額";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(452, 61);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(225, 31);
            this.btn_submit.TabIndex = 7;
            this.btn_submit.Text = "轉帳";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // la_list
            // 
            this.la_list.AutoSize = true;
            this.la_list.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.la_list.Location = new System.Drawing.Point(83, 195);
            this.la_list.Name = "la_list";
            this.la_list.Size = new System.Drawing.Size(102, 23);
            this.la_list.TabIndex = 8;
            this.la_list.Text = "帳戶明細";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(191, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(486, 260);
            this.dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.la_list);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.tb_money);
            this.Controls.Add(this.la_money);
            this.Controls.Add(this.tb_account);
            this.Controls.Add(this.la_account);
            this.Controls.Add(this.tb_myaccount);
            this.Controls.Add(this.la_name1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label la_name1;
        private System.Windows.Forms.TextBox tb_myaccount;
        private System.Windows.Forms.TextBox tb_account;
        private System.Windows.Forms.Label la_account;
        private System.Windows.Forms.TextBox tb_money;
        private System.Windows.Forms.Label la_money;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label la_list;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

