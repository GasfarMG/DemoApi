namespace DemoApi.Common
{
	public class Contact
	{
		public string FullName { get; set; }
		public string ContactId { get; set; }
	}

	public enum ContactsTabs
	{
		ReceiveRequestTb,
		SentRequestTb
	}
}
