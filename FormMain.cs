using System.Diagnostics;
using dotnet_lab11.Models;
using Microsoft.Data.SqlClient;

namespace dotnet_lab11;

public partial class FormMain : Form
{
	private const string _connectionString = "Data Source=localhost;"
		+ "Initial Catalog=lab_dotnet;"
		+ "Integrated Security=True;"
		+ "Persist Security Info=False;"
		+ "Pooling=False;"
		+ "MultipleActiveResultSets=False;"
		+ "Encrypt=False;"
		+ "TrustServerCertificate=True";

	private readonly SqlConnection _sqlconn = new(_connectionString);

	private readonly FormDepartmentFill _formDepartment = new();

	public FormMain()
	{
		this.InitializeComponent();
		this.Text = this.tabControlMain.SelectedTab?.Text;
	}

	/// <summary> Изменение названия по смене вкладки </summary>
	private void tabControlMain_Selecting(object _, TabControlCancelEventArgs __)
		=> this.Text = this.tabControlMain.SelectedTab?.Text;

	/// <summary> Нажатие на кнопку загрузки кафедр </summary>
	private void buttonDepartmentsLoad_Click(object _, EventArgs __)
		=> this.LoadDepartmentsFromDB();

	/// <summary> Загрузка кафедр БД </summary>
	private void LoadDepartmentsFromDB()
	{ 
		this.listViewDepartments.Items.Clear();
		try {
			var list = DepartmentModel.List(this._sqlconn);
			foreach (var item in list) {
				this.listViewDepartments.Items.Add(DepartmentModelItem(item));
			}
		}
		catch (Exception ex) {
			MessageBox.Show($"Ошибка при загрузке базы кафедр:\r\n{ex.Message}",
				"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return;
		}
	}

	/// <summary> Преобразование модели кафедры в соответствующий элемент списка </summary>
	/// <param name="model">Модель кафедры</param>
	/// <returns>Элемент списка</returns>
	private static ListViewItem DepartmentModelItem(DepartmentModel model)
	{
		ListViewItem item = new(model.Id.ToString());
		item.SubItems.Add(model.Name);
		item.SubItems.Add(model.FacultyName);
		item.Tag = model;

		return item;
	}

	/// <summary> Нажатие на клавишу удаления кафедры </summary>
	private void buttonDepartmentsDelete_Click(object _, EventArgs __)
	{
		if (this.listViewDepartments.SelectedItems.Count <= 0) {
			return;
		}

		var lvItemIdx = this.listViewDepartments.SelectedItems[0].Index;
		var department = this.listViewDepartments.Items[lvItemIdx].Tag
			as DepartmentModel;
		Debug.Assert(department != null);

		try {
			department.DeleteFromDB(this._sqlconn);
		}
		catch (Exception ex) {
			MessageBox.Show($"Ошибка при загрузке базы кафедр:\r\n{ex.Message}",
				"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		finally {
			this.listViewDepartments.Items.RemoveAt(lvItemIdx);
		}
	}

	/// <summary> Нажатие на клавишу добавления кафедры </summary>
	private void buttonDepartmentsAdd_Click(object _, EventArgs __)
	{
		this._formDepartment.Model = new DepartmentModel();
		if (DialogResult.OK != this._formDepartment.ShowDialog()) {
			return;
		}
		try {
			this._formDepartment.Model.AddToDB(this._sqlconn);
		}
		catch (Exception ex) {
			MessageBox.Show($"Ошибка при добавлении в базу кафедр:\r\n{ex.Message}",
				"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		finally {
			this.LoadDepartmentsFromDB();
		}

	}

	/// <summary> Нажатие на клавишу обновления кафедры в БД </summary>
	private void buttonDepartmentsUpdate_Click(object _, EventArgs __)
	{
		if (this.listViewDepartments.SelectedItems.Count <= 0) {
			return;
		}

		var lvItemIdx = this.listViewDepartments.SelectedItems[0].Index;
		var department = this.listViewDepartments.Items[lvItemIdx].Tag
			as DepartmentModel;
		Debug.Assert(department != null);

		this._formDepartment.Model = department;

		if (DialogResult.OK != this._formDepartment.ShowDialog()) {
			return;
		}
		//todo

		this.LoadDepartmentsFromDB();
	}
}
