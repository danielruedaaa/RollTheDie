using System.Collections.Generic;
using System.Drawing;

namespace JocAmbDaus.CLASSES
{
    public class ClJugador
    {
        public string nick { get; private set; }
        public Color color { get; private set; }
        public List<ClFitxa> Fitxes { get; private set; } = new List<ClFitxa>();

        public int id = 0;

        public ClJugador(string nom, Color color, int xid)
        {
            this.nick = nom;
            this.color = color;
            this.id = xid;

            // Crear 4 fichas lógicas
            for (int i = 0; i < 4; i++)
                Fitxes.Add(new ClFitxa(color));
        }
        public int FitxesRestants()
        {
            int count = 0;
            foreach (var f in Fitxes)
                if (f.pb != null && f.pb.Visible && !f.ALaMeta) count++;
            return count;
        }

    }
}
