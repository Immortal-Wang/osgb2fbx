namespace osgb2fbx
{
    partial class 数据转换器
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(数据转换器));
            this.btn_datapath = new System.Windows.Forms.Button();
            this.btn_outpath = new System.Windows.Forms.Button();
            this.btn_exchange = new System.Windows.Forms.Button();
            this.txt_datapath = new System.Windows.Forms.TextBox();
            this.txt_outpath = new System.Windows.Forms.TextBox();
            this.pb_exc = new System.Windows.Forms.ProgressBar();
            this.lbl_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_datapath
            // 
            this.btn_datapath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_datapath.Location = new System.Drawing.Point(19, 23);
            this.btn_datapath.Name = "btn_datapath";
            this.btn_datapath.Size = new System.Drawing.Size(113, 34);
            this.btn_datapath.TabIndex = 0;
            this.btn_datapath.Text = "input path";
            this.btn_datapath.UseVisualStyleBackColor = true;
            this.btn_datapath.Click += new System.EventHandler(this.btn_datapath_Click);
            // 
            // btn_outpath
            // 
            this.btn_outpath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_outpath.Location = new System.Drawing.Point(19, 63);
            this.btn_outpath.Name = "btn_outpath";
            this.btn_outpath.Size = new System.Drawing.Size(113, 34);
            this.btn_outpath.TabIndex = 0;
            this.btn_outpath.Text = "out path";
            this.btn_outpath.UseVisualStyleBackColor = true;
            this.btn_outpath.Click += new System.EventHandler(this.btn_outpath_Click);
            // 
            // btn_exchange
            // 
            this.btn_exchange.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exchange.Location = new System.Drawing.Point(19, 119);
            this.btn_exchange.Name = "btn_exchange";
            this.btn_exchange.Size = new System.Drawing.Size(453, 104);
            this.btn_exchange.TabIndex = 0;
            this.btn_exchange.Text = "convert";
            this.btn_exchange.UseVisualStyleBackColor = true;
            this.btn_exchange.Click += new System.EventHandler(this.btn_exchange_Click);
            // 
            // txt_datapath
            // 
            this.txt_datapath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_datapath.Location = new System.Drawing.Point(159, 27);
            this.txt_datapath.Name = "txt_datapath";
            this.txt_datapath.Size = new System.Drawing.Size(313, 26);
            this.txt_datapath.TabIndex = 1;
            // 
            // txt_outpath
            // 
            this.txt_outpath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_outpath.Location = new System.Drawing.Point(159, 67);
            this.txt_outpath.Name = "txt_outpath";
            this.txt_outpath.Size = new System.Drawing.Size(313, 26);
            this.txt_outpath.TabIndex = 1;
            // 
            // pb_exc
            // 
            this.pb_exc.Location = new System.Drawing.Point(19, 244);
            this.pb_exc.Name = "pb_exc";
            this.pb_exc.Size = new System.Drawing.Size(453, 10);
            this.pb_exc.TabIndex = 2;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(22, 228);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 12);
            this.lbl_status.TabIndex = 3;
            // 
            // 数据转换器
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 266);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.pb_exc);
            this.Controls.Add(this.txt_outpath);
            this.Controls.Add(this.txt_datapath);
            this.Controls.Add(this.btn_exchange);
            this.Controls.Add(this.btn_outpath);
            this.Controls.Add(this.btn_datapath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "数据转换器";
            this.Text = "osgb2fbxV0.1";
            this.Load += new System.EventHandler(this.数据转换器_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_datapath;
        private System.Windows.Forms.Button btn_outpath;
        private System.Windows.Forms.Button btn_exchange;
        private System.Windows.Forms.TextBox txt_datapath;
        private System.Windows.Forms.TextBox txt_outpath;
        private System.Windows.Forms.ProgressBar pb_exc;
        private System.Windows.Forms.Label lbl_status;
    }
}

