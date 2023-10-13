using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ContentOffice
    {
        public int OfficeId { get; set; }
        public string OfficeName { get; set; } = null!;
        public string? OfficeCompanyName { get; set; }
        public string? OfficeAddress1 { get; set; }
        public string? OfficeAddress2 { get; set; }
        public string? OfficeCity { get; set; }
        public string? OfficeZip { get; set; }
        public string? OfficeState { get; set; }
        public string? OfficeCountry { get; set; }
        public string? OfficePhone { get; set; }
        public string? OfficeEmail { get; set; }
        public string? OfficeDirections { get; set; }
        public double? OfficeLatitude { get; set; }
        public double? OfficeLongitude { get; set; }
        public Guid? OfficePhoto { get; set; }
        public string? OfficeDescription { get; set; }
        public bool? OfficeIsHeadquarters { get; set; }
        public string? OfficeIconUrl { get; set; }
    }
}
