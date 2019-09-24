using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Media;
using System.Threading;


namespace Tarot_Card_actual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen Drawpen = new Pen(Color.Black);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            g.Clear(Color.Black);
            g.FillRectangle(blueBrush, 0, 0, 220, 120);

            Font drawfont = new Font("Freehand591 BTFreehand591", 12);
            g.DrawString("Happy Birthday", drawfont, drawBrush, 0, 0);
            Thread.Sleep(1000);
            g.DrawString("Matty", drawfont, drawBrush, 75, 35);
            Thread.Sleep(1000);
            g.DrawString("Vanstone", drawfont, drawBrush, 100, 75);

            SoundPlayer GodzillaSound = new SoundPlayer(Properties.Resources.Godzilla_Marc_785758480);
            GodzillaSound.Play();
        }
    }
}
