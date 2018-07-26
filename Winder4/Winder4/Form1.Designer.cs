namespace Winder4
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.pathEdit = new System.Windows.Forms.TextBox();
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // pathEdit
            // 
            this.pathEdit.Location = new System.Drawing.Point(12, 12);
            this.pathEdit.Name = "pathEdit";
            this.pathEdit.Size = new System.Drawing.Size(927, 25);
            this.pathEdit.TabIndex = 0;
            this.pathEdit.TextChanged += new System.EventHandler(this.PathEdit_TextChanged);
            this.pathEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PathEdit_KeyDown);
            // 
            // filesListBox
            // 
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.ItemHeight = 18;
            this.filesListBox.Location = new System.Drawing.Point(12, 43);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(927, 508);
            this.filesListBox.TabIndex = 1;
            this.filesListBox.DoubleClick += new System.EventHandler(this.filesListBox_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 552);
            this.Controls.Add(this.filesListBox);
            this.Controls.Add(this.pathEdit);
            this.Name = "Form1";
            this.Text = "Winder4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathEdit;
        private System.Windows.Forms.ListBox filesListBox;
    }
}

