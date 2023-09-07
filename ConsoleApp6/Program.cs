using Npgsql.EntityFrameworkCore.PostgreSQL;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp6.StudentEntity;
using static ConsoleApp6.ClassroomsEntity;
using ConsoleApp6;
using static ConsoleApp6.AcademicsubjEntity;
using static ConsoleApp6.ExamEntity;

class ApplicationContext : DbContext
{



    public ApplicationContext()
    {
    }

    public DbSet<Classrooms> classrooms { get; set; }
    public DbSet<Student> students { get; set; }
    public DbSet<Academicsubj> academicsubj { get; set; }
    public DbSet<Exam> exam { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=DB3;Username=postgres;Password=1234");
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }



    static void Main(string[] args)
    {
        using (ApplicationContext applicationContext = new ApplicationContext())
        {
            Classrooms classrooms1 = new Classrooms { teacher = "Фролов Константин Иванович" };
            Classrooms classrooms2 = new Classrooms { teacher = "Кузнецов Илья Степанович" };
            Classrooms classrooms3 = new Classrooms { teacher = "Соколова Екатерина Михайловна" };

            Student student1 = new Student { name = "Анна Попова" };
            Student student2 = new Student { name = "Анастасия Афанасьева" };
            Student student3 = new Student { name = "Евгений Соловьев" };
            Student student4 = new Student { name = "Сергей Морозов" };
            Student student5 = new Student { name = "Игорь Воробьев" };
            Student student6 = new Student { name = "Анжелика Голубева" };
            Student student7 = new Student { name = "Наталья Орлова" };

            Academicsubj academicsubj1 = new Academicsubj { name = "Математика" };
            Academicsubj academicsubj2 = new Academicsubj { name = "Информатика" };
            Academicsubj academicsubj3 = new Academicsubj { name = "Физика" };

            Exam exam1 = new Exam { name = "Экзамен по математике" };
            Exam exam2 = new Exam { name = "Экзамен по информатике" };
            Exam exam3 = new Exam { name = "Экзамен по физике" };


            classrooms1.students.Add(student1);
            classrooms2.students.Add(student3);
            classrooms3.students.Add(student2);
            classrooms1.students.Add(student5);
            classrooms2.students.Add(student7);
            classrooms3.students.Add(student6);

            student1.exam.Add(exam1);
            student2.exam.Add(exam1);
            student3.exam.Add(exam2);
            student4.exam.Add(exam2);
            student5.exam.Add(exam3);
            student6.exam.Add(exam2);
            student7.exam.Add(exam3);

            academicsubj1.exam.Add(exam1);
            academicsubj2.exam.Add(exam2);
            academicsubj3.exam.Add(exam3);

            applicationContext.SaveChanges();

        }



        using (ApplicationContext applicationContext = new ApplicationContext())
        {
            List<Exam> exam = applicationContext.exam.ToList();
            foreach (Exam t in exam)
            {
                Console.WriteLine(t);

            }
        }

    }
}
