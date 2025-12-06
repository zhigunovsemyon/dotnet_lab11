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
			tabControlMain.SuspendLayout();
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
			tabPageDepartments.Location = new Point(4, 24);
			tabPageDepartments.Name = "tabPageDepartments";
			tabPageDepartments.Padding = new Padding(3);
			tabPageDepartments.Size = new Size(792, 422);
			tabPageDepartments.TabIndex = 1;
			tabPageDepartments.Text = "Кафедры";
			tabPageDepartments.UseVisualStyleBackColor = true;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tabControlMain);
			MinimumSize = new Size(320, 240);
			Name = "FormMain";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			tabControlMain.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControlMain;
		private TabPage tabPageMajors;
		private TabPage tabPageDepartments;
	}
}
