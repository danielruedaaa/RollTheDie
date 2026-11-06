using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace JocAmbDaus.CLASSES
{
    public class ClFitxa
    {
        public Color Color { get; private set; }
        public PictureBox pb { get; private set; }
        public bool ALaMeta { get; set; }

        public ClFitxa(Color color)
        {
            Color = color;
            ALaMeta = false;
        }

        public void CrearVisual(Control parent, int x, int y)
        {
            pb = new PictureBox();
            pb.Width = pb.Height = 20;
            pb.Left = x;
            pb.Top = y;
            pb.BackColor = Color.Transparent;
            pb.BorderStyle = BorderStyle.None;

            AplicarRegioCircular();

            pb.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (Brush br = new SolidBrush(Color))
                    e.Graphics.FillEllipse(br, 0, 0, pb.Width - 1, pb.Height - 1);
                e.Graphics.DrawEllipse(Pens.Black, 0, 0, pb.Width - 1, pb.Height - 1);
            };

            // Si el PictureBox cambia de tamaño, mantener la forma circular
            // para que no aparezca el fondo blanco rectangular.
            pb.Resize += (s, e) => AplicarRegioCircular();

            parent.Controls.Add(pb);
            pb.BringToFront();
        }

        private void AplicarRegioCircular()
        {
            if (pb == null) return;
            try
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(0, 0, pb.Width, pb.Height);
                    if (pb.Region != null) pb.Region.Dispose();
                    pb.Region = new Region(path);
                }
            }
            catch { }
        }


        public void ReparentTo(Panel newParent)
        {
            if (pb == null) return;
            if (pb.Parent == newParent) return;

            Control oldParent = pb.Parent;
            Point screenPos = oldParent.PointToScreen(pb.Location);

            oldParent.Controls.Remove(pb);
            newParent.Controls.Add(pb);

            pb.Location = newParent.PointToClient(screenPos);
            pb.BackColor = Color.Transparent;
            AplicarRegioCircular();
            pb.BringToFront();
        }

        public void MoureA(int indexCasella, ClTauler tauler)
        {
            if (pb == null || tauler == null) return;

            ReparentTo(tauler.Panel);

            Point topLeft = tauler.IndexAPixels(indexCasella);

            int offsetX = (tauler.MidaCasella - pb.Width) / 2;
            int offsetY = (tauler.MidaCasella - pb.Height) / 2;
            Point dest = new Point(topLeft.X + offsetX, topLeft.Y + offsetY);

            Point start = pb.Location;
            AnimateMove(pb, start, dest);
        }

        private void AnimateMove(PictureBox control, Point start, Point dest)
        {
            int passos = 12;
            int step = 0;
            Timer t = new Timer();
            t.Interval = 18;
            t.Tick += (s, e) =>
            {
                step++;
                control.Left = start.X + (dest.X - start.X) * step / passos;
                control.Top = start.Y + (dest.Y - start.Y) * step / passos;

                if (step >= passos)
                {
                    t.Stop();
                    t.Dispose();
                    control.Left = dest.X;
                    control.Top = dest.Y;
                }
            };
            t.Start();
        }

        public void MoureALaMeta()
        {
            if (pb == null) return;
            ALaMeta = true;

            pb.Visible = false;
        }
    }
}
