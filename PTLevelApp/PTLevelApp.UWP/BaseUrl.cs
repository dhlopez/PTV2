using PTLevelApp.UWP;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl))]
namespace PTLevelApp.UWP
{
    public class BaseUrl : IBaseUrl
    {
        public string Get()
        {
            return "ms-appx-web:///";
        }
    }
}
