using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._03Cshap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tạo đối tượng 
            StudentModel action = new StudentModel();
            // gọi phương thức lấy tất cả sinh viên
            List<Student> listall =action.GetStudents();
            // hiển thị
            foreach (var item  in listall)
            {
                item.Display();
            }
            // gọi phương thức lấy sinh viên theo ID
            Student st = action.GetStudent(2); 
            // hiển thị
            st.Display();
            // gọi phương thức lấy sinh viên có tuổi từ 25-30
            List<Student> listage = action.GetStudent(19, 20);
            foreach (var item in listage)
            {
                item.Display();
            }
            Console.ReadKey();
        }
    }
}
