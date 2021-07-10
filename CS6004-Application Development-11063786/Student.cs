using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CS6004_Application_Development_11063786
{   [Serializable]
    public class Student : ISerializable, IComparable
    {
        public int studentId;
        private string firstName = "";
        private string surName = "";
        private string email = "";
        private string groupNo;
        private int percentage;
        private int marking;


        public Student(int studentID)
        {
            studentId = studentID;
      
        }

        public int StudentID
        {
            get { return this.studentId; }
            set { this.studentId = value; }
        }

        public string StudentsFirst
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string StudentLast
        {
            get { return this.surName; }
            set { this.surName = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }

        }

        public string Group
        {
            get { return this.groupNo; }
            set { this.groupNo = value; }

        }

        public int Percentage
        {
            get {return this.percentage;}
            set {this.percentage = value;}
        }

        public int Grade
        {
            get {return this.marking;}
            set {this.marking = value;}
        }


        public Student(SerializationInfo info, StreamingContext ctxt)
        {
            this.StudentID = (int) info.GetValue("CustomerID", typeof(int));
            this.StudentsFirst = (string) info.GetValue("First Name", typeof(string));
            this.StudentLast = (string) info.GetValue("Last Name", typeof(string));
            this.Email = (string) info.GetValue("Email", typeof(string));
            this.Group = (string) info.GetValue("Group", typeof(string));
            this.Percentage = (int) info.GetValue("%", typeof(int));
            this.Grade = (int)info.GetValue("Grade", typeof(int));
        }


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("CustomerID", (object) this.StudentID);
            info.AddValue("First Name", (object) this.StudentsFirst);
            info.AddValue("Last Name", (object) this.StudentLast);
            info.AddValue("Email", (object) this.Email);
            info.AddValue("Group", (object) this.Group);
            info.AddValue("%", (object)this.Percentage);
            info.AddValue("Grade",(object)this.Grade);
        }

        public int CompareTo(object obj)
        {
            if (obj is Student)
                return this.StudentLast.CompareTo(((Student)obj).StudentLast);
            throw new ArgumentException("HINT: THIS IS NOT A STUDENT !");
        }

        private class StudentSortHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Student student1 = (Student)a;
                Student student2 = (Student)b;

                return (Convert.ToInt32(student1.StudentID)).CompareTo(Convert.ToInt32(student2.StudentID));
            }
        }

       public static IComparer StudentIDsort()
        {
            return (IComparer)new Student.StudentSortHelper();
        }

      
    }
}
