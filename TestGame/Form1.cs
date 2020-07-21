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

    public partial class gameForm : Form
    {
        private settingsForm form;
        private int maxPerTurn;
        private GameEngine game;
        private Validation validator;
        private AI ai;
        public gameForm(settingsForm mainForm, int amount = 25, int maxPerTurn=3)
        {
            InitializeComponent();
            this.maxPerTurn = maxPerTurn;
            form = mainForm;
            game = new GameEngine(amount);
            lblEntireAmount.Text = "x " + Convert.ToString(game.AllSticks);
            lblAIPoints.Text = Convert.ToString(game.AISticks);
            lblPlayerPoints.Text = Convert.ToString(game.PlayerSticks);
            validator = new Validation();
            ai = new AI(maxPerTurn);
        }

        private void gameForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            form.Show();
            this.Hide();
            this.Dispose();
        }

     
        private void btn_go_Click(object sender, EventArgs e)
        {
           
            if (!validator.IsDigit(tbChosenNumberOfSticksByPlayer.Text))
            {
                MessageBox.Show("Plz enter only numbers");
                return;
            }
            if (!validator.BiggerThen(0,Convert.ToInt32(tbChosenNumberOfSticksByPlayer.Text)))
            {
                MessageBox.Show("Plz enter only integers");
                return;
            }
            int numberOfSticks = Convert.ToInt32(tbChosenNumberOfSticksByPlayer.Text);
            
            if (!validator.LessThen(maxPerTurn, numberOfSticks))
            { 
                MessageBox.Show("You can't choose this number, you can't choose nubers bigger then permited max nuber sticks by every turn ( " + maxPerTurn.ToString() + " )");
                return;
            }
            if (!validator.LessThen(game.AllSticks, numberOfSticks))
            {
                MessageBox.Show("You can't choose this number, you can't choose nubers bigger then number of remaining sticks ( " + game.AllSticks.ToString() + " )");
                return;
            }
            game.Turn(PlayerTypes.Player, numberOfSticks);
           
            if (game.Winner() == PlayerTypes.Undefined)
            {
                game.Turn(PlayerTypes.AI, ai.AITurn(game.AllSticks));
            }
           
            if (game.Winner() == PlayerTypes.AI)
            {
                lblWinner.Text = "Congratulations, you lose";
                pbAIWin.Visible = true;
                btnTurn.Enabled = false;
            }
            else if (game.Winner() == PlayerTypes.Player)
            {
                lblWinner.Text = "Congratulations, you win";
                btnTurn.Enabled = false;
                pbAILose.Visible = true;
            }
            
            lblEntireAmount.Text = "x " + Convert.ToString(game.AllSticks);
            lblAIPoints.Text = Convert.ToString(game.AISticks);
            lblPlayerPoints.Text = Convert.ToString(game.PlayerSticks);
        }

       
    }
}

