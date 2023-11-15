using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

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
        }

        public Name Name { get; set; }
		public Document Document { get; set; }
		public Email Email { get; set; } 
		public Address Address { get; set; }
		public IReadOnlyCollection<Subscription> Subscriptions { get{return _subscriptions.ToArray();} }

		public void AddSubscription(Subscription subscription)
		{
			foreach (var sub in Subscriptions)
				sub.Inactivate();

			_subscriptions.Add(subscription);
		}
	}
}