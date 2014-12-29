using DemoApi.TranscryptApi.TranscryptApiService;

namespace DemoApi.Common
{
	public class Organization
	{
		public string FullName { get; set; }
		public string DocflowMemberId { get; set; }
		public EntityState State { get; set; }
	}
}
