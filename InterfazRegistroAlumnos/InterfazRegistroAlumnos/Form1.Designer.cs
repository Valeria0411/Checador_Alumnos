namespace InterfazRegistroAlumnos
{
    partial class DatosAlumnos
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
            if (disposing && (components != null))
            {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosAlumnos));
            this.btnexaminar = new System.Windows.Forms.Button();
            this.labNombre = new System.Windows.Forms.Label();
            this.labApellido = new System.Windows.Forms.Label();
            this.labTurno = new System.Windows.Forms.Label();
            this.labGrado = new System.Windows.Forms.Label();
            this.labGrupo = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataMostrarDatos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datosAlumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registroAlumnosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RegistroAlumnosDataSet = new InterfazRegistroAlumnos.RegistroAlumnosDataSet();
            this.datosAlumnosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pbfotoalumno = new System.Windows.Forms.PictureBox();
            this.pbgenerar = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgrado = new System.Windows.Forms.TextBox();
            this.txtgrupo = new System.Windows.Forms.TextBox();
            this.txtturno = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.generar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datosAlumnosTableAdapter = new InterfazRegistroAlumnos.RegistroAlumnosDataSetTableAdapters.DatosAlumnosTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcontra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMostrarDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosAlumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroAlumnosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistroAlumnosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosAlumnosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfotoalumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbgenerar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexaminar
            // 
            this.btnexaminar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnexaminar.BackColor = System.Drawing.Color.Gray;
            this.btnexaminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexaminar.FlatAppearance.BorderSize = 0;
            this.btnexaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexaminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnexaminar.Location = new System.Drawing.Point(112, 233);
            this.btnexaminar.Name = "btnexaminar";
            this.btnexaminar.Size = new System.Drawing.Size(110, 35);
            this.btnexaminar.TabIndex = 23;
            this.btnexaminar.Text = "Examinar";
            this.btnexaminar.UseVisualStyleBackColor = false;
            this.btnexaminar.UseWaitCursor = true;
            this.btnexaminar.Click += new System.EventHandler(this.btnexaminar_Click);
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.Location = new System.Drawing.Point(197, 208);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(79, 24);
            this.labNombre.TabIndex = 0;
            this.labNombre.Text = "Nombre";
            // 
            // labApellido
            // 
            this.labApellido.AutoSize = true;
            this.labApellido.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApellido.Location = new System.Drawing.Point(423, 208);
            this.labApellido.Name = "labApellido";
            this.labApellido.Size = new System.Drawing.Size(82, 24);
            this.labApellido.TabIndex = 1;
            this.labApellido.Text = "Apellido";
            // 
            // labTurno
            // 
            this.labTurno.AutoSize = true;
            this.labTurno.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTurno.Location = new System.Drawing.Point(500, 278);
            this.labTurno.Name = "labTurno";
            this.labTurno.Size = new System.Drawing.Size(63, 24);
            this.labTurno.TabIndex = 2;
            this.labTurno.Text = "Turno";
            // 
            // labGrado
            // 
            this.labGrado.AutoSize = true;
            this.labGrado.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGrado.Location = new System.Drawing.Point(54, 283);
            this.labGrado.Name = "labGrado";
            this.labGrado.Size = new System.Drawing.Size(65, 24);
            this.labGrado.TabIndex = 3;
            this.labGrado.Text = "Grado";
            // 
            // labGrupo
            // 
            this.labGrupo.AutoSize = true;
            this.labGrupo.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGrupo.Location = new System.Drawing.Point(268, 278);
            this.labGrupo.Name = "labGrupo";
            this.labGrupo.Size = new System.Drawing.Size(65, 24);
            this.labGrupo.TabIndex = 4;
            this.labGrupo.Text = "Grupo";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(282, 210);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(109, 22);
            this.txtnombre.TabIndex = 7;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(511, 210);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(110, 22);
            this.txtapellido.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 87);
            this.label1.TabIndex = 12;
            this.label1.Text = "BIENVENIDO AL SISTEMA DE REGISTRO \r\nESCUELA SECUNDARIA Nª 51\r\nREVOLUCION MEXICANA" +
    "";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1154, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Black;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(12, 410);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(136, 33);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Black;
            this.btnConsultar.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(185, 411);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(136, 32);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(524, 412);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(126, 32);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "ELIMINAR ";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Black;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(358, 412);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(147, 33);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1178, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // dataMostrarDatos
            // 
            this.dataMostrarDatos.AutoGenerateColumns = false;
            this.dataMostrarDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMostrarDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataMostrarDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataMostrarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMostrarDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.turnoDataGridViewTextBoxColumn,
            this.gradoDataGridViewTextBoxColumn,
            this.grupoDataGridViewTextBoxColumn});
            this.dataMostrarDatos.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.datosAlumnosBindingSource, "Nombre", true));
            this.dataMostrarDatos.DataSource = this.datosAlumnosBindingSource1;
            this.dataMostrarDatos.Location = new System.Drawing.Point(12, 450);
            this.dataMostrarDatos.Name = "dataMostrarDatos";
            this.dataMostrarDatos.RowTemplate.Height = 24;
            this.dataMostrarDatos.Size = new System.Drawing.Size(1060, 250);
            this.dataMostrarDatos.TabIndex = 20;
            this.dataMostrarDatos.DataSourceChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            this.dataMostrarDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            // 
            // gradoDataGridViewTextBoxColumn
            // 
            this.gradoDataGridViewTextBoxColumn.DataPropertyName = "Grado";
            this.gradoDataGridViewTextBoxColumn.HeaderText = "Grado";
            this.gradoDataGridViewTextBoxColumn.Name = "gradoDataGridViewTextBoxColumn";
            // 
            // grupoDataGridViewTextBoxColumn
            // 
            this.grupoDataGridViewTextBoxColumn.DataPropertyName = "Grupo";
            this.grupoDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.grupoDataGridViewTextBoxColumn.Name = "grupoDataGridViewTextBoxColumn";
            // 
            // datosAlumnosBindingSource
            // 
            this.datosAlumnosBindingSource.DataMember = "DatosAlumnos";
            this.datosAlumnosBindingSource.DataSource = this.registroAlumnosDataSetBindingSource;
            // 
            // registroAlumnosDataSetBindingSource
            // 
            this.registroAlumnosDataSetBindingSource.DataSource = this.RegistroAlumnosDataSet;
            this.registroAlumnosDataSetBindingSource.Position = 0;
            // 
            // RegistroAlumnosDataSet
            // 
            this.RegistroAlumnosDataSet.DataSetName = "RegistroAlumnosDataSet";
            this.RegistroAlumnosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosAlumnosBindingSource1
            // 
            this.datosAlumnosBindingSource1.DataMember = "DatosAlumnos";
            this.datosAlumnosBindingSource1.DataSource = this.registroAlumnosDataSetBindingSource;
            // 
            // pbfotoalumno
            // 
            this.pbfotoalumno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbfotoalumno.BackgroundImage")));
            this.pbfotoalumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbfotoalumno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbfotoalumno.Location = new System.Drawing.Point(88, 38);
            this.pbfotoalumno.Name = "pbfotoalumno";
            this.pbfotoalumno.Size = new System.Drawing.Size(167, 175);
            this.pbfotoalumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbfotoalumno.TabIndex = 21;
            this.pbfotoalumno.TabStop = false;
            this.pbfotoalumno.UseWaitCursor = true;
            this.pbfotoalumno.Click += new System.EventHandler(this.pbfotoalumno_Click);
            // 
            // pbgenerar
            // 
            this.pbgenerar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbgenerar.InitialImage = null;
            this.pbgenerar.Location = new System.Drawing.Point(730, 175);
            this.pbgenerar.Name = "pbgenerar";
            this.pbgenerar.Size = new System.Drawing.Size(148, 132);
            this.pbgenerar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbgenerar.TabIndex = 22;
            this.pbgenerar.TabStop = false;
            this.pbgenerar.Click += new System.EventHandler(this.pbgenerar_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(29, 213);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(26, 24);
            this.label.TabIndex = 23;
            this.label.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(69, 210);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(109, 22);
            this.txtId.TabIndex = 24;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1384, 143);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.pbfotoalumno);
            this.groupBox1.Controls.Add(this.btnexaminar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox1.Location = new System.Drawing.Point(1072, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 294);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESA LA FOTO";
            this.groupBox1.UseWaitCursor = true;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 33);
            this.label2.TabIndex = 31;
            this.label2.Text = "INGRESA LOS DATOS DEL ALUMNO";
            // 
            // txtgrado
            // 
            this.txtgrado.Location = new System.Drawing.Point(125, 283);
            this.txtgrado.Name = "txtgrado";
            this.txtgrado.Size = new System.Drawing.Size(52, 22);
            this.txtgrado.TabIndex = 32;
            // 
            // txtgrupo
            // 
            this.txtgrupo.Location = new System.Drawing.Point(339, 278);
            this.txtgrupo.Name = "txtgrupo";
            this.txtgrupo.Size = new System.Drawing.Size(52, 22);
            this.txtgrupo.TabIndex = 33;
            // 
            // txtturno
            // 
            this.txtturno.Location = new System.Drawing.Point(569, 278);
            this.txtturno.Name = "txtturno";
            this.txtturno.Size = new System.Drawing.Size(52, 22);
            this.txtturno.TabIndex = 34;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.datosAlumnosBindingSource;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1390, 27);
            this.fillByToolStrip.TabIndex = 35;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Black;
            this.btnLimpiar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(292, 357);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(155, 38);
            this.btnLimpiar.TabIndex = 36;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(1139, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 55);
            this.button1.TabIndex = 37;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // generar
            // 
            this.generar.BackColor = System.Drawing.Color.Black;
            this.generar.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.generar.Location = new System.Drawing.Point(745, 318);
            this.generar.Name = "generar";
            this.generar.Size = new System.Drawing.Size(118, 34);
            this.generar.TabIndex = 38;
            this.generar.Text = "Generar QR";
            this.generar.UseVisualStyleBackColor = false;
            this.generar.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1184, 616);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(727, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // datosAlumnosTableAdapter
            // 
            this.datosAlumnosTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1108, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Contraseña";
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(1210, 510);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(117, 22);
            this.txtcontra.TabIndex = 42;
            this.txtcontra.TextChanged += new System.EventHandler(this.contraseña_TextChanged);
            // 
            // DatosAlumnos
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1390, 699);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.generar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.txtturno);
            this.Controls.Add(this.txtgrupo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtgrado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbgenerar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dataMostrarDatos);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.labGrupo);
            this.Controls.Add(this.labGrado);
            this.Controls.Add(this.labTurno);
            this.Controls.Add(this.labApellido);
            this.Controls.Add(this.labNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatosAlumnos";
            this.Text = "DatosAlumnos";
            this.Load += new System.EventHandler(this.DatosAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMostrarDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosAlumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroAlumnosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistroAlumnosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosAlumnosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfotoalumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbgenerar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label labApellido;
        private System.Windows.Forms.Label labTurno;
        private System.Windows.Forms.Label labGrado;
        private System.Windows.Forms.Label labGrupo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataMostrarDatos;
        private System.Windows.Forms.PictureBox pbfotoalumno;
        private System.Windows.Forms.PictureBox pbgenerar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.BindingSource registroAlumnosDataSetBindingSource;
        private RegistroAlumnosDataSet RegistroAlumnosDataSet;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtturno;
        private System.Windows.Forms.TextBox txtgrupo;
        private System.Windows.Forms.TextBox txtgrado;
        private System.Windows.Forms.BindingSource datosAlumnosBindingSource;
        private RegistroAlumnosDataSetTableAdapters.DatosAlumnosTableAdapter datosAlumnosTableAdapter;
        private System.Windows.Forms.BindingSource datosAlumnosBindingSource1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnexaminar;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button generar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.Label label4;
    }
}

