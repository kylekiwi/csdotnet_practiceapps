namespace DiPractice
{
  public class BusinessLogic// : IBusinessLogic
  {
		// IMyLogger _logger;

    // public BusinessLogic(IMyLogger logger)
    // {
    //   _logger = logger;
    // }

		IMyLogger _logger;
		public BusinessLogic(IMyLogger logger)
		{
			_logger = logger;
				
		}
    public void ProcessData()
    {
			// MyLogger myLogger = new MyLogger();
			// myLogger.log();
			_logger.log();
    }



  }
}