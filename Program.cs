/*
 * create a list of students
 * create a list of student records
 * calculate studentgrades
 * create a new list that has the complete record
 * 
 * 
 * entry point
 * business logic 
 */

using List;
using List.Models;

var student = new List<Student>()
{
    new Student
    {
        FullName = "Augustine Aroke",
        Id = 1
    },
      new Student
    {
        FullName = "Esther Rotimi",
        Id = 2
    },
        new Student
    {
        FullName = "Abdullahi Jamilu",
        Id = 3
    }

};

var studentRecord = new List<StudentRecord>()
{
    new StudentRecord
    {
        Id = 1,
        EnglishScore = 89,
        MathsScore = 70
    },
    new StudentRecord
    {
        Id = 3,
        EnglishScore = 99,
        MathsScore = 94
    },
    new StudentRecord
    {
        Id = 2,
        EnglishScore = 89,
        MathsScore = 90
    },
    new StudentRecord
    {
        Id = 49,
        EnglishScore = 20,
        MathsScore = 78
    }
};


var beans = studentRecord.Select(x => new StudentRecordWithGrade
{
    Id = x.Id,
    EnglishScore = x.EnglishScore,
    MathsScore = x.MathsScore,
    EnglishGrade = GradeCalculator.Calculator(x.EnglishScore),
    MathsGrade = GradeCalculator.Calculator(x.MathsScore)
}).ToList();


List<StudentRecordWithScore> records = new List<StudentRecordWithScore>();
foreach (var d in beans)
{
    var currentstudent = student.FirstOrDefault(x =>  x.Id == d.Id);  
   
    if (currentstudent != null)
    {
        records.Add(new StudentRecordWithScore
        {
            Id = d.Id,
            FullName = currentstudent.FullName,
            EnglishScore = d.EnglishScore,
            MathsScore = d.MathsScore,
            EnglishGrade = d.EnglishGrade,
            MathsGrade = d.MathsGrade
        });
    }
}


foreach (var mydata in records)
{
    Console.WriteLine($"the id of this fellow is {mydata.Id} and the fellow's name is {mydata.FullName} and the score in English is {mydata.EnglishScore}");
}

