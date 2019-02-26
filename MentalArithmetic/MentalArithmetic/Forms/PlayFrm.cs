using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MentalArithmetic.Classes;

namespace MentalArithmetic.Forms
{
    public partial class PlayFrm : Form
    {
        Summation sum;
        Subtraction sub;
        Multiplication multi;
        Division div;
        Exponent ex;
        Root root;

        public PlayFrm()
        {
            InitializeComponent();
        }

        public PlayFrm(bool sum, bool sub, bool multi, bool div, bool ex, bool root)
        {

        }
    }
}
