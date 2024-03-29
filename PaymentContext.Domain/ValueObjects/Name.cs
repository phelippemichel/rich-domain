using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract<Name>()
                .Requires()
                .IsBetween(FirstName.Length, 3, 20, "Name.FirstName", "Nome deve conter entre 3 e 40 caracteres")
                .IsBetween(LastName.Length, 3, 20, "Name.LastName", "Sobrenome deve conter entre 3 e 40 caracteres")
            );
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
