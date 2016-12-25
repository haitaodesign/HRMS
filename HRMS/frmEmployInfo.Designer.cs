namespace HRMS
{
    partial class frmEmployInfo
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbQueryType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQueryValue = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvEmplyInfo = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCurrentName = new System.Windows.Forms.TextBox();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.btnChosePic = new System.Windows.Forms.Button();
            this.btnDeletePic = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSex = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbJob = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmplyInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label5.Location = new System.Drawing.Point(1, 21);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(29, 20);
            label5.TabIndex = 12;
            label5.Text = "ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label6.Location = new System.Drawing.Point(209, 23);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(49, 20);
            label6.TabIndex = 14;
            label6.Text = "姓名";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label7.Location = new System.Drawing.Point(433, 23);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(49, 20);
            label7.TabIndex = 16;
            label7.Text = "性别";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label8.Location = new System.Drawing.Point(665, 23);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(49, 20);
            label8.TabIndex = 18;
            label8.Text = "电话";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label9.Location = new System.Drawing.Point(665, 96);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(49, 20);
            label9.TabIndex = 26;
            label9.Text = "备注";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label10.Location = new System.Drawing.Point(433, 96);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(49, 20);
            label10.TabIndex = 24;
            label10.Text = "邮件";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label11.Location = new System.Drawing.Point(209, 96);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(49, 20);
            label11.TabIndex = 22;
            label11.Text = "地址";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label12.Location = new System.Drawing.Point(1, 96);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(49, 20);
            label12.TabIndex = 20;
            label12.Text = "职位";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "分类查询";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(54, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "查询类型";
            // 
            // cbQueryType
            // 
            this.cbQueryType.FormattingEnabled = true;
            this.cbQueryType.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Sex",
            "Phone",
            "Position",
            "Address",
            "Email"});
            this.cbQueryType.Location = new System.Drawing.Point(150, 55);
            this.cbQueryType.Name = "cbQueryType";
            this.cbQueryType.Size = new System.Drawing.Size(144, 23);
            this.cbQueryType.TabIndex = 2;
            this.cbQueryType.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(433, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "查询条件";
            // 
            // tbQueryValue
            // 
            this.tbQueryValue.Location = new System.Drawing.Point(528, 54);
            this.tbQueryValue.Name = "tbQueryValue";
            this.tbQueryValue.Size = new System.Drawing.Size(144, 25);
            this.tbQueryValue.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(829, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvEmplyInfo
            // 
            this.dgvEmplyInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEmplyInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmplyInfo.Location = new System.Drawing.Point(35, 132);
            this.dgvEmplyInfo.Name = "dgvEmplyInfo";
            this.dgvEmplyInfo.RowTemplate.Height = 27;
            this.dgvEmplyInfo.Size = new System.Drawing.Size(869, 311);
            this.dgvEmplyInfo.TabIndex = 6;
            this.dgvEmplyInfo.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmplyInfo_RowHeaderMouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(966, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "当前记录";
            // 
            // tbCurrentName
            // 
            this.tbCurrentName.Location = new System.Drawing.Point(969, 54);
            this.tbCurrentName.Name = "tbCurrentName";
            this.tbCurrentName.Size = new System.Drawing.Size(239, 25);
            this.tbCurrentName.TabIndex = 8;
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(969, 132);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(239, 311);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 9;
            this.pbPhoto.TabStop = false;
            // 
            // btnChosePic
            // 
            this.btnChosePic.Location = new System.Drawing.Point(1047, 489);
            this.btnChosePic.Name = "btnChosePic";
            this.btnChosePic.Size = new System.Drawing.Size(100, 30);
            this.btnChosePic.TabIndex = 10;
            this.btnChosePic.Text = "选择图片";
            this.btnChosePic.UseVisualStyleBackColor = true;
            this.btnChosePic.Click += new System.EventHandler(this.btnChosePic_Click);
            // 
            // btnDeletePic
            // 
            this.btnDeletePic.Location = new System.Drawing.Point(1047, 618);
            this.btnDeletePic.Name = "btnDeletePic";
            this.btnDeletePic.Size = new System.Drawing.Size(100, 30);
            this.btnDeletePic.TabIndex = 11;
            this.btnDeletePic.Text = "删除图片";
            this.btnDeletePic.UseVisualStyleBackColor = true;
            this.btnDeletePic.Click += new System.EventHandler(this.btnDeletePic_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(55, 21);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(144, 25);
            this.tbID.TabIndex = 13;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(267, 21);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(144, 25);
            this.tbName.TabIndex = 15;
            // 
            // tbSex
            // 
            this.tbSex.Location = new System.Drawing.Point(491, 21);
            this.tbSex.Name = "tbSex";
            this.tbSex.Size = new System.Drawing.Size(144, 25);
            this.tbSex.TabIndex = 17;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(723, 21);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(144, 25);
            this.tbPhone.TabIndex = 19;
            // 
            // tbMemo
            // 
            this.tbMemo.Location = new System.Drawing.Point(723, 94);
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.Size = new System.Drawing.Size(144, 25);
            this.tbMemo.TabIndex = 27;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(491, 94);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(144, 25);
            this.tbEmail.TabIndex = 25;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(267, 94);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(144, 25);
            this.tbAddress.TabIndex = 23;
            // 
            // tbJob
            // 
            this.tbJob.Location = new System.Drawing.Point(55, 94);
            this.tbJob.Name = "tbJob";
            this.tbJob.Size = new System.Drawing.Size(144, 25);
            this.tbJob.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(35, 618);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(233, 618);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(431, 618);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(629, 618);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(827, 618);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(label5);
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(label7);
            this.panel1.Controls.Add(this.tbSex);
            this.panel1.Controls.Add(this.tbMemo);
            this.panel1.Controls.Add(label8);
            this.panel1.Controls.Add(label9);
            this.panel1.Controls.Add(this.tbPhone);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(label12);
            this.panel1.Controls.Add(label10);
            this.panel1.Controls.Add(this.tbJob);
            this.panel1.Controls.Add(this.tbAddress);
            this.panel1.Controls.Add(label11);
            this.panel1.Location = new System.Drawing.Point(35, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 135);
            this.panel1.TabIndex = 33;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmEmployInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDeletePic);
            this.Controls.Add(this.btnChosePic);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.tbCurrentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvEmplyInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbQueryValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbQueryType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEmployInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmplyInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbQueryType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQueryValue;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvEmplyInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCurrentName;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Button btnChosePic;
        private System.Windows.Forms.Button btnDeletePic;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSex;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbJob;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}