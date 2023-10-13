using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ShokouhPardisCourseStudent
    {
        public int CourseStudentId { get; set; }
        public Guid CourseStudentGuid { get; set; }
        public DateTime CourseStudentLastModified { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
    }
}
