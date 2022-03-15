using DragonDBExample.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonDBExample.Views
{
    public partial class ShowDragonsView : Form
    {
        ShowDragonsController showDragonsController = new ShowDragonsController();

        public ShowDragonsView()
        {
            InitializeComponent();
        }

        private void ShowDragonsView_Load(object sender, EventArgs e)
        {
            dgvDragons.DataSource = showDragonsController.GetAllDragons();
        }

        private void btnDragonsMoreThan20Kills_Click(object sender, EventArgs e)
        {
            dgvDragons.DataSource = showDragonsController.ShowAllDragonsWithMoreKills();
        }
    }
}
