using FontAwesome.Sharp;
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
    public partial class FormMenu : Form
    {

        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public FormMenu()
        {
            InitializeComponent();

            ResetSE();
            //Borde de color
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        #region Colors
        private struct MyColors
        {
            public static Color Black = Color.FromArgb(49, 57, 60);
            public static Color Grey = Color.FromArgb(211, 212, 217);
            public static Color Blue = Color.FromArgb(2, 123, 206);
        }

        #endregion

        #region Metodos UI
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = MyColors.Grey;
                currentBtn.ForeColor = MyColors.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = MyColors.Black;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconActual.IconChar = currentBtn.IconChar;
                lblTitleForm.Text = currentBtn.Text;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = MyColors.Black;
                currentBtn.ForeColor = MyColors.Grey;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = MyColors.Grey;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                leftBorderBtn.Visible = false;
                iconActual.IconChar = IconChar.Home;
                lblTitleForm.Text = "Inicio";
            }
        }
        #endregion

        #region Metodos SE
        private void ResetSE()
        {
            DisableButton();
            OpenChildForm(new FormInicio());
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {                
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = MyColors.Grey;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        private void btnMenuConsulta_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, MyColors.Blue);
            OpenChildForm(new FormConsulta());
        }

        private void btnMenuBaseConocimientos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, MyColors.Blue);
            OpenChildForm(new FormBaseConocimiento());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            ResetSE();
        }
       
    }
}
