namespace CS6004_Application_Development_11063786
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
            this.components = new System.ComponentModel.Container();
            this.Sort_Student = new System.Windows.Forms.Button();
            this.Sort_ByID_Stu = new System.Windows.Forms.Button();
            this.CreateStudent = new System.Windows.Forms.Button();
            this.Retrieve_ClassList = new System.Windows.Forms.Button();
            this.Save_ClassList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.T2ID = new System.Windows.Forms.TextBox();
            this.T3FirstName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.T4LastName = new System.Windows.Forms.TextBox();
            this.T5Email = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BulkAssign = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.studentGroupIdSelect = new System.Windows.Forms.ComboBox();
            this.GroupID_Sort = new System.Windows.Forms.Button();
            this.Student_Mark_SortID = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.T6GMARK = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.T7indiviPercen = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ApplyindiMark = new System.Windows.Forms.Button();
            this.ApplyGroup = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SaveIndiviMark = new System.Windows.Forms.Button();
            this.IndiviMarkStuIDSelect = new System.Windows.Forms.ComboBox();
            this.RetrieveIndivi = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SaveGroupMark = new System.Windows.Forms.Button();
            this.GroupMarkIDSelect = new System.Windows.Forms.ComboBox();
            this.RetrieveGroup = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.createGroupId = new System.Windows.Forms.Button();
            this.T1 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Clear_IndiviScreen = new System.Windows.Forms.Button();
            this.CloseProg = new System.Windows.Forms.Button();
            this.Student_Clear = new System.Windows.Forms.Button();
            this.Clear_Group = new System.Windows.Forms.Button();
            this.CSV_Retrieve = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sort_Student
            // 
            this.Sort_Student.Location = new System.Drawing.Point(249, 65);
            this.Sort_Student.Name = "Sort_Student";
            this.Sort_Student.Size = new System.Drawing.Size(61, 23);
            this.Sort_Student.TabIndex = 0;
            this.Sort_Student.Text = "SORT";
            this.Sort_Student.UseVisualStyleBackColor = true;
            this.Sort_Student.Click += new System.EventHandler(this.Sort_Student_Click);
            // 
            // Sort_ByID_Stu
            // 
            this.Sort_ByID_Stu.Location = new System.Drawing.Point(316, 65);
            this.Sort_ByID_Stu.Name = "Sort_ByID_Stu";
            this.Sort_ByID_Stu.Size = new System.Drawing.Size(123, 23);
            this.Sort_ByID_Stu.TabIndex = 2;
            this.Sort_ByID_Stu.Text = "STUDENT ID SORT";
            this.Sort_ByID_Stu.UseVisualStyleBackColor = true;
            this.Sort_ByID_Stu.Click += new System.EventHandler(this.Sort_ByID_Stu_Click);
            // 
            // CreateStudent
            // 
            this.CreateStudent.Location = new System.Drawing.Point(220, 177);
            this.CreateStudent.Name = "CreateStudent";
            this.CreateStudent.Size = new System.Drawing.Size(75, 23);
            this.CreateStudent.TabIndex = 3;
            this.CreateStudent.Text = "Add Student";
            this.CreateStudent.UseVisualStyleBackColor = true;
            this.CreateStudent.Click += new System.EventHandler(this.CreateStudent_Click);
            // 
            // Retrieve_ClassList
            // 
            this.Retrieve_ClassList.Location = new System.Drawing.Point(66, 65);
            this.Retrieve_ClassList.Name = "Retrieve_ClassList";
            this.Retrieve_ClassList.Size = new System.Drawing.Size(75, 23);
            this.Retrieve_ClassList.TabIndex = 4;
            this.Retrieve_ClassList.Text = "RETRIEVE";
            this.Retrieve_ClassList.UseVisualStyleBackColor = true;
            this.Retrieve_ClassList.Click += new System.EventHandler(this.Retrieve_ClassList_Click);
            // 
            // Save_ClassList
            // 
            this.Save_ClassList.Location = new System.Drawing.Point(11, 65);
            this.Save_ClassList.Name = "Save_ClassList";
            this.Save_ClassList.Size = new System.Drawing.Size(49, 23);
            this.Save_ClassList.TabIndex = 5;
            this.Save_ClassList.Text = "SAVE";
            this.Save_ClassList.UseVisualStyleBackColor = true;
            this.Save_ClassList.Click += new System.EventHandler(this.Save_ClassList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Group ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "ASSIGN STUDENT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(229, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "CLASS LIST";
            // 
            // T2ID
            // 
            this.T2ID.Location = new System.Drawing.Point(89, 44);
            this.T2ID.Name = "T2ID";
            this.T2ID.Size = new System.Drawing.Size(121, 20);
            this.T2ID.TabIndex = 18;
            this.T2ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.T2ID.MouseHover += new System.EventHandler(this.T2ID_MouseHover);
            // 
            // T3FirstName
            // 
            this.T3FirstName.Location = new System.Drawing.Point(89, 75);
            this.T3FirstName.Name = "T3FirstName";
            this.T3FirstName.Size = new System.Drawing.Size(121, 20);
            this.T3FirstName.TabIndex = 19;
            this.T3FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.T3FirstName.MouseHover += new System.EventHandler(this.T3FirstName_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 198);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(588, 93);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(234, 198);
            this.dataGridView2.TabIndex = 27;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Surname";
            // 
            // T4LastName
            // 
            this.T4LastName.Location = new System.Drawing.Point(89, 107);
            this.T4LastName.Name = "T4LastName";
            this.T4LastName.Size = new System.Drawing.Size(121, 20);
            this.T4LastName.TabIndex = 31;
            this.T4LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            this.T4LastName.MouseHover += new System.EventHandler(this.T4LastName_MouseHover);
            // 
            // T5Email
            // 
            this.T5Email.Location = new System.Drawing.Point(89, 140);
            this.T5Email.Name = "T5Email";
            this.T5Email.Size = new System.Drawing.Size(121, 20);
            this.T5Email.TabIndex = 33;
            this.T5Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Email";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BulkAssign);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Location = new System.Drawing.Point(324, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 95);
            this.panel1.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Bulk Assignment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Enter Group ID :";
            // 
            // BulkAssign
            // 
            this.BulkAssign.Location = new System.Drawing.Point(112, 66);
            this.BulkAssign.Name = "BulkAssign";
            this.BulkAssign.Size = new System.Drawing.Size(75, 23);
            this.BulkAssign.TabIndex = 25;
            this.BulkAssign.Text = "Enter";
            this.BulkAssign.UseVisualStyleBackColor = true;
            this.BulkAssign.Click += new System.EventHandler(this.BulkAssign_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(94, 40);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 28;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            this.textBox5.MouseHover += new System.EventHandler(this.textBox5_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.CreateStudent);
            this.panel2.Controls.Add(this.T5Email);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.T4LastName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.T2ID);
            this.panel2.Controls.Add(this.T3FirstName);
            this.panel2.Controls.Add(this.studentGroupIdSelect);
            this.panel2.Location = new System.Drawing.Point(12, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 208);
            this.panel2.TabIndex = 36;
            // 
            // studentGroupIdSelect
            // 
            this.studentGroupIdSelect.FormattingEnabled = true;
            this.studentGroupIdSelect.Location = new System.Drawing.Point(89, 177);
            this.studentGroupIdSelect.Name = "studentGroupIdSelect";
            this.studentGroupIdSelect.Size = new System.Drawing.Size(121, 21);
            this.studentGroupIdSelect.TabIndex = 20;
            // 
            // GroupID_Sort
            // 
            this.GroupID_Sort.Location = new System.Drawing.Point(648, 296);
            this.GroupID_Sort.Name = "GroupID_Sort";
            this.GroupID_Sort.Size = new System.Drawing.Size(119, 23);
            this.GroupID_Sort.TabIndex = 38;
            this.GroupID_Sort.Text = "Group ID Sort";
            this.GroupID_Sort.UseVisualStyleBackColor = true;
            this.GroupID_Sort.Click += new System.EventHandler(this.GroupID_Sort_Click);
            // 
            // Student_Mark_SortID
            // 
            this.Student_Mark_SortID.Location = new System.Drawing.Point(973, 297);
            this.Student_Mark_SortID.Name = "Student_Mark_SortID";
            this.Student_Mark_SortID.Size = new System.Drawing.Size(119, 23);
            this.Student_Mark_SortID.TabIndex = 37;
            this.Student_Mark_SortID.Text = "Student ID Sort";
            this.Student_Mark_SortID.UseVisualStyleBackColor = true;
            this.Student_Mark_SortID.Click += new System.EventHandler(this.Student_Mark_SortID_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "GROUP MARKS";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Group ID";
            // 
            // T6GMARK
            // 
            this.T6GMARK.Location = new System.Drawing.Point(94, 68);
            this.T6GMARK.Name = "T6GMARK";
            this.T6GMARK.Size = new System.Drawing.Size(121, 20);
            this.T6GMARK.TabIndex = 42;
            this.T6GMARK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            this.T6GMARK.MouseHover += new System.EventHandler(this.textBox4_MouseHover);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "Group Mark";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(66, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 16);
            this.label17.TabIndex = 50;
            this.label17.Text = "%";
            // 
            // T7indiviPercen
            // 
            this.T7indiviPercen.Location = new System.Drawing.Point(99, 68);
            this.T7indiviPercen.Name = "T7indiviPercen";
            this.T7indiviPercen.Size = new System.Drawing.Size(121, 20);
            this.T7indiviPercen.TabIndex = 48;
            this.T7indiviPercen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox10_KeyPress);
            this.T7indiviPercen.MouseHover += new System.EventHandler(this.textBox10_MouseHover);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "Student ID";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(62, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 13);
            this.label19.TabIndex = 46;
            this.label19.Text = "INDIVIDUAL MARKS";
            // 
            // ApplyindiMark
            // 
            this.ApplyindiMark.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyindiMark.Location = new System.Drawing.Point(13, 95);
            this.ApplyindiMark.Name = "ApplyindiMark";
            this.ApplyindiMark.Size = new System.Drawing.Size(75, 23);
            this.ApplyindiMark.TabIndex = 51;
            this.ApplyindiMark.Text = "Apply";
            this.ApplyindiMark.UseVisualStyleBackColor = true;
            this.ApplyindiMark.Click += new System.EventHandler(this.ApplyindiMark_Click);
            // 
            // ApplyGroup
            // 
            this.ApplyGroup.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyGroup.Location = new System.Drawing.Point(12, 95);
            this.ApplyGroup.Name = "ApplyGroup";
            this.ApplyGroup.Size = new System.Drawing.Size(75, 23);
            this.ApplyGroup.TabIndex = 52;
            this.ApplyGroup.Text = "Apply";
            this.ApplyGroup.UseVisualStyleBackColor = true;
            this.ApplyGroup.Click += new System.EventHandler(this.ApplyGroup_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SaveIndiviMark);
            this.panel4.Controls.Add(this.IndiviMarkStuIDSelect);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.RetrieveIndivi);
            this.panel4.Controls.Add(this.ApplyindiMark);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.T7indiviPercen);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Location = new System.Drawing.Point(926, 350);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 205);
            this.panel4.TabIndex = 53;
            // 
            // SaveIndiviMark
            // 
            this.SaveIndiviMark.Location = new System.Drawing.Point(13, 130);
            this.SaveIndiviMark.Name = "SaveIndiviMark";
            this.SaveIndiviMark.Size = new System.Drawing.Size(75, 23);
            this.SaveIndiviMark.TabIndex = 58;
            this.SaveIndiviMark.Text = "Save";
            this.SaveIndiviMark.UseVisualStyleBackColor = true;
            this.SaveIndiviMark.Click += new System.EventHandler(this.SaveIndiviMark_Click);
            // 
            // IndiviMarkStuIDSelect
            // 
            this.IndiviMarkStuIDSelect.FormattingEnabled = true;
            this.IndiviMarkStuIDSelect.Location = new System.Drawing.Point(99, 39);
            this.IndiviMarkStuIDSelect.Name = "IndiviMarkStuIDSelect";
            this.IndiviMarkStuIDSelect.Size = new System.Drawing.Size(121, 21);
            this.IndiviMarkStuIDSelect.TabIndex = 57;
            // 
            // RetrieveIndivi
            // 
            this.RetrieveIndivi.Location = new System.Drawing.Point(13, 169);
            this.RetrieveIndivi.Name = "RetrieveIndivi";
            this.RetrieveIndivi.Size = new System.Drawing.Size(75, 23);
            this.RetrieveIndivi.TabIndex = 53;
            this.RetrieveIndivi.Text = "Retrieve";
            this.RetrieveIndivi.UseVisualStyleBackColor = true;
            this.RetrieveIndivi.Click += new System.EventHandler(this.RetrieveIndivi_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.SaveGroupMark);
            this.panel5.Controls.Add(this.GroupMarkIDSelect);
            this.panel5.Controls.Add(this.RetrieveGroup);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.ApplyGroup);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.T6GMARK);
            this.panel5.Location = new System.Drawing.Point(596, 353);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 202);
            this.panel5.TabIndex = 54;
            // 
            // SaveGroupMark
            // 
            this.SaveGroupMark.Location = new System.Drawing.Point(12, 130);
            this.SaveGroupMark.Name = "SaveGroupMark";
            this.SaveGroupMark.Size = new System.Drawing.Size(75, 23);
            this.SaveGroupMark.TabIndex = 57;
            this.SaveGroupMark.Text = "Save";
            this.SaveGroupMark.UseVisualStyleBackColor = true;
            this.SaveGroupMark.Click += new System.EventHandler(this.SaveGroupMark_Click);
            // 
            // GroupMarkIDSelect
            // 
            this.GroupMarkIDSelect.FormattingEnabled = true;
            this.GroupMarkIDSelect.Location = new System.Drawing.Point(94, 37);
            this.GroupMarkIDSelect.Name = "GroupMarkIDSelect";
            this.GroupMarkIDSelect.Size = new System.Drawing.Size(121, 21);
            this.GroupMarkIDSelect.TabIndex = 56;
            // 
            // RetrieveGroup
            // 
            this.RetrieveGroup.Location = new System.Drawing.Point(12, 169);
            this.RetrieveGroup.Name = "RetrieveGroup";
            this.RetrieveGroup.Size = new System.Drawing.Size(75, 23);
            this.RetrieveGroup.TabIndex = 54;
            this.RetrieveGroup.Text = "Retrieve";
            this.RetrieveGroup.UseVisualStyleBackColor = true;
            this.RetrieveGroup.Click += new System.EventHandler(this.RetrieveGroup_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.createGroupId);
            this.panel6.Controls.Add(this.T1);
            this.panel6.Controls.Add(this.label24);
            this.panel6.Controls.Add(this.label23);
            this.panel6.Location = new System.Drawing.Point(12, 304);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(306, 56);
            this.panel6.TabIndex = 55;
            // 
            // createGroupId
            // 
            this.createGroupId.Location = new System.Drawing.Point(221, 23);
            this.createGroupId.Name = "createGroupId";
            this.createGroupId.Size = new System.Drawing.Size(75, 23);
            this.createGroupId.TabIndex = 35;
            this.createGroupId.Text = "Enter";
            this.createGroupId.UseVisualStyleBackColor = true;
            this.createGroupId.Click += new System.EventHandler(this.createGroupId_Click);
            // 
            // T1
            // 
            this.T1.Location = new System.Drawing.Point(94, 25);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(121, 20);
            this.T1.TabIndex = 34;
            this.T1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox13_KeyPress);
            this.T1.MouseHover += new System.EventHandler(this.T1_MouseHover);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(20, 28);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(50, 13);
            this.label24.TabIndex = 35;
            this.label24.Text = "Group ID";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(111, 6);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(92, 13);
            this.label23.TabIndex = 34;
            this.label23.Text = "CREATE GROUP";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(828, 93);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(400, 198);
            this.dataGridView3.TabIndex = 56;
            this.dataGridView3.SelectionChanged += new System.EventHandler(this.dataGridView3_SelectionChanged);
            // 
            // Clear_IndiviScreen
            // 
            this.Clear_IndiviScreen.Location = new System.Drawing.Point(949, 321);
            this.Clear_IndiviScreen.Name = "Clear_IndiviScreen";
            this.Clear_IndiviScreen.Size = new System.Drawing.Size(173, 23);
            this.Clear_IndiviScreen.TabIndex = 58;
            this.Clear_IndiviScreen.Text = "Clear Individual Screen";
            this.Clear_IndiviScreen.UseVisualStyleBackColor = true;
            this.Clear_IndiviScreen.Click += new System.EventHandler(this.Clear_IndiviScreen_Click);
            // 
            // CloseProg
            // 
            this.CloseProg.Location = new System.Drawing.Point(588, 615);
            this.CloseProg.Name = "CloseProg";
            this.CloseProg.Size = new System.Drawing.Size(125, 23);
            this.CloseProg.TabIndex = 59;
            this.CloseProg.Text = "Close";
            this.CloseProg.UseVisualStyleBackColor = true;
            this.CloseProg.Click += new System.EventHandler(this.CloseProg_Click);
            // 
            // Student_Clear
            // 
            this.Student_Clear.Location = new System.Drawing.Point(445, 65);
            this.Student_Clear.Name = "Student_Clear";
            this.Student_Clear.Size = new System.Drawing.Size(75, 23);
            this.Student_Clear.TabIndex = 61;
            this.Student_Clear.Text = "CLEAR";
            this.Student_Clear.UseVisualStyleBackColor = true;
            this.Student_Clear.Click += new System.EventHandler(this.Student_Clear_Click);
            // 
            // Clear_Group
            // 
            this.Clear_Group.Location = new System.Drawing.Point(626, 321);
            this.Clear_Group.Name = "Clear_Group";
            this.Clear_Group.Size = new System.Drawing.Size(173, 23);
            this.Clear_Group.TabIndex = 62;
            this.Clear_Group.Text = "Clear Group Screen";
            this.Clear_Group.UseVisualStyleBackColor = true;
            this.Clear_Group.Click += new System.EventHandler(this.Clear_Group_Click);
            // 
            // CSV_Retrieve
            // 
            this.CSV_Retrieve.Location = new System.Drawing.Point(147, 65);
            this.CSV_Retrieve.Name = "CSV_Retrieve";
            this.CSV_Retrieve.Size = new System.Drawing.Size(96, 23);
            this.CSV_Retrieve.TabIndex = 63;
            this.CSV_Retrieve.Text = "CSV RETRIEVE";
            this.CSV_Retrieve.UseVisualStyleBackColor = true;
            this.CSV_Retrieve.Click += new System.EventHandler(this.CSV_Retrieve_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(631, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 22);
            this.label5.TabIndex = 64;
            this.label5.Text = "GROUP SCREEN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(969, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 22);
            this.label9.TabIndex = 65;
            this.label9.Text = "INDIVIDUAL SCREEN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1233, 678);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CSV_Retrieve);
            this.Controls.Add(this.Clear_Group);
            this.Controls.Add(this.Student_Clear);
            this.Controls.Add(this.CloseProg);
            this.Controls.Add(this.Clear_IndiviScreen);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.GroupID_Sort);
            this.Controls.Add(this.Student_Mark_SortID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Save_ClassList);
            this.Controls.Add(this.Retrieve_ClassList);
            this.Controls.Add(this.Sort_ByID_Stu);
            this.Controls.Add(this.Sort_Student);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sort_Student;
        private System.Windows.Forms.Button Sort_ByID_Stu;
        private System.Windows.Forms.Button CreateStudent;
        private System.Windows.Forms.Button Retrieve_ClassList;
        private System.Windows.Forms.Button Save_ClassList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox T2ID;
        private System.Windows.Forms.TextBox T3FirstName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox T4LastName;
        private System.Windows.Forms.TextBox T5Email;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button GroupID_Sort;
        private System.Windows.Forms.Button Student_Mark_SortID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox T6GMARK;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox T7indiviPercen;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button ApplyindiMark;
        private System.Windows.Forms.Button ApplyGroup;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button RetrieveGroup;
        private System.Windows.Forms.Button RetrieveIndivi;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button createGroupId;
        private System.Windows.Forms.TextBox T1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button Clear_IndiviScreen;
        private System.Windows.Forms.Button CloseProg;
        private System.Windows.Forms.Button Student_Clear;
        private System.Windows.Forms.ComboBox studentGroupIdSelect;
        private System.Windows.Forms.Button Clear_Group;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CSV_Retrieve;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox GroupMarkIDSelect;
        private System.Windows.Forms.ComboBox IndiviMarkStuIDSelect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveGroupMark;
        private System.Windows.Forms.Button SaveIndiviMark;
        private System.Windows.Forms.Button BulkAssign;
    }
}

