using System;
using DemoApi.TranscryptApi.TranscryptApiService;

namespace DemoApi.Common
{
	public class Document
	{
		public string AgentName { get; set; }
		public string Title { get; set; }
		public string Status { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime UpdateTime { get; set; }
		public Guid DocumentId { get; set; }
	}
}
