using HaveshApp.Data;
using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ShokouhPardisTeacherTermClass : BranchBaseModel
	{
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public DateTime LastModified { get; set; }
        public int TeacherFk { get; set; }
        public int TermFk { get; set; }
    }
}
