using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Goose_Customizer
{
    public partial class ManageSlots : Form
    {
        public int SlotIndex = 0; // Selected items index

        public ManageSlots(int indx = 0)
            // This is called whenever a new dialog box has been created,
            // indx is old selected slot index.
        {
            InitializeComponent(); // Form stuff i dont know
            SlotIndex = indx; // Sets the slot index to old slot index
        }
        void SetItems() // Will clear and write items to slot list
        {
            SlotIndex = SlotList.SelectedIndex; // Sets the slot index so it doesnt reset to first one
            SlotList.Items.Clear(); // Clears list items
            for (int i = 0; i < Properties.Settings.Default.SaveSlots.Count; i++)
                // Repeat for save slot's count
            {
                SlotList.Items.Add(Properties.Settings.Default.SaveSlotNames[i]);
                // Set the item
            }
            SlotList.SelectedIndex = SlotIndex; // Set selected item 
            slotCount.Text = SlotList.Items.Count + " Slots"; // Set the text between "+" and "-"
        }
        private void ManageSlots_Load(object sender, EventArgs e)
            // When program first loads
        {
            ok.DialogResult = DialogResult.OK;
            cancel.DialogResult = DialogResult.Cancel;
            // Set the dialog results
            this.SetItems(); // Set Items
            SlotList.SelectedIndex = 0; // Set the selected index to zero to prevent bugs
        }

        private void SlotList_SelectedIndexChanged(object sender, EventArgs e)
            // When user choose another item from list
        {
            //SlotName.Enabled = true;
            try
            {
                configText.Text = string.Join("\n", Properties.Settings.Default.SaveSlots[SlotList.SelectedIndex].Split('\\'));
                //SlotName.Text = Properties.Settings.Default.SaveSlotNames[SlotList.SelectedIndex];
                slotMinus.Enabled = (SlotList.SelectedIndex != 0);
                SlotIndex = SlotList.SelectedIndex;
                // Try to get slot text, if error warn user
            }
            catch (Exception)
            {
                configText.Text = "ERR_SLOT_NOTFOUND";
                //SlotName.Text = "ERR_NAME_NOTFOUND";
                //SlotName.Enabled = false;
            }
        }

        private void ok_Click(object sender, EventArgs e)
            // When user choose a item and press ok
        {
            SlotIndex = SlotList.SelectedIndex; // Return the slot index to goose-customizer.cs
            Properties.Settings.Default.Save();
        }

        private void SlotName_TextChanged(object sender, EventArgs e)
        {
            // i hate this
        }

        private void slotPlus_Click(object sender, EventArgs e)
            // When user presses "+"
        {
            Properties.Settings.Default.SaveSlotNames.Add("Slot " + SlotList.Items.Count); // Adds name of item
            Properties.Settings.Default.SaveSlots.Add(@"Version_DoNotEdit=1\EnableMods=False\SilenceSounds=False\Task_CanAttackMouse=True\AttackRandomly=False\UseCustomColors=False\GooseDefaultWhite=#ffffff\GooseDefaultOrange=#ffa500\GooseDefaultOutline=#d3d3d3\MinWanderingTimeSeconds=40\MaxWanderingTimeSeconds=20\FirstWanderTimeSeconds=40");
            // Adds context of item
            this.SetItems(); // Set items again
        }

        private void slotMinus_Click(object sender, EventArgs e)
            // When user presses "-"
        {
            Properties.Settings.Default.SaveSlotNames.RemoveAt(SlotList.SelectedIndex);
            Properties.Settings.Default.SaveSlots.RemoveAt(SlotList.SelectedIndex);
            // Removes the item at Selected Index
            SlotList.SelectedIndex = 0;
            SlotIndex = 0;
            // Sets selected indexes to zero, to prevent bugs
            this.SetItems(); // Set items again
        }
    }
}
