using DemoApi.TranscryptApi.TranscryptApiService;

namespace DemoApi.TranscryptApi
{
	public interface ITranscryptApi :
		ITranscryptApiAuth,
		ITranscryptApiProfile,
		ITranscryptApiTransport,
		ITranscryptApiAddressBook
	{
	}
}
