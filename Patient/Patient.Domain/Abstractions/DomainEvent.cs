using MediatR;

namespace PatientManagement.Domain.Abstractions
{
    public abstract record DomainEvent : INotification
    {
        public Guid Id { get; set; }
        public DateTime OccurredOn { get; private set; }       
        protected DomainEvent()
        {
            Id = Guid.NewGuid();
            OccurredOn = DateTime.UtcNow;
        }
    }
}
