namespace _02显示学生表数据
{
	partial class Form1
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
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.txtTSId = new System.Windows.Forms.TextBox();
			this.txtMath = new System.Windows.Forms.TextBox();
			this.txtEnglish = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(596, 262);
			this.dataGridView1.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
			// 
			// tsmiDelete
			// 
			this.tsmiDelete.Name = "tsmiDelete";
			this.tsmiDelete.Size = new System.Drawing.Size(100, 22);
			this.tsmiDelete.Text = "删除";
			this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
			// 
			// txtTSId
			// 
			this.txtTSId.Location = new System.Drawing.Point(99, 280);
			this.txtTSId.Name = "txtTSId";
			this.txtTSId.Size = new System.Drawing.Size(100, 21);
			this.txtTSId.TabIndex = 3;
			// 
			// txtMath
			// 
			this.txtMath.Location = new System.Drawing.Point(99, 334);
			this.txtMath.Name = "txtMath";
			this.txtMath.Size = new System.Drawing.Size(100, 21);
			this.txtMath.TabIndex = 4;
			// 
			// txtEnglish
			// 
			this.txtEnglish.Location = new System.Drawing.Point(99, 307);
			this.txtEnglish.Name = "txtEnglish";
			this.txtEnglish.Size = new System.Drawing.Size(100, 21);
			this.txtEnglish.TabIndex = 5;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(124, 361);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = "增加";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 289);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 12);
			this.label2.TabIndex = 8;
			this.label2.Text = "tSId:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(28, 316);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 12);
			this.label3.TabIndex = 8;
			this.label3.Text = "tSEnglish:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(28, 343);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 12);
			this.label4.TabIndex = 8;
			this.label4.Text = "tSMath:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(620, 447);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtEnglish);
			this.Controls.Add(this.txtMath);
			this.Controls.Add(this.txtTSId);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
		private System.Windows.Forms.TextBox txtTSId;
		private System.Windows.Forms.TextBox txtMath;
		private System.Windows.Forms.TextBox txtEnglish;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}

