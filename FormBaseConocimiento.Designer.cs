namespace SEParaPeliculas
{
    partial class FormBaseConocimiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelOpcions = new System.Windows.Forms.Panel();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.panelMainGrid = new System.Windows.Forms.Panel();
            this.panelGridPelis = new System.Windows.Forms.Panel();
            this.gridPeliculas = new System.Windows.Forms.DataGridView();
            this.panelFormPelicula = new System.Windows.Forms.Panel();
            this.btnAddPeli = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecomendacion = new System.Windows.Forms.TextBox();
            this.txtNombrePeli = new System.Windows.Forms.TextBox();
            this.panelAtributos = new System.Windows.Forms.Panel();
            this.panelGridPropiedades = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAtributo = new System.Windows.Forms.TextBox();
            this.btnAddAtributo = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gridAtributos = new System.Windows.Forms.DataGridView();
            this.atributosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelAtributosTitulo = new System.Windows.Forms.Panel();
            this.lblPeluculaName = new System.Windows.Forms.Label();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPeliculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recomendacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelOpcions.SuspendLayout();
            this.panelMainGrid.SuspendLayout();
            this.panelGridPelis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPeliculas)).BeginInit();
            this.panelFormPelicula.SuspendLayout();
            this.panelAtributos.SuspendLayout();
            this.panelGridPropiedades.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAtributos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atributosBindingSource)).BeginInit();
            this.panelAtributosTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oPeliculaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOpcions
            // 
            this.panelOpcions.Controls.Add(this.btnSave);
            this.panelOpcions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpcions.Location = new System.Drawing.Point(0, 0);
            this.panelOpcions.Name = "panelOpcions";
            this.panelOpcions.Size = new System.Drawing.Size(1066, 69);
            this.panelOpcions.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.Crimson;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Lato Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(1);
            this.btnSave.Size = new System.Drawing.Size(1066, 60);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Click para Guardar los cambios";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelMainGrid
            // 
            this.panelMainGrid.Controls.Add(this.panelGridPelis);
            this.panelMainGrid.Controls.Add(this.panelFormPelicula);
            this.panelMainGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainGrid.Location = new System.Drawing.Point(0, 69);
            this.panelMainGrid.Name = "panelMainGrid";
            this.panelMainGrid.Size = new System.Drawing.Size(599, 412);
            this.panelMainGrid.TabIndex = 1;
            // 
            // panelGridPelis
            // 
            this.panelGridPelis.Controls.Add(this.gridPeliculas);
            this.panelGridPelis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridPelis.Location = new System.Drawing.Point(0, 94);
            this.panelGridPelis.Name = "panelGridPelis";
            this.panelGridPelis.Size = new System.Drawing.Size(599, 318);
            this.panelGridPelis.TabIndex = 2;
            // 
            // gridPeliculas
            // 
            this.gridPeliculas.AllowUserToAddRows = false;
            this.gridPeliculas.AllowUserToDeleteRows = false;
            this.gridPeliculas.AutoGenerateColumns = false;
            this.gridPeliculas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(212)))), ((int)(((byte)(217)))));
            this.gridPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.recomendacionDataGridViewTextBoxColumn});
            this.gridPeliculas.DataSource = this.oPeliculaBindingSource;
            this.gridPeliculas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPeliculas.Location = new System.Drawing.Point(0, 0);
            this.gridPeliculas.MultiSelect = false;
            this.gridPeliculas.Name = "gridPeliculas";
            this.gridPeliculas.RowHeadersWidth = 51;
            this.gridPeliculas.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.gridPeliculas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPeliculas.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPeliculas.RowTemplate.Height = 50;
            this.gridPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPeliculas.Size = new System.Drawing.Size(599, 318);
            this.gridPeliculas.TabIndex = 0;
            this.gridPeliculas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPeliculas_CellEndEdit);
            this.gridPeliculas.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.gridPeliculas_CellValidating);
            this.gridPeliculas.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPeliculas_RowHeaderMouseDoubleClick);
            this.gridPeliculas.SelectionChanged += new System.EventHandler(this.gridPeliculas_SelectionChanged);
            // 
            // panelFormPelicula
            // 
            this.panelFormPelicula.Controls.Add(this.btnAddPeli);
            this.panelFormPelicula.Controls.Add(this.label4);
            this.panelFormPelicula.Controls.Add(this.label3);
            this.panelFormPelicula.Controls.Add(this.txtRecomendacion);
            this.panelFormPelicula.Controls.Add(this.txtNombrePeli);
            this.panelFormPelicula.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormPelicula.Location = new System.Drawing.Point(0, 0);
            this.panelFormPelicula.Name = "panelFormPelicula";
            this.panelFormPelicula.Size = new System.Drawing.Size(599, 94);
            this.panelFormPelicula.TabIndex = 1;
            // 
            // btnAddPeli
            // 
            this.btnAddPeli.BackColor = System.Drawing.Color.Green;
            this.btnAddPeli.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddPeli.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPeli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddPeli.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddPeli.IconColor = System.Drawing.Color.White;
            this.btnAddPeli.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPeli.IconSize = 25;
            this.btnAddPeli.Location = new System.Drawing.Point(482, 0);
            this.btnAddPeli.Name = "btnAddPeli";
            this.btnAddPeli.Size = new System.Drawing.Size(117, 94);
            this.btnAddPeli.TabIndex = 5;
            this.btnAddPeli.Text = "Agregar Pelicula";
            this.btnAddPeli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPeli.UseVisualStyleBackColor = false;
            this.btnAddPeli.Click += new System.EventHandler(this.btnAddPeli_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Lato", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(265, -4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Recomendación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lato", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // txtRecomendacion
            // 
            this.txtRecomendacion.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecomendacion.Location = new System.Drawing.Point(245, 21);
            this.txtRecomendacion.Multiline = true;
            this.txtRecomendacion.Name = "txtRecomendacion";
            this.txtRecomendacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecomendacion.Size = new System.Drawing.Size(231, 67);
            this.txtRecomendacion.TabIndex = 2;
            // 
            // txtNombrePeli
            // 
            this.txtNombrePeli.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePeli.Location = new System.Drawing.Point(85, 43);
            this.txtNombrePeli.Name = "txtNombrePeli";
            this.txtNombrePeli.Size = new System.Drawing.Size(154, 31);
            this.txtNombrePeli.TabIndex = 1;
            // 
            // panelAtributos
            // 
            this.panelAtributos.Controls.Add(this.panelGridPropiedades);
            this.panelAtributos.Controls.Add(this.panelAtributosTitulo);
            this.panelAtributos.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAtributos.Location = new System.Drawing.Point(599, 69);
            this.panelAtributos.Name = "panelAtributos";
            this.panelAtributos.Size = new System.Drawing.Size(451, 412);
            this.panelAtributos.TabIndex = 1;
            // 
            // panelGridPropiedades
            // 
            this.panelGridPropiedades.Controls.Add(this.panel1);
            this.panelGridPropiedades.Controls.Add(this.gridAtributos);
            this.panelGridPropiedades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridPropiedades.Location = new System.Drawing.Point(0, 94);
            this.panelGridPropiedades.Name = "panelGridPropiedades";
            this.panelGridPropiedades.Size = new System.Drawing.Size(451, 318);
            this.panelGridPropiedades.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAtributo);
            this.panel1.Controls.Add(this.btnAddAtributo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 318);
            this.panel1.TabIndex = 4;
            // 
            // txtAtributo
            // 
            this.txtAtributo.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtributo.Location = new System.Drawing.Point(17, 60);
            this.txtAtributo.MaxLength = 250;
            this.txtAtributo.Name = "txtAtributo";
            this.txtAtributo.Size = new System.Drawing.Size(196, 35);
            this.txtAtributo.TabIndex = 2;
            // 
            // btnAddAtributo
            // 
            this.btnAddAtributo.BackColor = System.Drawing.Color.Green;
            this.btnAddAtributo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAtributo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAtributo.Font = new System.Drawing.Font("Lato", 10F);
            this.btnAddAtributo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddAtributo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddAtributo.IconColor = System.Drawing.Color.White;
            this.btnAddAtributo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddAtributo.IconSize = 25;
            this.btnAddAtributo.Location = new System.Drawing.Point(17, 102);
            this.btnAddAtributo.Name = "btnAddAtributo";
            this.btnAddAtributo.Padding = new System.Windows.Forms.Padding(15, 2, 10, 0);
            this.btnAddAtributo.Size = new System.Drawing.Size(196, 36);
            this.btnAddAtributo.TabIndex = 3;
            this.btnAddAtributo.Text = "Agregar";
            this.btnAddAtributo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddAtributo.UseVisualStyleBackColor = false;
            this.btnAddAtributo.Click += new System.EventHandler(this.btnAddAtributo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregar Atributo";
            // 
            // gridAtributos
            // 
            this.gridAtributos.AllowUserToAddRows = false;
            this.gridAtributos.AllowUserToDeleteRows = false;
            this.gridAtributos.AutoGenerateColumns = false;
            this.gridAtributos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(212)))), ((int)(((byte)(217)))));
            this.gridAtributos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAtributos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valueDataGridViewTextBoxColumn});
            this.gridAtributos.DataSource = this.atributosBindingSource;
            this.gridAtributos.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridAtributos.Location = new System.Drawing.Point(0, 0);
            this.gridAtributos.MultiSelect = false;
            this.gridAtributos.Name = "gridAtributos";
            this.gridAtributos.RowHeadersWidth = 51;
            this.gridAtributos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridAtributos.RowTemplate.Height = 24;
            this.gridAtributos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAtributos.Size = new System.Drawing.Size(220, 318);
            this.gridAtributos.TabIndex = 0;
            this.gridAtributos.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.gridPeliculas_CellValidating);
            this.gridAtributos.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridAtributos_RowHeaderMouseDoubleClick);
            // 
            // atributosBindingSource
            // 
            this.atributosBindingSource.DataMember = "Atributos";
            this.atributosBindingSource.DataSource = this.oPeliculaBindingSource;
            // 
            // panelAtributosTitulo
            // 
            this.panelAtributosTitulo.Controls.Add(this.lblPeluculaName);
            this.panelAtributosTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAtributosTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelAtributosTitulo.Name = "panelAtributosTitulo";
            this.panelAtributosTitulo.Size = new System.Drawing.Size(451, 94);
            this.panelAtributosTitulo.TabIndex = 2;
            // 
            // lblPeluculaName
            // 
            this.lblPeluculaName.Font = new System.Drawing.Font("Lato Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeluculaName.Location = new System.Drawing.Point(6, 3);
            this.lblPeluculaName.Name = "lblPeluculaName";
            this.lblPeluculaName.Size = new System.Drawing.Size(429, 88);
            this.lblPeluculaName.TabIndex = 0;
            this.lblPeluculaName.Text = "Pelicula";
            this.lblPeluculaName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Atributo";
            this.valueDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // oPeliculaBindingSource
            // 
            this.oPeliculaBindingSource.DataSource = typeof(SEParaPeliculas.oPelicula);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // recomendacionDataGridViewTextBoxColumn
            // 
            this.recomendacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.recomendacionDataGridViewTextBoxColumn.DataPropertyName = "Recomendacion";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recomendacionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.recomendacionDataGridViewTextBoxColumn.HeaderText = "Recomendación";
            this.recomendacionDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.recomendacionDataGridViewTextBoxColumn.Name = "recomendacionDataGridViewTextBoxColumn";
            // 
            // FormBaseConocimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 481);
            this.Controls.Add(this.panelAtributos);
            this.Controls.Add(this.panelMainGrid);
            this.Controls.Add(this.panelOpcions);
            this.Name = "FormBaseConocimiento";
            this.Text = "FormBaseConocimiento";
            this.panelOpcions.ResumeLayout(false);
            this.panelOpcions.PerformLayout();
            this.panelMainGrid.ResumeLayout(false);
            this.panelGridPelis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPeliculas)).EndInit();
            this.panelFormPelicula.ResumeLayout(false);
            this.panelFormPelicula.PerformLayout();
            this.panelAtributos.ResumeLayout(false);
            this.panelGridPropiedades.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAtributos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atributosBindingSource)).EndInit();
            this.panelAtributosTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oPeliculaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOpcions;
        private System.Windows.Forms.Panel panelMainGrid;
        private System.Windows.Forms.DataGridView gridPeliculas;
        private System.Windows.Forms.Panel panelAtributos;
        private System.Windows.Forms.DataGridView gridAtributos;
        private System.Windows.Forms.Panel panelAtributosTitulo;
        private System.Windows.Forms.Panel panelGridPropiedades;
        private System.Windows.Forms.BindingSource oPeliculaBindingSource;
        private System.Windows.Forms.BindingSource atributosBindingSource;
        private System.Windows.Forms.Label lblPeluculaName;
        private FontAwesome.Sharp.IconButton btnAddAtributo;
        private System.Windows.Forms.TextBox txtAtributo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFormPelicula;
        private System.Windows.Forms.Panel panelGridPelis;
        private FontAwesome.Sharp.IconButton btnAddPeli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRecomendacion;
        private System.Windows.Forms.TextBox txtNombrePeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recomendacionDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}