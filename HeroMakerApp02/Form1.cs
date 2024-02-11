using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//------------------ C# avatar maker app 01 How to use checkboxes tutorial -----------------------------
//ref link:https://www.youtube.com/watch?v=UgbzxnlckxY&list=PLhPyEFL5u-i2w2fa7ErcbkbEkjqLh7Io1&index=15

// label(Hero's Name), textbox(MessageBox), groupbox, checkbox x8(abilities[0-7], button(btn_create), status_message

//----------------- C# avatar maker app 02 How to use a listbox tutorial -------------------------------
//ref link:https://www.youtube.com/watch?v=ihBNF1j5qNU&list=PLhPyEFL5u-i2w2fa7ErcbkbEkjqLh7Io1&index=14

// listbox(Item Collection)(SelectionMode:MultiSimple), label(Office Locations)

namespace HeroMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //------START---------- C# avatar maker app 01 How to use checkboxes tutorial -----------------------------

        private void btn_create_Click(object sender, EventArgs e)
        {
            bool[] abilities = {false, false, false, false, false, false, false, false };

            abilities[0] = chk_fly.Checked;
            abilities[1] = chk_xray.Checked;
            abilities[2] = chk_invisible.Checked;
            abilities[3] = chk_energy.Checked;
            abilities[4] = chk_luck.Checked;
            abilities[5] = chk_fart.Checked;
            abilities[6] = chk_water_breath.Checked;
            abilities[7] = chk_timecontrol.Checked;

            //----START--------- C# avatar maker app 02 How to use a listbox tutorial -------------------------------
            // listbox
            // cities
            // array or list?
            List<String> cities = new List<String>();

            // add the selected items to cities
            foreach(String s in lst_cities.SelectedItems)
            {
                cities.Add(s);
            }

            //-----END---------- C# avatar maker app 02 How to use a listbox tutorial -------------------------------


            string status_message = "Your new hero is " + txt_name.Text + 
                " You have selected the following abilities: ";

            if (abilities[0])
                status_message += "Fly, ";
            if (abilities[1])
                status_message += "xRay Vision, ";
            if (abilities[2])
                status_message += "Invisibility, ";
            if (abilities[3])
                status_message += "Absorb Energy, ";
            if (abilities[4])
                status_message += "Extreme Luck, ";
            if (abilities[5])
                status_message += "Explosive Farts, ";
            if (abilities[6])
                status_message += "Water Breathing, ";
            if (abilities[7])
                status_message += "Time Control, ";

            //----START--------- C# avatar maker app 02 How to use a listbox tutorial -------------------------------
            //listbox
            status_message += "The hero works in these cities: "; 
            foreach(String city in cities)
            {
                status_message += city + ", ";
            }
            //-----END---------- C# avatar maker app 02 How to use a listbox tutorial -------------------------------

            MessageBox.Show(status_message);

            //------END---------- C# avatar maker app 01 How to use checkboxes tutorial -----------------------------

        }
    }
}
