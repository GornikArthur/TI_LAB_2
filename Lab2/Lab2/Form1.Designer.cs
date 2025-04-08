namespace Lab1
{
	partial class Form1
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
			RegTextBox = new TextBox();
			Columnlabel1 = new Label();
			SiphreButton = new Button();
			InputTextBox = new TextBox();
			label1 = new Label();
			LoadButton = new Button();
			SaveButton = new Button();
			CreatedKeyTextBox = new TextBox();
			label2 = new Label();
			OutputTextBox = new TextBox();
			label3 = new Label();
			SuspendLayout();
			// 
			// RegTextBox
			// 
			RegTextBox.Location = new Point(21, 56);
			RegTextBox.Name = "RegTextBox";
			RegTextBox.ScrollBars = ScrollBars.Horizontal;
			RegTextBox.Size = new Size(554, 23);
			RegTextBox.TabIndex = 1;
			RegTextBox.TextChanged += RegTextBox_TextChanged;
			// 
			// Columnlabel1
			// 
			Columnlabel1.AutoSize = true;
			Columnlabel1.Location = new Point(19, 38);
			Columnlabel1.Name = "Columnlabel1";
			Columnlabel1.Size = new Size(239, 15);
			Columnlabel1.TabIndex = 2;
			Columnlabel1.Text = "Состояние регистра: (Всего состояний 27)";
			// 
			// SiphreButton
			// 
			SiphreButton.Location = new Point(21, 85);
			SiphreButton.Name = "SiphreButton";
			SiphreButton.Size = new Size(189, 33);
			SiphreButton.TabIndex = 5;
			SiphreButton.Text = "Зашифровать/Расшифровать";
			SiphreButton.UseVisualStyleBackColor = true;
			SiphreButton.EnabledChanged += SiphreButton_EnabledChanged;
			SiphreButton.Click += SiphreButton_Click;
			// 
			// InputTextBox
			// 
			InputTextBox.Location = new Point(21, 264);
			InputTextBox.Multiline = true;
			InputTextBox.Name = "InputTextBox";
			InputTextBox.ReadOnly = true;
			InputTextBox.ScrollBars = ScrollBars.Vertical;
			InputTextBox.Size = new Size(554, 105);
			InputTextBox.TabIndex = 9;
			InputTextBox.TextChanged += ResTextBox_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(19, 387);
			label1.Name = "label1";
			label1.Size = new Size(63, 15);
			label1.TabIndex = 10;
			label1.Text = "Результат:";
			// 
			// LoadButton
			// 
			LoadButton.Location = new Point(21, 2);
			LoadButton.Name = "LoadButton";
			LoadButton.Size = new Size(189, 33);
			LoadButton.TabIndex = 18;
			LoadButton.Text = "Загрузить данные из файла";
			LoadButton.UseVisualStyleBackColor = true;
			LoadButton.Click += LoadButton_Click;
			// 
			// SaveButton
			// 
			SaveButton.Location = new Point(19, 516);
			SaveButton.Name = "SaveButton";
			SaveButton.Size = new Size(189, 32);
			SaveButton.TabIndex = 19;
			SaveButton.Text = "Сохранить данные в файл";
			SaveButton.UseVisualStyleBackColor = true;
			SaveButton.Click += SaveButton_Click;
			// 
			// CreatedKeyTextBox
			// 
			CreatedKeyTextBox.AcceptsReturn = true;
			CreatedKeyTextBox.AcceptsTab = true;
			CreatedKeyTextBox.AllowDrop = true;
			CreatedKeyTextBox.Location = new Point(21, 145);
			CreatedKeyTextBox.Multiline = true;
			CreatedKeyTextBox.Name = "CreatedKeyTextBox";
			CreatedKeyTextBox.ReadOnly = true;
			CreatedKeyTextBox.ScrollBars = ScrollBars.Vertical;
			CreatedKeyTextBox.Size = new Size(554, 86);
			CreatedKeyTextBox.TabIndex = 20;
			CreatedKeyTextBox.WordWrap = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(21, 127);
			label2.Name = "label2";
			label2.Size = new Size(139, 15);
			label2.TabIndex = 21;
			label2.Text = "Сгенирированый ключ:";
			// 
			// OutputTextBox
			// 
			OutputTextBox.Location = new Point(21, 405);
			OutputTextBox.Multiline = true;
			OutputTextBox.Name = "OutputTextBox";
			OutputTextBox.ReadOnly = true;
			OutputTextBox.ScrollBars = ScrollBars.Vertical;
			OutputTextBox.Size = new Size(554, 105);
			OutputTextBox.TabIndex = 22;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(19, 246);
			label3.Name = "label3";
			label3.Size = new Size(97, 15);
			label3.TabIndex = 23;
			label3.Text = "Исходный текст:";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(583, 554);
			Controls.Add(label3);
			Controls.Add(OutputTextBox);
			Controls.Add(label2);
			Controls.Add(CreatedKeyTextBox);
			Controls.Add(SaveButton);
			Controls.Add(LoadButton);
			Controls.Add(label1);
			Controls.Add(InputTextBox);
			Controls.Add(SiphreButton);
			Controls.Add(Columnlabel1);
			Controls.Add(RegTextBox);
			Name = "Form1";
			Text = "ТИ Lab2";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox RegTextBox;
		private Label Columnlabel1;
		private Button SiphreButton;
		private TextBox InputTextBox;
		private Label label1;
		private Button LoadButton;
		private Button SaveButton;
		private TextBox CreatedKeyTextBox;
		private Label label2;
		private TextBox OutputTextBox;
		private Label label3;
	}
}
