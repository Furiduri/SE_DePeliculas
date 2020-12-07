namespace SEParaPeliculas
{
    partial class FormConsulta
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
            this.panelStart = new System.Windows.Forms.Panel();
            this.btnStart = new FontAwesome.Sharp.IconButton();
            this.btnAddNo = new FontAwesome.Sharp.IconButton();
            this.btnAddYes = new FontAwesome.Sharp.IconButton();
            this.cmbAtributos = new Telerik.WinControls.UI.RadDropDownList();
            this.atributosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oPeliculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblInstrucions = new System.Windows.Forms.Label();
            this.panelListAtributes = new System.Windows.Forms.Panel();
            this.panelListNot = new System.Windows.Forms.Panel();
            this.listNo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelListYes = new System.Windows.Forms.Panel();
            this.listYes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelQuestions = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnAddNoQ = new FontAwesome.Sharp.IconButton();
            this.btnAddYesQ = new FontAwesome.Sharp.IconButton();
            this.lblAtributo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescriptcion = new System.Windows.Forms.Label();
            this.lblPeliName = new System.Windows.Forms.Label();
            this.btnRestart = new FontAwesome.Sharp.IconButton();
            this.panelStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAtributos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atributosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPeliculaBindingSource)).BeginInit();
            this.panelListAtributes.SuspendLayout();
            this.panelListNot.SuspendLayout();
            this.panelListYes.SuspendLayout();
            this.panelQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelResultado.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStart
            // 
            this.panelStart.Controls.Add(this.btnStart);
            this.panelStart.Controls.Add(this.btnAddNo);
            this.panelStart.Controls.Add(this.btnAddYes);
            this.panelStart.Controls.Add(this.cmbAtributos);
            this.panelStart.Controls.Add(this.lblInstrucions);
            this.panelStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStart.Location = new System.Drawing.Point(0, 0);
            this.panelStart.Name = "panelStart";
            this.panelStart.Padding = new System.Windows.Forms.Padding(10);
            this.panelStart.Size = new System.Drawing.Size(800, 104);
            this.panelStart.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnStart.IconColor = System.Drawing.Color.White;
            this.btnStart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStart.IconSize = 25;
            this.btnStart.Location = new System.Drawing.Point(629, 34);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(161, 60);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Iniciar Consulta";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAddNo
            // 
            this.btnAddNo.AutoSize = true;
            this.btnAddNo.BackColor = System.Drawing.Color.Crimson;
            this.btnAddNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNo.Font = new System.Drawing.Font("Lato", 10F);
            this.btnAddNo.ForeColor = System.Drawing.Color.White;
            this.btnAddNo.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnAddNo.IconColor = System.Drawing.Color.White;
            this.btnAddNo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNo.IconSize = 30;
            this.btnAddNo.Location = new System.Drawing.Point(422, 49);
            this.btnAddNo.Name = "btnAddNo";
            this.btnAddNo.Size = new System.Drawing.Size(151, 42);
            this.btnAddNo.TabIndex = 3;
            this.btnAddNo.Text = "Agregar a No";
            this.btnAddNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNo.UseVisualStyleBackColor = false;
            this.btnAddNo.Click += new System.EventHandler(this.btnAddNo_Click);
            // 
            // btnAddYes
            // 
            this.btnAddYes.AutoSize = true;
            this.btnAddYes.BackColor = System.Drawing.Color.Green;
            this.btnAddYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddYes.Font = new System.Drawing.Font("Lato", 10F);
            this.btnAddYes.ForeColor = System.Drawing.Color.White;
            this.btnAddYes.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddYes.IconColor = System.Drawing.Color.White;
            this.btnAddYes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddYes.IconSize = 25;
            this.btnAddYes.Location = new System.Drawing.Point(271, 49);
            this.btnAddYes.Name = "btnAddYes";
            this.btnAddYes.Size = new System.Drawing.Size(145, 42);
            this.btnAddYes.TabIndex = 2;
            this.btnAddYes.Text = "Agregar a Si";
            this.btnAddYes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddYes.UseVisualStyleBackColor = false;
            this.btnAddYes.Click += new System.EventHandler(this.btnAddYes_Click);
            // 
            // cmbAtributos
            // 
            this.cmbAtributos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAtributos.DataSource = this.atributosBindingSource;
            this.cmbAtributos.DisplayMember = "Value";
            this.cmbAtributos.Font = new System.Drawing.Font("Lato", 14F);
            this.cmbAtributos.ItemHeight = 36;
            this.cmbAtributos.Location = new System.Drawing.Point(14, 63);
            this.cmbAtributos.Name = "cmbAtributos";
            this.cmbAtributos.Size = new System.Drawing.Size(241, 33);
            this.cmbAtributos.TabIndex = 1;
            this.cmbAtributos.ValueMember = "Value";
            // 
            // atributosBindingSource
            // 
            this.atributosBindingSource.DataMember = "Atributos";
            this.atributosBindingSource.DataSource = this.oPeliculaBindingSource;
            // 
            // oPeliculaBindingSource
            // 
            this.oPeliculaBindingSource.DataSource = typeof(SEParaPeliculas.oPelicula);
            // 
            // lblInstrucions
            // 
            this.lblInstrucions.AutoSize = true;
            this.lblInstrucions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInstrucions.Font = new System.Drawing.Font("Lato Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucions.Location = new System.Drawing.Point(10, 10);
            this.lblInstrucions.Name = "lblInstrucions";
            this.lblInstrucions.Size = new System.Drawing.Size(548, 24);
            this.lblInstrucions.TabIndex = 0;
            this.lblInstrucions.Text = "Selecione al menos un atributo para realizar la consulta";
            // 
            // panelListAtributes
            // 
            this.panelListAtributes.Controls.Add(this.panelListNot);
            this.panelListAtributes.Controls.Add(this.panelListYes);
            this.panelListAtributes.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelListAtributes.Location = new System.Drawing.Point(0, 104);
            this.panelListAtributes.Name = "panelListAtributes";
            this.panelListAtributes.Size = new System.Drawing.Size(300, 346);
            this.panelListAtributes.TabIndex = 1;
            // 
            // panelListNot
            // 
            this.panelListNot.Controls.Add(this.listNo);
            this.panelListNot.Controls.Add(this.label2);
            this.panelListNot.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelListNot.Location = new System.Drawing.Point(150, 0);
            this.panelListNot.Name = "panelListNot";
            this.panelListNot.Size = new System.Drawing.Size(150, 346);
            this.panelListNot.TabIndex = 1;
            // 
            // listNo
            // 
            this.listNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listNo.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listNo.FormattingEnabled = true;
            this.listNo.HorizontalScrollbar = true;
            this.listNo.ItemHeight = 24;
            this.listNo.Location = new System.Drawing.Point(0, 65);
            this.listNo.Name = "listNo";
            this.listNo.Size = new System.Drawing.Size(150, 281);
            this.listNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Lato", 10F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(150, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = "Listado de Atributos Rechazados";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelListYes
            // 
            this.panelListYes.Controls.Add(this.listYes);
            this.panelListYes.Controls.Add(this.label1);
            this.panelListYes.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelListYes.Location = new System.Drawing.Point(0, 0);
            this.panelListYes.Name = "panelListYes";
            this.panelListYes.Size = new System.Drawing.Size(150, 346);
            this.panelListYes.TabIndex = 0;
            // 
            // listYes
            // 
            this.listYes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listYes.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listYes.FormattingEnabled = true;
            this.listYes.HorizontalScrollbar = true;
            this.listYes.ItemHeight = 24;
            this.listYes.Location = new System.Drawing.Point(0, 65);
            this.listYes.Name = "listYes";
            this.listYes.Size = new System.Drawing.Size(150, 281);
            this.listYes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Lato", 10F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(150, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Atributos Aceptados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelQuestions
            // 
            this.panelQuestions.Controls.Add(this.lblMensaje);
            this.panelQuestions.Controls.Add(this.btnAddNoQ);
            this.panelQuestions.Controls.Add(this.btnAddYesQ);
            this.panelQuestions.Controls.Add(this.lblAtributo);
            this.panelQuestions.Controls.Add(this.label3);
            this.panelQuestions.Controls.Add(this.iconPictureBox1);
            this.panelQuestions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuestions.Location = new System.Drawing.Point(300, 104);
            this.panelQuestions.Name = "panelQuestions";
            this.panelQuestions.Size = new System.Drawing.Size(500, 191);
            this.panelQuestions.TabIndex = 2;
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.SteelBlue;
            this.lblMensaje.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMensaje.Font = new System.Drawing.Font("Lato", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Location = new System.Drawing.Point(0, 155);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(500, 36);
            this.lblMensaje.TabIndex = 5;
            // 
            // btnAddNoQ
            // 
            this.btnAddNoQ.AutoSize = true;
            this.btnAddNoQ.BackColor = System.Drawing.Color.Crimson;
            this.btnAddNoQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNoQ.Font = new System.Drawing.Font("Lato", 10F);
            this.btnAddNoQ.ForeColor = System.Drawing.Color.White;
            this.btnAddNoQ.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnAddNoQ.IconColor = System.Drawing.Color.White;
            this.btnAddNoQ.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNoQ.IconSize = 30;
            this.btnAddNoQ.Location = new System.Drawing.Point(278, 110);
            this.btnAddNoQ.Name = "btnAddNoQ";
            this.btnAddNoQ.Size = new System.Drawing.Size(151, 42);
            this.btnAddNoQ.TabIndex = 4;
            this.btnAddNoQ.Text = "Agregar a No";
            this.btnAddNoQ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNoQ.UseVisualStyleBackColor = false;
            this.btnAddNoQ.Click += new System.EventHandler(this.btnAddNoQ_Click);
            // 
            // btnAddYesQ
            // 
            this.btnAddYesQ.AutoSize = true;
            this.btnAddYesQ.BackColor = System.Drawing.Color.Green;
            this.btnAddYesQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddYesQ.Font = new System.Drawing.Font("Lato", 10F);
            this.btnAddYesQ.ForeColor = System.Drawing.Color.White;
            this.btnAddYesQ.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddYesQ.IconColor = System.Drawing.Color.White;
            this.btnAddYesQ.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddYesQ.IconSize = 25;
            this.btnAddYesQ.Location = new System.Drawing.Point(66, 110);
            this.btnAddYesQ.Name = "btnAddYesQ";
            this.btnAddYesQ.Size = new System.Drawing.Size(145, 42);
            this.btnAddYesQ.TabIndex = 3;
            this.btnAddYesQ.Text = "Agregar a Si";
            this.btnAddYesQ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddYesQ.UseVisualStyleBackColor = false;
            this.btnAddYesQ.Click += new System.EventHandler(this.btnAddYesQ_Click);
            // 
            // lblAtributo
            // 
            this.lblAtributo.Font = new System.Drawing.Font("Lato", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtributo.Location = new System.Drawing.Point(60, 55);
            this.lblAtributo.Name = "lblAtributo";
            this.lblAtributo.Size = new System.Drawing.Size(369, 42);
            this.lblAtributo.TabIndex = 2;
            this.lblAtributo.Text = "Atributo";
            this.lblAtributo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 12F);
            this.label3.Location = new System.Drawing.Point(62, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "¿La pelicula que busca tiene este atributo?";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.DodgerBlue;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 50;
            this.iconPictureBox1.Location = new System.Drawing.Point(6, 6);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(50, 50);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.panel1);
            this.panelResultado.Controls.Add(this.btnRestart);
            this.panelResultado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelResultado.Location = new System.Drawing.Point(300, 295);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(500, 167);
            this.panelResultado.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDescriptcion);
            this.panel1.Controls.Add(this.lblPeliName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 167);
            this.panel1.TabIndex = 6;
            // 
            // lblDescriptcion
            // 
            this.lblDescriptcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescriptcion.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptcion.Location = new System.Drawing.Point(0, 41);
            this.lblDescriptcion.Name = "lblDescriptcion";
            this.lblDescriptcion.Padding = new System.Windows.Forms.Padding(10);
            this.lblDescriptcion.Size = new System.Drawing.Size(339, 126);
            this.lblDescriptcion.TabIndex = 1;
            // 
            // lblPeliName
            // 
            this.lblPeliName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPeliName.Font = new System.Drawing.Font("Lato Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeliName.Location = new System.Drawing.Point(0, 0);
            this.lblPeliName.Name = "lblPeliName";
            this.lblPeliName.Padding = new System.Windows.Forms.Padding(10);
            this.lblPeliName.Size = new System.Drawing.Size(339, 41);
            this.lblPeliName.TabIndex = 0;
            // 
            // btnRestart
            // 
            this.btnRestart.AutoSize = true;
            this.btnRestart.BackColor = System.Drawing.Color.SlateGray;
            this.btnRestart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Lato", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.btnRestart.IconColor = System.Drawing.Color.White;
            this.btnRestart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestart.IconSize = 25;
            this.btnRestart.Location = new System.Drawing.Point(339, 0);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(161, 167);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Iniciar Consulta";
            this.btnRestart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.panelQuestions);
            this.Controls.Add(this.panelListAtributes);
            this.Controls.Add(this.panelStart);
            this.Name = "FormConsulta";
            this.Text = "FormConsulta";
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAtributos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atributosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPeliculaBindingSource)).EndInit();
            this.panelListAtributes.ResumeLayout(false);
            this.panelListNot.ResumeLayout(false);
            this.panelListYes.ResumeLayout(false);
            this.panelQuestions.ResumeLayout(false);
            this.panelQuestions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.Label lblInstrucions;
        private Telerik.WinControls.UI.RadDropDownList cmbAtributos;
        private FontAwesome.Sharp.IconButton btnAddYes;
        private System.Windows.Forms.Panel panelListAtributes;
        private System.Windows.Forms.Panel panelListNot;
        private System.Windows.Forms.Panel panelListYes;
        private FontAwesome.Sharp.IconButton btnStart;
        private FontAwesome.Sharp.IconButton btnAddNo;
        private System.Windows.Forms.Panel panelQuestions;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.BindingSource atributosBindingSource;
        private System.Windows.Forms.BindingSource oPeliculaBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listYes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listNo;
        private FontAwesome.Sharp.IconButton btnAddNoQ;
        private FontAwesome.Sharp.IconButton btnAddYesQ;
        private System.Windows.Forms.Label lblAtributo;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPeliName;
        private FontAwesome.Sharp.IconButton btnRestart;
        private System.Windows.Forms.Label lblDescriptcion;
        private System.Windows.Forms.Label lblMensaje;
    }
}