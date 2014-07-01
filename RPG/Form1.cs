using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RPG.Character;

namespace RPG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var calc = new CharacterCalculator("Human", "Male");
            int age = calc.BeginningAge( "Fighter");
        }
    }
}
