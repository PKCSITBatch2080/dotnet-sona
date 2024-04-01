//LINQ=Language Integrated Query
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

class LINQLearner
{
    void Learn()
    {
        int[] numbers=[3,4,5,66,11,56,77,89];
        List<string>names=["Sona","Sita","Seema","Prajita","Prakriti"];

        var s1=new Student("Sona",21,new DateTime(2001,12,21));
        var s2=new Student("Prajita",22,new DateTime(2000,12,2));
        var s3=new Student("Prakriti",21,new DateTime(1999,12,1));
        var s4=new Student("Anupa",25,new DateTime(1994,12,21));
        var s5=new Student("Bamikshya",25,new DateTime(1995,12,21));
        List<Student>students=[s1,s2,s3,s4,s5];
        //Get odd numbers from numbers
        var oddNumbers=numbers.Where(number=>number%2==1);
        
        //Get squares of all items in "numbers"
        var squares=numbers.Select(x=>x*x);
        
        //get squares of even number
        var evenSquares=numbers.Where(x=>x%2==0).Select(y=>y*y);    //Lamda expression
        //Query syntax
        evenSquares=from x in numbers
              where x%2==0
              select x*x;
        
        //get all name initial
        var initial=names.Select(name=>name[0]);  //['s','s','s','p','p']
        //Order names in ascending order
        var namesOrdered=names.OrderBy(x=>x);

        //find students name starting with "B"
        var bStudents=students.Where(student=>student.name.StartsWith('B'));
        //group student by months
        var dobGroups=students.GroupBy(student=>student.Dob.Month);

        //get youngest student
        var youngest=students.OrderByDescending(x=>x.Dob).First();
        youngest=students.MaxBy(x=>x.Dob);
        // youngest=students.FirstOrDefault(x=>DateTime.Now-x.Dob);
    }
}