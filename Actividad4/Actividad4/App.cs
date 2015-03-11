using System;
using Xamarin.Forms;

namespace Actividad4
{
	public class App
	{
		public static Page GetMainPage ()
		{
			ContentPage contentPage = new ContentPage{
				Content = new Label{
					Text = "Etiqueta cambiada",
					TextColor = Color.Blue,
					YAlign = TextAlignment.Center
				}
			};

			return contentPage;
		}
	}
}

