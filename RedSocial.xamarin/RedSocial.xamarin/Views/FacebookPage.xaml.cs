using Newtonsoft.Json;
using Redsocial.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RedSocial.xamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FacebookPage : ContentPage
	{
		public FacebookPage ()
		{
            InitializeComponent();
            CargarPublicaciones();
        }
        private async void CargarPublicaciones()
        {
            HttpClient cliente = new HttpClient();
            cliente.BaseAddress = new Uri("http://192.168.1.55");

            var request = await cliente.GetAsync("/RedSocialApis/api/Publicacion");
            if (request.IsSuccessStatusCode)
            {
                var responseJson = await request.Content.ReadAsStringAsync();
                var publicaciones = JsonConvert.DeserializeObject<List<Publicacion>>(responseJson);
                listPublicaciones.ItemsSource = publicaciones;
            }
        }
    }
}