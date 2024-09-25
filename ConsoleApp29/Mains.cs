
using System;

using Microsoft.EntityFrameworkCore;

namespace ConsoleApp29;




public class Program
{


    static  async Task Main(string[] args)
    {
        Kurs kurs = new Kurs();

        Teacher teacher1 = new Teacher()
        {
           
            Name = "Akif",



        };


        Teacher teacher2 = new Teacher()
        {
           
            Name = "Qasim",



        };


        Teacher teacher3 = new Teacher()
        {
           
            Name = "Adil",



        };


        Teacher teacher4 = new Teacher()
        {
            
            Name = "Elman",



        };

        Group group1 = new Group()
        {
            //GroupId = 132,
            GroupName = "Riyaziyyat",
           // TeacherId = 214,



        };


        Group group2 = new Group()
        {
            //GroupId = 122,
            GroupName = "Dizayn",
           // TeacherId = 234,



        };



        Group group3 = new Group()
        {
            //GroupId = 130,
            GroupName = "IT",
           // TeacherId = 913,




        };



        Student student1 = new Student()
        {
            FirstName = "Famil",
            LastName = "Rzayev",
            //StudentId = 1,
            //GroupId = 130,
        };


        Student student2 = new Student()
        {
            FirstName = "Qasim",
            LastName = "Verdiyev",
            //StudentId = 2,
            //GroupId = 130,
        };

        Student student3 = new Student()
        {
            FirstName = "Akif",
            LastName = "Verdiyev",
           // StudentId = 3,
           // GroupId = 122,
        };

        Student student4 = new Student()
        {
            FirstName = "Akif",
            LastName = "Bunyadov",
           // StudentId = 4,
           // GroupId = 122,
        };


        Student student5 = new Student()
        {
            FirstName = "Anar",
            LastName = "Bunyadov",
           // StudentId = 5,
           // GroupId = 132,
        };

        Student student6 = new Student()
        {
            FirstName = "Anar",
            LastName = "Qasimli",
            //StudentId = 6,
            //GroupId = 132,
        };

        //await kurs.Teachers.AddAsync(teacher1);
        //await kurs.Teachers.AddAsync(teacher2);
        //await kurs.Teachers.AddAsync(teacher3);
        //await kurs.Teachers.AddAsync(teacher4);
        //await kurs.SaveChangesAsync();


        //await kurs.Students.AddAsync(student1);
        //await kurs.Students.AddAsync(student2);
        //await kurs.Students.AddAsync(student3);
        //await kurs.Students.AddAsync(student4);
        //await kurs.Students.AddAsync(student5);
        //await kurs.Students.AddAsync(student6);
        //await kurs.SaveChangesAsync();


        //await kurs.Groups.AddAsync(group1);
        //await kurs.Groups.AddAsync(group2);
        //await kurs.Groups.AddAsync(group3);
        //await kurs.SaveChangesAsync();



        var Teacher = kurs.Teachers.FirstOrDefault(p => p.TeacherId == 1);

        kurs.Teachers.RemoveRange(teacher1);
        await kurs.SaveChangesAsync();



        //kurs.Teachers.Attach(teacher1);
        //kurs.Entry(teacher1).Property(p => p.Name).IsModified = true;
        //kurs.SaveChanges();





    }



      

}
