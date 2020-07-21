using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGame
{
    public partial class settingsForm : Form
    {
        private Validation validator;
        private bool customMode;
        private gameForm form;
        public settingsForm()
        {
            InitializeComponent();
            validator = new Validation();
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            if (!validator.IsDigit(tbAmount.Text))
            {
                MessageBox.Show("Plz enter only numbers");
                return;
            }
            if (!validator.IsDigit(tbMaxPerTurn.Text))
            {
                MessageBox.Show("Plz enter only numbers");
                return;
            }
            if (!validator.BiggerThen(0, Convert.ToInt32(tbAmount.Text)))
            {
                MessageBox.Show("Plz enter only integers");
                return;
            }
            if (!validator.BiggerThen(0, Convert.ToInt32(tbMaxPerTurn.Text)))
            {
                MessageBox.Show("Plz enter only integers");
                return;
            }
            if (!validator.IsPermitedAmount(Convert.ToInt32(tbAmount.Text)))
            {
                MessageBox.Show("Plz enter only odd numbers");
                return;
            }

            int amount = Convert.ToInt32(tbAmount.Text);
            int max_per_turn = Convert.ToInt32(tbMaxPerTurn.Text);

            if (customMode)
            {
                if (cbFirstTurnAI.Checked)
                {
                    form = new gameForm(this, amount, max_per_turn, PlayerTypes.AI, PlayerTypes.Player);
                }

                else
                {
                    form = new gameForm(this, amount, max_per_turn);
                }
            }
            else
            {
               form = new gameForm(this);
            }

            form.Show();
            this.Hide();
            GC.Collect();
        }

        private void settingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void rbDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDefault.Checked)
            {
                tbAmount.Visible = false;
                tbMaxPerTurn.Visible = false;
                lblAmount.Visible = false;
                lblMaxPerTurn.Visible = false;
                customMode = false;
                cbFirstTurnAI.Visible = false;
            }
            else if (rbCustom.Checked)
            {
                tbAmount.Visible = true;
                tbMaxPerTurn.Visible = true;
                lblAmount.Visible = true;
                lblMaxPerTurn.Visible = true;
                customMode = true;
                cbFirstTurnAI.Visible = true;
            }
        }
    }
    
}
