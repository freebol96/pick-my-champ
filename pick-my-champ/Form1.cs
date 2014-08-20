using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PickMyChamp.Model;

namespace PickMyChamp
{
    public partial class Form1 : Form
    {
        private List<Champion> myChampions;
        private Random rnd = new Random();

        public Form1 ()
        {
            InitializeComponent();
            CreatePlayStyleCheckBoxes();
            FillChampionList(); // work some magic here ;)
        }

        internal void SelectChampion (object sender, EventArgs e)
        {
            IEnumerable<PlayStyle> styles = FetchSelectedPlayStyles();
            IEnumerable<Champion> validForChoice = myChampions.Where
                (champ => 
                    { foreach (PlayStyle style in styles) 
                        { 
                            if (champ.Roles.Contains(style))
                            {
                                return true;
                            }
                        }
                    return false;
                    });

            Champion randomChoice =
                   validForChoice.ElementAt(rnd.Next(0, validForChoice.Count()));

            result.Text = randomChoice.Name;
        }

        private IEnumerable<PlayStyle> FetchSelectedPlayStyles ()
        {
            return new List<PlayStyle>() { PlayStyle.SUPPORT };
        }

        private void CreatePlayStyleCheckBoxes ()
        {
            //throw new NotImplementedException();
        }

        private void FillChampionList ()
        {
            myChampions = new List<Champion>();
            myChampions.Add(new Champion("Swain", new List<PlayStyle>(){PlayStyle.SUPPORT, PlayStyle.MAGE}));
        }

    }
}
