using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();

		Console.WriteLine("20/7 = " + (20/7) + " resto = " + (20%7) );

		buttonGoForward.Clicked += delegate {
			label_saludo.Text = "Hola " + entry_name.Text;
		};

		Table table = new Table (9, 10, true);

/*		for (uint vez = 0; vez < 90; vez++) {
			Button button = new Button ();
			button.Label = "Btn " + vez;
			button.Visible = true;
			table.Attach (button, vez%10, vez%10 + 1, vez/10, vez/10 +1);
			button.Clicked += delegate {
				Console.WriteLine ("Clicked on");
			};
		}*/

		for (uint row = 0; row < 9; row++) {
			for (uint column = 0; column < 10; column++) {
				uint index = row * 10 + column;
				Button button = new Button ();
				button.Label = "Btn " + index;
				button.Visible = true;
				table.Attach (button, column, column + 1, row, row + 1);
				button.Clicked += delegate {
					Console.WriteLine ("Clicked on");
				};
			}
		}


		table.Visible = true;
		vbox1.Add (table);
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

/*	protected void OnBtnForwardClicked (object sender, EventArgs e)
	{
		label_saludo.Text = "Hola " + entry_name.Text;
	} */
}
