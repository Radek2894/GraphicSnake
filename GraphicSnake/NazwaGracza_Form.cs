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
        public static string nazwaGracza = "";
        public NazwaGracza_Form()
        {

            InitializeComponent();

        }
  
        private void playButton_Click(object sender, EventArgs e)
        {
            nazwaGracza = nazwa.Text;

            Gra_Form gameWindow = new Gra_Form();


             this.Close();

            gameWindow.ShowDialog();

                this.Show();
            
        }

        

    }
}

