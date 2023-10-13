using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using Amazon.S3.Model;
using ShokouhApp.Admin.MemberShip.Model;

namespace ShokouhApp.Model
{
    public partial class InboxMessage
    {
        [Key]
        public int InboxID { get; set; }

        public string Subject { get; set; }
        public int UserFk { get; set; }
        public string MessageBody { get; set; }
        public DateTime CreateDate { get; set; }

        public int ParentMessageID { get; set; }

        public DateTime ExpiryDate { get; set; }

        public int IsReminder { get; set; }
        public DateTime NextReminderDate { get; set; }

        public int ReminderFrequencyId { get; set; }
        
        //comma separator User ID
        public string ReferralMembers { get; set; }
        public int ReferralRoll { get; set; }

        public Guid InboxGuid { get; set; }
        public DateTime InboxLastModified { get; set; }



    }


}
