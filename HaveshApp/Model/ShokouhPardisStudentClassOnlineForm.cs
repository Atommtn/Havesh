using HaveshApp.Data;
using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ShokouhPardisStudentClassOnlineForm : BranchBaseModel
	{
        public int StudentClassId { get; set; }
        public string StudentIdno { get; set; } = null!;
        public string StudentName { get; set; } = null!;
        public string StudentFamily { get; set; } = null!;
        public int? StudentShno { get; set; }
        public DateTime? StudentBirthDay { get; set; }
        public string? StudentFatherName { get; set; }
        public string? FatherJob { get; set; }
        public string? StudentMotherFullName { get; set; }
        public string? MotherJob { get; set; }
        public string? StudentAddress { get; set; }
        public string? StudentFrom { get; set; }
        public string? StudentPhone { get; set; }
        public string? FatherPhone { get; set; }
        public string? MotherPhone { get; set; }
        public string? HomePhone { get; set; }
        public string? WhatsAppPhone { get; set; }
        public Guid StudentClassGuid { get; set; }
        public DateTime StudentClassLastModified { get; set; }
        public DateTime? SchholStart { get; set; }
        public DateTime? SchoolEnd { get; set; }
        public Guid? UniqueKey { get; set; }
        public string? ProfilePicture { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? RecordVersion { get; set; }
        public bool? IsGirl { get; set; }
    }
}
