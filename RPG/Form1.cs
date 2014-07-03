using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RPG.Character;
using RPG.General;

namespace RPG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            var c = new CharacterFactory().CreateInstance(RaceEnum.Human, Character.Class.ClassEnum.Fighter, AlignmentEnum.Neutral, GenderEnum.Male);            
            textBox1.Text = c.Age.ToString();
            textBox2.Text = c.Height.ToString();
            textBox3.Text = c.Weight.ToString();
            strBox.Text = c.Strength.ToString();
            dexBox.Text = c.Dexterity.ToString();
            conBox.Text = c.Constitution.ToString();
            intBox.Text = c.Intelligence.ToString();
            wisBox.Text = c.Wisdom.ToString();
            chaBox.Text = c.Charisma.ToString();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            Initialize();
        }
    }
}
