using System;
using Xamarin.Forms;

namespace Actividad10
{
	public class Login: ContentPage
	{
		public Login ()
		{
			Entry usuario = new Entry { Placeholder = "Usuario" };
			Entry clave = new Entry { Placeholder = "Clave", IsPassword = true };

			Button boton = new Button {
				Text = "Login",
				TextColor = Color.White,
				BackgroundColor = Color.FromHex ("77D065") 
			};

			boton.Clicked += (sender, e) => {

				if(usuario.Text.Equals("usuario") && usuario.Text.Equals("clave"){
					Navigation.PushAsync(new Contenido());
				} else {
				    usuario.TextColor = Color.Red;
				    clave.TextColor = Color.Red;
				}
			};

			StackLayout stackLayout = new StackLayout
			{
				Spacing = 20, 
				Padding = 50,
				VerticalOptions = LayoutOptions.Center,
				Children =
				{
					usuario,
					clave,
					boton
				}
			};

			this.Content = stackLayout;
			this.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5);
		}
	}
}

