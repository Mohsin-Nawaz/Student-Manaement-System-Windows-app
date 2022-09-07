
namespace register
{
    partial class crud
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crud));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.smsbtn = new System.Windows.Forms.Button();
            this.stdname = new System.Windows.Forms.Label();
            this.cnic = new System.Windows.Forms.Label();
            this.stdregno = new System.Windows.Forms.Label();
            this.stdmobile = new System.Windows.Forms.Label();
            this.stdcgpa = new System.Windows.Forms.Label();
            this.txtstudentname = new System.Windows.Forms.TextBox();
            this.txtstudentcnic = new System.Windows.Forms.TextBox();
            this.txtstudentregno = new System.Windows.Forms.TextBox();
            this.txtstudentmobile = new System.Windows.Forms.TextBox();
            this.txtstudentcgpa = new System.Windows.Forms.TextBox();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.registerDataSet = new register.registerDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new register.registerDataSetTableAdapters.TableTableAdapter();
            this.studentrecorddatagridview = new System.Windows.Forms.DataGridView();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet1 = new register.studentDataSet1();
            this.studentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet = new register.studentDataSet();
            this.insertbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.studentTableAdapter = new register.studentDataSet1TableAdapters.studentTableAdapter();
            this.student_id = new System.Windows.Forms.Label();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentrecorddatagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(708, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(-7, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(232, 22);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // smsbtn
            // 
            this.smsbtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.smsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smsbtn.ForeColor = System.Drawing.Color.Blue;
            this.smsbtn.Location = new System.Drawing.Point(287, 12);
            this.smsbtn.Name = "smsbtn";
            this.smsbtn.Size = new System.Drawing.Size(226, 58);
            this.smsbtn.TabIndex = 5;
            this.smsbtn.Text = " Student Management System";
            this.smsbtn.UseVisualStyleBackColor = false;
            this.smsbtn.Click += new System.EventHandler(this.loginformbtn_Click);
            // 
            // stdname
            // 
            this.stdname.AutoSize = true;
            this.stdname.BackColor = System.Drawing.Color.LemonChiffon;
            this.stdname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdname.ForeColor = System.Drawing.Color.Blue;
            this.stdname.Location = new System.Drawing.Point(3, 120);
            this.stdname.Name = "stdname";
            this.stdname.Size = new System.Drawing.Size(130, 24);
            this.stdname.TabIndex = 9;
            this.stdname.Text = "Student Name";
            // 
            // cnic
            // 
            this.cnic.AutoSize = true;
            this.cnic.BackColor = System.Drawing.Color.LemonChiffon;
            this.cnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnic.ForeColor = System.Drawing.Color.Blue;
            this.cnic.Location = new System.Drawing.Point(3, 158);
            this.cnic.Name = "cnic";
            this.cnic.Size = new System.Drawing.Size(123, 24);
            this.cnic.TabIndex = 9;
            this.cnic.Text = "Student CNIC";
            // 
            // stdregno
            // 
            this.stdregno.AutoSize = true;
            this.stdregno.BackColor = System.Drawing.Color.LemonChiffon;
            this.stdregno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdregno.ForeColor = System.Drawing.Color.Blue;
            this.stdregno.Location = new System.Drawing.Point(3, 196);
            this.stdregno.Name = "stdregno";
            this.stdregno.Size = new System.Drawing.Size(136, 24);
            this.stdregno.TabIndex = 9;
            this.stdregno.Text = "Student Regno";
            // 
            // stdmobile
            // 
            this.stdmobile.AutoSize = true;
            this.stdmobile.BackColor = System.Drawing.Color.LemonChiffon;
            this.stdmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdmobile.ForeColor = System.Drawing.Color.Blue;
            this.stdmobile.Location = new System.Drawing.Point(3, 234);
            this.stdmobile.Name = "stdmobile";
            this.stdmobile.Size = new System.Drawing.Size(136, 24);
            this.stdmobile.TabIndex = 9;
            this.stdmobile.Text = "Student Mobile";
            // 
            // stdcgpa
            // 
            this.stdcgpa.AutoSize = true;
            this.stdcgpa.BackColor = System.Drawing.Color.LemonChiffon;
            this.stdcgpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdcgpa.ForeColor = System.Drawing.Color.Blue;
            this.stdcgpa.Location = new System.Drawing.Point(3, 272);
            this.stdcgpa.Name = "stdcgpa";
            this.stdcgpa.Size = new System.Drawing.Size(131, 24);
            this.stdcgpa.TabIndex = 9;
            this.stdcgpa.Text = "Student CGPA";
            // 
            // txtstudentname
            // 
            this.txtstudentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentname.Location = new System.Drawing.Point(216, 120);
            this.txtstudentname.Multiline = true;
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(350, 24);
            this.txtstudentname.TabIndex = 10;
            // 
            // txtstudentcnic
            // 
            this.txtstudentcnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentcnic.Location = new System.Drawing.Point(216, 158);
            this.txtstudentcnic.Multiline = true;
            this.txtstudentcnic.Name = "txtstudentcnic";
            this.txtstudentcnic.Size = new System.Drawing.Size(350, 24);
            this.txtstudentcnic.TabIndex = 10;
            // 
            // txtstudentregno
            // 
            this.txtstudentregno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentregno.Location = new System.Drawing.Point(216, 196);
            this.txtstudentregno.Multiline = true;
            this.txtstudentregno.Name = "txtstudentregno";
            this.txtstudentregno.Size = new System.Drawing.Size(350, 24);
            this.txtstudentregno.TabIndex = 10;
            // 
            // txtstudentmobile
            // 
            this.txtstudentmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentmobile.Location = new System.Drawing.Point(216, 234);
            this.txtstudentmobile.Multiline = true;
            this.txtstudentmobile.Name = "txtstudentmobile";
            this.txtstudentmobile.Size = new System.Drawing.Size(350, 24);
            this.txtstudentmobile.TabIndex = 10;
            // 
            // txtstudentcgpa
            // 
            this.txtstudentcgpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentcgpa.Location = new System.Drawing.Point(216, 272);
            this.txtstudentcgpa.Multiline = true;
            this.txtstudentcgpa.Name = "txtstudentcgpa";
            this.txtstudentcgpa.Size = new System.Drawing.Size(350, 24);
            this.txtstudentcgpa.TabIndex = 10;
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.Color.Blue;
            this.logoutbtn.Location = new System.Drawing.Point(700, 314);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(119, 40);
            this.logoutbtn.TabIndex = 8;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // registerDataSet
            // 
            this.registerDataSet.DataSetName = "registerDataSet";
            this.registerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.registerDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // studentrecorddatagridview
            // 
            this.studentrecorddatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentrecorddatagridview.Location = new System.Drawing.Point(74, 371);
            this.studentrecorddatagridview.Name = "studentrecorddatagridview";
            this.studentrecorddatagridview.Size = new System.Drawing.Size(631, 160);
            this.studentrecorddatagridview.TabIndex = 11;
            this.studentrecorddatagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.studentrecorddatagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.studentDataSet1;
            // 
            // studentDataSet1
            // 
            this.studentDataSet1.DataSetName = "studentDataSet1";
            this.studentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDataSetBindingSource
            // 
            this.studentDataSetBindingSource.DataSource = this.studentDataSet;
            this.studentDataSetBindingSource.Position = 0;
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "studentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insertbtn
            // 
            this.insertbtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.insertbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertbtn.ForeColor = System.Drawing.Color.Blue;
            this.insertbtn.Location = new System.Drawing.Point(120, 315);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(92, 39);
            this.insertbtn.TabIndex = 12;
            this.insertbtn.Text = "Insert";
            this.insertbtn.UseVisualStyleBackColor = false;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.Color.Blue;
            this.updatebtn.Location = new System.Drawing.Point(245, 314);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(87, 40);
            this.updatebtn.TabIndex = 12;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.Blue;
            this.deletebtn.Location = new System.Drawing.Point(365, 314);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(92, 40);
            this.deletebtn.TabIndex = 12;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.Color.Blue;
            this.searchbtn.Location = new System.Drawing.Point(490, 315);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(104, 40);
            this.searchbtn.TabIndex = 12;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // student_id
            // 
            this.student_id.AutoSize = true;
            this.student_id.BackColor = System.Drawing.Color.LemonChiffon;
            this.student_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_id.ForeColor = System.Drawing.Color.Blue;
            this.student_id.Location = new System.Drawing.Point(3, 86);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(101, 24);
            this.student_id.TabIndex = 9;
            this.student_id.Text = "Student  ID";
            // 
            // txtstudentid
            // 
            this.txtstudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentid.Location = new System.Drawing.Point(216, 86);
            this.txtstudentid.Multiline = true;
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(350, 24);
            this.txtstudentid.TabIndex = 10;
            // 
            // crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(817, 543);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.studentrecorddatagridview);
            this.Controls.Add(this.txtstudentcgpa);
            this.Controls.Add(this.txtstudentmobile);
            this.Controls.Add(this.txtstudentregno);
            this.Controls.Add(this.txtstudentcnic);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtstudentname);
            this.Controls.Add(this.stdcgpa);
            this.Controls.Add(this.stdmobile);
            this.Controls.Add(this.stdregno);
            this.Controls.Add(this.cnic);
            this.Controls.Add(this.student_id);
            this.Controls.Add(this.stdname);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.smsbtn);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "crud";
            this.Text = "Crud";
            this.Load += new System.EventHandler(this.crud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentrecorddatagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button smsbtn;
        private System.Windows.Forms.Label stdname;
        private System.Windows.Forms.Label cnic;
        private System.Windows.Forms.Label stdregno;
        private System.Windows.Forms.Label stdmobile;
        private System.Windows.Forms.Label stdcgpa;
        private System.Windows.Forms.TextBox txtstudentname;
        private System.Windows.Forms.TextBox txtstudentcnic;
        private System.Windows.Forms.TextBox txtstudentregno;
        private System.Windows.Forms.TextBox txtstudentmobile;
        private System.Windows.Forms.TextBox txtstudentcgpa;
        private System.Windows.Forms.Button logoutbtn;
        private registerDataSet registerDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private registerDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridView studentrecorddatagridview;
        private System.Windows.Forms.BindingSource studentDataSetBindingSource;
        private studentDataSet studentDataSet;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button searchbtn;
        private studentDataSet1 studentDataSet1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private studentDataSet1TableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Label student_id;
        private System.Windows.Forms.TextBox txtstudentid;
    }
}