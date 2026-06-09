public class RegistrationHandler
{
    private readonly IMediator<UserRegisteredEvent> _mediator;

    public RegistrationHandler(IMediator<UserRegisteredEvent> mediator)
    {
        _mediator = mediator;
    }

    public void HandleUserRegistered(string username)
    {
        var eventData = new UserRegisteredEvent { Username = username };

        _mediator.Notify(eventData);
    }
}
