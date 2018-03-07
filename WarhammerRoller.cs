using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warhammer40KRoller
{
    public partial class WarhammerRoller : Form
    {
        public WarhammerRoller()
        {
            InitializeComponent();
            lblResult.Text = "";
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            if (txtIRLRoll.Text.Equals("In real life roll"))
            {
                Random r = new Random();
                int res = r.Next(1, 101);
                decimal n;
                lblRolled.Text = "D100 rolled result: " + res.ToString();

                if (txtDifficulty.Text.Equals("Difficulty"))
                {
                }
                else
                {
                    if (decimal.TryParse(txtDifficulty.Text, out n))
                    {
                        decimal diff = Convert.ToDecimal(txtDifficulty.Text);
                        lblResult.Text = RollCalculator(diff, res);
                    }
                    else
                    {
                        lblResult.Text = "Difficulty is not a number";
                    }
                    
                }
            }
        }

        private void WarhammerRoller_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblRolled;
            txtIRLRoll.GotFocus += new EventHandler(this.IRLRollGotFocus);
            txtIRLRoll.LostFocus += new EventHandler(this.IRLRollLostFocus);
            txtDifficulty.GotFocus += new EventHandler(this.DifGotFocus);
            txtDifficulty.LostFocus += new EventHandler(this.DifLostFocus);
            txtDifficulty.LostFocus += new EventHandler(this.BothOnFocus);
            txtIRLRoll.LostFocus += new EventHandler(this.BothOnFocus);
        }

        private string RollCalculator(decimal _diff, decimal _roll)
        {
            string result = "";
            decimal diffRes = (_diff - _roll) / 10;
            if (_roll <= _diff)
            {
                if (Math.Ceiling(diffRes) == 0)
                {
                    result = "Succeeds: 1";
                }
                else
                {
                    result = "Succeeds: " + Math.Ceiling(diffRes).ToString();
                }
            }
            else
            {
                if (Math.Floor(diffRes) == 0)
                {
                    result = "Fails: 1";
                }
                result = "Fails: " + Math.Floor(diffRes).ToString();
            }
            return result;
        }

        private void IRLRollGotFocus(object sender, EventArgs e)
        {
            GotFocusTextChecker(sender, "In real life roll");
        }
        private void IRLRollLostFocus(object sender, EventArgs e)
        {
            LostFocusTextChecker(sender, "In real life roll");
        }

        private void DifGotFocus(object sender, EventArgs e)
        {
            GotFocusTextChecker(sender, "Difficulty");
        }
        private void DifLostFocus(object sender, EventArgs e)
        {
            LostFocusTextChecker(sender, "Difficulty");
        }

        private void BothOnFocus(object sender, EventArgs e)
        {
            decimal n;
            if (!txtIRLRoll.Text.Equals("In real life roll"))
            {
                if (!txtDifficulty.Text.Equals("Difficulty"))
                {
                    if (decimal.TryParse(txtIRLRoll.Text, out n))
                    {
                        if (decimal.TryParse(txtDifficulty.Text, out n))
                        {
                            lblResult.Text = RollCalculator(Convert.ToDecimal(txtDifficulty.Text), Convert.ToDecimal(txtIRLRoll.Text));
                        }
                        else
                        {
                            lblResult.Text = "Difficulty is not a number";
                        }
                    }
                    else
                    {
                        lblResult.Text = "Real life roll is not a number.";
                    }
                }
                else
                {
                    lblResult.Text = "";
                }
            }
            else
            {
                lblResult.Text = "";
            }
        }

        private void GotFocusTextChecker(object sender, string _t)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Equals(_t))
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;
            }
        }
        private void LostFocusTextChecker(object sender, string _t)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Equals(""))
            {
                txt.Text = _t;
                txt.ForeColor = Color.DarkGray;
            }
        }
    }
}
