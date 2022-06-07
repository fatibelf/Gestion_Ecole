using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEcole
{
    public partial class Accueil : Form
    {
        private Button currentbutton;
        private Random random;
        private int tepIndex;
        private Form activForm;
        public Accueil()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color SelectThemeColoer()
        {
            int index = random.Next(ThemColor.ColorList.Count);
            while (tepIndex == index)
            {
                index = random.Next(ThemColor.ColorList.Count);
            }
            tepIndex = index;
            string color = ThemColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentbutton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColoer();
                    currentbutton = (Button)btnSender;
                    currentbutton.BackColor = color;
                    currentbutton.ForeColor = Color.White;
                    currentbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitBar.BackColor = color;
                    panellOGO.BackColor = ThemColor.ChangeColorBrightness(color,-0.3);
                }

            }

        }
        private void DisableButton()
        {
            foreach (Control previousbtn in panelMenu.Controls)
            {
                if (previousbtn.GetType() == typeof(Button))
                {
                    previousbtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousbtn.ForeColor = Color.Gainsboro;
                    previousbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm,object btnSender)
        {
            if(activForm!=null)
            {
                activForm.Close();

            }
            ActivButton(btnSender);
            activForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = childForm.Text;
        }
        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void btnStagaire_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Stagaire(), sender);
        }

        private void btnEtudier_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Paiment(), sender);
        }

        private void btnDiplom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Type__Paiment(), sender);
        }

        

        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeplom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Diplome(), sender);
        }

        private void btnFilier_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Filier(), sender);
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Module(), sender);
        }

        private void brnFormateur_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Formateur(), sender);
        }

        private void btnClasse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Views.Classe(), sender);
        }
    }
}
