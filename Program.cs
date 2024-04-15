using PatternState.State;

CustomerContext customerContext = new CustomerContext();

Console.WriteLine(customerContext.GetState);

customerContext.Requesst();

customerContext.SetState(new RevisionState());

Console.WriteLine(customerContext.GetState);

customerContext.Requesst();