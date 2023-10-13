using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ViewNewsletterSubscriptionsJoined
    {
        public int SubscriberId { get; set; }
        public string? SubscriberFullName { get; set; }
        public string? SubscriberEmail { get; set; }
        public bool? SubscriptionApproved { get; set; }
        public int NewsletterId { get; set; }
        public string? SubscriberType { get; set; }
        public int? SubscriberBounces { get; set; }
        public string NewsletterDisplayName { get; set; } = null!;
        public int SubscriberRelatedId { get; set; }
        public int SubscriberNewsletterId { get; set; }
    }
}
