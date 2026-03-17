var googleStrategy = new GoogleRegister("token_secreto_123");
var system = new RegisterSystem(googleStrategy);
system.Register();
