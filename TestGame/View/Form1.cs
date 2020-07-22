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
        private PlayerTypes firstPlayer, secondPlayer;
        public gameForm(settingsForm mainForm, int amount = 25, int maxPerTurn = 3, 
                        PlayerTypes firstPlayer = PlayerTypes.Player, PlayerTypes secondPlayer = PlayerTypes.AI)
        {
            InitializeComponent();
            this.maxPerTurn = maxPerTurn;
            form = mainForm;
            game = new GameEngine(amount, maxPerTurn);
            validator = new Validation();
            this.firstPlayer = firstPlayer;
            this.secondPlayer = secondPlayer;
        }

        private void gameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Show();
            this.Hide();
            this.Dispose();
        }


        private void btn_go_Click(object sender, EventArgs e)
        {
            if (!InputValidation(tbChosenNumberOfSticksByPlayer.Text))
            {
                return;
            }
            int numberOfSticks = Convert.ToInt32(tbChosenNumberOfSticksByPlayer.Text);
            game.Turn(PlayerTypes.Player, numberOfSticks);

            if (game.Winner() == PlayerTypes.Undefined)
            {
                game.Turn(PlayerTypes.AI);
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

        private void gameForm_Load(object sender, EventArgs e)
        {
            if (firstPlayer == PlayerTypes.AI)
            {
                game.Turn(PlayerTypes.AI);
            }
            lblEntireAmount.Text = "x " + Convert.ToString(game.AllSticks);
            lblAIPoints.Text = Convert.ToString(game.AISticks);
            lblPlayerPoints.Text = Convert.ToString(game.PlayerSticks);
        }

        private void btChangeSettings_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
            this.Dispose();
        }

        private bool InputValidation(string input)
        {
            if (!validator.IsDigit(input))
            {
                MessageBox.Show("Plz enter only numbers");
                return false;
            }
            if (!validator.IsBiggerThen(0, Convert.ToInt32(input)))
            {
                MessageBox.Show("Plz enter only integers");
                return false;
            }
            int numberOfSticks = Convert.ToInt32(input);

            if (!validator.IsLessThen(maxPerTurn, numberOfSticks))
            {
                MessageBox.Show("You can't choose this number, you can't choose nubers bigger then permited max nuber sticks by every turn ( " + maxPerTurn.ToString() + " )");
                return false;
            }
            if (!validator.IsLessThen(game.AllSticks, numberOfSticks))
            {
                MessageBox.Show("You can't choose this number, you can't choose nubers bigger then number of remaining sticks ( " + game.AllSticks.ToString() + " )");
                return false;
            }

            return true;
        }
    }
}

