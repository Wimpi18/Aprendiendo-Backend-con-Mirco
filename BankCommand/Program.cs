BankAccount bankAccount = new BankAccount("6495824", 0m);

ActionCommand depositCommand1 = new ActionCommand(
    () => bankAccount.Deposit(100m),
    () => bankAccount.Withdraw(100m)
);

ActionCommand depositCommand2 = new ActionCommand(
    () => bankAccount.Deposit(10m),
    () => bankAccount.Withdraw(10m)
);

ActionCommand depositCommand3 = new ActionCommand(
    () => bankAccount.Deposit(20m),
    () => bankAccount.Withdraw(20m)
);

ActionCommand depositCommand4 = new ActionCommand(
    () => bankAccount.Deposit(1000m),
    () => bankAccount.Withdraw(1000m)
);

TransactionManager transactionManager = new TransactionManager();
transactionManager.ExecuteCommand(depositCommand1);
transactionManager.ExecuteCommand(depositCommand2);
transactionManager.UndoCommand();
transactionManager.UndoCommand();
transactionManager.UndoCommand();
transactionManager.ExecuteCommand(depositCommand3);
transactionManager.UndoCommand();
transactionManager.ExecuteCommand(depositCommand4);
