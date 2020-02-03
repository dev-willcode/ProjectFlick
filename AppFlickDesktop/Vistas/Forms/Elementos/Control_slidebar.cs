using System;
using System.Windows.Forms;

namespace AppFlickDesktop.Vistas.Forms.Elementos
{
    public partial class Control_slidebar : UserControl
    {
        internal bool Expandido { get; set; }

        public Control_slidebar()
        {
            InitializeComponent();
        }

        public void Expandir()
        {
            Expandido = true;
            timer.Start();
        }

        public void Contraer()
        {
            Expandido = false;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Expandido)
            {
                if (slide.Width < Width)
                {
                    slide.Width += 10;
                }
                else
                {
                    timer.Stop();
                }
            }
            else
            {
                if (slide.Width > 0)
                {
                    slide.Width -= 10;
                }
                else
                {
                    timer.Stop();
                }
            }
        }
    }
}
