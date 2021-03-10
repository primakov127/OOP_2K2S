namespace LAB_05
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Semestr = new System.Windows.Forms.CheckedListBox();
            this.Course = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Speciality = new System.Windows.Forms.ComboBox();
            this.ControlType = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PulpitName = new System.Windows.Forms.TextBox();
            this.LecturerName = new System.Windows.Forms.TextBox();
            this.LecturesCount = new System.Windows.Forms.NumericUpDown();
            this.LabsCount = new System.Windows.Forms.NumericUpDown();
            this.DisciplineName = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onLectCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onControlTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLastAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturesCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labsCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pulpitNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auditoriumNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Course.SuspendLayout();
            this.ControlType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LecturesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Semestr
            // 
            this.Semestr.FormattingEnabled = true;
            this.Semestr.Items.AddRange(new object[] {
            "1",
            "2"});
            this.Semestr.Location = new System.Drawing.Point(3, 95);
            this.Semestr.Name = "Semestr";
            this.Semestr.Size = new System.Drawing.Size(147, 55);
            this.Semestr.TabIndex = 1;
            this.Semestr.Validating += new System.ComponentModel.CancelEventHandler(this.SemestrValid);
            // 
            // Course
            // 
            this.Course.Controls.Add(this.radioButton4);
            this.Course.Controls.Add(this.radioButton3);
            this.Course.Controls.Add(this.radioButton2);
            this.Course.Controls.Add(this.radioButton1);
            this.Course.Location = new System.Drawing.Point(3, 156);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(147, 129);
            this.Course.TabIndex = 2;
            this.Course.TabStop = false;
            this.Course.Text = "Курс";
            this.Course.Validating += new System.ComponentModel.CancelEventHandler(this.CourseValid);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(0, 104);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(37, 21);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(0, 76);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(37, 21);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(0, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(0, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(37, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Speciality
            // 
            this.Speciality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Speciality.FormattingEnabled = true;
            this.Speciality.Items.AddRange(new object[] {
            "ПОИТ",
            "ДЭВИ",
            "ПОИБМС",
            "ИСиТ"});
            this.Speciality.Location = new System.Drawing.Point(3, 308);
            this.Speciality.Name = "Speciality";
            this.Speciality.Size = new System.Drawing.Size(147, 24);
            this.Speciality.TabIndex = 3;
            this.Speciality.Validating += new System.ComponentModel.CancelEventHandler(this.SpecialityValid);
            // 
            // ControlType
            // 
            this.ControlType.Controls.Add(this.radioButton6);
            this.ControlType.Controls.Add(this.radioButton5);
            this.ControlType.Location = new System.Drawing.Point(3, 428);
            this.ControlType.Name = "ControlType";
            this.ControlType.Size = new System.Drawing.Size(147, 80);
            this.ControlType.TabIndex = 6;
            this.ControlType.TabStop = false;
            this.ControlType.Text = "Вид контроля";
            this.ControlType.Validating += new System.ComponentModel.CancelEventHandler(this.ControlTypeValid);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(0, 50);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(67, 21);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "зачёт";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(0, 22);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(83, 21);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "экзамен";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PulpitName);
            this.groupBox1.Controls.Add(this.LecturerName);
            this.groupBox1.Location = new System.Drawing.Point(3, 514);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 156);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Лектор";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(0, 126);
            this.maskedTextBox2.Mask = "000-0?";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(176, 22);
            this.maskedTextBox2.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-3, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Аудитория";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Кафедра";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label6.Location = new System.Drawing.Point(-3, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ф. И. О";
            // 
            // PulpitName
            // 
            this.PulpitName.Location = new System.Drawing.Point(0, 81);
            this.PulpitName.Name = "PulpitName";
            this.PulpitName.Size = new System.Drawing.Size(176, 22);
            this.PulpitName.TabIndex = 1;
            // 
            // LecturerName
            // 
            this.LecturerName.Location = new System.Drawing.Point(0, 36);
            this.LecturerName.Name = "LecturerName";
            this.LecturerName.Size = new System.Drawing.Size(176, 22);
            this.LecturerName.TabIndex = 0;
            // 
            // LecturesCount
            // 
            this.LecturesCount.Location = new System.Drawing.Point(3, 355);
            this.LecturesCount.Name = "LecturesCount";
            this.LecturesCount.Size = new System.Drawing.Size(88, 22);
            this.LecturesCount.TabIndex = 9;
            // 
            // LabsCount
            // 
            this.LabsCount.Location = new System.Drawing.Point(3, 400);
            this.LabsCount.Name = "LabsCount";
            this.LabsCount.Size = new System.Drawing.Size(88, 22);
            this.LabsCount.TabIndex = 10;
            // 
            // DisciplineName
            // 
            this.DisciplineName.Location = new System.Drawing.Point(3, 51);
            this.DisciplineName.Name = "DisciplineName";
            this.DisciplineName.Size = new System.Drawing.Size(147, 22);
            this.DisciplineName.TabIndex = 1;
            this.DisciplineName.Validating += new System.ComponentModel.CancelEventHandler(this.DisciplineValid);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Название дисциплины";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Семестр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Специальность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Количество лекций";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Количество лабораторных";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.specialityDataGridViewTextBoxColumn,
            this.lecturesCountDataGridViewTextBoxColumn,
            this.labsCountDataGridViewTextBoxColumn,
            this.controlTypeDataGridViewTextBoxColumn,
            this.lecturerNameDataGridViewTextBoxColumn,
            this.pulpitNameDataGridViewTextBoxColumn,
            this.auditoriumNumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.disciplineBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(191, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1362, 639);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(3, 676);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(144, 37);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(191, 676);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(94, 37);
            this.buttonOpen.TabIndex = 19;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1427, 676);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(126, 37);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Xml files|*.xml";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            this.saveFileDialog1.Filter = "Xml files|*.xml";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.formatToolStripMenuItem,
            this.ToolPanelToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1608, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 24);
            this.toolStripMenuItem1.Text = "Файл";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.сортировкаToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.formatToolStripMenuItem.Text = "Формат";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.searchToolStripMenuItem.Text = "Поиск";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onLectCountToolStripMenuItem,
            this.onControlTypeToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            this.сортировкаToolStripMenuItem.Click += new System.EventHandler(this.сортировкаToolStripMenuItem_Click);
            // 
            // onLectCountToolStripMenuItem
            // 
            this.onLectCountToolStripMenuItem.Name = "onLectCountToolStripMenuItem";
            this.onLectCountToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.onLectCountToolStripMenuItem.Text = "по количеству лекций";
            this.onLectCountToolStripMenuItem.Click += new System.EventHandler(this.onLectCountToolStripMenuItem_Click);
            // 
            // onControlTypeToolStripMenuItem
            // 
            this.onControlTypeToolStripMenuItem.Name = "onControlTypeToolStripMenuItem";
            this.onControlTypeToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.onControlTypeToolStripMenuItem.Text = "по виду контроля";
            this.onControlTypeToolStripMenuItem.Click += new System.EventHandler(this.onControlTypeToolStripMenuItem_Click);
            // 
            // ToolPanelToolStripMenuItem
            // 
            this.ToolPanelToolStripMenuItem.Name = "ToolPanelToolStripMenuItem";
            this.ToolPanelToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.ToolPanelToolStripMenuItem.Text = "Панель инструментов";
            this.ToolPanelToolStripMenuItem.Click += new System.EventHandler(this.ToolPanelToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCount,
            this.toolStripStatusLabelLastAction,
            this.toolStripStatusLabelTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 728);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1608, 25);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCount
            // 
            this.toolStripStatusLabelCount.Name = "toolStripStatusLabelCount";
            this.toolStripStatusLabelCount.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabelCount.Text = "Кол-во элементов: 0";
            this.toolStripStatusLabelCount.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabelLastAction
            // 
            this.toolStripStatusLabelLastAction.Name = "toolStripStatusLabelLastAction";
            this.toolStripStatusLabelLastAction.Size = new System.Drawing.Size(155, 20);
            this.toolStripStatusLabelLastAction.Text = "Последнее действие:";
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabelTime.Text = "Время";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(1568, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(40, 700);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(22, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(22, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specialityDataGridViewTextBoxColumn
            // 
            this.specialityDataGridViewTextBoxColumn.DataPropertyName = "Speciality";
            this.specialityDataGridViewTextBoxColumn.HeaderText = "Speciality";
            this.specialityDataGridViewTextBoxColumn.Name = "specialityDataGridViewTextBoxColumn";
            this.specialityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lecturesCountDataGridViewTextBoxColumn
            // 
            this.lecturesCountDataGridViewTextBoxColumn.DataPropertyName = "LecturesCount";
            this.lecturesCountDataGridViewTextBoxColumn.HeaderText = "LecturesCount";
            this.lecturesCountDataGridViewTextBoxColumn.Name = "lecturesCountDataGridViewTextBoxColumn";
            this.lecturesCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // labsCountDataGridViewTextBoxColumn
            // 
            this.labsCountDataGridViewTextBoxColumn.DataPropertyName = "LabsCount";
            this.labsCountDataGridViewTextBoxColumn.HeaderText = "LabsCount";
            this.labsCountDataGridViewTextBoxColumn.Name = "labsCountDataGridViewTextBoxColumn";
            this.labsCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // controlTypeDataGridViewTextBoxColumn
            // 
            this.controlTypeDataGridViewTextBoxColumn.DataPropertyName = "ControlType";
            this.controlTypeDataGridViewTextBoxColumn.HeaderText = "ControlType";
            this.controlTypeDataGridViewTextBoxColumn.Name = "controlTypeDataGridViewTextBoxColumn";
            this.controlTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lecturerNameDataGridViewTextBoxColumn
            // 
            this.lecturerNameDataGridViewTextBoxColumn.DataPropertyName = "LecturerName";
            this.lecturerNameDataGridViewTextBoxColumn.HeaderText = "LecturerName";
            this.lecturerNameDataGridViewTextBoxColumn.Name = "lecturerNameDataGridViewTextBoxColumn";
            this.lecturerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pulpitNameDataGridViewTextBoxColumn
            // 
            this.pulpitNameDataGridViewTextBoxColumn.DataPropertyName = "PulpitName";
            this.pulpitNameDataGridViewTextBoxColumn.HeaderText = "PulpitName";
            this.pulpitNameDataGridViewTextBoxColumn.Name = "pulpitNameDataGridViewTextBoxColumn";
            this.pulpitNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // auditoriumNumDataGridViewTextBoxColumn
            // 
            this.auditoriumNumDataGridViewTextBoxColumn.DataPropertyName = "AuditoriumNum";
            this.auditoriumNumDataGridViewTextBoxColumn.HeaderText = "AuditoriumNum";
            this.auditoriumNumDataGridViewTextBoxColumn.Name = "auditoriumNumDataGridViewTextBoxColumn";
            this.auditoriumNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // disciplineBindingSource
            // 
            this.disciplineBindingSource.DataSource = typeof(LAB_05.Classes.Discipline);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 753);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisciplineName);
            this.Controls.Add(this.LabsCount);
            this.Controls.Add(this.LecturesCount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ControlType);
            this.Controls.Add(this.Speciality);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.Semestr);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(1626, 800);
            this.MinimumSize = new System.Drawing.Size(1626, 800);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAB_05";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Course.ResumeLayout(false);
            this.Course.PerformLayout();
            this.ControlType.ResumeLayout(false);
            this.ControlType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LecturesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox Semestr;
        private System.Windows.Forms.GroupBox Course;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox Speciality;
        private System.Windows.Forms.GroupBox ControlType;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LecturerName;
        private System.Windows.Forms.TextBox PulpitName;
        private System.Windows.Forms.NumericUpDown LecturesCount;
        private System.Windows.Forms.NumericUpDown LabsCount;
        private System.Windows.Forms.MaskedTextBox DisciplineName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource disciplineBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturesCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labsCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pulpitNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn auditoriumNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onLectCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onControlTypeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLastAction;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem ToolPanelToolStripMenuItem;
    }
}

