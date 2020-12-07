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
    public partial class FormConsulta : Form
    {

        List<StringValue> ListAtributos;
        List<oPelicula> ListPeliculas;
        int IndexP;
        int IndexAtt;

        public FormConsulta()
        {
            InitializeComponent();
            LoadComboAtributos();
            LoadStartPanel();
        }

        private void LoadStartPanel()
        {
            panelStart.Enabled = true;
            panelQuestions.Enabled = false;
            panelResultado.Enabled = false;
            lblAtributo.Text = String.Empty;
            lblPeliName.Text = String.Empty;
            lblDescriptcion.Text = String.Empty;
            IndexP = 0;
            IndexAtt = 0;
            lblMensaje.Height = 0;
            listNo.Items.Clear();
            listYes.Items.Clear();
        }

        private void LoadComboAtributos()
        {
            ListPeliculas = CRUDPeliculas.GetListPeliculas();
            if (ListAtributos == null)
            {
                ListAtributos = new List<StringValue>();
                foreach (var item in ListPeliculas)
                {
                    foreach (var item2 in item.Atributos)
                    {
                        if (ListAtributos.FindIndex(x => x.Value == item2.Value) == -1)
                            ListAtributos.Add(item2);
                    }
                }
            }

            cmbAtributos.DataSource = ListAtributos;
        }

        private void btnAddYes_Click(object sender, EventArgs e)
        {
            if (cmbAtributos.SelectedValue != null)
            {
                string value = cmbAtributos.SelectedValue.ToString();
                AddToListYes(value);
            }
            else
            {
                MessageBox.Show("Favor de selecionar algun atributo para agregar a la lista");
            }
        }


        private void btnAddNo_Click(object sender, EventArgs e)
        {
            if (cmbAtributos.SelectedValue != null)
            {
                string value = cmbAtributos.SelectedValue.ToString();
                AddToListNo(value);
            }
            else
            {
                MessageBox.Show("Favor de selecionar algun atributo para agregar a la lista");
            }
        }

        private void AddToListYes(string value)
        {
            if (listNo.FindString(value) == -1 && listYes.FindString(value) == -1)
                listYes.Items.Add(value);
        }

        private void AddToListNo(string value)
        {
            if (listYes.FindString(value) == -1 && listNo.FindString(value) == -1)
                listNo.Items.Add(value);
        }

        private void btnAddYesQ_Click(object sender, EventArgs e)
        {
            AddToListYes(lblAtributo.Text);
            IndexAtt++;
            Consulta();
        }

        private void btnAddNoQ_Click(object sender, EventArgs e)
        {
            AddToListNo(lblAtributo.Text);
            IndexP++;
            IndexAtt = 0;
            Consulta();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            LoadStartPanel();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            panelStart.Enabled = false;
            panelQuestions.Enabled = true;
            panelResultado.Enabled = true;
            IndexP = 0;
            IndexAtt = 0;
            Consulta();
        }

        private void Consulta()
        {
            lblMensaje.Height = 0;
            if (IndexAtt == 0)
            {
                while (!CheckYesNotObjet()) ;
            }

            if (ListPeliculas.Count > IndexP)
            {
                while (!CheckList()) ;
                if (ListPeliculas[IndexP].Atributos.Count > IndexAtt)
                {
                    lblAtributo.Text = ListPeliculas[IndexP].Atributos[IndexAtt].Value;
                }
                else
                {
                    if (EsLaRespuesta())
                        Consulta();
                }
            }
            else
            {
                lblMensaje.Height = 35;
                lblMensaje.Text = "Ya no ahi mas peliculas a comparar.";
                panelQuestions.Enabled = false;
                lblAtributo.Text = string.Empty;
            }
        }

        private bool EsLaRespuesta()
        {
            lblMensaje.Height = 35;
            lblPeliName.Text = ListPeliculas[IndexP].Nombre;
            lblDescriptcion.Text = ListPeliculas[IndexP].Recomendacion;

            IndexP++;
            while (!CheckYesNotObjet()) ;
            IndexAtt = 0;

            if (ListPeliculas.Count > IndexP)
            {
                if (YesNoMensaje(lblPeliName.Text, lblDescriptcion.Text))
                {
                    lblMensaje.Text = "Se encontro una coincidencia, pero aun existen mas posibilidades.";

                }
                else
                {
                    panelQuestions.Enabled = false;
                    lblAtributo.Text = string.Empty;
                    lblMensaje.Text = "Se a terminado la consulta por parte del usuario.";
                    return false;
                }
            }
            return true;
        }

        private bool CheckYesNotObjet()
        {
            if (ListPeliculas.Count > IndexP)
            {
                int cont = 0;
                foreach (var item in ListPeliculas[IndexP].Atributos)
                {
                    if (listNo.FindString(item.Value) != -1)
                    {
                        IndexP++;
                        return false;
                    }
                    else if (listYes.FindString(item.Value) != -1)
                    {
                        cont++;
                    }
                }

                if (cont == listYes.Items.Count)
                {
                    return true;
                }
                else
                {
                    IndexP++;
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        private bool CheckList()
        {
            if (ListPeliculas[IndexP].Atributos.Count > IndexAtt)
            {
                string AttrActual = ListPeliculas[IndexP].Atributos[IndexAtt].Value;
                if (listYes.FindString(AttrActual) != -1)
                {
                    IndexAtt++;
                    return false;
                }
            }

            return true;
        }

        private bool YesNoMensaje(string titulo, string descripcion)
        {
            DialogResult res = MessageBox
                .Show("Se encontro una coincidencia, pero aun existen mas posibilidades: \n"
                                               + "Titulo: " + titulo + "\n" + descripcion,
                                                "Deseas continuar la consulta?",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Information);

            return (res == DialogResult.Yes);
        }
    }
}
