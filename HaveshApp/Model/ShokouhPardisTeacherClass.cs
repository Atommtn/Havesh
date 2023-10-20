using HaveshApp.Data;
using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ShokouhPardisTeacherClass : BranchBaseModel
	{
        public int TeacherClassId { get; set; }
        public string? TeacherNationalId { get; set; }
        public Guid TeacherClassGuid { get; set; }
        public DateTime TeacherClassLastModified { get; set; }
        public string TeacherName { get; set; } = null!;
        public string TeacherFamily { get; set; } = null!;
        public bool? TeacherSex { get; set; }
        public DateTime? TeacherBirthDay { get; set; }
        public string? TeacherPic { get; set; }
        public int TermId { get; set; }
        public int? UserId { get; set; }

    }
}
