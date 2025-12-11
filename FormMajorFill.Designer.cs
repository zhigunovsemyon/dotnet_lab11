namespace dotnet_lab11
{
	partial class FormMajorFill
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
			textBoxName = new TextBox();
			comboBoxDepartments = new ComboBox();
			labelId = new Label();
			labelName = new Label();
			labelDepartment = new Label();
			buttonSave = new Button();
			SuspendLayout();
			// 
			// textBoxId
			// 
			textBoxId.Location = new Point(12, 27);
			textBoxId.Name = "textBoxId";
			textBoxId.ReadOnly = true;
			textBoxId.Size = new Size(185, 23);
			textBoxId.TabIndex = 0;
			// 
			// textBoxName
			// 
			textBoxName.Location = new Point(12, 71);
			textBoxName.Name = "textBoxName";
			textBoxName.Size = new Size(185, 23);
			textBoxName.TabIndex = 1;
			// 
			// comboBoxDepartments
			// 
			comboBoxDepartments.FormattingEnabled = true;
			comboBoxDepartments.Location = new Point(12, 115);
			comboBoxDepartments.Name = "comboBoxDepartments";
			comboBoxDepartments.Size = new Size(185, 23);
			comboBoxDepartments.TabIndex = 2;
			// 
			// labelId
			// 
			labelId.AutoSize = true;
			labelId.Location = new Point(12, 9);
			labelId.Name = "labelId";
			labelId.Size = new Size(24, 15);
			labelId.TabIndex = 3;
			labelId.Text = "ИД";
			// 
			// labelName
			// 
			labelName.AutoSize = true;
			labelName.Location = new Point(12, 53);
			labelName.Name = "labelName";
			labelName.Size = new Size(59, 15);
			labelName.TabIndex = 4;
			labelName.Text = "Название";
			// 
			// labelDepartment
			// 
			labelDepartment.AutoSize = true;
			labelDepartment.Location = new Point(12, 97);
			labelDepartment.Name = "labelDepartment";
			labelDepartment.Size = new Size(54, 15);
			labelDepartment.TabIndex = 5;
			labelDepartment.Text = "Кафедра";
			// 
			// buttonSave
			// 
			buttonSave.Location = new Point(101, 144);
			buttonSave.Name = "buttonSave";
			buttonSave.Size = new Size(96, 23);
			buttonSave.TabIndex = 6;
			buttonSave.Text = "Сохранить";
			buttonSave.UseVisualStyleBackColor = true;
			buttonSave.Click += buttonSave_Click;
			// 
			// FormMajorFill
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(209, 181);
			Controls.Add(buttonSave);
			Controls.Add(labelDepartment);
			Controls.Add(labelName);
			Controls.Add(labelId);
			Controls.Add(comboBoxDepartments);
			Controls.Add(textBoxName);
			Controls.Add(textBoxId);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FormMajorFill";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Данные о специальности";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBoxId;
		private TextBox textBoxName;
		private ComboBox comboBoxDepartments;
		private Label labelId;
		private Label labelName;
		private Label labelDepartment;
		private Button buttonSave;
	}
}