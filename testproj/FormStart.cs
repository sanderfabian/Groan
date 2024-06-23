using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanderVictorAssgt
{
    //Sander Fabian C3418982 & Victor Chua Jia Zhi C3418248

    public partial class FormStart : Form
    {

        
        public FormStart()
        {
            InitializeComponent();
            
           
        }


        private void FormStart_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Fixed3D; 

            
        }

        private void bPvp_Click(object sender, EventArgs e) // if button PVP is clicked, it will open PVP form
        {
            PVP pvp = new PVP();

            pvp.Show();
            this.Hide();
        }

        private void bPvai_Click(object sender, EventArgs e) // if button PVAI is clicked, it will open PVAI form
        {
            PVAI pvai = new PVAI();
            pvai.Show();
            this.Hide();
        }

        private void bExit_Click(object sender, EventArgs e) // exit
        {
            this.Close();
        }


    }
}
