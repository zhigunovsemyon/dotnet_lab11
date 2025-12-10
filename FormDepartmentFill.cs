using dotnet_lab11.Models;

namespace dotnet_lab11;

public partial class FormDepartmentFill : Form
{
	private DepartmentModel _model = new();

	/// <summary> Модель формы </summary>
	public DepartmentModel Model
	{
		get => this._model;
		set
		{
			this._model = value;
			this.loadBoxes();
		}
	}

	/// <summary> Загрузка полей из объекта кафедры </summary>
	private void loadBoxes()
	{
		this.textBoxFaculty.Text = this._model.FacultyName;
		this.textBoxId.Text = (this._model.Id < 0) ? "" : this.Model.Id.ToString();
		this.textBoxName.Text = this._model.Name;
	}

	/// <summary> Запись содержимого полей в объект кафедры </summary>
	private void Save()
	{
		if (String.IsNullOrWhiteSpace(this.textBoxName.Text)) {
			return;
		}

		this.Model.Name = this.textBoxName.Text.Trim();
		this.DialogResult = DialogResult.OK;

		if (String.IsNullOrWhiteSpace(this.textBoxFaculty.Text)) {
			this.Model.FacultyName = null;
			return;
		}
		this.Model.FacultyName = this.textBoxFaculty.Text.Trim();
	}

	public FormDepartmentFill() => this.InitializeComponent();

	/// <summary> Нажатие на кнопку сохранить </summary>
	private void buttonSave_Click(object _, EventArgs __)
	{
		this.Save();
		this.Close();
	}
}
