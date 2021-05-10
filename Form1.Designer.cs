namespace MessageDialogForm
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNotice = new System.Windows.Forms.Button();
            this.buttonError = new System.Windows.Forms.Button();
            this.buttonWarn = new System.Windows.Forms.Button();
            this.labelNotice = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.labelWarn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNotice
            // 
            this.buttonNotice.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonNotice.Location = new System.Drawing.Point(105, 88);
            this.buttonNotice.Name = "buttonNotice";
            this.buttonNotice.Size = new System.Drawing.Size(76, 32);
            this.buttonNotice.TabIndex = 0;
            this.buttonNotice.Text = "通知";
            this.buttonNotice.UseVisualStyleBackColor = true;
            this.buttonNotice.Click += new System.EventHandler(this.buttonNotice_Click);
            // 
            // buttonError
            // 
            this.buttonError.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonError.Location = new System.Drawing.Point(315, 88);
            this.buttonError.Name = "buttonError";
            this.buttonError.Size = new System.Drawing.Size(76, 32);
            this.buttonError.TabIndex = 1;
            this.buttonError.Text = "異常";
            this.buttonError.UseVisualStyleBackColor = true;
            this.buttonError.Click += new System.EventHandler(this.buttonError_Click);
            // 
            // buttonWarn
            // 
            this.buttonWarn.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonWarn.Location = new System.Drawing.Point(525, 88);
            this.buttonWarn.Name = "buttonWarn";
            this.buttonWarn.Size = new System.Drawing.Size(76, 32);
            this.buttonWarn.TabIndex = 2;
            this.buttonWarn.Text = "警告";
            this.buttonWarn.UseVisualStyleBackColor = true;
            this.buttonWarn.Click += new System.EventHandler(this.buttonWarn_Click);
            // 
            // labelNotice
            // 
            this.labelNotice.AutoSize = true;
            this.labelNotice.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelNotice.Location = new System.Drawing.Point(105, 152);
            this.labelNotice.Name = "labelNotice";
            this.labelNotice.Size = new System.Drawing.Size(73, 20);
            this.labelNotice.TabIndex = 3;
            this.labelNotice.Text = "通知操作";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelError.Location = new System.Drawing.Point(311, 152);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(73, 20);
            this.labelError.TabIndex = 4;
            this.labelError.Text = "異常操作";
            // 
            // labelWarn
            // 
            this.labelWarn.AutoSize = true;
            this.labelWarn.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelWarn.Location = new System.Drawing.Point(521, 152);
            this.labelWarn.Name = "labelWarn";
            this.labelWarn.Size = new System.Drawing.Size(73, 20);
            this.labelWarn.TabIndex = 5;
            this.labelWarn.Text = "警告操作";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 264);
            this.Controls.Add(this.labelWarn);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelNotice);
            this.Controls.Add(this.buttonWarn);
            this.Controls.Add(this.buttonError);
            this.Controls.Add(this.buttonNotice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNotice;
        private System.Windows.Forms.Button buttonError;
        private System.Windows.Forms.Button buttonWarn;
        private System.Windows.Forms.Label labelNotice;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelWarn;
    }
}

