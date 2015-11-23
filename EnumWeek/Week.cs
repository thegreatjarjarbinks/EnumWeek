/*
 * Created by: Alex Mathias
 * Created on: 23-Nov-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 6-01
 * This program displays an Enum containing the days of the week.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumWeek
{
    public partial class frmWeek : Form
    {
        //Global Variables
        enum WEEK
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        
        
        public frmWeek()
        {
            InitializeComponent();
        }

        private void frmWeek_Load(object sender, EventArgs e)
        {
            //Load the enum into the listbox
            foreach (WEEK singleDay in Enum.GetValues(typeof(WEEK)))
            {
                this.lstDays.Items.Add(singleDay);
            }
        }

        private void lstDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Saying what item the user selected
            string selectValue;

            selectValue = Convert.ToString(lstDays.SelectedItem);

            MessageBox.Show("Your favourite day of the week is " + selectValue, "Enum Week");
        }
    }
}
