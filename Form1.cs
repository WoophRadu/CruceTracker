using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CruceTracker
{
    public partial class Form1 : Form
    {
        string tromf = "";
        public Form1()
        {
            InitializeComponent();
        }

        void updateMajore(string culoare)
        {
            if (culoare == "duba")
            {
                if (pictureBoxda.Image == null)
                {
                    labelDubaMajoraVal.Text = "As (11)";
                }
                else if (pictureBoxd10.Image == null)
                {
                    labelDubaMajoraVal.Text = "X (10)";
                }
                else if (pictureBoxd4.Image == null)
                {
                    labelDubaMajoraVal.Text = "IV (4)";
                }
                else if (pictureBoxd3.Image == null)
                {
                    labelDubaMajoraVal.Text = "III (3)";
                }
                else if (pictureBoxd2.Image == null)
                {
                    labelDubaMajoraVal.Text = "II (2)";
                }
                else
                {
                    labelDubaMajoraVal.Text = "IX (0)";
                }
            }
            else if (culoare == "ghinda")
            {
                if (pictureBoxga.Image == null)
                {
                    labelGhindaMajoraVal.Text = "As (11)";
                }
                else if (pictureBoxg10.Image == null)
                {
                    labelGhindaMajoraVal.Text = "X (10)";
                }
                else if (pictureBoxg4.Image == null)
                {
                    labelGhindaMajoraVal.Text = "IV (4)";
                }
                else if (pictureBoxg3.Image == null)
                {
                    labelGhindaMajoraVal.Text = "III (3)";
                }
                else if (pictureBoxg2.Image == null)
                {
                    labelGhindaMajoraVal.Text = "II (2)";
                }
                else
                {
                    labelGhindaMajoraVal.Text = "IX (0)";
                }
            }
            else if (culoare == "rosu")
            {
                if (pictureBoxra.Image == null)
                {
                    labelRosuMajorVal.Text = "As (11)";
                }
                else if (pictureBoxr10.Image == null)
                {
                    labelRosuMajorVal.Text = "X (10)";
                }
                else if (pictureBoxr4.Image == null)
                {
                    labelRosuMajorVal.Text = "IV (4)";
                }
                else if (pictureBoxr3.Image == null)
                {
                    labelRosuMajorVal.Text = "III (3)";
                }
                else if (pictureBoxr2.Image == null)
                {
                    labelRosuMajorVal.Text = "II (2)";
                }
                else
                {
                    labelRosuMajorVal.Text = "IX (0)";
                }
            }
            else
            {
                if (pictureBoxva.Image == null)
                {
                    labelVerdeMajorVal.Text = "As (11)";
                }
                else if (pictureBoxv10.Image == null)
                {
                    labelVerdeMajorVal.Text = "X (10)";
                }
                else if (pictureBoxv4.Image == null)
                {
                    labelVerdeMajorVal.Text = "IV (4)";
                }
                else if (pictureBoxv3.Image == null)
                {
                    labelVerdeMajorVal.Text = "III (3)";
                }
                else if (pictureBoxv2.Image == null)
                {
                    labelVerdeMajorVal.Text = "II (2)";
                }
                else
                {
                    labelVerdeMajorVal.Text = "IX (0)";
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void pictureBoxGhinda_Click(object sender, EventArgs e)
        {
            pictureBoxDuba.Hide();
            pictureBoxRosu.Hide();
            pictureBoxVerde.Hide();
            tromf = "ghinda";
        }

        private void pictureBoxDuba_Click(object sender, EventArgs e)
        {
            pictureBoxGhinda.Hide();
            pictureBoxRosu.Hide();
            pictureBoxVerde.Hide();
            tromf = "duba";
        }

        private void pictureBoxRosu_Click(object sender, EventArgs e)
        {
            pictureBoxGhinda.Hide();
            pictureBoxDuba.Hide();
            pictureBoxVerde.Hide();
            tromf = "rosu";
        }

        private void pictureBoxVerde_Click(object sender, EventArgs e)
        {
            pictureBoxGhinda.Hide();
            pictureBoxDuba.Hide();
            pictureBoxRosu.Hide();
            tromf = "verde";
        }

        private void pictureBoxda_Click(object sender, EventArgs e)
        {
            if (pictureBoxda.Image != null)
            {
                pictureBoxda.Image = null;
                if(tromf == "duba")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxda.Image = Properties.Resources.x;
                if (tromf == "duba")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("duba");
        }

        private void pictureBoxga_Click(object sender, EventArgs e)
        {
            if (pictureBoxga.Image != null)
            {
                pictureBoxga.Image = null;
                if (tromf == "ghinda")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxga.Image = Properties.Resources.x;
                if (tromf == "ghinda")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("ghinda");
        }

        private void pictureBoxra_Click(object sender, EventArgs e)
        {
            if (pictureBoxra.Image != null)
            {
                pictureBoxra.Image = null;
                if (tromf == "rosu")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxra.Image = Properties.Resources.x;
                if (tromf == "rosu")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("rosu");
        }

        private void pictureBoxva_Click(object sender, EventArgs e)
        {
            if (pictureBoxva.Image != null)
            {
                pictureBoxva.Image = null;
                if (tromf == "verde")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxva.Image = Properties.Resources.x;
                if (tromf == "verde")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("verde");
        }

        private void pictureBoxd10_Click(object sender, EventArgs e)
        {
            if (pictureBoxd10.Image != null)
            {
                pictureBoxd10.Image = null;
                if (tromf == "duba")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxd10.Image = Properties.Resources.x;
                if (tromf == "duba")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("duba");
        }

        private void pictureBoxg10_Click(object sender, EventArgs e)
        {
            if (pictureBoxg10.Image != null)
            {
                pictureBoxg10.Image = null;
                if (tromf == "ghinda")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxg10.Image = Properties.Resources.x;
                if (tromf == "ghinda")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("ghinda");
        }

        private void pictureBoxr10_Click(object sender, EventArgs e)
        {
            if (pictureBoxr10.Image != null)
            {
                pictureBoxr10.Image = null;
                if (tromf == "rosu")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxr10.Image = Properties.Resources.x;
                if (tromf == "rosu")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("rosu");
        }

        private void pictureBoxv10_Click(object sender, EventArgs e)
        {
            if (pictureBoxv10.Image != null)
            {
                pictureBoxv10.Image = null;
                if (tromf == "verde")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxv10.Image = Properties.Resources.x;
                if (tromf == "verde")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("verde");
        }

        private void pictureBoxd4_Click(object sender, EventArgs e)
        {
            if (pictureBoxd4.Image != null)
            {
                pictureBoxd4.Image = null;
                if (tromf == "duba")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxd4.Image = Properties.Resources.x;
                if (tromf == "duba")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("duba");
        }

        private void pictureBoxg4_Click(object sender, EventArgs e)
        {
            if (pictureBoxg4.Image != null)
            {
                pictureBoxg4.Image = null;
                if (tromf == "ghinda")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxg4.Image = Properties.Resources.x;
                if (tromf == "ghinda")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("ghinda");
        }

        private void pictureBoxr4_Click(object sender, EventArgs e)
        {
            if (pictureBoxr4.Image != null)
            {
                pictureBoxr4.Image = null;
                if (tromf == "rosu")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxr4.Image = Properties.Resources.x;
                if (tromf == "rosu")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("rosu");
        }

        private void pictureBoxv4_Click(object sender, EventArgs e)
        {
            if (pictureBoxv4.Image != null)
            {
                pictureBoxv4.Image = null;
                if (tromf == "verde")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxv4.Image = Properties.Resources.x;
                if (tromf == "verde")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("verde");
        }

        private void pictureBoxd3_Click(object sender, EventArgs e)
        {
            if (pictureBoxd3.Image != null)
            {
                pictureBoxd3.Image = null;
                if (tromf == "duba")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxd3.Image = Properties.Resources.x;
                if (tromf == "duba")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("duba");
        }

        private void pictureBoxg3_Click(object sender, EventArgs e)
        {
            if (pictureBoxg3.Image != null)
            {
                pictureBoxg3.Image = null;
                if (tromf == "ghinda")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxg3.Image = Properties.Resources.x;
                if (tromf == "ghinda")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("ghinda");
        }

        private void pictureBoxr3_Click(object sender, EventArgs e)
        {
            if (pictureBoxr3.Image != null)
            {
                pictureBoxr3.Image = null;
                if (tromf == "rosu")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxr3.Image = Properties.Resources.x;
                if (tromf == "rosu")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("rosu");
        }

        private void pictureBoxv3_Click(object sender, EventArgs e)
        {
            if (pictureBoxv3.Image != null)
            {
                pictureBoxv3.Image = null;
                if (tromf == "verde")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxv3.Image = Properties.Resources.x;
                if (tromf == "verde")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("verde");
        }

        private void pictureBoxd2_Click(object sender, EventArgs e)
        {
            if (pictureBoxd2.Image != null)
            {
                pictureBoxd2.Image = null;
                if (tromf == "duba")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxd2.Image = Properties.Resources.x;
                if (tromf == "duba")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("duba");
        }

        private void pictureBoxg2_Click(object sender, EventArgs e)
        {
            if (pictureBoxg2.Image != null)
            {
                pictureBoxg2.Image = null;
                if (tromf == "ghinda")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxg2.Image = Properties.Resources.x;
                if (tromf == "ghinda")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("ghinda");
        }

        private void pictureBoxr2_Click(object sender, EventArgs e)
        {
            if (pictureBoxr2.Image != null)
            {
                pictureBoxr2.Image = null;
                if (tromf == "rosu")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxr2.Image = Properties.Resources.x;
                if (tromf == "rosu")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("rosu");
        }

        private void pictureBoxv2_Click(object sender, EventArgs e)
        {
            if (pictureBoxv2.Image != null)
            {
                pictureBoxv2.Image = null;
                if (tromf == "verde")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxv2.Image = Properties.Resources.x;
                if (tromf == "verde")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("verde");
        }

        private void pictureBoxd9_Click(object sender, EventArgs e)
        {
            if (pictureBoxd9.Image != null)
            {
                pictureBoxd9.Image = null;
                if (tromf == "duba")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxd9.Image = Properties.Resources.x;
                if (tromf == "duba")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("duba");
        }

        private void pictureBoxg9_Click(object sender, EventArgs e)
        {
            if (pictureBoxg9.Image != null)
            {
                pictureBoxg9.Image = null;
                if (tromf == "ghinda")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxg9.Image = Properties.Resources.x;
                if (tromf == "ghinda")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("ghinda");
        }

        private void pictureBoxr9_Click(object sender, EventArgs e)
        {
            if (pictureBoxr9.Image != null)
            {
                pictureBoxr9.Image = null;
                if (tromf == "rosu")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxr9.Image = Properties.Resources.x;
                if (tromf == "rosu")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("rosu");
        }

        private void pictureBoxv9_Click(object sender, EventArgs e)
        {
            if (pictureBoxv9.Image != null)
            {
                pictureBoxv9.Image = null;
                if (tromf == "verde")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) + 1).ToString();
                }
            }
            else
            {
                pictureBoxv9.Image = Properties.Resources.x;
                if (tromf == "verde")
                {
                    labelNrTromfi.Text = (Int32.Parse(labelNrTromfi.Text) - 1).ToString();
                }
            }
            updateMajore("verde");
        }
    }
}
