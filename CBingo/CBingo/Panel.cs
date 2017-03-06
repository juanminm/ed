using Gtk;
using System;
using System.Collections.Generic;

namespace CBingo
{
	public class Panel
	{
		private static readonly Gdk.Color COLOR_GREEN = new Gdk.Color (0, 255, 0);
		private IList<Button> buttons = new List<Button> ();
		private Table table = new Table (9, 10, true);

		public Panel ()
		{
			for (int index = 0; index < 90; index++) {
				uint fila = (uint)index / 10;
				uint columna = (uint)index % 10;
				Button button = new Button ();

				button.Label = "" + (index + 1);
				button.Visible = true;
				table.Attach (button, columna, columna + 1, fila, fila + 1);
				buttons.Add (button);
			}

			table.Visible = true;
		}

		public void MarcarNumero (int numero)
		{
			buttons [numero - 1].ModifyBg (StateType.Normal, COLOR_GREEN);
		}

		public Table Table {
			get {
				return table;
			}
		}
	}
}

