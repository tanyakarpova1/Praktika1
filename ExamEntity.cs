using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp6.Models.AcademicsubjEntity;
using static ConsoleApp6.Models.StudentEntity;

namespace ConsoleApp6.Models
{
    class ExamEntity
    {
        public class Exam
        {
            [Key]
            public int Id_ { get; set; }
            public string name { get; set; }
            public int score { get; set; }
            public int academicsubjacademicsub { get; set; }
            public int studentid { get; set; }

            public Academicsubj academicsubj { get; set; }

            public Student student { get; set; }

            public override string ToString()
            {
                return $"Information: name = {name}, academic subject = {academicsubjacademicsub}, student_id = {studentid}";
            }


        }

    }
}
