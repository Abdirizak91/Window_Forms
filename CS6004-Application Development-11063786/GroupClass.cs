using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Collections;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;

namespace CS6004_Application_Development_11063786
{
    [Serializable]
    public class GroupClass : ISerializable, IComparable
    {
        string groupID;
        string groupName = "";
        int mark;

        public GroupClass(string GID)
        {
            this.groupID = GID;
        }

        public string Group
        {
            get { return this.groupID; }
            set { this.groupID = value; }
        }


        public int Mark
        {
            get { return this.mark; }
            set { this.mark = value; }

        }

    
        public string GroupLabel
        { 
            get { return this.groupName; }
            set { this.groupName = value; }
        }

        public GroupClass(SerializationInfo info, StreamingContext context)
        {
            this.groupID = (string) info.GetValue("Group ID", typeof(string));
            this.Mark = (int) info.GetValue("Mark", typeof(int));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Group ID", (object) this.groupID.ToString());
            info.AddValue("Mark", (object)this.Mark);
        }

        public int CompareTo(object obj)
        {
            if (obj is GroupClass)
                return this.groupID.CompareTo(((GroupClass) obj).groupID);
            throw new ArgumentException("object is not a Department");
        }

        public static IComparer sortByGroup()
        {
            return (IComparer) new GroupClass.IDGROUPHELPER();
        }

        private class IDGROUPHELPER : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                GroupClass group1 = (GroupClass)a;
                GroupClass group2 = (GroupClass)b;

                return (Convert.ToInt32(group1.Group)).CompareTo(Convert.ToInt32(group2.Group));
            }
        }
    }
}