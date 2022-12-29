using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicSnake
{
    public partial class NazwaGracza_Form : Form
    {
        public NazwaGracza_Form()
        {

            InitializeComponent();


            nazwa.Text += new System.EventHandler(Set_Name);
            nazwa.Text = Menu_Form.nazwaGracza;



        }
        private void Set_Name(object sender, System.EventArgs e)
        {
            Menu_Form.nazwaGracza = nazwa.Text;
        }


        private void LoadGame(object sender, EventArgs e)
        {
            Gra_Form gameWindow = new Gra_Form();

            this.Hide();

            gameWindow.ShowDialog();

            
                this.Show();
           
        }

       

        private void playButton_Click(object sender, EventArgs e)
        {
            Gra_Form gameWindow = new Gra_Form();

            this.Hide();

            gameWindow.ShowDialog();

           
                this.Show();
            
        }

        

    }
}

