using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;
using Flunt.Notifications;
using Flunt.Validations;

namespace PaymentContext.Domain.Entities
{
	public class Student : Entity
	{
		private IList<Subscription> _subscriptions;
        public Student(Name name, string lastName, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
			_subscriptions = new List<Subscription>();

			AddNotifications(name, document, email);
        }

        public Name Name { get; set; }
		public Document Document { get; set; }
		public Email Email { get; set; } 
		public Address Address { get; set; }
		public IReadOnlyCollection<Subscription> Subscriptions { get{return _subscriptions.ToArray();} }

		public void AddSubscription(Subscription subscription)
		{
			var hasSubscriptionActive = false;
			foreach (var sub in _subscriptions)
			{
				if(sub.Active)
					hasSubscriptionActive = true;
			}

			// AddNotifications(new Contract<Student>()
            //     .Requires()
            //     .IsFalse(hasSubscriptionActive, "Student.Subscriptions", "Você já tem uma assinatura ativa")
            // );

			if (hasSubscriptionActive)
				AddNotification("Student.Subscriptions", "Você já tem uma assinatura ativa");
		}
	}
}