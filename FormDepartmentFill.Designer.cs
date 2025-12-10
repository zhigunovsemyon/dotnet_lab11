namespace dotnet_lab11
{
	partial class FormDepartmentFill
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBoxId = new TextBox();
			textBoxFaculty = new TextBox();
			textBoxName = new TextBox();
			labelId = new Label();
			labelFaculty = new Label();
			labelName = new Label();
			buttonSave = new Button();
			SuspendLayout();
			// 
			// textBoxId
			// 
			textBoxId.Location = new Point(12, 27);
			textBoxId.Name = "textBoxId";
			textBoxId.ReadOnly = true;
			textBoxId.Size = new Size(124, 23);
			textBoxId.TabIndex = 0;
			// 
			// textBoxFaculty
			// 
			textBoxFaculty.Location = new Point(12, 71);
			textBoxFaculty.Name = "textBoxFaculty";
			textBoxFaculty.Size = new Size(124, 23);
			textBoxFaculty.TabIndex = 1;
			// 
			// textBoxName
			// 
			textBoxName.Location = new Point(142, 27);
			textBoxName.Name = "textBoxName";
			textBoxName.Size = new Size(124, 23);
			textBoxName.TabIndex = 2;
			// 
			// labelId
			// 
			labelId.AutoSize = true;
			labelId.Location = new Point(12, 9);
			labelId.Name = "labelId";
			labelId.Size = new Size(94, 15);
			labelId.TabIndex = 3;
			labelId.Text = "Идентификатор";
			// 
			// labelFaculty
			// 
			labelFaculty.AutoSize = true;
			labelFaculty.Location = new Point(12, 53);
			labelFaculty.Name = "labelFaculty";
			labelFaculty.Size = new Size(124, 15);
			labelFaculty.TabIndex = 4;
			labelFaculty.Text = "Название факультета";
			// 
			// labelName
			// 
			labelName.AutoSize = true;
			labelName.Location = new Point(142, 9);
			labelName.Name = "labelName";
			labelName.Size = new Size(59, 15);
			labelName.TabIndex = 5;
			labelName.Text = "Название";
			// 
			// buttonSave
			// 
			buttonSave.Location = new Point(142, 71);
			buttonSave.Name = "buttonSave";
			buttonSave.Size = new Size(124, 23);
			buttonSave.TabIndex = 6;
			buttonSave.Text = "Сохранить";
			buttonSave.UseVisualStyleBackColor = true;
			// 
			// FormDepartmentFill
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(272, 113);
			Controls.Add(buttonSave);
			Controls.Add(labelName);
			Controls.Add(labelFaculty);
			Controls.Add(labelId);
			Controls.Add(textBoxName);
			Controls.Add(textBoxFaculty);
			Controls.Add(textBoxId);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FormDepartmentFill";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Информация о кафедре";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBoxId;
		private TextBox textBoxFaculty;
		private TextBox textBoxName;
		private Label labelId;
		private Label labelFaculty;
		private Label labelName;
		private Button buttonSave;
	}
}