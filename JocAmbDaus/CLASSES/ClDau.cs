using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocAmbDaus.CLASSES
{
    public class ClDau
    {
        private readonly Panel pnlDau;

        public ClDau(Panel xpnl, int xnum)
        {
            pnlDau = xpnl;
        }

        public void pintar(PaintEventArgs e, int num)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Cara del dado: fondo blanco con borde, así se ve bien
            // sobre cualquier color de jugador del panel.
            int cara = 4;
            Rectangle rect = new Rectangle(cara, cara, pnlDau.Width - cara * 2 - 1, pnlDau.Height - cara * 2 - 1);
            using (SolidBrush fons = new SolidBrush(Color.White))
                g.FillRectangle(fons, rect);
            g.DrawRectangle(Pens.Black, rect);

            int radi = 10;
            int esq = cara + 6;
            int dreta = pnlDau.Width - cara - 6 - radi;
            int mig = pnlDau.Width / 2 - radi / 2;
            int migV = pnlDau.Height / 2 - radi / 2;

            switch (num)
            {
                case 1:
                    g.FillEllipse(Brushes.Black, mig, migV, radi, radi);
                    break;

                case 2:
                    g.FillEllipse(Brushes.Black, esq, esq, radi, radi);
                    g.FillEllipse(Brushes.Black, dreta, dreta, radi, radi);
                    break;

                case 3:
                    g.FillEllipse(Brushes.Black, esq, esq, radi, radi);
                    g.FillEllipse(Brushes.Black, mig, migV, radi, radi);
                    g.FillEllipse(Brushes.Black, dreta, dreta, radi, radi);
                    break;

                case 4:
                    g.FillEllipse(Brushes.Black, esq, esq, radi, radi);
                    g.FillEllipse(Brushes.Black, dreta, esq, radi, radi);
                    g.FillEllipse(Brushes.Black, esq, dreta, radi, radi);
                    g.FillEllipse(Brushes.Black, dreta, dreta, radi, radi);
                    break;

                case 5:
                    g.FillEllipse(Brushes.Black, esq, esq, radi, radi);
                    g.FillEllipse(Brushes.Black, dreta, esq, radi, radi);
                    g.FillEllipse(Brushes.Black, mig, migV, radi, radi);
                    g.FillEllipse(Brushes.Black, esq, dreta, radi, radi);
                    g.FillEllipse(Brushes.Black, dreta, dreta, radi, radi);
                    break;

                case 6:
                    g.FillEllipse(Brushes.Black, esq, esq, radi, radi);
                    g.FillEllipse(Brushes.Black, dreta, esq, radi, radi);
                    g.FillEllipse(Brushes.Black, esq, migV, radi, radi);
                    g.FillEllipse(Brushes.Black, dreta, migV, radi, radi);
                    g.FillEllipse(Brushes.Black, esq, dreta, radi, radi);
                    g.FillEllipse(Brushes.Black, dreta, dreta, radi, radi);
                    break;
            }
        }
    }
}
