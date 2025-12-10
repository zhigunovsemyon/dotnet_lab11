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
		InitializeComponent();
		this.Text = this.tabControlMain.SelectedTab?.Text;
	}

	private void tabControlMain_Selecting(object sender, TabControlCancelEventArgs e)
		=> this.Text = this.tabControlMain.SelectedTab?.Text;

	private void buttonDepartmentsLoad_Click(object sender, EventArgs e)
		=> this.LoadFromDB();

	private void LoadFromDB()
	{ 
		this.listViewDepartments.Items.Clear();
		try {
			var list = DepartmentModel.List(this._sqlconn);
			foreach (var item in list) {
				this.listViewDepartments.Items.Add(departmentModelItem(item));
			}
		}
		catch (Exception ex) {
			MessageBox.Show($"Ошибка при загрузке базы кафедр:\r\n{ex.Message}",
				"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return;
		}
	}

	private static ListViewItem departmentModelItem(DepartmentModel model)
	{
		ListViewItem item = new(model.Id.ToString());
		item.SubItems.Add(model.Name);
		item.SubItems.Add(model.FacultyName);
		item.Tag = model;

		return item;
	}

	private void buttonDepartmentsDelete_Click(object sender, EventArgs e)
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

	private void buttonDepartmentsAdd_Click(object sender, EventArgs e)
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
			this.LoadFromDB();
		}

	}

	private void buttonDepartmentsUpdate_Click(object sender, EventArgs e)
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


		this.LoadFromDB();
	}
}
