
namespace LTWin_Last
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.textSEX = new System.Windows.Forms.TextBox();
            this.txt_bIRTHDAY = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDEL = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLook = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textPhoneNumber);
            this.panel1.Controls.Add(this.textSEX);
            this.panel1.Controls.Add(this.txt_bIRTHDAY);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(227, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 439);
            this.panel1.TabIndex = 33;
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Location = new System.Drawing.Point(30, 337);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.ReadOnly = true;
            this.textPhoneNumber.Size = new System.Drawing.Size(357, 34);
            this.textPhoneNumber.TabIndex = 20;
            this.textPhoneNumber.Text = "SỐ ĐIỆN THOẠI:";
            // 
            // textSEX
            // 
            this.textSEX.Location = new System.Drawing.Point(30, 270);
            this.textSEX.Name = "textSEX";
            this.textSEX.ReadOnly = true;
            this.textSEX.Size = new System.Drawing.Size(357, 34);
            this.textSEX.TabIndex = 19;
            this.textSEX.Text = "GIỚI TÍNH: ";
            // 
            // txt_bIRTHDAY
            // 
            this.txt_bIRTHDAY.Location = new System.Drawing.Point(30, 206);
            this.txt_bIRTHDAY.Name = "txt_bIRTHDAY";
            this.txt_bIRTHDAY.ReadOnly = true;
            this.txt_bIRTHDAY.Size = new System.Drawing.Size(357, 34);
            this.txt_bIRTHDAY.TabIndex = 15;
            this.txt_bIRTHDAY.Text = "NGÀY SINH: ";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(30, 151);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(357, 34);
            this.txt_name.TabIndex = 14;
            this.txt_name.Text = "TÊN: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.Location = new System.Drawing.Point(741, 498);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(191, 107);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDEL
            // 
            this.btnDEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDEL.Location = new System.Drawing.Point(741, 338);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(191, 107);
            this.btnDEL.TabIndex = 39;
            this.btnDEL.Text = "Xoá";
            this.btnDEL.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Cyan;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnInsert.Location = new System.Drawing.Point(741, 166);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(191, 107);
            this.btnInsert.TabIndex = 38;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 37;
            this.label2.Text = "SỐ ĐIỆN THOẠI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(284, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "Thông Tin Cá Nhân";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(299, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 22);
            this.textBox1.TabIndex = 34;
            // 
            // btnLook
            // 
            this.btnLook.BackColor = System.Drawing.Color.Transparent;
            this.btnLook.Image = global::LTWin_Last.Properties.Resources.Look_icon;
            this.btnLook.Location = new System.Drawing.Point(541, 64);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(33, 31);
            this.btnLook.TabIndex = 43;
            this.btnLook.UseVisualStyleBackColor = false;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LTWin_Last.Properties.Resources.css_gradient;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDEL);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Customer";
            this.Text = "CUSTOMER";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.TextBox textSEX;
        private System.Windows.Forms.TextBox txt_bIRTHDAY;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLook;
    }
}