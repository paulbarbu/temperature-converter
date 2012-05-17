namespace WindowsFormsApplication1 {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.cBox = new System.Windows.Forms.TextBox();
			this.fBox = new System.Windows.Forms.TextBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnCnVert = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.kBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cfk = new System.Windows.Forms.RadioButton();
			this.fck = new System.Windows.Forms.RadioButton();
			this.kcf = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cBox
			// 
			this.cBox.Location = new System.Drawing.Point(35, 20);
			this.cBox.Name = "cBox";
			this.cBox.Size = new System.Drawing.Size(216, 20);
			this.cBox.TabIndex = 0;
			this.cBox.TextChanged += new System.EventHandler(this.cBox_TextChanged);
			// 
			// fBox
			// 
			this.fBox.Location = new System.Drawing.Point(35, 46);
			this.fBox.Name = "fBox";
			this.fBox.Size = new System.Drawing.Size(216, 20);
			this.fBox.TabIndex = 1;
			this.fBox.TextChanged += new System.EventHandler(this.fBox_TextChanged);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(75, 98);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(116, 23);
			this.btnClear.TabIndex = 2;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnCnVert
			// 
			this.btnCnVert.Location = new System.Drawing.Point(-10, 124);
			this.btnCnVert.Name = "btnCnVert";
			this.btnCnVert.Size = new System.Drawing.Size(116, 23);
			this.btnCnVert.TabIndex = 2;
			this.btnCnVert.Text = "Convert";
			this.btnCnVert.UseVisualStyleBackColor = true;
			this.btnCnVert.Visible = false;
			this.btnCnVert.Click += new System.EventHandler(this.btnCnVert_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(19, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "C:";
			// 
			// kBox
			// 
			this.kBox.Location = new System.Drawing.Point(35, 72);
			this.kBox.Name = "kBox";
			this.kBox.Size = new System.Drawing.Size(216, 20);
			this.kBox.TabIndex = 1;
			this.kBox.TextChanged += new System.EventHandler(this.kBox_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(19, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "K:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(18, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "F:";
			// 
			// cfk
			// 
			this.cfk.AutoSize = true;
			this.cfk.Location = new System.Drawing.Point(-1, 0);
			this.cfk.Name = "cfk";
			this.cfk.Size = new System.Drawing.Size(57, 17);
			this.cfk.TabIndex = 4;
			this.cfk.TabStop = true;
			this.cfk.Text = "C->F-K";
			this.cfk.UseVisualStyleBackColor = true;
			this.cfk.Visible = false;
			this.cfk.CheckedChanged += new System.EventHandler(this.cfk_CheckedChanged_1);
			// 
			// fck
			// 
			this.fck.AutoSize = true;
			this.fck.Location = new System.Drawing.Point(62, 0);
			this.fck.Name = "fck";
			this.fck.Size = new System.Drawing.Size(57, 17);
			this.fck.TabIndex = 4;
			this.fck.TabStop = true;
			this.fck.Text = "F->C-K";
			this.fck.UseVisualStyleBackColor = true;
			this.fck.Visible = false;
			this.fck.CheckedChanged += new System.EventHandler(this.fck_CheckedChanged_1);
			// 
			// kcf
			// 
			this.kcf.AutoSize = true;
			this.kcf.Location = new System.Drawing.Point(125, 0);
			this.kcf.Name = "kcf";
			this.kcf.Size = new System.Drawing.Size(57, 17);
			this.kcf.TabIndex = 4;
			this.kcf.TabStop = true;
			this.kcf.Text = "K->C-F";
			this.kcf.UseVisualStyleBackColor = true;
			this.kcf.Visible = false;
			this.kcf.CheckedChanged += new System.EventHandler(this.kcf_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label2.Location = new System.Drawing.Point(197, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(263, 125);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.kcf);
			this.Controls.Add(this.fck);
			this.Controls.Add(this.cfk);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCnVert);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.kBox);
			this.Controls.Add(this.fBox);
			this.Controls.Add(this.cBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Temperature CnVerter";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox cBox;
		private System.Windows.Forms.TextBox fBox;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnCnVert;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox kBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton cfk;
		private System.Windows.Forms.RadioButton fck;
		private System.Windows.Forms.RadioButton kcf;
		private System.Windows.Forms.Label label2;
	}
}

