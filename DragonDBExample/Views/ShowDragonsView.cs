using DragonDBExample.Controllers;
using DragonDBExample.Models;
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

        private void RefreshTable()
        {
            dgvDragons.DataSource = showDragonsController.GetAllDragons();
        }

        private void ShowDragonsView_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void btnDragonsMoreThan20Kills_Click(object sender, EventArgs e)
        {
            dgvDragons.DataSource = showDragonsController.ShowAllDragonsWithMoreKills();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Dragon dragon = new Dragon();
            dragon.Name = txtName.Text;
            dragon.Kills = int.Parse(txtKills.Text);
            showDragonsController.CreateDragon(dragon);
            RefreshTable();
        }
    }
}
