using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matching_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // firstClicked points to the first Label control 
            // that the player clicks, but it will be null 
            // if the player hasn't clicked a label yet
            Label firstClicked = null;

            // secondClicked points to the second Label control 
            // that the player clicks
            Label secondClicked = null;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Use this Random object to choose random icons for the squares
            Random random = new Random();

            // Each of these letters is an interesting icon
            // in the Webdings font,
            // and each icon appears twice in this list
            List<string> icons = new List<string>()
            {
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"

        };

            /// <summary>
            /// Assign each icon from the list of icons to a random square
            /// </summary>
             
            {
                // The TableLayoutPanel has 16 labels,
                // and the icon list has 16 icons,
                // so an icon is pulled at random from the list
                // and added to each label
                foreach (Control control in tableLayoutPanel1.Controls)
                {
                    Label iconLabel = control as Label;
                    if (iconLabel != null)
                    {
                        int randomNumber = random.Next(icons.Count);
                        iconLabel.Text = icons[randomNumber];
                        // iconLabel.ForeColor = iconLabel.BackColor;
                        icons.RemoveAt(randomNumber);
                    }
                }
            }




        }
        
        private void label1_Click(object sender, EventArgs e)

        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)

            { // If the clicked label is black, the player clicked
              // an icon that's already been revealed --
              // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                clickedLabel.ForeColor = Color.Black;
            }





        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

      