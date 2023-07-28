using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._03Cshap
{
    internal class StudentModel
    {
        // Khai báo danh tập hợp chứa các sinh viên
        List<Student> liststudents;
        // phương thức khởi tạo
        public StudentModel()
        {
            this.liststudents = new List<Student>
            {
                new Student(){Id=1,Name="Dung",Age=18},
                new Student(){Id=2,Name="Tuan",Age =19},
                new Student(){Id=3,Name="Ha",Age =20},
                new Student(){Id=4,Name="Anh",Age=21},
                new Student(){Id=5,Name="Long",Age=22},
            };
        }
        #region các phương thức overloading
        // phương thức trả về danh sách sinh viên
        public List<Student> GetStudents()
        {
            return liststudents;
        }
        // phương thức trả về sinh viên theo ID
        public Student GetStudent(int id)
        {
            Student st = null;
            foreach (var item in liststudents) 
            {
                if (item.Id == id)
                    st = item;
            }
            return st;
        }
        //Phương thức trả về sinh viên có tuổi từ x to y
        public List<Student> GetStudent(int x, int y)
        {
            List<Student> result = new List<Student>();
            foreach (var item in liststudents) 
            {
                if(item.Age>= x && item.Age<=y)
                    result.Add(item);
            }
            return result;
        }
        #endregion
    }
}
