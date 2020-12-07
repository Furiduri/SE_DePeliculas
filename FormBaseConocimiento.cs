using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEParaPeliculas
{
    public partial class FormBaseConocimiento : Form
    {
        List<oPelicula> ListPeliculas;
        int? IndexP;

        public FormBaseConocimiento()
        {
            InitializeComponent();
            ListPeliculas = CRUDPeliculas.GetListPeliculas();
            LoadGrid();
            SetBtnSaveGreen();
        }

        private void LoadGrid()
        {
            txtNombrePeli.Text = string.Empty;
            txtRecomendacion.Text = string.Empty;
            gridPeliculas.DataSource = null;
            gridPeliculas.DataSource = ListPeliculas;
            panelAtributos.Visible = false;
            IndexP = 0;
        }

        private void gridPeliculas_SelectionChanged(object sender, EventArgs e)
        {
            panelAtributos.Visible = true;
            if (gridPeliculas.SelectedRows.Count == 1)
            {
                IndexP = gridPeliculas.SelectedRows[0].Index;
            }
            LoadAtributosPeluculaActual();
        }

        private void LoadAtributosPeluculaActual()
        {
            if (IndexP != null)
            {
                txtAtributo.Text = string.Empty;
                lblPeluculaName.Text = ListPeliculas[IndexP.Value].Nombre;
                gridAtributos.DataSource = null;
                gridAtributos.DataSource = ListPeliculas[IndexP.Value].Atributos;
            }
            else
            {
                MessageBox.Show("Favor de selecionar alguna pelicula");
            }
            
        }

        private void btnAddAtributo_Click(object sender, EventArgs e)
        {
            if (IndexP != null)
            {
                AddNewAttributo();                
            }
            else
            {
                MessageBox.Show("Favor de selecionar alguna pelicula");
            }
        }

        private void AddNewAttributo()
        {
            if(!String.IsNullOrWhiteSpace( txtAtributo.Text))
            {
                ListPeliculas[IndexP.Value].Atributos.Add(
                    new StringValue(txtAtributo.Text.Trim())
                    );
                LoadAtributosPeluculaActual();
                SetBtnSaveRed();
            }
            else
            {
                MessageBox.Show("Favor de escribir algun atributo");
            }
        }

        private void btnAddPeli_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNombrePeli.Text))
            {
                string NombrePeli = txtNombrePeli.Text.Trim();
                ListPeliculas.Add(new oPelicula()
                {
                    Nombre = NombrePeli,
                    Recomendacion = txtRecomendacion.Text.Trim(),
                    Atributos = new List<StringValue>()
                });
                LoadGrid();
                //gridPeliculas.SelectedRows.Clear();
                foreach (DataGridViewRow row in gridPeliculas.Rows)
                {
                    if(row.Cells[0].Value.ToString() == NombrePeli)
                    {
                        row.Selected = true;
                        gridPeliculas.CurrentCell = row.Cells[0];
                    }
                }
                LoadAtributosPeluculaActual();
                SetBtnSaveRed();
            }
            else
            {
                MessageBox.Show("Favor de escribir minimo el nombre de la pelicula");
            }
        }

        private void gridPeliculas_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Cancel = String.IsNullOrWhiteSpace(e.FormattedValue.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CRUDPeliculas.SaveFile(ListPeliculas))
                {
                    SetBtnSaveGreen();
                }
                else
                {
                    SetBtnSaveRed();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetBtnSaveRed()
        {
            try
            {
                btnSave.Text = "Click para Guardar los cambios";
                btnSave.BackColor = Color.Crimson;
                btnSave.ForeColor = Color.White;
                btnSave.IconColor = Color.White;
                btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
                btnSave.Enabled = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void SetBtnSaveGreen()
        {
            try
            {
                btnSave.Text = "No ahi cambios para guardar";
                btnSave.BackColor = Color.Transparent;
                btnSave.ForeColor = Color.Black;
                btnSave.IconColor = Color.Green;
                btnSave.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                btnSave.Enabled = false;

            }
            catch (Exception ex)      
            {

            }
        }

        private void gridPeliculas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SetBtnSaveRed();
        }

        private void gridPeliculas_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           bool res =  DeleteMensaje();
            if (res)
            {
                ListPeliculas.Remove(ListPeliculas[e.RowIndex]);
                SetBtnSaveRed();
                IndexP = 0;
                LoadGrid();
            }
        }

        private void gridAtributos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            bool res = DeleteMensaje();
            if (res)
            {
                ListPeliculas[IndexP.Value].Atributos
                    .Remove(ListPeliculas[IndexP.Value].Atributos[e.RowIndex]);
                SetBtnSaveRed();
                IndexP = 0;
                LoadAtributosPeluculaActual();
            }
        }


        private bool DeleteMensaje()
        {
            DialogResult res = MessageBox.Show("Estas seguro de querer borrar este dato?",
                                               "Estas Seguro", MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning);

            return (res == DialogResult.Yes);
        }

    }

}
