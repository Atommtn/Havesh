using System.ComponentModel.DataAnnotations.Schema;

namespace HaveshApp.Model
{
    public partial class ShokouhPardisInterval
    {
        [NotMapped]
        public int SourceId { get; set; }


        public static ShokouhPardisInterval CreateInterval()
        {
            return new ShokouhPardisInterval()
            {
                IntervalGuid = Guid.NewGuid(),
                IntervalLastModified = DateTime.Now
            };
        }
    }
    
}
