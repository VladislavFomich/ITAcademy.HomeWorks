using System;
using System.Collections.Generic;
using System.Text;

namespace hm_11_task_1
{
    class StudentAndTeacherTest
    {
       public static void Test()
        {
            Person person = new Person();
            person.Greeting();

            Student student = new Student();
            student.SetAge();
            student.ShowAge();
            student.Greeting();
            student.GoToClasses();
            
            Teacher teacher = new Teacher();
            teacher.SetAge();
            teacher.Explain();
        }
    }
}
