namespace _02test
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblRes = new System.Windows.Forms.Label();
			this.lblComputer = new System.Windows.Forms.Label();
			this.lblPlayer = new System.Windows.Forms.Label();
			this.btnStone = new System.Windows.Forms.Button();
			this.btnCut = new System.Windows.Forms.Button();
			this.btnCloth = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "玩家：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(144, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "结果：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(256, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "电脑：";
			// 
			// lblRes
			// 
			this.lblRes.AutoSize = true;
			this.lblRes.Location = new System.Drawing.Point(237, 152);
			this.lblRes.Name = "lblRes";
			this.lblRes.Size = new System.Drawing.Size(41, 12);
			this.lblRes.TabIndex = 0;
			this.lblRes.Text = "label1";
			// 
			// lblComputer
			// 
			this.lblComputer.AutoSize = true;
			this.lblComputer.Location = new System.Drawing.Point(337, 63);
			this.lblComputer.Name = "lblComputer";
			this.lblComputer.Size = new System.Drawing.Size(41, 12);
			this.lblComputer.TabIndex = 0;
			this.lblComputer.Text = "label1";
			// 
			// lblPlayer
			// 
			this.lblPlayer.AutoSize = true;
			this.lblPlayer.Location = new System.Drawing.Point(128, 63);
			this.lblPlayer.Name = "lblPlayer";
			this.lblPlayer.Size = new System.Drawing.Size(41, 12);
			this.lblPlayer.TabIndex = 0;
			this.lblPlayer.Text = "label1";
			// 
			// btnStone
			// 
			this.btnStone.Location = new System.Drawing.Point(48, 228);
			this.btnStone.Name = "btnStone";
			this.btnStone.Size = new System.Drawing.Size(75, 23);
			this.btnStone.TabIndex = 1;
			this.btnStone.Text = "石头";
			this.btnStone.UseVisualStyleBackColor = true;
			this.btnStone.Click += new System.EventHandler(this.btnStone_Click);
			// 
			// btnCut
			// 
			this.btnCut.Location = new System.Drawing.Point(179, 228);
			this.btnCut.Name = "btnCut";
			this.btnCut.Size = new System.Drawing.Size(75, 23);
			this.btnCut.TabIndex = 1;
			this.btnCut.Text = "剪刀";
			this.btnCut.UseVisualStyleBackColor = true;
			this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
			// 
			// btnCloth
			// 
			this.btnCloth.Location = new System.Drawing.Point(303, 228);
			this.btnCloth.Name = "btnCloth";
			this.btnCloth.Size = new System.Drawing.Size(75, 23);
			this.btnCloth.TabIndex = 1;
			this.btnCloth.Text = "布";
			this.btnCloth.UseVisualStyleBackColor = true;
			this.btnCloth.Click += new System.EventHandler(this.btnCloth_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(479, 359);
			this.Controls.Add(this.btnCloth);
			this.Controls.Add(this.btnCut);
			this.Controls.Add(this.btnStone);
			this.Controls.Add(this.lblComputer);
			this.Controls.Add(this.lblRes);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblPlayer);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblRes;
		private System.Windows.Forms.Label lblComputer;
		private System.Windows.Forms.Label lblPlayer;
		private System.Windows.Forms.Button btnStone;
		private System.Windows.Forms.Button btnCut;
		private System.Windows.Forms.Button btnCloth;
	}
}

