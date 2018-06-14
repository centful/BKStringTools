namespace 批量操作工具
{
    partial class BKYZtools
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
            this.txtContent1 = new System.Windows.Forms.TextBox();
            this.txtContent2 = new System.Windows.Forms.TextBox();
            this.btnProperty = new System.Windows.Forms.Button();
            this.btnReqXML = new System.Windows.Forms.Button();
            this.btnResXML = new System.Windows.Forms.Button();
            this.btnReqCs = new System.Windows.Forms.Button();
            this.btnResCs = new System.Windows.Forms.Button();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtContent1
            // 
            this.txtContent1.Location = new System.Drawing.Point(14, 61);
            this.txtContent1.Multiline = true;
            this.txtContent1.Name = "txtContent1";
            this.txtContent1.Size = new System.Drawing.Size(357, 680);
            this.txtContent1.TabIndex = 0;
            this.txtContent1.Text = "deptId\t\r\ndoctorId\t\r\nregDate\t\r\nregType\t\r\n";
            // 
            // txtContent2
            // 
            this.txtContent2.Location = new System.Drawing.Point(503, 61);
            this.txtContent2.Multiline = true;
            this.txtContent2.Name = "txtContent2";
            this.txtContent2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent2.Size = new System.Drawing.Size(399, 680);
            this.txtContent2.TabIndex = 0;
            // 
            // btnProperty
            // 
            this.btnProperty.Location = new System.Drawing.Point(390, 131);
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.Size = new System.Drawing.Size(91, 44);
            this.btnProperty.TabIndex = 1;
            this.btnProperty.Text = "生成属性";
            this.btnProperty.UseVisualStyleBackColor = true;
            this.btnProperty.Click += new System.EventHandler(this.btnProperty_Click);
            // 
            // btnReqXML
            // 
            this.btnReqXML.Location = new System.Drawing.Point(390, 216);
            this.btnReqXML.Name = "btnReqXML";
            this.btnReqXML.Size = new System.Drawing.Size(91, 44);
            this.btnReqXML.TabIndex = 1;
            this.btnReqXML.Text = "生成请求XML";
            this.btnReqXML.UseVisualStyleBackColor = true;
            this.btnReqXML.Click += new System.EventHandler(this.btnReqXML_Click);
            // 
            // btnResXML
            // 
            this.btnResXML.Location = new System.Drawing.Point(390, 305);
            this.btnResXML.Name = "btnResXML";
            this.btnResXML.Size = new System.Drawing.Size(91, 44);
            this.btnResXML.TabIndex = 1;
            this.btnResXML.Text = "生成回参XML";
            this.btnResXML.UseVisualStyleBackColor = true;
            this.btnResXML.Click += new System.EventHandler(this.btnResXML_Click);
            // 
            // btnReqCs
            // 
            this.btnReqCs.Location = new System.Drawing.Point(383, 389);
            this.btnReqCs.Name = "btnReqCs";
            this.btnReqCs.Size = new System.Drawing.Size(107, 44);
            this.btnReqCs.TabIndex = 1;
            this.btnReqCs.Text = "生成请求类文件";
            this.btnReqCs.UseVisualStyleBackColor = true;
            this.btnReqCs.Click += new System.EventHandler(this.btnReqCs_Click);
            // 
            // btnResCs
            // 
            this.btnResCs.Location = new System.Drawing.Point(384, 466);
            this.btnResCs.Name = "btnResCs";
            this.btnResCs.Size = new System.Drawing.Size(107, 44);
            this.btnResCs.TabIndex = 1;
            this.btnResCs.Text = "生成回参类文件";
            this.btnResCs.UseVisualStyleBackColor = true;
            this.btnResCs.Click += new System.EventHandler(this.btnResCs_Click);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(177, 19);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(194, 21);
            this.txtClass.TabIndex = 2;
            this.txtClass.Text = "GetHospitalList";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "类 名 ：";
            // 
            // BKYZtools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 781);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.btnResCs);
            this.Controls.Add(this.btnReqCs);
            this.Controls.Add(this.btnResXML);
            this.Controls.Add(this.btnReqXML);
            this.Controls.Add(this.btnProperty);
            this.Controls.Add(this.txtContent2);
            this.Controls.Add(this.txtContent1);
            this.Name = "BKYZtools";
            this.Text = "批量操作工具";
            this.Load += new System.EventHandler(this.BKYZtools_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContent1;
        private System.Windows.Forms.TextBox txtContent2;
        private System.Windows.Forms.Button btnProperty;
        private System.Windows.Forms.Button btnReqXML;
        private System.Windows.Forms.Button btnResXML;
        private System.Windows.Forms.Button btnReqCs;
        private System.Windows.Forms.Button btnResCs;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label1;
    }
}

