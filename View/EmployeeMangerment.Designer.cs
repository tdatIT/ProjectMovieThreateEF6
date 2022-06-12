
namespace LTWin_Last.View
{
    partial class EmployeeMangerment
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
			this.dgv = new System.Windows.Forms.DataGridView();
			this.lb_Name = new System.Windows.Forms.Label();
			this.lb_Birth = new System.Windows.Forms.Label();
			this.lb_Sex = new System.Windows.Forms.Label();
			this.lb_Job = new System.Windows.Forms.Label();
			this.lb_Username = new System.Windows.Forms.Label();
			this.lb_Password = new System.Windows.Forms.Label();
			this.lb_Salary = new System.Windows.Forms.Label();
			this.btn_Update = new System.Windows.Forms.Button();
			this.btn_Del = new System.Windows.Forms.Button();
			this.btn_Add = new System.Windows.Forms.Button();
			this.txt_Name = new System.Windows.Forms.TextBox();
			this.txt_Salary = new System.Windows.Forms.TextBox();
			this.txt_Job = new System.Windows.Forms.TextBox();
			this.txt_Username = new System.Windows.Forms.TextBox();
			this.txt_Pass = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.txt_id = new System.Windows.Forms.TextBox();
			this.lb_Id = new System.Windows.Forms.Label();
			this.rbtn_Nu = new System.Windows.Forms.RadioButton();
			this.rbtn_Nam = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_Birthday = new System.Windows.Forms.TextBox();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgv
			// 
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Location = new System.Drawing.Point(10, 24);
			this.dgv.Margin = new System.Windows.Forms.Padding(2);
			this.dgv.Name = "dgv";
			this.dgv.RowHeadersWidth = 51;
			this.dgv.RowTemplate.Height = 24;
			this.dgv.Size = new System.Drawing.Size(793, 307);
			this.dgv.TabIndex = 0;
			this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cell_click);
			this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
			// 
			// lb_Name
			// 
			this.lb_Name.AutoSize = true;
			this.lb_Name.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_Name.ForeColor = System.Drawing.Color.White;
			this.lb_Name.Location = new System.Drawing.Point(2, 104);
			this.lb_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lb_Name.Name = "lb_Name";
			this.lb_Name.Size = new System.Drawing.Size(54, 18);
			this.lb_Name.TabIndex = 1;
			this.lb_Name.Text = "Tên NV:";
			// 
			// lb_Birth
			// 
			this.lb_Birth.AutoSize = true;
			this.lb_Birth.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_Birth.ForeColor = System.Drawing.Color.White;
			this.lb_Birth.Location = new System.Drawing.Point(619, 103);
			this.lb_Birth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lb_Birth.Name = "lb_Birth";
			this.lb_Birth.Size = new System.Drawing.Size(70, 18);
			this.lb_Birth.TabIndex = 2;
			this.lb_Birth.Text = "Ngày sinh:";
			// 
			// lb_Sex
			// 
			this.lb_Sex.AutoSize = true;
			this.lb_Sex.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_Sex.ForeColor = System.Drawing.Color.White;
			this.lb_Sex.Location = new System.Drawing.Point(619, 72);
			this.lb_Sex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lb_Sex.Name = "lb_Sex";
			this.lb_Sex.Size = new System.Drawing.Size(61, 18);
			this.lb_Sex.TabIndex = 3;
			this.lb_Sex.Text = "Giới tính:";
			// 
			// lb_Job
			// 
			this.lb_Job.AutoSize = true;
			this.lb_Job.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_Job.ForeColor = System.Drawing.Color.White;
			this.lb_Job.Location = new System.Drawing.Point(200, 103);
			this.lb_Job.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lb_Job.Name = "lb_Job";
			this.lb_Job.Size = new System.Drawing.Size(71, 18);
			this.lb_Job.TabIndex = 4;
			this.lb_Job.Text = "Công việc:";
			// 
			// lb_Username
			// 
			this.lb_Username.AutoSize = true;
			this.lb_Username.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_Username.ForeColor = System.Drawing.Color.White;
			this.lb_Username.Location = new System.Drawing.Point(400, 72);
			this.lb_Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lb_Username.Name = "lb_Username";
			this.lb_Username.Size = new System.Drawing.Size(72, 18);
			this.lb_Username.TabIndex = 5;
			this.lb_Username.Text = "Username:";
			// 
			// lb_Password
			// 
			this.lb_Password.AutoSize = true;
			this.lb_Password.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_Password.ForeColor = System.Drawing.Color.White;
			this.lb_Password.Location = new System.Drawing.Point(404, 103);
			this.lb_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lb_Password.Name = "lb_Password";
			this.lb_Password.Size = new System.Drawing.Size(71, 18);
			this.lb_Password.TabIndex = 6;
			this.lb_Password.Text = "Passwork:";
			// 
			// lb_Salary
			// 
			this.lb_Salary.AutoSize = true;
			this.lb_Salary.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_Salary.ForeColor = System.Drawing.Color.White;
			this.lb_Salary.Location = new System.Drawing.Point(199, 74);
			this.lb_Salary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lb_Salary.Name = "lb_Salary";
			this.lb_Salary.Size = new System.Drawing.Size(53, 18);
			this.lb_Salary.TabIndex = 7;
			this.lb_Salary.Text = "Lương: ";
			// 
			// btn_Update
			// 
			this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btn_Update.FlatAppearance.BorderSize = 0;
			this.btn_Update.Font = new System.Drawing.Font("Be Vietnam Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btn_Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
			this.btn_Update.Location = new System.Drawing.Point(275, 521);
			this.btn_Update.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.Size = new System.Drawing.Size(98, 37);
			this.btn_Update.TabIndex = 43;
			this.btn_Update.Text = "Cập nhật";
			this.btn_Update.UseVisualStyleBackColor = false;
			this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
			// 
			// btn_Del
			// 
			this.btn_Del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btn_Del.FlatAppearance.BorderSize = 0;
			this.btn_Del.Font = new System.Drawing.Font("Be Vietnam Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btn_Del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
			this.btn_Del.Location = new System.Drawing.Point(154, 521);
			this.btn_Del.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Del.Name = "btn_Del";
			this.btn_Del.Size = new System.Drawing.Size(87, 36);
			this.btn_Del.TabIndex = 42;
			this.btn_Del.Text = "Xoá";
			this.btn_Del.UseVisualStyleBackColor = false;
			this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
			// 
			// btn_Add
			// 
			this.btn_Add.BackColor = System.Drawing.Color.Cyan;
			this.btn_Add.FlatAppearance.BorderSize = 0;
			this.btn_Add.Font = new System.Drawing.Font("Be Vietnam Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
			this.btn_Add.Location = new System.Drawing.Point(34, 519);
			this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(92, 37);
			this.btn_Add.TabIndex = 41;
			this.btn_Add.Text = "Thêm";
			this.btn_Add.UseVisualStyleBackColor = false;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// txt_Name
			// 
			this.txt_Name.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Name.ForeColor = System.Drawing.Color.Black;
			this.txt_Name.Location = new System.Drawing.Point(70, 103);
			this.txt_Name.Margin = new System.Windows.Forms.Padding(2);
			this.txt_Name.Name = "txt_Name";
			this.txt_Name.Size = new System.Drawing.Size(106, 23);
			this.txt_Name.TabIndex = 44;
			// 
			// txt_Salary
			// 
			this.txt_Salary.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Salary.ForeColor = System.Drawing.Color.Black;
			this.txt_Salary.Location = new System.Drawing.Point(268, 72);
			this.txt_Salary.Margin = new System.Windows.Forms.Padding(2);
			this.txt_Salary.Name = "txt_Salary";
			this.txt_Salary.Size = new System.Drawing.Size(106, 23);
			this.txt_Salary.TabIndex = 46;
			// 
			// txt_Job
			// 
			this.txt_Job.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Job.ForeColor = System.Drawing.Color.Black;
			this.txt_Job.Location = new System.Drawing.Point(268, 103);
			this.txt_Job.Margin = new System.Windows.Forms.Padding(2);
			this.txt_Job.Name = "txt_Job";
			this.txt_Job.Size = new System.Drawing.Size(106, 23);
			this.txt_Job.TabIndex = 47;
			// 
			// txt_Username
			// 
			this.txt_Username.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Username.ForeColor = System.Drawing.Color.Black;
			this.txt_Username.Location = new System.Drawing.Point(482, 72);
			this.txt_Username.Margin = new System.Windows.Forms.Padding(2);
			this.txt_Username.Name = "txt_Username";
			this.txt_Username.Size = new System.Drawing.Size(106, 23);
			this.txt_Username.TabIndex = 48;
			// 
			// txt_Pass
			// 
			this.txt_Pass.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Pass.ForeColor = System.Drawing.Color.Black;
			this.txt_Pass.Location = new System.Drawing.Point(482, 103);
			this.txt_Pass.Margin = new System.Windows.Forms.Padding(2);
			this.txt_Pass.Name = "txt_Pass";
			this.txt_Pass.Size = new System.Drawing.Size(106, 23);
			this.txt_Pass.TabIndex = 49;
			// 
			// textBox6
			// 
			this.textBox6.Font = new System.Drawing.Font("Open Sans SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox6.ForeColor = System.Drawing.Color.White;
			this.textBox6.Location = new System.Drawing.Point(718, 50);
			this.textBox6.Margin = new System.Windows.Forms.Padding(2);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(106, 26);
			this.textBox6.TabIndex = 50;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(33)))), ((int)(((byte)(59)))));
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.txt_id);
			this.panel1.Controls.Add(this.lb_Id);
			this.panel1.Controls.Add(this.rbtn_Nu);
			this.panel1.Controls.Add(this.rbtn_Nam);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txt_Pass);
			this.panel1.Controls.Add(this.txt_Username);
			this.panel1.Controls.Add(this.txt_Job);
			this.panel1.Controls.Add(this.txt_Salary);
			this.panel1.Controls.Add(this.txt_Birthday);
			this.panel1.Controls.Add(this.txt_Name);
			this.panel1.Controls.Add(this.lb_Salary);
			this.panel1.Controls.Add(this.lb_Password);
			this.panel1.Controls.Add(this.lb_Username);
			this.panel1.Controls.Add(this.lb_Job);
			this.panel1.Controls.Add(this.lb_Sex);
			this.panel1.Controls.Add(this.lb_Birth);
			this.panel1.Controls.Add(this.lb_Name);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.ForeColor = System.Drawing.Color.Black;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(839, 139);
			this.panel1.TabIndex = 51;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(180)))), ((int)(((byte)(69)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Be Vietnam Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
			this.button1.Location = new System.Drawing.Point(5, 11);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 31);
			this.button1.TabIndex = 56;
			this.button1.Text = "Xuất file";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txt_id
			// 
			this.txt_id.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_id.ForeColor = System.Drawing.Color.Black;
			this.txt_id.Location = new System.Drawing.Point(70, 72);
			this.txt_id.Margin = new System.Windows.Forms.Padding(2);
			this.txt_id.Name = "txt_id";
			this.txt_id.ReadOnly = true;
			this.txt_id.Size = new System.Drawing.Size(106, 23);
			this.txt_id.TabIndex = 55;
			// 
			// lb_Id
			// 
			this.lb_Id.AutoSize = true;
			this.lb_Id.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_Id.ForeColor = System.Drawing.Color.White;
			this.lb_Id.Location = new System.Drawing.Point(2, 72);
			this.lb_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lb_Id.Name = "lb_Id";
			this.lb_Id.Size = new System.Drawing.Size(52, 18);
			this.lb_Id.TabIndex = 54;
			this.lb_Id.Text = "Mã NV:";
			// 
			// rbtn_Nu
			// 
			this.rbtn_Nu.AutoSize = true;
			this.rbtn_Nu.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
			this.rbtn_Nu.ForeColor = System.Drawing.Color.White;
			this.rbtn_Nu.Location = new System.Drawing.Point(760, 72);
			this.rbtn_Nu.Margin = new System.Windows.Forms.Padding(2);
			this.rbtn_Nu.Name = "rbtn_Nu";
			this.rbtn_Nu.Size = new System.Drawing.Size(42, 22);
			this.rbtn_Nu.TabIndex = 53;
			this.rbtn_Nu.TabStop = true;
			this.rbtn_Nu.Text = "Nữ";
			this.rbtn_Nu.UseVisualStyleBackColor = true;
			// 
			// rbtn_Nam
			// 
			this.rbtn_Nam.AutoSize = true;
			this.rbtn_Nam.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 8.999999F, System.Drawing.FontStyle.Bold);
			this.rbtn_Nam.ForeColor = System.Drawing.Color.White;
			this.rbtn_Nam.Location = new System.Drawing.Point(688, 71);
			this.rbtn_Nam.Margin = new System.Windows.Forms.Padding(2);
			this.rbtn_Nam.Name = "rbtn_Nam";
			this.rbtn_Nam.Size = new System.Drawing.Size(54, 22);
			this.rbtn_Nam.TabIndex = 52;
			this.rbtn_Nam.TabStop = true;
			this.rbtn_Nam.Text = "Nam";
			this.rbtn_Nam.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(324, 7);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(306, 31);
			this.label1.TabIndex = 51;
			this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
			// 
			// txt_Birthday
			// 
			this.txt_Birthday.Font = new System.Drawing.Font("Be Vietnam Pro SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Birthday.ForeColor = System.Drawing.Color.Black;
			this.txt_Birthday.Location = new System.Drawing.Point(693, 103);
			this.txt_Birthday.Margin = new System.Windows.Forms.Padding(2);
			this.txt_Birthday.Name = "txt_Birthday";
			this.txt_Birthday.Size = new System.Drawing.Size(106, 23);
			this.txt_Birthday.TabIndex = 45;
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(180)))), ((int)(((byte)(69)))));
			this.btn_Cancel.FlatAppearance.BorderSize = 0;
			this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Cancel.Font = new System.Drawing.Font("Be Vietnam Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
			this.btn_Cancel.Location = new System.Drawing.Point(718, 521);
			this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(90, 36);
			this.btn_Cancel.TabIndex = 52;
			this.btn_Cancel.Text = "Hủy";
			this.btn_Cancel.UseVisualStyleBackColor = false;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// btn_Save
			// 
			this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(180)))), ((int)(((byte)(69)))));
			this.btn_Save.FlatAppearance.BorderSize = 0;
			this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Save.Font = new System.Drawing.Font("Be Vietnam Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
			this.btn_Save.Location = new System.Drawing.Point(554, 521);
			this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(123, 36);
			this.btn_Save.TabIndex = 53;
			this.btn_Save.Text = "Lưu";
			this.btn_Save.UseVisualStyleBackColor = false;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(128)))));
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.dgv);
			this.panel2.Location = new System.Drawing.Point(4, 150);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(826, 351);
			this.panel2.TabIndex = 54;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(67)))), ((int)(((byte)(128)))));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(7, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 24);
			this.label2.TabIndex = 53;
			this.label2.Text = "Nhân viên";
			// 
			// EmployeeMangerment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
			this.ClientSize = new System.Drawing.Size(839, 578);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.btn_Update);
			this.Controls.Add(this.btn_Del);
			this.Controls.Add(this.btn_Add);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "EmployeeMangerment";
			this.Text = "EmployeeMangerment";
			this.Load += new System.EventHandler(this.EmployeeMangerment_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Birth;
        private System.Windows.Forms.Label lb_Sex;
        private System.Windows.Forms.Label lb_Job;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lb_Salary;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Salary;
        private System.Windows.Forms.TextBox txt_Job;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtn_Nu;
        private System.Windows.Forms.RadioButton rbtn_Nam;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lb_Id;
        private System.Windows.Forms.TextBox txt_Birthday;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}