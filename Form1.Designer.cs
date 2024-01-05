namespace IEIFrontendRoig
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.cvtxt = new System.Windows.Forms.TextBox();
            this.murtxt = new System.Windows.Forms.TextBox();
            this.cattxt = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodigoPostal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Longitud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Latitud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.snombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.scp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stipo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.slongitud = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sdescripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sdireccion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.slatitud = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.slocalidad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.scomunidad = new System.Windows.Forms.TextBox();
            this.urltxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 46);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(40, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "CV";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(14, 72);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(51, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "MUR";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(14, 99);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(47, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "CAT";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // cvtxt
            // 
            this.cvtxt.Location = new System.Drawing.Point(100, 43);
            this.cvtxt.Name = "cvtxt";
            this.cvtxt.Size = new System.Drawing.Size(100, 20);
            this.cvtxt.TabIndex = 4;
            // 
            // murtxt
            // 
            this.murtxt.Location = new System.Drawing.Point(100, 70);
            this.murtxt.Name = "murtxt";
            this.murtxt.Size = new System.Drawing.Size(100, 20);
            this.murtxt.TabIndex = 5;
            // 
            // cattxt
            // 
            this.cattxt.Location = new System.Drawing.Point(100, 97);
            this.cattxt.Name = "cattxt";
            this.cattxt.Size = new System.Drawing.Size(100, 20);
            this.cattxt.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Tipo,
            this.Direccion,
            this.CodigoPostal,
            this.Longitud,
            this.Latitud,
            this.Telefono,
            this.Descripcion});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 185);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(606, 248);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 84;
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo";
            this.Tipo.Width = 79;
            // 
            // Direccion
            // 
            this.Direccion.Text = "Direccion";
            this.Direccion.Width = 96;
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.Text = "Codigo Postal";
            this.CodigoPostal.Width = 89;
            // 
            // Longitud
            // 
            this.Longitud.Text = "Longitud";
            // 
            // Latitud
            // 
            this.Latitud.Text = "Latitud";
            // 
            // Telefono
            // 
            this.Telefono.Text = "Telefono";
            // 
            // Descripcion
            // 
            this.Descripcion.Text = "Descripcion";
            this.Descripcion.Width = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Archivos a insertar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Resultado de la búsqueda";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Insertar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // snombre
            // 
            this.snombre.Location = new System.Drawing.Point(254, 43);
            this.snombre.Name = "snombre";
            this.snombre.Size = new System.Drawing.Size(100, 20);
            this.snombre.TabIndex = 11;
            this.snombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "codigo postal";
            // 
            // scp
            // 
            this.scp.Location = new System.Drawing.Point(254, 82);
            this.scp.Name = "scp";
            this.scp.Size = new System.Drawing.Size(100, 20);
            this.scp.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "telefono";
            // 
            // stelefono
            // 
            this.stelefono.Location = new System.Drawing.Point(254, 119);
            this.stelefono.Name = "stelefono";
            this.stelefono.Size = new System.Drawing.Size(100, 20);
            this.stelefono.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "tipo";
            // 
            // stipo
            // 
            this.stipo.Location = new System.Drawing.Point(360, 43);
            this.stipo.Name = "stipo";
            this.stipo.Size = new System.Drawing.Size(100, 20);
            this.stipo.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "longitud";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // slongitud
            // 
            this.slongitud.Location = new System.Drawing.Point(360, 82);
            this.slongitud.Name = "slongitud";
            this.slongitud.Size = new System.Drawing.Size(100, 20);
            this.slongitud.TabIndex = 20;
            this.slongitud.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "descripcion";
            // 
            // sdescripcion
            // 
            this.sdescripcion.Location = new System.Drawing.Point(360, 119);
            this.sdescripcion.Name = "sdescripcion";
            this.sdescripcion.Size = new System.Drawing.Size(100, 20);
            this.sdescripcion.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(466, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "direccion";
            // 
            // sdireccion
            // 
            this.sdireccion.Location = new System.Drawing.Point(466, 43);
            this.sdireccion.Name = "sdireccion";
            this.sdireccion.Size = new System.Drawing.Size(100, 20);
            this.sdireccion.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(466, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "latitud";
            // 
            // slatitud
            // 
            this.slatitud.Location = new System.Drawing.Point(466, 82);
            this.slatitud.Name = "slatitud";
            this.slatitud.Size = new System.Drawing.Size(100, 20);
            this.slatitud.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(466, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "localidad";
            // 
            // slocalidad
            // 
            this.slocalidad.Location = new System.Drawing.Point(466, 119);
            this.slocalidad.Name = "slocalidad";
            this.slocalidad.Size = new System.Drawing.Size(100, 20);
            this.slocalidad.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(254, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "comunidad";
            // 
            // scomunidad
            // 
            this.scomunidad.Location = new System.Drawing.Point(254, 159);
            this.scomunidad.Name = "scomunidad";
            this.scomunidad.Size = new System.Drawing.Size(100, 20);
            this.scomunidad.TabIndex = 30;
            // 
            // urltxt
            // 
            this.urltxt.Location = new System.Drawing.Point(17, 4);
            this.urltxt.Name = "urltxt";
            this.urltxt.Size = new System.Drawing.Size(100, 20);
            this.urltxt.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(124, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "URL";
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(633, 27);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(472, 406);
            this.gMapControl1.TabIndex = 34;
            this.gMapControl1.Zoom = 0D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 445);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.urltxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.scomunidad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.slocalidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.slatitud);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sdireccion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sdescripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.slongitud);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.snombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cattxt);
            this.Controls.Add(this.murtxt);
            this.Controls.Add(this.cvtxt);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox cvtxt;
        private System.Windows.Forms.TextBox murtxt;
        private System.Windows.Forms.TextBox cattxt;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader Direccion;
        private System.Windows.Forms.ColumnHeader CodigoPostal;
        private System.Windows.Forms.ColumnHeader Longitud;
        private System.Windows.Forms.ColumnHeader Latitud;
        private System.Windows.Forms.ColumnHeader Telefono;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox snombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox scp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox slongitud;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sdescripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sdireccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox slatitud;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox slocalidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox scomunidad;
        private System.Windows.Forms.TextBox urltxt;
        private System.Windows.Forms.Label label13;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
    }
}

