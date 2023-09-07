using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp6.AcademicsubjEntity;
using static ConsoleApp6.StudentEntity;

namespace ConsoleApp6
{
    class ExamEntity
    {
        public class Exam
        {
            [Key]
            public int Id_ { get; set; }
            public string name { get; set; }
            public int score { get; set; }
            public int academicsub { get; set; }
            public int studentid { get; set; }

            public Academicsubj academicsubj { get; set; }

            public Student student { get; set; }

            public override string ToString()
            {
                return $"Information: name = {name}, score = {score}, student_id = {studentid}";
            }


        }

    }
}
