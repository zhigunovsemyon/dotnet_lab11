namespace dotnet_lab11
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tabControlMain = new TabControl();
			tabPageMajors = new TabPage();
			tabPageDepartments = new TabPage();
			tableLayoutPanelDepartments = new TableLayoutPanel();
			tableLayoutPanelDepartmentsButtons = new TableLayoutPanel();
			buttonDepartmentsDelete = new Button();
			buttonDepartmentsAdd = new Button();
			buttonDepartmentsLoad = new Button();
			buttonDepartmentsUpdate = new Button();
			tableLayoutPanelMajors = new TableLayoutPanel();
			tableLayoutPanelMajorsButtons = new TableLayoutPanel();
			buttonMajorDelete = new Button();
			buttonMajorAdd = new Button();
			buttonMajorLoad = new Button();
			buttonMajorUpdate = new Button();
			tabControlMain.SuspendLayout();
			tabPageMajors.SuspendLayout();
			tabPageDepartments.SuspendLayout();
			tableLayoutPanelDepartments.SuspendLayout();
			tableLayoutPanelDepartmentsButtons.SuspendLayout();
			tableLayoutPanelMajors.SuspendLayout();
			tableLayoutPanelMajorsButtons.SuspendLayout();
			SuspendLayout();
			// 
			// tabControlMain
			// 
			tabControlMain.Controls.Add(tabPageMajors);
			tabControlMain.Controls.Add(tabPageDepartments);
			tabControlMain.Dock = DockStyle.Fill;
			tabControlMain.Location = new Point(0, 0);
			tabControlMain.Name = "tabControlMain";
			tabControlMain.SelectedIndex = 0;
			tabControlMain.Size = new Size(800, 450);
			tabControlMain.TabIndex = 0;
			tabControlMain.Selecting += tabControlMain_Selecting;
			// 
			// tabPageMajors
			// 
			tabPageMajors.Controls.Add(tableLayoutPanelMajors);
			tabPageMajors.Location = new Point(4, 24);
			tabPageMajors.Name = "tabPageMajors";
			tabPageMajors.Padding = new Padding(3);
			tabPageMajors.Size = new Size(792, 422);
			tabPageMajors.TabIndex = 0;
			tabPageMajors.Text = "Специальности";
			tabPageMajors.UseVisualStyleBackColor = true;
			// 
			// tabPageDepartments
			// 
			tabPageDepartments.Controls.Add(tableLayoutPanelDepartments);
			tabPageDepartments.Location = new Point(4, 24);
			tabPageDepartments.Name = "tabPageDepartments";
			tabPageDepartments.Padding = new Padding(3);
			tabPageDepartments.Size = new Size(792, 422);
			tabPageDepartments.TabIndex = 1;
			tabPageDepartments.Text = "Кафедры";
			tabPageDepartments.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanelDepartments
			// 
			tableLayoutPanelDepartments.ColumnCount = 1;
			tableLayoutPanelDepartments.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanelDepartments.Controls.Add(tableLayoutPanelDepartmentsButtons, 0, 1);
			tableLayoutPanelDepartments.Dock = DockStyle.Fill;
			tableLayoutPanelDepartments.Location = new Point(3, 3);
			tableLayoutPanelDepartments.Name = "tableLayoutPanelDepartments";
			tableLayoutPanelDepartments.RowCount = 2;
			tableLayoutPanelDepartments.RowStyles.Add(new RowStyle(SizeType.Percent, 99.99999F));
			tableLayoutPanelDepartments.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
			tableLayoutPanelDepartments.Size = new Size(786, 416);
			tableLayoutPanelDepartments.TabIndex = 0;
			// 
			// tableLayoutPanelDepartmentsButtons
			// 
			tableLayoutPanelDepartmentsButtons.ColumnCount = 4;
			tableLayoutPanelDepartmentsButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanelDepartmentsButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanelDepartmentsButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanelDepartmentsButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanelDepartmentsButtons.Controls.Add(buttonDepartmentsDelete, 2, 0);
			tableLayoutPanelDepartmentsButtons.Controls.Add(buttonDepartmentsAdd, 1, 0);
			tableLayoutPanelDepartmentsButtons.Controls.Add(buttonDepartmentsLoad, 0, 0);
			tableLayoutPanelDepartmentsButtons.Controls.Add(buttonDepartmentsUpdate, 3, 0);
			tableLayoutPanelDepartmentsButtons.Dock = DockStyle.Fill;
			tableLayoutPanelDepartmentsButtons.Location = new Point(3, 381);
			tableLayoutPanelDepartmentsButtons.Name = "tableLayoutPanelDepartmentsButtons";
			tableLayoutPanelDepartmentsButtons.RowCount = 1;
			tableLayoutPanelDepartmentsButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanelDepartmentsButtons.Size = new Size(780, 32);
			tableLayoutPanelDepartmentsButtons.TabIndex = 0;
			// 
			// buttonDepartmentsDelete
			// 
			buttonDepartmentsDelete.Dock = DockStyle.Fill;
			buttonDepartmentsDelete.Location = new Point(393, 3);
			buttonDepartmentsDelete.Name = "buttonDepartmentsDelete";
			buttonDepartmentsDelete.Size = new Size(189, 26);
			buttonDepartmentsDelete.TabIndex = 3;
			buttonDepartmentsDelete.Text = "Удалить";
			buttonDepartmentsDelete.UseVisualStyleBackColor = true;
			// 
			// buttonDepartmentsAdd
			// 
			buttonDepartmentsAdd.Dock = DockStyle.Fill;
			buttonDepartmentsAdd.Location = new Point(198, 3);
			buttonDepartmentsAdd.Name = "buttonDepartmentsAdd";
			buttonDepartmentsAdd.Size = new Size(189, 26);
			buttonDepartmentsAdd.TabIndex = 2;
			buttonDepartmentsAdd.Text = "Добавить";
			buttonDepartmentsAdd.UseVisualStyleBackColor = true;
			// 
			// buttonDepartmentsLoad
			// 
			buttonDepartmentsLoad.Dock = DockStyle.Fill;
			buttonDepartmentsLoad.Location = new Point(3, 3);
			buttonDepartmentsLoad.Name = "buttonDepartmentsLoad";
			buttonDepartmentsLoad.Size = new Size(189, 26);
			buttonDepartmentsLoad.TabIndex = 1;
			buttonDepartmentsLoad.Text = "Загрузить";
			buttonDepartmentsLoad.UseVisualStyleBackColor = true;
			// 
			// buttonDepartmentsUpdate
			// 
			buttonDepartmentsUpdate.Dock = DockStyle.Fill;
			buttonDepartmentsUpdate.Location = new Point(588, 3);
			buttonDepartmentsUpdate.Name = "buttonDepartmentsUpdate";
			buttonDepartmentsUpdate.Size = new Size(189, 26);
			buttonDepartmentsUpdate.TabIndex = 0;
			buttonDepartmentsUpdate.Text = "Обновить";
			buttonDepartmentsUpdate.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanelMajors
			// 
			tableLayoutPanelMajors.ColumnCount = 1;
			tableLayoutPanelMajors.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanelMajors.Controls.Add(tableLayoutPanelMajorsButtons, 0, 1);
			tableLayoutPanelMajors.Dock = DockStyle.Fill;
			tableLayoutPanelMajors.Location = new Point(3, 3);
			tableLayoutPanelMajors.Name = "tableLayoutPanelMajors";
			tableLayoutPanelMajors.RowCount = 2;
			tableLayoutPanelMajors.RowStyles.Add(new RowStyle(SizeType.Percent, 99.99999F));
			tableLayoutPanelMajors.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
			tableLayoutPanelMajors.Size = new Size(786, 416);
			tableLayoutPanelMajors.TabIndex = 1;
			// 
			// tableLayoutPanelMajorsButtons
			// 
			tableLayoutPanelMajorsButtons.ColumnCount = 4;
			tableLayoutPanelMajorsButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanelMajorsButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanelMajorsButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanelMajorsButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			tableLayoutPanelMajorsButtons.Controls.Add(buttonMajorDelete, 2, 0);
			tableLayoutPanelMajorsButtons.Controls.Add(buttonMajorAdd, 1, 0);
			tableLayoutPanelMajorsButtons.Controls.Add(buttonMajorLoad, 0, 0);
			tableLayoutPanelMajorsButtons.Controls.Add(buttonMajorUpdate, 3, 0);
			tableLayoutPanelMajorsButtons.Dock = DockStyle.Fill;
			tableLayoutPanelMajorsButtons.Location = new Point(3, 381);
			tableLayoutPanelMajorsButtons.Name = "tableLayoutPanelMajorsButtons";
			tableLayoutPanelMajorsButtons.RowCount = 1;
			tableLayoutPanelMajorsButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanelMajorsButtons.Size = new Size(780, 32);
			tableLayoutPanelMajorsButtons.TabIndex = 0;
			// 
			// buttonMajorDelete
			// 
			buttonMajorDelete.Dock = DockStyle.Fill;
			buttonMajorDelete.Location = new Point(393, 3);
			buttonMajorDelete.Name = "buttonMajorDelete";
			buttonMajorDelete.Size = new Size(189, 26);
			buttonMajorDelete.TabIndex = 3;
			buttonMajorDelete.Text = "Удалить";
			buttonMajorDelete.UseVisualStyleBackColor = true;
			// 
			// buttonMajorAdd
			// 
			buttonMajorAdd.Dock = DockStyle.Fill;
			buttonMajorAdd.Location = new Point(198, 3);
			buttonMajorAdd.Name = "buttonMajorAdd";
			buttonMajorAdd.Size = new Size(189, 26);
			buttonMajorAdd.TabIndex = 2;
			buttonMajorAdd.Text = "Добавить";
			buttonMajorAdd.UseVisualStyleBackColor = true;
			// 
			// buttonMajorLoad
			// 
			buttonMajorLoad.Dock = DockStyle.Fill;
			buttonMajorLoad.Location = new Point(3, 3);
			buttonMajorLoad.Name = "buttonMajorLoad";
			buttonMajorLoad.Size = new Size(189, 26);
			buttonMajorLoad.TabIndex = 1;
			buttonMajorLoad.Text = "Загрузить";
			buttonMajorLoad.UseVisualStyleBackColor = true;
			// 
			// buttonMajorUpdate
			// 
			buttonMajorUpdate.Dock = DockStyle.Fill;
			buttonMajorUpdate.Location = new Point(588, 3);
			buttonMajorUpdate.Name = "buttonMajorUpdate";
			buttonMajorUpdate.Size = new Size(189, 26);
			buttonMajorUpdate.TabIndex = 0;
			buttonMajorUpdate.Text = "Обновить";
			buttonMajorUpdate.UseVisualStyleBackColor = true;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tabControlMain);
			MinimumSize = new Size(360, 240);
			Name = "FormMain";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			tabControlMain.ResumeLayout(false);
			tabPageMajors.ResumeLayout(false);
			tabPageDepartments.ResumeLayout(false);
			tableLayoutPanelDepartments.ResumeLayout(false);
			tableLayoutPanelDepartmentsButtons.ResumeLayout(false);
			tableLayoutPanelMajors.ResumeLayout(false);
			tableLayoutPanelMajorsButtons.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControlMain;
		private TabPage tabPageMajors;
		private TabPage tabPageDepartments;
		private TableLayoutPanel tableLayoutPanelDepartments;
		private TableLayoutPanel tableLayoutPanelDepartmentsButtons;
		private Button buttonDepartmentsDelete;
		private Button buttonDepartmentsAdd;
		private Button buttonDepartmentsLoad;
		private Button buttonDepartmentsUpdate;
		private TableLayoutPanel tableLayoutPanelMajors;
		private TableLayoutPanel tableLayoutPanelMajorsButtons;
		private Button buttonMajorDelete;
		private Button buttonMajorAdd;
		private Button buttonMajorLoad;
		private Button buttonMajorUpdate;
	}
}
