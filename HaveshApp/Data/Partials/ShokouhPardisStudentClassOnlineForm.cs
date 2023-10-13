using System.ComponentModel.DataAnnotations.Schema;

namespace ShokouhApp.Model
{
    public partial class ShokouhPardisStudentClassOnlineForm
    {
       

        [NotMapped]
        public TimeSpan? SchoolStartTime
        {
            get => SchholStart?.TimeOfDay;
            set
            {
                if(value is {})
                    SchholStart = DateTime.MinValue.Add(value.Value);
            }
        }

        [NotMapped]
        public TimeSpan? SchoolEndTime
        {
            get => SchoolEnd?.TimeOfDay;
            set
            {
                if (value is { })
                    SchoolEnd = DateTime.MinValue.Add(value.Value);
            }

        }

       
    }
}
