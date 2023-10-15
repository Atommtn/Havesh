using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ShokouhBranchNode
    {
        public int BranchNodeId { get; set; }
        public string? BranchType { get; set; }
        public string BranchName { get; set; } = null!;
        public string? BranchTel { get; set; }
        public string? BranchAdd { get; set; }
        public string? BranchManager { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string? BranchPicUrl { get; set; }
        public string? BranchDesc { get; set; }
    }
}
