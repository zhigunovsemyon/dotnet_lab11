namespace dotnet_lab11;

public partial class FormMain : Form
{
	public FormMain()
	{
		InitializeComponent();
		this.Text = this.tabControlMain.SelectedTab?.Text;
	}

	private void tabControlMain_Selecting(object sender, TabControlCancelEventArgs e)
		=> this.Text = this.tabControlMain.SelectedTab?.Text;
}
