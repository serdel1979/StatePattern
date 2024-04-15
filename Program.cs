using PatternState.State;

CustomerContext customerContext = new CustomerContext();

Console.WriteLine(customerContext.GetState);

customerContext.Requesst();