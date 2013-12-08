namespace _05新版增删改查
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
			if (disposing && (components != null))
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
			this.dGV = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.rbMan = new System.Windows.Forms.RadioButton();
			this.rbWoman = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtClassId = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.gbUpdate = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtUpName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.rdoUpMan = new System.Windows.Forms.RadioButton();
			this.rdoUpWoman = new System.Windows.Forms.RadioButton();
			this.label8 = new System.Windows.Forms.Label();
			this.txtUpAge = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtUpClassId = new System.Windows.Forms.TextBox();
			this.btnUp = new System.Windows.Forms.Button();
			this.lblId = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
			this.gbUpdate.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dGV
			// 
			this.dGV.AllowUserToAddRows = false;
			this.dGV.AllowUserToDeleteRows = false;
			this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dGV.ContextMenuStrip = this.contextMenuStrip1;
			this.dGV.Location = new System.Drawing.Point(12, 12);
			this.dGV.Name = "dGV";
			this.dGV.ReadOnly = true;
			this.dGV.RowTemplate.Height = 23;
			this.dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGV.Size = new System.Drawing.Size(382, 246);
			this.dGV.TabIndex = 0;
			this.dGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_RowEnter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(400, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "姓名";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(448, 54);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(162, 21);
			this.txtName.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(400, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "性别";
			// 
			// rbMan
			// 
			this.rbMan.AutoSize = true;
			this.rbMan.Location = new System.Drawing.Point(448, 81);
			this.rbMan.Name = "rbMan";
			this.rbMan.Size = new System.Drawing.Size(35, 16);
			this.rbMan.TabIndex = 3;
			this.rbMan.TabStop = true;
			this.rbMan.Text = "男";
			this.rbMan.UseVisualStyleBackColor = true;
			// 
			// rbWoman
			// 
			this.rbWoman.AutoSize = true;
			this.rbWoman.Location = new System.Drawing.Point(499, 81);
			this.rbWoman.Name = "rbWoman";
			this.rbWoman.Size = new System.Drawing.Size(35, 16);
			this.rbWoman.TabIndex = 4;
			this.rbWoman.TabStop = true;
			this.rbWoman.Text = "女";
			this.rbWoman.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(400, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 1;
			this.label3.Text = "年龄";
			// 
			// txtAge
			// 
			this.txtAge.Location = new System.Drawing.Point(448, 112);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(162, 21);
			this.txtAge.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(400, 142);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 12);
			this.label4.TabIndex = 1;
			this.label4.Text = "班级id";
			// 
			// txtClassId
			// 
			this.txtClassId.Location = new System.Drawing.Point(448, 139);
			this.txtClassId.Name = "txtClassId";
			this.txtClassId.Size = new System.Drawing.Size(162, 21);
			this.txtClassId.TabIndex = 2;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(535, 166);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "添加";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// gbUpdate
			// 
			this.gbUpdate.Controls.Add(this.label6);
			this.gbUpdate.Controls.Add(this.btnUp);
			this.gbUpdate.Controls.Add(this.label5);
			this.gbUpdate.Controls.Add(this.rdoUpWoman);
			this.gbUpdate.Controls.Add(this.rdoUpMan);
			this.gbUpdate.Controls.Add(this.txtUpClassId);
			this.gbUpdate.Controls.Add(this.txtUpName);
			this.gbUpdate.Controls.Add(this.lblId);
			this.gbUpdate.Controls.Add(this.label9);
			this.gbUpdate.Controls.Add(this.txtUpAge);
			this.gbUpdate.Controls.Add(this.label7);
			this.gbUpdate.Controls.Add(this.label8);
			this.gbUpdate.Location = new System.Drawing.Point(14, 273);
			this.gbUpdate.Name = "gbUpdate";
			this.gbUpdate.Size = new System.Drawing.Size(469, 125);
			this.gbUpdate.TabIndex = 6;
			this.gbUpdate.TabStop = false;
			this.gbUpdate.Text = "修改";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 29);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 12);
			this.label5.TabIndex = 1;
			this.label5.Text = "姓名";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(-364, 309);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 12);
			this.label6.TabIndex = 1;
			this.label6.Text = "姓名";
			// 
			// txtUpName
			// 
			this.txtUpName.Location = new System.Drawing.Point(55, 26);
			this.txtUpName.Name = "txtUpName";
			this.txtUpName.Size = new System.Drawing.Size(162, 21);
			this.txtUpName.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 75);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 12);
			this.label7.TabIndex = 1;
			this.label7.Text = "性别";
			// 
			// rdoUpMan
			// 
			this.rdoUpMan.AutoSize = true;
			this.rdoUpMan.Location = new System.Drawing.Point(43, 75);
			this.rdoUpMan.Name = "rdoUpMan";
			this.rdoUpMan.Size = new System.Drawing.Size(35, 16);
			this.rdoUpMan.TabIndex = 3;
			this.rdoUpMan.TabStop = true;
			this.rdoUpMan.Text = "男";
			this.rdoUpMan.UseVisualStyleBackColor = true;
			// 
			// rdoUpWoman
			// 
			this.rdoUpWoman.AutoSize = true;
			this.rdoUpWoman.Location = new System.Drawing.Point(94, 75);
			this.rdoUpWoman.Name = "rdoUpWoman";
			this.rdoUpWoman.Size = new System.Drawing.Size(35, 16);
			this.rdoUpWoman.TabIndex = 4;
			this.rdoUpWoman.TabStop = true;
			this.rdoUpWoman.Text = "女";
			this.rdoUpWoman.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(237, 29);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(29, 12);
			this.label8.TabIndex = 1;
			this.label8.Text = "年龄";
			// 
			// txtUpAge
			// 
			this.txtUpAge.Location = new System.Drawing.Point(285, 26);
			this.txtUpAge.Name = "txtUpAge";
			this.txtUpAge.Size = new System.Drawing.Size(162, 21);
			this.txtUpAge.TabIndex = 2;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(237, 69);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(41, 12);
			this.label9.TabIndex = 1;
			this.label9.Text = "班级id";
			// 
			// txtUpClassId
			// 
			this.txtUpClassId.Location = new System.Drawing.Point(285, 66);
			this.txtUpClassId.Name = "txtUpClassId";
			this.txtUpClassId.Size = new System.Drawing.Size(162, 21);
			this.txtUpClassId.TabIndex = 2;
			// 
			// btnUp
			// 
			this.btnUp.Location = new System.Drawing.Point(372, 93);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(75, 23);
			this.btnUp.TabIndex = 5;
			this.btnUp.Text = "修改";
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(159, 93);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(0, 12);
			this.lblId.TabIndex = 1;
			this.lblId.Visible = false;
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
			this.tsmiDelete.Size = new System.Drawing.Size(152, 22);
			this.tsmiDelete.Text = "删除";
			this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 405);
			this.Controls.Add(this.gbUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.rbWoman);
			this.Controls.Add(this.rbMan);
			this.Controls.Add(this.txtClassId);
			this.Controls.Add(this.txtAge);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dGV);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
			this.gbUpdate.ResumeLayout(false);
			this.gbUpdate.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dGV;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rbMan;
		private System.Windows.Forms.RadioButton rbWoman;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtClassId;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.GroupBox gbUpdate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnUp;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton rdoUpWoman;
		private System.Windows.Forms.RadioButton rdoUpMan;
		private System.Windows.Forms.TextBox txtUpClassId;
		private System.Windows.Forms.TextBox txtUpName;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtUpAge;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
	}
}

