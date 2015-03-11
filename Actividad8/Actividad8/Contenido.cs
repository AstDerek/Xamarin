using System;
using Xamarin.Forms;

namespace Actividad8
{
	public class Contenido: ContentPage
	{
		public Contenido ()
		{
			this.Content = new Label {
				Text = "Bienvenido al contenido",
				TextColor = Color.Green,
				BackgroundColor = Color.White,
				HorizontalOptions = LayoutOptions.ExpandAndCenter,
				VerticalOptions = LayoutOptions.ExpandAndCenter
			}
		}
	}
}

