namespace SEParaPeliculas
{
    partial class FormMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitleForm = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelSombra = new System.Windows.Forms.Panel();
            this.iconActual = new FontAwesome.Sharp.IconPictureBox();
            this.btnMenuBaseConocimientos = new FontAwesome.Sharp.IconButton();
            this.btnMenuConsulta = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))));
            this.panelMenu.Controls.Add(this.btnMenuBaseConocimientos);
            this.panelMenu.Controls.Add(this.btnMenuConsulta);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 603);
            this.panelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnInicio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 100);
            this.panel2.TabIndex = 0;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(123)))), ((int)(((byte)(206)))));
            this.panelTitulo.Controls.Add(this.lblTitleForm);
            this.panelTitulo.Controls.Add(this.iconActual);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(220, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Padding = new System.Windows.Forms.Padding(5);
            this.panelTitulo.Size = new System.Drawing.Size(981, 60);
            this.panelTitulo.TabIndex = 1;
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.AutoSize = true;
            this.lblTitleForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitleForm.Font = new System.Drawing.Font("Lato Medium", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitleForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleForm.Location = new System.Drawing.Point(73, 25);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitleForm.Size = new System.Drawing.Size(78, 30);
            this.lblTitleForm.TabIndex = 1;
            this.lblTitleForm.Text = "Inicio";
            this.lblTitleForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 60);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(981, 543);
            this.panelDesktop.TabIndex = 2;
            // 
            // panelSombra
            // 
            this.panelSombra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(111)))), ((int)(((byte)(183)))));
            this.panelSombra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSombra.Location = new System.Drawing.Point(220, 60);
            this.panelSombra.Name = "panelSombra";
            this.panelSombra.Size = new System.Drawing.Size(981, 9);
            this.panelSombra.TabIndex = 3;
            // 
            // iconActual
            // 
            this.iconActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(123)))), ((int)(((byte)(206)))));
            this.iconActual.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconActual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconActual.IconColor = System.Drawing.Color.White;
            this.iconActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconActual.IconSize = 50;
            this.iconActual.Location = new System.Drawing.Point(5, 5);
            this.iconActual.Margin = new System.Windows.Forms.Padding(5);
            this.iconActual.Name = "iconActual";
            this.iconActual.Padding = new System.Windows.Forms.Padding(10);
            this.iconActual.Size = new System.Drawing.Size(60, 50);
            this.iconActual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconActual.TabIndex = 0;
            this.iconActual.TabStop = false;
            // 
            // btnMenuBaseConocimientos
            // 
            this.btnMenuBaseConocimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuBaseConocimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuBaseConocimientos.FlatAppearance.BorderSize = 0;
            this.btnMenuBaseConocimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuBaseConocimientos.Font = new System.Drawing.Font("Lato", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuBaseConocimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(212)))), ((int)(((byte)(217)))));
            this.btnMenuBaseConocimientos.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnMenuBaseConocimientos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(212)))), ((int)(((byte)(217)))));
            this.btnMenuBaseConocimientos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuBaseConocimientos.IconSize = 40;
            this.btnMenuBaseConocimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuBaseConocimientos.Location = new System.Drawing.Point(0, 160);
            this.btnMenuBaseConocimientos.Name = "btnMenuBaseConocimientos";
            this.btnMenuBaseConocimientos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMenuBaseConocimientos.Size = new System.Drawing.Size(220, 60);
            this.btnMenuBaseConocimientos.TabIndex = 1;
            this.btnMenuBaseConocimientos.Text = "Base de conocimientos";
            this.btnMenuBaseConocimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuBaseConocimientos.UseVisualStyleBackColor = true;
            this.btnMenuBaseConocimientos.Click += new System.EventHandler(this.btnMenuBaseConocimientos_Click);
            // 
            // btnMenuConsulta
            // 
            this.btnMenuConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuConsulta.FlatAppearance.BorderSize = 0;
            this.btnMenuConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuConsulta.Font = new System.Drawing.Font("Lato", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(212)))), ((int)(((byte)(217)))));
            this.btnMenuConsulta.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnMenuConsulta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(212)))), ((int)(((byte)(217)))));
            this.btnMenuConsulta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuConsulta.IconSize = 40;
            this.btnMenuConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuConsulta.Location = new System.Drawing.Point(0, 100);
            this.btnMenuConsulta.Name = "btnMenuConsulta";
            this.btnMenuConsulta.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMenuConsulta.Size = new System.Drawing.Size(220, 60);
            this.btnMenuConsulta.TabIndex = 0;
            this.btnMenuConsulta.Text = "Consulta";
            this.btnMenuConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuConsulta.UseVisualStyleBackColor = true;
            this.btnMenuConsulta.Click += new System.EventHandler(this.btnMenuConsulta_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInicio.Image = global::SEParaPeliculas.Properties.Resources.CETI;
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(10);
            this.btnInicio.Size = new System.Drawing.Size(220, 100);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(212)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1201, 603);
            this.Controls.Add(this.panelSombra);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMenu";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnMenuConsulta;
        private FontAwesome.Sharp.IconButton btnMenuBaseConocimientos;
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitleForm;
        private FontAwesome.Sharp.IconPictureBox iconActual;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelSombra;
    }
}

