using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;
namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player player1;

        public SuperAdventure()
        {
            InitializeComponent();

            Location location = new Location(1, "Home", "This is your house.");

            player1 = new Player(10, 10, 20, 0, 1);

            lblHitPoints.Text = player1.CurrentHitPoints.ToString();
            lblGold.Text = player1.Gold.ToString();
            lblExperience.Text = player1.ExperiencePoints.ToString();
            lblLevel.Text = player1.Level.ToString();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {

        }

        private void btnNorth_Click(object sender, EventArgs e)
        {

        }

        private void btnEast_Click(object sender, EventArgs e)
        {

        }

        private void btnSouth_Click(object sender, EventArgs e)
        {

        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {

        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {

        }
    }
}
