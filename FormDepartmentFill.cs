using dotnet_lab11.Models;

namespace dotnet_lab11;

public partial class FormDepartmentFill : Form
{
	private DepartmentModel _model = new();

	public DepartmentModel Model
	{
		get => this._model; 
		set
		{
			this._model = value;
			this.loadBoxes();
		}
	}

	private void loadBoxes()
	{
		this.textBoxFaculty.Text = this._model.FacultyName;
		this.textBoxId.Text = (this._model.Id < 0) ? "" : this.Model.Id.ToString();
		this.textBoxName.Text = this._model.Name;
	}

	public FormDepartmentFill()
	{
		InitializeComponent();
	}
}
