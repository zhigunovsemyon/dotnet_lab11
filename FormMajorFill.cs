using dotnet_lab11.Models;

namespace dotnet_lab11;

public partial class FormMajorFill : Form
{
	/// <summary> Добавить новую кафедрку в список доступных </summary>
	/// <param name="department">Кафедра</param>
	public void AddDepartmentModel (DepartmentModel department)
		=> this.comboBoxDepartments.Items.Add (department);

	/// <summary> Очистить список кафедр </summary>
	public void ClearDepartmentModels()
		=> this.comboBoxDepartments.Items.Clear();

	private MajorModel _model = new();

	/// <summary> Модель формы </summary>
	public MajorModel Model
	{
		get => this._model;
		set
		{
			this._model = value;
			this.loadBoxes();
		}
	}

	public FormMajorFill() => this.InitializeComponent();


	/// <summary> Нажатие на кнопку сохранить </summary>
	private void buttonSave_Click(object _, EventArgs __)
	{
		this.Save();
		this.Close();
	}

	/// <summary> Перевести содержимое полей в модель </summary>
	private void Save()
	{
		var selectedItem = this.comboBoxDepartments.SelectedItem as DepartmentModel;
		this.textBoxName.Text = this.textBoxName.Text.Trim();
		if (this.textBoxName.Text.Length <= 0 || selectedItem is null) {
			return;
		}

		this.Model.DepartmentId = selectedItem.Id;
		this.Model.Name = this.textBoxName.Text;
		this.Model.Image = null;

		this.DialogResult = DialogResult.OK;
	}

	/// <summary> Перевести содержимое модели в поля </summary>
	private void loadBoxes()
	{
		if (this.comboBoxDepartments.Items.Count > 0) {
			this.comboBoxDepartments.SelectedIndex = 0;
		}

		this.textBoxId.Text = this.Model.Id < 0 ? "" : this.Model.Id.ToString();
		this.textBoxName.Text = this.Model.Name;
	}
}
