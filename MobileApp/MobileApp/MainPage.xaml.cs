using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            speechButton.Clicked += async (object sender, EventArgs e) =>
            {
                var speechText = await WaitForSpeechToText();
                speechTextLabel.Text = string.IsNullOrEmpty(speechText) ? "Nothing Recorded" : speechText;
            };
        }
        async Task<string> WaitForSpeechToText()
        {
            return await DependencyService.Get<ISpeechToText>().SpeechToTextAsync();
        }
    }
}
