
namespace ClientReservasi_040
{
	partial class Register
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
			this.comboBoxKategori = new System.Windows.Forms.ComboBox();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.textBoxUsername = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btSimpan = new System.Windows.Forms.Button();
			this.btUpdate = new System.Windows.Forms.Button();
			this.btHapus = new System.Windows.Forms.Button();
			this.btClear = new System.Windows.Forms.Button();
			this.dtRegister = new System.Windows.Forms.DataGridView();
			this.textBoxID = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dtRegister)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBoxKategori
			// 
			this.comboBoxKategori.FormattingEnabled = true;
			this.comboBoxKategori.Items.AddRange(new object[] {
            "Admin",
            "Resepsionis"});
			this.comboBoxKategori.Location = new System.Drawing.Point(243, 186);
			this.comboBoxKategori.Name = "comboBoxKategori";
			this.comboBoxKategori.Size = new System.Drawing.Size(214, 28);
			this.comboBoxKategori.TabIndex = 0;
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.Location = new System.Drawing.Point(243, 28);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(214, 26);
			this.textBoxUsername.TabIndex = 1;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(243, 106);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(214, 26);
			this.textBoxPassword.TabIndex = 2;
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(38, 31);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(83, 20);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(38, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(38, 186);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Kategori";
			// 
			// btSimpan
			// 
			this.btSimpan.Location = new System.Drawing.Point(581, 53);
			this.btSimpan.Name = "btSimpan";
			this.btSimpan.Size = new System.Drawing.Size(75, 27);
			this.btSimpan.TabIndex = 6;
			this.btSimpan.Text = "Simpan";
			this.btSimpan.UseVisualStyleBackColor = true;
			this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
			// 
			// btUpdate
			// 
			this.btUpdate.Location = new System.Drawing.Point(581, 96);
			this.btUpdate.Name = "btUpdate";
			this.btUpdate.Size = new System.Drawing.Size(75, 30);
			this.btUpdate.TabIndex = 7;
			this.btUpdate.Text = "Update";
			this.btUpdate.UseVisualStyleBackColor = true;
			this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
			// 
			// btHapus
			// 
			this.btHapus.Location = new System.Drawing.Point(581, 141);
			this.btHapus.Name = "btHapus";
			this.btHapus.Size = new System.Drawing.Size(75, 31);
			this.btHapus.TabIndex = 8;
			this.btHapus.Text = "Hapus";
			this.btHapus.UseVisualStyleBackColor = true;
			this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
			// 
			// btClear
			// 
			this.btClear.Location = new System.Drawing.Point(581, 196);
			this.btClear.Name = "btClear";
			this.btClear.Size = new System.Drawing.Size(75, 32);
			this.btClear.TabIndex = 9;
			this.btClear.Text = "Clear";
			this.btClear.UseVisualStyleBackColor = true;
			this.btClear.Click += new System.EventHandler(this.btClear_Click);
			// 
			// dtRegister
			// 
			this.dtRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtRegister.Location = new System.Drawing.Point(42, 251);
			this.dtRegister.Name = "dtRegister";
			this.dtRegister.RowHeadersWidth = 62;
			this.dtRegister.RowTemplate.Height = 28;
			this.dtRegister.Size = new System.Drawing.Size(614, 189);
			this.dtRegister.TabIndex = 10;
			this.dtRegister.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtRegister_CellContentClick);
			// 
			// textBoxID
			// 
			this.textBoxID.Location = new System.Drawing.Point(463, 12);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.Size = new System.Drawing.Size(307, 26);
			this.textBoxID.TabIndex = 11;
			this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
			// 
			// Register
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBoxID);
			this.Controls.Add(this.dtRegister);
			this.Controls.Add(this.btClear);
			this.Controls.Add(this.btHapus);
			this.Controls.Add(this.btUpdate);
			this.Controls.Add(this.btSimpan);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxUsername);
			this.Controls.Add(this.comboBoxKategori);
			this.Name = "Register";
			this.Text = "Register";
			((System.ComponentModel.ISupportInitialize)(this.dtRegister)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxKategori;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.TextBox textBoxUsername;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btSimpan;
		private System.Windows.Forms.Button btUpdate;
		private System.Windows.Forms.Button btHapus;
		private System.Windows.Forms.Button btClear;
		private System.Windows.Forms.DataGridView dtRegister;
		private System.Windows.Forms.TextBox textBoxID;
	}
}