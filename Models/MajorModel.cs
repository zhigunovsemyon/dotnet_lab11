using Microsoft.Data.SqlClient;

namespace dotnet_lab11.Models;

public class MajorModel
{
	public string Name { get; set; } = "";

	public Int16 Id { get; set; } = -1;

	public Int16 DepartmentId { get; set; } = -1;

	public byte[]? Image { get; set; } = null;

	private static readonly string _selectMajorsCommand = @"SELECT [majorid], [name], [departmentid], [picture] FROM [dbo].[Majors]";
	private static readonly string _insertMajorCommand = @"INSERT INTO [dbo].[Majors] ([name], [departmentid], [picture]) VALUES (@Name, @DepartmentId, @Image)";
	private static readonly string _updateMajorCommand = @"UPDATE [dbo].[Majors] SET [name] = @Name, [departmentid] = @DepartmentId, [picture] = @Image WHERE [majorid] = @Id";
	private static readonly string _deleteMajorCommand = @"DELETE FROM [dbo].[Majors] WHERE [majorid] = @Id";


	/// <summary> Удаление данной специальности из БД </summary>
	/// <param name="connection">Соединение с сервером</param>
	public void DeleteFromDB(SqlConnection connection)
	{
		using SqlCommand comm = new(_deleteMajorCommand, connection);
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

	/// <summary> Получение списка специльностей </summary>
	/// <param name="connection">Соединение с сервером</param>
	/// <returns>Список специальностей<returns>
	public static List<MajorModel> List(SqlConnection connection)
	{
		List<MajorModel> list = [];

		using SqlCommand comm = new(_selectMajorsCommand, connection);

		try {
			connection.Open();
			var reader = comm.ExecuteReader();
			while (reader.Read()) {
				var newMajor = new MajorModel()
				{
					Id = (Int16)reader["majorid"],
					Name = (String)reader["name"],
					DepartmentId = (Int16)reader["departmentid"],
					Image = reader["picture"] as byte[]
				};

				list.Add(newMajor);
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

	/// <summary> Обновление специальности в БД </summary>
	/// <param name="connection">Соединение с БД</param>
	public void UpdateDB(SqlConnection connection)
	{
		throw new NotImplementedException("MajorModel.UpdateDB() not implimented");
	}

	/// <summary> Добавление специальности в БД </summary>
	/// <param name="connection">Соединение с сервером</param>
	public void AddToDB(SqlConnection connection)
	{
		throw new NotImplementedException("MajorModel.AddToDB() not implimented");
	}
}
