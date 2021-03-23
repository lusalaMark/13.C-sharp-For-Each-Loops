namespace _13.C_sharp_For_Each_Loops
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblNumbers = new System.Windows.Forms.Label();
			this.lblLetters = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblNumbers
			// 
			this.lblNumbers.AutoSize = true;
			this.lblNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
			this.lblNumbers.Location = new System.Drawing.Point(507, 204);
			this.lblNumbers.Name = "lblNumbers";
			this.lblNumbers.Size = new System.Drawing.Size(0, 63);
			this.lblNumbers.TabIndex = 9;
			// 
			// lblLetters
			// 
			this.lblLetters.AutoSize = true;
			this.lblLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
			this.lblLetters.Location = new System.Drawing.Point(12, 204);
			this.lblLetters.Name = "lblLetters";
			this.lblLetters.Size = new System.Drawing.Size(0, 63);
			this.lblLetters.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
			this.label2.Location = new System.Drawing.Point(507, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(246, 63);
			this.label2.TabIndex = 7;
			this.label2.Text = "Numbers";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
			this.label1.Location = new System.Drawing.Point(12, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(192, 63);
			this.label1.TabIndex = 6;
			this.label1.Text = "Letters";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
			this.textBox1.Location = new System.Drawing.Point(12, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(829, 68);
			this.textBox1.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(855, 450);
			this.Controls.Add(this.lblNumbers);
			this.Controls.Add(this.lblLetters);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNumbers;
		private System.Windows.Forms.Label lblLetters;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
	}
}

