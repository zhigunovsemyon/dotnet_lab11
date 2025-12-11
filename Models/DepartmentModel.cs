
using Microsoft.Data.SqlClient;

namespace dotnet_lab11.Models;

public class DepartmentModel
{
	private static readonly string _selectDepartmentsCommand = @"SELECT [departmentid], [name], [facultyname] FROM [dbo].[Departments]";
	private static readonly string _insertDepartmentCommand = @"INSERT INTO [dbo].[Departments] ([name], [facultyname]) VALUES (@Name, @FacultyName)";
	private static readonly string _updateDepartmentCommand = @"UPDATE [dbo].[Departments] SET [name] = @Name, [facultyname] = @FacultyName WHERE [departmentid] = @Id";
	private static readonly string _deleteDepartmentCommand = @"DELETE FROM [dbo].[Departments] WHERE [departmentid] = @Id";

	/// <summary> ИД в БД </summary>
	public Int16 Id { get; set; } = -1;

	/// <summary> Название кафедры </summary>
	public string Name { get; set; } = "";

	/// <summary> Название факультета (может отсутствовать) </summary>
	public string? FacultyName { get; set; } = null;

	/// <summary> Удаление данной кафедры из БД </summary>
	/// <param name="connection">Соединение с сервером</param>
	public void DeleteFromDB (SqlConnection connection)
	{
		using SqlCommand comm = new(_deleteDepartmentCommand, connection);
		comm.Parameters.Add("@Id", System.Data.SqlDbType.SmallInt).Value = this.Id;
		try {
			connection.Open();
			comm.ExecuteNonQuery();
		}
		finally {
			if (connection is not null &&
				connection.State == System.Data.ConnectionState.Open) {
				connection.Close();
			}
		}
	}

	/// <summary> Получение списка кафедр </summary>
	/// <param name="connection">Соединение с сервером</param>
	/// <returns>Список кафедр</returns>
	public static List<DepartmentModel> List(SqlConnection connection)
	{
		List<DepartmentModel> list = [];

		using SqlCommand comm = new(_selectDepartmentsCommand, connection);

		try {
			connection.Open();
			var reader = comm.ExecuteReader();
			while (reader.Read()) {
				var newDepartment = new DepartmentModel()
				{
					Id = (Int16)reader["departmentid"],
					Name = (String)reader["name"],
					FacultyName = reader["facultyname"] as string 
				};

				list.Add(newDepartment);
			}
		}
		finally {
			if (connection is not null &&
				connection.State == System.Data.ConnectionState.Open) {
				connection.Close();
			}
		}

		return list;
	}

	/// <summary> Добавление кафедры в БД </summary>
	/// <param name="connection">Соединение с сервером</param>
	public void AddToDB(SqlConnection connection)
	{
		using SqlCommand comm = new(_insertDepartmentCommand, connection);
		comm.Parameters.Add("@Name", System.Data.SqlDbType.VarChar, 50).Value = this.Name;
		comm.Parameters.Add("@FacultyName", System.Data.SqlDbType.VarChar, 50).Value = (object?)this.FacultyName ?? DBNull.Value;
		try {
			connection.Open();
			comm.ExecuteNonQuery();
		}
		finally {
			if (connection is not null &&
				connection.State == System.Data.ConnectionState.Open) {
				connection.Close();
			}
		}
	}

	/// <summary> Обновление кафедры в БД </summary>
	/// <param name="connection">Соединение с БД</param>
	public void UpdateDB(SqlConnection connection)
	{
		using SqlCommand comm = new(_updateDepartmentCommand, connection);
		comm.Parameters.Add("@Id", System.Data.SqlDbType.SmallInt).Value = this.Id;
		comm.Parameters.Add("@Name", System.Data.SqlDbType.VarChar, 50).Value = this.Name;
		comm.Parameters.Add("@FacultyName", System.Data.SqlDbType.VarChar, 50).Value = (object?)this.FacultyName ?? DBNull.Value;

		try {
			connection.Open();
			comm.ExecuteNonQuery();
		}
		finally {
			if (connection is not null &&
				connection.State == System.Data.ConnectionState.Open) {
				connection.Close();
			}
		}
	}

	public override string ToString() => $"{this.Id} {this.Name} {this.FacultyName}";
}
