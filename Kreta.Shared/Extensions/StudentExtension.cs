﻿using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.Shared.Extensions
{
    public static class StudentExtension
    {
        public static StudentDto ToStudentDto(this Student student)
        {
            return new StudentDto
            {
                Id=student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                BirthDay = student.BirthDay,
                SchoolYear = student.SchoolYear,
                SchoolClass = student.SchoolClass,
                EducationLevel = student.EducationLevel
            };
        }

        public static Student ToStudent(this StudentDto studentdto) 
        {
            return new Student
            {
                Id = studentdto.Id,
                FirstName = studentdto.FirstName,
                LastName = studentdto.LastName,
                BirthDay = studentdto.BirthDay,
                SchoolYear = studentdto.SchoolYear,
                SchoolClass = studentdto.SchoolClass,
                EducationLevel = studentdto.EducationLevel
            };
        }
    }

}
