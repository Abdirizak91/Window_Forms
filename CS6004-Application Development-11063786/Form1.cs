using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;
using Microsoft.SqlServer.Server;
using PropertyAttributes = System.Data.PropertyAttributes;


namespace CS6004_Application_Development_11063786
{

    
    [Serializable] 
    public partial class Form1 : Form 
    {
        private static int countofstudents = 4;
        private static int countofgroup = 5;
        public ArrayList StudentList = new ArrayList();
        public ArrayList GroupList = new ArrayList();
        public ArrayList StudentMarking = new ArrayList();
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentGroupIdSelect.Items.Add("");
        }

        //Good
        private void createGroupId_Click(object sender, EventArgs e)
        {

            
            if (studentGroupIdSelect.Items.Contains(T1.Text) || GroupMarkIDSelect.Items.Contains((T1.Text)))
            {
                MessageBox.Show("Group ID Entered Already Exists, Please Select From 'Assign Student' / 'GROUP MARKS' Drop Down Menu. Alternatively Please Enter A Unique Group ID", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
               if (T1.Text == null)
                {
                    
                    MessageBox.Show("An empty selection already exists in Group ID drop down menu under 'Assign Student'");
                    
                }
                studentGroupIdSelect.Items.Add(T1.Text);
                

                MessageBox.Show("Unique group ID Was Added To 'Group ID' Under 'Assign Student' & 'GROUP MARKS'");
            }

            
           
        }

        //Good
        private void Student_Clear_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = null;
            
        }


        private void Sort_Student_Click(object sender, EventArgs e)
        {

            this.StudentList.Sort();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.StudentList;
           
        }

        private void CreateStudent_Click(object sender, EventArgs e)
        {
            if (T2ID.Text == "")
            {
                MessageBox.Show("Please provide a student ID");
                return;
            }
            

            //To check new ID is unique.
            foreach (object studentS in StudentList)
            {
                //if a duplicate ID is found
                int check = (((Student) studentS).StudentID);

                if (check.CompareTo(Convert.ToInt32((this.T2ID.Text.ToString()))) == 0)
                {
                    //Creating MessageBox Details & Buttons
                    string writing = "Student ID Entered Is Duplicate. Student ID " + check +
                                     " Already Exists, Would You Like To Update The Student Who Had The ID " + check +
                                     " With The New Values Entered ?";
                    string caption = "CAUTION !";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // Displaying the messagebox for a scenario from above code
                    result = MessageBox.Show(writing, caption, buttons);


                    if (result == DialogResult.Yes)
                    {
                        if (studentGroupIdSelect.SelectedIndex == -1)
                        {
                            MessageBox.Show(
                                "Please select the blank choice from the 'ASSIGN STUDENT' 'Group ID' drop down items, alteratively add a group and select group ID");
                            return;
                        }
                        //Update Student Table
                        ((Student) studentS).StudentsFirst = this.T3FirstName.Text;
                        ((Student) studentS).StudentLast = this.T4LastName.Text;
                        string pattern = "^(?(\")(\".+?(?<!\\\\)\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9][\\-a-z0-9]{0,22}[a-z0-9]))$";
                        if (Regex.IsMatch(T5Email.Text, pattern))
                        {
                            ((Student)studentS).Email = this.T5Email.Text;
                        }
                        else
                        {
                            MessageBox.Show(this.T5Email, "Please Enter Lowercase E-mail With Valid Format");
                            return;
                        }

                        ((Student) studentS).Group = studentGroupIdSelect.SelectedItem.ToString();

                        int count3 = 0;
                        foreach (object x in this.StudentList)
                        {
                            string target = ((Student)x).Group;
                            if (target == studentGroupIdSelect.SelectedItem.ToString() && studentGroupIdSelect.SelectedItem.ToString() != "" && studentGroupIdSelect.SelectedItem.ToString() != null)
                            {
                                count3++;

                            }

                        }

                        if (count3 == 2 ) //if count is 2, execute the code below 
                        {
                            if (!GroupMarkIDSelect.Items.Contains(studentGroupIdSelect.SelectedItem.ToString()))
                            {
                                GroupMarkIDSelect.Items.Add(studentGroupIdSelect.SelectedItem.ToString());
                            }

                            // add the group ID to combobox3 which is for group marking


                            MessageBox.Show(
                                "Group ID " + studentGroupIdSelect.SelectedItem.ToString() + " Is now a group, this group must not exceed 4",
                                "NOTE"); // message to let the user know
                        }



                        MessageBox.Show("The Student With The Email " + ((Student) studentS).Email +
                                        " Is The New Updated Data For ID " + check);

                        //refresh datagridview table 
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = StudentList;
                        dataGridView1.Columns[0].Visible = true;
                        dataGridView1.Columns[1].Visible = true;
                        dataGridView1.Columns[2].Visible = true;
                        dataGridView1.Columns[3].Visible = true;
                        dataGridView1.Columns[4].Visible = true;
                        dataGridView1.Columns[5].Visible = false;
                        dataGridView1.Columns[6].Visible = false;

                        this.T1.Text = "";
                        this.T2ID.Text = "";
                        this.T3FirstName.Text = "";
                        this.T4LastName.Text = "";
                        this.T5Email.Text = "";
                        this.studentGroupIdSelect.SelectedItem = null;
                    }

                    return;
                }
            }



            if (studentGroupIdSelect.SelectedIndex == -1) // combobox is empty and there is a selection made, show message below
            {
                MessageBox.Show("Please select the blank choice from the 'ASSIGN STUDENT' 'Group ID' drop down items");
                return;
            }

            string key = studentGroupIdSelect.SelectedItem.ToString();
            int count = 0;
            foreach (object STUdents in this.StudentList) // loop through the studentlist arraylist
            {
                string gId = ((Student) STUdents).Group;
                if (gId == key && gId != "" && gId != null) // if the newly created student's group ID matches the studentlist arraylist object ID's execute code below
                {
                    count++; //increment counter

                }
            }

            if (count <= 3) // if counter is 3 or less execute code below 
            {
              
                //creating new student object and adding it to studentlist arraylist and displayin it to DGV1
                Student student = new Student(Convert.ToInt32(this.T2ID.Text));
                student.StudentID = Convert.ToInt32(this.T2ID.Text);
                student.StudentsFirst = this.T3FirstName.Text;
                student.StudentLast = this.T4LastName.Text;
                string pattern = "^(?(\")(\".+?(?<!\\\\)\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9][\\-a-z0-9]{0,22}[a-z0-9]))$";
                if (Regex.IsMatch(T5Email.Text, pattern))
                {
                    student.Email = this.T5Email.Text;
                }
                else
                {
                    MessageBox.Show(this.T5Email, "Please Enter Lowercase E-mail With Valid Format");
                    return;
                }
                student.Group = this.studentGroupIdSelect.Text.ToString();

                StudentList.Add(student);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = StudentList;
                dataGridView1.Columns[0].Visible = true;
                dataGridView1.Columns[1].Visible = true;
                dataGridView1.Columns[2].Visible = true;
                dataGridView1.Columns[3].Visible = true;
                dataGridView1.Columns[4].Visible = true;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;



            }

            else
            {
                MessageBox.Show("You have reached the maximum members count for the group " +
                                studentGroupIdSelect.SelectedItem.ToString() +
                                "\neach group can contain a maximum of four members", "CREATE NEW GROUP");
            }



            // counting 'students' objects in studentlist array, checking newly created object
            string key1 = studentGroupIdSelect.SelectedItem.ToString();
            int count2 = 0;
            foreach (object x in this.StudentList)
            {
                string target = ((Student) x).Group;
                if (target == key1 && key1 != "" && key1 != null)
                {
                    count2++;

                }

            }

            if (count2 == 2 && count < 3) //if count is 2, execute the code below 
            {
                if (GroupMarkIDSelect.Items.ToString() != studentGroupIdSelect.SelectedItem.ToString())
                {
                    GroupMarkIDSelect.Items.Add(studentGroupIdSelect.SelectedItem.ToString()); 
                }

                 // add the group ID to combobox3 which is for group marking
                
                
                MessageBox.Show(
                    "Group ID " + studentGroupIdSelect.SelectedItem.ToString() + " Is now a group, this group must not exceed 4",
                    "NOTE"); // message to let the user know
            }

            IndiviMarkStuIDSelect.Items.Add(Convert.ToInt32(T2ID.Text)); // add student ID's to students individual marking combobox

            studentGroupIdSelect.Sorted = true;
            GroupMarkIDSelect.Sorted = true;  // sort all the combobox's
            IndiviMarkStuIDSelect.Sorted = true;

            this.T1.Text = "";
            this.T2ID.Text = "";
            this.T3FirstName.Text = "";
            this.T4LastName.Text = "";  // clear entries fields & selction field.
            this.T5Email.Text = "";
            this.studentGroupIdSelect.SelectedItem = null;
        }

        //Good
        private bool old = true;
        private void Sort_ByID_Stu_Click(object sender, EventArgs e)
        {
            this.StudentList.Sort(Student.StudentIDsort());   //sorts student ID
            this.dataGridView1.DataSource = (object)null;
            this.dataGridView1.DataSource = (object)this.StudentList;

        }

        private void CloseProg_Click(object sender, EventArgs e)
        {
            string writing = "You are about to close the program, are you sure you want to end your session ?\n\nIf you have saved/serialized your work press 'Yes' to close, or 'No' to keep running.";
            string writing2 = "CAUTION";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(writing, writing2, buttons); // close button message and buttons
            if (result == DialogResult.Yes) // if yes is selected in the messagebox options, execute code below
            {
                Close(); // close the program
            }

            return;


        }

     
        private void Save_ClassList_Click(object sender, EventArgs e)
        {
            Stream saveStudent = (Stream)File.Open("Student Details.dat", FileMode.Create); // serializing student from info from DGV1
            new BinaryFormatter().Serialize(saveStudent, StudentList);
            saveStudent.Close();
        }

        private void Retrieve_ClassList_Click(object sender, EventArgs e)
        {
            // Deserialization of students and displaying them to the DGV1 
            Stream openStudent = (Stream) File.Open("Student Details.dat", FileMode.Open);
            this.StudentList = (ArrayList) new BinaryFormatter().Deserialize(openStudent);
            openStudent.Close();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.StudentList;

            // After Deserialization, values stored when retrieved in deserialization.. the values go to their respective fields i.e. comboBox's to store or amend details quickly.
            foreach (object DeserializedStudent in StudentList)
            {
                if (studentGroupIdSelect.Items.Contains(((Student) DeserializedStudent).Group)) // if combobox contains the group ID do nothing
                {

                }
                else
                {

                    studentGroupIdSelect.Items.Add(((Student) DeserializedStudent)
                        .Group); // add deserialized students group ID to studentGroupIdSelect
                }

                if (IndiviMarkStuIDSelect.Items.Contains(((Student) DeserializedStudent).StudentID)) // if combobox contains the student ID do nothing
                {

                }
                else
                {
                    IndiviMarkStuIDSelect.Items.Add(((Student) DeserializedStudent)
                        .StudentID); // Add deserialized students student ID's  to combobox1
                }

            }

            foreach (object DeserializedGroup in StudentList)
            {
              
                if (GroupMarkIDSelect.Items.Contains(((Student) DeserializedGroup).Group)) //if combobox contains the group ID do nothing
                {

                }
                else
                {
                    GroupMarkIDSelect.Items.Add(((Student) DeserializedGroup).Group); // else add the group ID to combobox2
                }
            }

            foreach (object check in GroupMarkIDSelect.Items) // loops through the GroupMark comboBox 
            {
                if (check.ToString().Equals("")) // checks if there is an empty choice
                {
                    GroupMarkIDSelect.Items.Remove(check); // removes empty choice
                    break;
                }
            }


        }

        private void BulkAssign_Click(object sender, EventArgs e)
        {
            int breakcounter = 0;
            int number = 0;
            int Counter = 0;
            int Increment = 0;
            ArrayList Groupless = new ArrayList();
            ArrayList groups = new ArrayList();
            foreach (object students in StudentList)
            {
                if (((Student) students).Group == "")
                {
                    Groupless.Add(((Student) students));
                }
            }

            foreach (object student in StudentList)
            {
                //if ((   (Student) student).Group == comboBox2.Items.ToString())
                if (((Student) student).Group != "")
                {
                    if (!groups.Contains(((Student)student)))
                    {
                        groups.Add(((Student)student));
                    }
                }

            }

            bool j = true;
            bool k = true;
            bool t = true;
            bool loop1 = true;
            bool docheck = true;
            foreach (object pupils in StudentList)
            {
                if (j == true)
                {
                    foreach (object TheGroups in groups)
                    {
                        if (((Student) pupils).Group == ((Student) TheGroups).Group)
                        {
                           Increment++;
                        }
                    }
                }

                j = false;
                
                if (Increment <= 3)
                {
                    if (((Student)pupils).Group == "")
                    {
                        number++;
                        foreach (object GroupIDList in groups)
                        {
                            if (k == true)
                            {
                                foreach (object Stu in StudentList)
                                {
                                    
                                        if (textBox5.Text == ((Student)Stu).Group)
                                        {

                                            Counter++;
                                        }
                                    


                                }

                                k = false;
                            }
                            
                        }
                    }
                }
            }

            if (Counter <= 3)
            {
                //if counter is 1 loop three times and add 
                if (Counter == 1)
                {
                    foreach (object stu in StudentList)
                    {

                        foreach (object grouplesspupils in groups)
                        {
                            if (loop1 == true)
                            {
                                if (((Student)stu).Group == "")
                                {
                                    ((Student)stu).Group = ((Student)grouplesspupils).Group;
                                    breakcounter++;
                                }
                            }

                            if (breakcounter == 3)
                            {
                                loop1 = false;

                            }


                        }

                    }
                }

                if (Counter == 2)
                {
                    foreach (object stu in StudentList)
                    {
                       
                            foreach (object grouplesspupils in groups)
                            {
                                if (loop1 == true)
                                {
                                    if (((Student)stu).Group == "")
                                    {
                                        ((Student)stu).Group = ((Student)grouplesspupils).Group;
                                        breakcounter++;
                                    }
                                }

                                if (breakcounter == 2)
                                {
                                    loop1 = false;

                                }


                            }
                        
                    }

                }

                if (Counter == 3)
                {
                        foreach (object stu in StudentList)
                        {
                       
                            foreach (object grouplesspupils in groups)
                            {
                                if (loop1 == true)
                                {
                                    if (((Student)stu).Group == "")
                                    {
                                        ((Student)stu).Group = ((Student)grouplesspupils).Group;
                                        breakcounter++;
                                    }
                                }

                                if (breakcounter == 1)
                                {
                                    loop1 = false;

                                }


                            }
                        
                        }
                }

                // if counter is 2 loop twice and addd, break 
                //if counter is 3 loop once and add, break.
                
            }
            

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = StudentList;



        }

        private void CSV_Retrieve_Click(object sender, EventArgs e)
        {

            string CSVfileName = "Students.csv"; // the csv file name 
            string csvData = "";

            using (StreamReader OpenStudentFile = new StreamReader(File.OpenRead(CSVfileName))) // stream reader
            {
                csvData = OpenStudentFile.ReadToEnd(); // reads all characters 
            }

            string[] rows = csvData.Replace("\r", "").Split('\n'); //array/store the read characters 
            foreach (string row in rows)
            {
                if (string.IsNullOrEmpty(row)) continue; // if row is empty continue 

                string[] columns = row.Split(','); // use comma as splitting the data 

                Student CSVStudents = new Student(0); // csv object creation

                //colums where datas will be placed
                CSVStudents.StudentID = Convert.ToInt32(columns[0]);
                CSVStudents.StudentsFirst = columns[1];     
                CSVStudents.StudentLast = columns[2];
                CSVStudents.Email = columns[3];
                CSVStudents.Group = columns[4];
                StudentList.Add(CSVStudents);
            }
            //refresh datagridview 1
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = StudentList;

            // empty textbox entry fields 
            this.T2ID.Text = ""; 
            this.T3FirstName.Text = "";
            this.T4LastName.Text = "";
            this.T5Email.Text = "";
        }

        private void Clear_Group_Click(object sender, EventArgs e)
        {
            
            dataGridView2.DataSource = null; // clear data grid view 2
        }

        private void Clear_IndiviScreen_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = null; // clear data grid view 3
        }

        private void ApplyGroup_Click(object sender, EventArgs e)
        {
           if (GroupMarkIDSelect.SelectedItem == "" || GroupMarkIDSelect.SelectedItem == null || T6GMARK.Text == "" || T6GMARK.Text == null)
           {
               MessageBox.Show("Group Markings Parameters Cannot Be Empty !");
               return;
           }

           foreach (object groupedup in GroupList)
           {
               //the compare to group ID
               string check = (((GroupClass)groupedup).Group.ToString());

               if (check.CompareTo((this.GroupMarkIDSelect.SelectedItem.ToString())) == 0)
               {
                   //Creating MessageBox Details & Buttons
                   string writing = "Group ID Entered Is Duplicate. Group ID " + check + "  has already been marked. Would you like to replace the group ID " + check + "'s old values with the values entered ?\nThis may also update individual student grade in 'INDIVIDUAL SCREEN'";
                   string caption = "CAUTION !";
                   MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                   DialogResult result;

                   // Displaying the messagebox for a scenario from above code
                   result = MessageBox.Show(writing, caption, buttons);
                   int counting = 0;
                   if (result == DialogResult.Yes)
                   {
                       //Update Student Table
                       ((GroupClass)groupedup).Group = GroupMarkIDSelect.SelectedItem.ToString();
                       ((GroupClass)groupedup).Mark = Convert.ToInt32(T6GMARK.Text);
                        


                       MessageBox.Show("The Group With The ID " + check + " has a new mark of " + ((GroupClass)groupedup).Mark + ". The group ID's " + check + " data has been successfully updated on to 'Group Screen'");

                       //refresh datagridview table 
                       dataGridView2.DataSource = null;
                       dataGridView2.DataSource = GroupList;
                       dataGridView2.Columns[0].Visible = true;
                       dataGridView2.Columns[1].Visible = true;
                       dataGridView2.Columns[2].Visible = false;

                       //When markings in group list is edited, it reflects on individual screen
                       foreach (object obj in StudentMarking) // loop through the student marking arraylist
                       {
                           if (StudentMarking.Count >= 1) // if the count of the array is more than one execute below code
                           {
                               counting++; // increment counting
                           }
                           if (counting>= 1) // if counting is more than or equals to 1, execute below
                           {
                               if ((GroupMarkIDSelect.SelectedItem.ToString()) == ((Student)obj).Group) // if combobox 2 selection equals to objects in student makring arraylist 
                               {
                                   ((Student)obj).Grade = (((Student)obj).Percentage / 100) * Convert.ToInt32(T6GMARK.Text); // set the grade to these calculations
                                  //refresh the datagridview 3
                                   dataGridView3.DataSource = null;
                                   dataGridView3.DataSource = StudentMarking;
                                   dataGridView3.Columns[0].Visible = true;
                                   dataGridView3.Columns[1].Visible = false;
                                   dataGridView3.Columns[2].Visible = false;
                                   dataGridView3.Columns[3].Visible = false;
                                   dataGridView3.Columns[4].Visible = true;
                                   dataGridView3.Columns[5].Visible = true;
                                   dataGridView3.Columns[6].Visible = true;
                                   int IDstuMark = ((Student)obj).StudentID;
                                    foreach (object studented in StudentList)
                                   {
                                       int IDstuList = ((Student)studented).StudentID;
                                       if (((GroupClass)groupedup).Group == ((Student)studented).Group && IDstuMark == IDstuList)
                                       {
                                           ((Student)studented).Grade = ((Student)obj).Grade;
                                       }
                                   }
                               }
                           }
                       }
                   }
   
                    // if dialog choice is 'no' then nothing happens
                   if (result == DialogResult.No)
                   {
                       return;
                   }
                    
                   return;
               }
           }
           GroupClass group = new GroupClass(this.GroupMarkIDSelect.SelectedItem.ToString());
           group.Group = (this.GroupMarkIDSelect.SelectedItem.ToString());
           group.Mark = Convert.ToInt32(T6GMARK.Text);
           GroupList.Add(group);
           dataGridView2.DataSource = null;
           dataGridView2.DataSource = GroupList;
           dataGridView2.Columns[0].Visible = true;
           dataGridView2.Columns[1].Visible = true;
           dataGridView2.Columns[2].Visible = false;
            
          
           // Refreshing DataGridView3 to reflect the calculations
           int countAgain = 0;
           foreach (object obj in StudentMarking)
           {
               int IDstuMark = ((Student) obj).StudentID;
               if (StudentMarking.Count >= 1)
               {
                   countAgain++;
               }
               if (countAgain >= 1)
               {
                   if ((GroupMarkIDSelect.SelectedItem.ToString()) == ((Student)obj).Group)
                   {
                       ((Student)obj).Grade = (((Student)obj).Percentage / 100) * Convert.ToInt32(T6GMARK.Text);
                       dataGridView3.DataSource = null;
                       dataGridView3.DataSource = StudentMarking;
                       dataGridView3.Columns[0].Visible = true;
                       dataGridView3.Columns[1].Visible = false;
                       dataGridView3.Columns[2].Visible = false;
                       dataGridView3.Columns[3].Visible = false;
                       dataGridView3.Columns[4].Visible = true;
                       dataGridView3.Columns[5].Visible = true;
                       dataGridView3.Columns[6].Visible = true;

                       foreach (object studented in StudentList)
                       {
                           int IDstuList = ((Student) studented).StudentID;
                           if (group.Group == ((Student)studented).Group && IDstuMark == IDstuList)
                           {
                               ((Student) studented).Grade = ((Student) obj).Grade;
                           }
                       }
                   }
               }
           }

           T6GMARK.Text = "";
           GroupMarkIDSelect.SelectedItem = null;
        }

        private void RetrieveGroup_Click(object sender, EventArgs e)
        {

            Stream OpenMarksOfGroups = (Stream)File.Open("GroupMarks.dat", FileMode.Open);
            this.GroupList = (ArrayList)new BinaryFormatter().Deserialize(OpenMarksOfGroups);
            OpenMarksOfGroups.Close();
            this.dataGridView2.DataSource = null;
            this.dataGridView2.DataSource = this.GroupList; 
            
        }

        private void GroupID_Sort_Click(object sender, EventArgs e)
        {
            this.GroupList.Sort(GroupClass.sortByGroup());
            this.dataGridView2.DataSource = (object)null;
            this.dataGridView2.DataSource = (object)this.GroupList;
        }

        private void ApplyindiMark_Click(object sender, EventArgs e)
        {
            if (IndiviMarkStuIDSelect.SelectedItem == null || IndiviMarkStuIDSelect.SelectedItem.ToString() == "" || T7indiviPercen.Text == "" || T7indiviPercen.Text == null)
            {
                MessageBox.Show("Student Marking Parameters Cannot Be Empty", "HINT");
                return;
            }
            Student MarkedStudent = new Student(Convert.ToInt32(IndiviMarkStuIDSelect.SelectedItem));
            MarkedStudent.Percentage = Convert.ToInt32(T7indiviPercen.Text);
            int weighting = Convert.ToInt32(T7indiviPercen.Text);
            int comboBox3Selection = Convert.ToInt32(IndiviMarkStuIDSelect.SelectedItem);
            string syncgroup = MarkedStudent.Group;
            bool check = true;
            int Grade = MarkedStudent.Grade;

            foreach (object checkmarkedstudent in StudentMarking)
            {
                if (((Student) checkmarkedstudent).StudentID == MarkedStudent.StudentID)
                {
                    string writing = "Student ID " + MarkedStudent.StudentID + " has already been marked, would you like to overwrite with the values entered now ?";
                    string caption = "WARNING";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(writing, caption, buttons);
                    if (result == DialogResult.Yes)
                    {
                        ((Student)checkmarkedstudent).StudentID = MarkedStudent.StudentID;
                        ((Student) checkmarkedstudent).Percentage = MarkedStudent.Percentage;

                        if (check == true)
                        {
                            foreach (object groups in GroupList)
                            {
                                if (((Student)checkmarkedstudent).Group == ((GroupClass)groups).Group)
                                {
                                    ((Student)checkmarkedstudent).Grade = (((Student)checkmarkedstudent).Percentage / 100) * ((GroupClass)groups).Mark;
                                    
                                }
                            }

                            if(check == true)
                            {
                                foreach (object FromStudentList in StudentList)
                                {
                                    if (((Student) FromStudentList).StudentID == MarkedStudent.StudentID)
                                    {
                                        ((Student)FromStudentList).Percentage = ((Student)checkmarkedstudent).Percentage;
                                        ((Student)FromStudentList).Grade = ((Student)checkmarkedstudent).Grade;
                                    }
                                    
                                }
                            }
                        }
                        dataGridView3.DataSource = null;
                        dataGridView3.DataSource = StudentMarking;
                        dataGridView3.Columns[0].Visible = true;
                        dataGridView3.Columns[1].Visible = false;
                        dataGridView3.Columns[2].Visible = false;
                        dataGridView3.Columns[3].Visible = false;
                        dataGridView3.Columns[4].Visible = true;
                        dataGridView3.Columns[5].Visible = true;
                        dataGridView3.Columns[6].Visible = true;

                        foreach (object FromStudentList in StudentList)
                        {
                            int StudentListIDs = Convert.ToInt32(((Student)FromStudentList).StudentID);
                            if (comboBox3Selection == StudentListIDs)
                            {
                                ((Student)FromStudentList).Percentage = weighting;
                                MarkedStudent.Group = ((Student)FromStudentList).Group;

                                if (check == true)
                                {
                                    foreach (object groups in GroupList)
                                    {
                                        if (MarkedStudent.Group == ((GroupClass)groups).Group)
                                        {
                                            MarkedStudent.Grade = (MarkedStudent.Percentage / 100) * ((GroupClass)groups).Mark;
                                            ((Student)FromStudentList).Grade = MarkedStudent.Grade;

                                        }
                                    }
                                }
                            }
                        }

                        //Refresh Student List DGV
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = StudentList;
                        return;
                    }

                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
            }

             
            foreach (object FromStudentList in StudentList)
            {
                int StudentListIDs = Convert.ToInt32(((Student)FromStudentList).StudentID);
                if (comboBox3Selection == StudentListIDs)
                {
                    ((Student) FromStudentList).Percentage = weighting;
                    MarkedStudent.Group = ((Student) FromStudentList).Group;

                    if (check == true)
                    {
                        foreach (object groups in GroupList)
                        {
                            if (MarkedStudent.Group == ((GroupClass) groups).Group)
                            {
                                MarkedStudent.Grade = (MarkedStudent.Percentage / 100) * ((GroupClass) groups).Mark;
                                ((Student) FromStudentList).Grade = MarkedStudent.Grade;

                            }
                        }
                    }
                }
            }
            
            StudentMarking.Add(MarkedStudent);
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = StudentMarking;
            dataGridView3.Columns[0].Visible = true;
            dataGridView3.Columns[1].Visible = false;
            dataGridView3.Columns[2].Visible = false;
            dataGridView3.Columns[3].Visible = false;
            dataGridView3.Columns[4].Visible = true;
            dataGridView3.Columns[5].Visible = true;
            dataGridView3.Columns[6].Visible = true;

            Stream IndividualMarkingSave = (Stream)File.Open("Individual Markings.dat", FileMode.Create);
            new BinaryFormatter().Serialize(IndividualMarkingSave, StudentMarking);
            IndividualMarkingSave.Close();
            
            T7indiviPercen.Text = "";
            IndiviMarkStuIDSelect.SelectedItem = null;
        }

        private void RetrieveIndivi_Click(object sender, EventArgs e)
        {//De-serialize student markings 
            Stream IndividualMarkingOpen = (Stream)File.Open("Individual Markings.dat", FileMode.Open);
            this.StudentMarking = (ArrayList)new BinaryFormatter().Deserialize(IndividualMarkingOpen);
            IndividualMarkingOpen.Close();

            //refresh datagridview3
            this.dataGridView3.DataSource = null;
            this.dataGridView3.DataSource = this.StudentMarking;
            dataGridView3.Columns[0].Visible = true;
            dataGridView3.Columns[1].Visible = false;
            dataGridView3.Columns[2].Visible = false;
            dataGridView3.Columns[3].Visible = false;
            dataGridView3.Columns[4].Visible = true;
            dataGridView3.Columns[5].Visible = true;
            dataGridView3.Columns[6].Visible = true;
        }

        private void Student_Mark_SortID_Click(object sender, EventArgs e)
        {//sorting out datagridview 3 by student ID 
            this.StudentMarking.Sort(Student.StudentIDsort());
            this.dataGridView3.DataSource = (object)null;
            this.dataGridView3.DataSource = (object)this.StudentMarking;
            dataGridView3.Columns[0].Visible = true;
            dataGridView3.Columns[1].Visible = false;
            dataGridView3.Columns[2].Visible = false;
            dataGridView3.Columns[3].Visible = false;
            dataGridView3.Columns[4].Visible = true;
            dataGridView3.Columns[5].Visible = true;
            dataGridView3.Columns[6].Visible = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void T1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Numbers Only", T1); //textbox would only accept numbers hover message
        }

        private void T2ID_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Numbers Only", T2ID); //textbox would only accept numbers hover message
        }

        private void T3FirstName_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Alphabet Only", T3FirstName); //textbox would only accept numbers hover message
        }

        private void T4LastName_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Alphabet Only", T4LastName); //textbox would only accept numbers hover message
        }

        private void textBox5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Numbers Only", textBox5); //textbox would only accept numbers hover message
        }

        private void textBox4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Numbers Only", T6GMARK); //textbox would only accept numbers hover message
        }

        private void textBox10_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Numbers Only", T7indiviPercen); //textbox would only accept numbers hover message
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            string pattern = "^(?(\")(\".+?(?<!\\\\)\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9][\\-a-z0-9]{0,22}[a-z0-9]))$";
            if (Regex.IsMatch(T5Email.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.T5Email, "Please Enter Lowercase E-mail With Valid Format");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            //Selection from datagridview reflect to 'ASSIGN STUDENT' fields
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                
                foreach (object student in StudentList)

                {
                    Student Selection = row.DataBoundItem as Student;
                    if (Selection != null)
                    {
                        this.T2ID.Text = Selection.StudentID.ToString();
                        this.T3FirstName.Text = Selection.StudentsFirst.ToString();
                        this.T4LastName.Text = Selection.StudentLast.ToString();
                        this.T5Email.Text = Selection.Email.ToString();
                        this.studentGroupIdSelect.SelectedItem = Selection.Group.ToString();
                    }

                }
            }



        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            //Selection from datagridview reflect to 'ASSIGN STUDENT' fields
            foreach (DataGridViewRow row in this.dataGridView2.SelectedRows)
            {

                foreach (object groupies in GroupList)

                {
                    GroupClass Selection2 = row.DataBoundItem as GroupClass;
                    if (Selection2 != null)
                    {
                        this.T6GMARK.Text = Selection2.Mark.ToString();
                        this.GroupMarkIDSelect.SelectedItem = Selection2.Group.ToString();
                    }

                }
            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView3.SelectedRows)
            {

                foreach (object StudentMarkRecord in StudentMarking)

                {
                    Student Selection3 = row.DataBoundItem as Student;
                    if (Selection3 != null)
                    {
                        this.T7indiviPercen.Text = Selection3.Percentage.ToString();
                        this.IndiviMarkStuIDSelect.SelectedItem = Selection3.StudentID.ToString();
                    }

                }
            }
        }

        private void SaveGroupMark_Click(object sender, EventArgs e)
        {
            Stream OpenMarksOfGroupies = (Stream)File.Open("GroupMarks.dat", FileMode.Create);
            new BinaryFormatter().Serialize(OpenMarksOfGroupies, GroupList);
            OpenMarksOfGroupies.Close();
        }

        private void SaveIndiviMark_Click(object sender, EventArgs e)
        {
            Stream IndividualMarkingSave = (Stream)File.Open("Individual Markings.dat", FileMode.Create);
            new BinaryFormatter().Serialize(IndividualMarkingSave, StudentMarking);
            IndividualMarkingSave.Close();
        }
    }
}
