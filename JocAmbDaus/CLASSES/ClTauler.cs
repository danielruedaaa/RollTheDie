using System;
using System.Drawing;
using System.Windows.Forms;

namespace JocAmbDaus.CLASSES
{
    public class ClTauler
    {
        private const int FILES = 10;
        private const int COLUMNES = 10;
        private const int MIDA_CASELLA = 70; 

        private readonly Panel pnlTauler;

        public bool TemaClar { get; set; } = false;

        public ClTauler(Panel panelAssociat)
        {
            pnlTauler = panelAssociat;
            ActivarDobleBuffer(pnlTauler);
            pnlTauler.Paint += pnlTauler_Paint;
        }

        private static void ActivarDobleBuffer(Panel panel)
        {
            try
            {
                // Panel.DoubleBuffered es protected: se activa por reflexión.
                // Sin esto, el tablero parpadea y se ve blanco al mover fichas.
                typeof(Panel).InvokeMember("DoubleBuffered",
                    System.Reflection.BindingFlags.SetProperty |
                    System.Reflection.BindingFlags.Instance |
                    System.Reflection.BindingFlags.NonPublic,
                    null, panel, new object[] { true });
            }
            catch { }
        }

        private void pnlTauler_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DibuixarTauler(g);
        }

        private void DibuixarTauler(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Color colorClar;
            Color colorFosc;
            Color linia;
            if (TemaClar)
            {
                colorClar = Color.White;
                colorFosc = Color.FromArgb(200, 210, 225);
                linia = Color.Gray;
            }
            else
            {
                colorClar = Color.White;
                colorFosc = Color.FromArgb(46, 52, 73);
                linia = Color.DimGray;
            }

            for (int fila = 0; fila < FILES; fila++)
            {
                for (int col = 0; col < COLUMNES; col++)
                {
                    bool clar = (fila + col) % 2 == 0;
                    Color colorCasella = clar ? colorClar : colorFosc;

                    using (SolidBrush b = new SolidBrush(colorCasella))
                    {
                        g.FillRectangle(b, col * MIDA_CASELLA, fila * MIDA_CASELLA, MIDA_CASELLA, MIDA_CASELLA);
                    }

                    g.DrawRectangle(new Pen(linia), col * MIDA_CASELLA, fila * MIDA_CASELLA, MIDA_CASELLA, MIDA_CASELLA);
                }
            }
        }

        public void Refrescar()
        {
            pnlTauler.Refresh();
        }

        public Point IndexACoordenades(int index)
        {
            int fila = FILES - 1 - (index / COLUMNES);
            int col = (index % COLUMNES);
            if ((FILES - 1 - fila) % 2 == 1)
                col = COLUMNES - 1 - col;

            return new Point(col, fila);
        }

        public Point CoordenadesAPixels(Point coords)
        {
            return new Point(coords.X * MIDA_CASELLA, coords.Y * MIDA_CASELLA);
        }

        public Point IndexAPixels(int index)
        {
            var coords = IndexACoordenades(index);
            return CoordenadesAPixels(coords);
        }

        public Panel Panel => pnlTauler;
        public int MidaCasella => MIDA_CASELLA;
    }
}
