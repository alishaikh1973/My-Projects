using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDStudent
{
    internal class StudentCrud
    {
        List<Student> stdlist;
        public StudentCrud()
        {
            stdlist = new List<Student>()
            {
                new Student(){Rollno=1,Name="Ali"},
                new Student(){Rollno=2,Name="Suyash"}
            };
        }

        public List<Student> ShowDetails()
        {
            return stdlist;
        }

        public Student SearchByRollNo(int rollNo)
        {
            Student stR = new Student();
            foreach (Student st in stdlist)
            {
                if (st.Rollno == rollNo)
                {
                    stR = st;
                    break;
                }
            }
            return stR;
        }

        public void AddStudent(Student st)
        {
            stdlist.Add(st);
        }

        public void UpdateRecord(Student st)
        {
            foreach (Student st1 in stdlist)
            {
                if (st.Rollno == st.Rollno)
                {
                    st1.Name = st.Name;
                    break;
                }
            }
        }

        public void DeleteRecord(int rollno)
        {
            foreach (Student st in stdlist)
            {
                if (st.Rollno == rollno)
                {
                    stdlist.Remove(st);
                    break;
                }
            }

        }

    }
}
    

