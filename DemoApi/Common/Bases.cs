using System.Windows.Forms;

namespace DemoApi.Common
{
	public abstract class Bases
	{
		public static void ShowError(string errorMessage)
		{
			MessageBox.Show(errorMessage, @"Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static void ShowInfo(string infoMessage)
		{
			MessageBox.Show(infoMessage, @"Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
