
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.VBox vBoxMain;
	private global::Gtk.HBox hbox4;
	private global::Gtk.Entry entry3;
	private global::Gtk.Button buttonGoForward;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vBoxMain = new global::Gtk.VBox ();
		this.vBoxMain.Name = "vBoxMain";
		this.vBoxMain.Spacing = 6;
		// Container child vBoxMain.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.entry3 = new global::Gtk.Entry ();
		this.entry3.CanFocus = true;
		this.entry3.Name = "entry3";
		this.entry3.IsEditable = true;
		this.entry3.InvisibleChar = '•';
		this.hbox4.Add (this.entry3);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.entry3]));
		w1.Position = 0;
		// Container child hbox4.Gtk.Box+BoxChild
		this.buttonGoForward = new global::Gtk.Button ();
		this.buttonGoForward.CanFocus = true;
		this.buttonGoForward.Name = "buttonGoForward";
		this.buttonGoForward.UseStock = true;
		this.buttonGoForward.UseUnderline = true;
		this.buttonGoForward.Label = "gtk-go-forward";
		this.hbox4.Add (this.buttonGoForward);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.buttonGoForward]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		this.vBoxMain.Add (this.hbox4);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vBoxMain [this.hbox4]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		this.Add (this.vBoxMain);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
