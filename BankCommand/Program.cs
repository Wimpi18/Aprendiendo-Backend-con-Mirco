BankAccount bankAccount = new BankAccount("6495824", 0m);
DepositCommand depositCommand1 = new DepositCommand(bankAccount, 100m);
DepositCommand depositCommand2 = new DepositCommand(bankAccount, 10m);
DepositCommand depositCommand3 = new DepositCommand(bankAccount, 20m);
DepositCommand depositCommand4 = new DepositCommand(bankAccount, 1000m);

TransactionManager transactionManager = new TransactionManager();
transactionManager.ExecuteCommand(depositCommand1);
transactionManager.ExecuteCommand(depositCommand2);
transactionManager.UndoCommand();
transactionManager.UndoCommand();
transactionManager.UndoCommand();
transactionManager.ExecuteCommand(depositCommand3);
transactionManager.UndoCommand();
transactionManager.ExecuteCommand(depositCommand4);
