using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MentalArithmetic
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            sumFractionCmBx.SelectedIndex = 0;
            subFractionCmBx.SelectedIndex = 0;
            multiFractionCmBx.SelectedIndex = 0;
            divFractionCmBx.SelectedIndex = 0;
            exFractionCmBx.SelectedIndex = 0;
            rootFractionCmBx.SelectedIndex = 0;
        }
    }
}
