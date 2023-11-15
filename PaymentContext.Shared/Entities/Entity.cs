namespace PaymentContext.Shared.Entities
{
    public abstract class Entity
    {
        public Entity()
        {
            Id =  Guid.NewGuid();
        }
        public System.Guid Id { get; private set; }
    }   
}