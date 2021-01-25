using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Desktop_Goose_Customizer
{

    // DESKTOP GOOSE by SamPerson
    // DESKTOP GOOSE CUSTOMIZER by lim10dev
    // Licensed under MIT license.

    public partial class dgc : Form
    {
        public string[] config; // The config.ini file's index, seperated by new lines (\n).
        public string GooseWhiteHex = "#ffffff"; // Represents Goose's body color, in hex.
        public string GooseOrangeHex = "#ffa500"; // Represents Goose's beak color, in hex.
        public string GooseOutlineHex = "#d3d3d3"; // Represents Goose's outline color, in hex.
        public string ConfigFilePath; // Path of Goose's config file.
        public int SlotIndex = 0; // Currently selected save slot.

        public dgc()
        {
            InitializeComponent();
        } // Visual Studio's code, idk.

        private void dgc_Load(object sender, EventArgs e)
            // First time program starts, or when you load a slot.
        {
            try
            {
                if (sender.ToString().StartsWith("Version"))
                    // If a save slot is loaded:
                {
                    config = sender.ToString().Split('\n'); // Sets all values to array ( like EnableMods=False, SilenceSounds=True...)
                    if (string.IsNullOrWhiteSpace(config[config.Length - 1]))
                        // If the last item of the array is empty:
                    {
                        SetDatas(config.Reverse<string>().Skip<string>(1).Reverse<string>().ToArray<string>());
                        // Delete the last item of array, so it won't cause errors and send the array to set settings.
                    }
                    else
                    {
                        SetDatas(config); // Send the array to set settings.
                    }
                    return; // End this function rn.
                } else
                {
                    ConfigFilePath = Environment.GetCommandLineArgs()[1];
                    // GetCommandLineArgs()[1] is the file location if this program has opened with
                    // a file attached, if no file is attached it will give error and will do the catch.
                    StreamReader sr = new StreamReader(ConfigFilePath); // Read the attached file.
                    config = sr.ReadToEnd().Split('\n'); // Sets all values to array ( like EnableMods=False, SilenceSounds=True...)
                    if (string.IsNullOrWhiteSpace(config[config.Length - 1]))
                    // If the last item of the array is empty:
                    {
                        SetDatas(config.Reverse<string>().Skip<string>(1).Reverse<string>().ToArray<string>());
                        // Delete the last item of array, so it won't cause errors and send the array to set settings.
                    }
                    else
                    {
                        SetDatas(config); // Send the array to set settings.
                    }
                    return; // End this function rn.
                }
            }
            catch (Exception)
            // If program has launched by clicking app and no attached files.
            {
                saveSet.Enabled = false;
                // Since the selected save slot will be the default one and you shouldn't be able to change it, we should disable it.
                if (openFile.ShowDialog() == DialogResult.OK)
                    // If you chose a directory:
                {
                    try
                        // Try to read file's index
                    {
                        StreamReader sr = new StreamReader(openFile.OpenFile());
                        ConfigFilePath = Path.GetFullPath(openFile.FileName);
                        config = sr.ReadToEnd().Split('\n');
                        // Gets file's path and reads it.
                        if (string.IsNullOrWhiteSpace(config[config.Length - 1]))
                        // If the last item of the array is empty:
                        {
                            SetDatas(config.Reverse<string>().Skip<string>(1).Reverse<string>().ToArray<string>());
                            // Delete the last item of array, so it won't cause errors and send the array to set settings.
                        }
                        else
                        {
                            SetDatas(config); // Send the array to set settings.
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to read config.ini file.\nPlease make sure you chose the correct file and try again.\nContact me: github.com/lim10dev");
                        dgc_Load("", EventArgs.Empty);
                        // Warns the user saying file is wrong, and shows the dialog again.
                    }
                }
                else
                // If user said N O to dialog:
                {
                    this.Close(); // Close the program
                }
            }
            
        }
        public void SetDatas(string[] datas)
            // Void to set settings.
            // string[] datas: config (that one splitted  with \n's)
        {
            string Data_Name; // The name of value (EnableMods)
            string Data_Value; // The value, of value (True)
            for (int i = 0; i < datas.Length; i++)
                // Repeats for every value
            {
                Data_Name = datas[i].Split('=')[0];
                // Current data name
                Data_Value = datas[i].Split('=')[1];
                // Current data value
                MaxWanderingTimeSeconds.Maximum = decimal.MaxValue;
                MinWanderingTimeSeconds.Maximum = decimal.MaxValue;
                FirstWanderTimeSeconds.Maximum = decimal.MaxValue;
                MaxWanderingTimeSeconds.Minimum = 0;
                MinWanderingTimeSeconds.Minimum = 0;
                FirstWanderTimeSeconds.Minimum = 0;
                // This is to prevent bug, cant actually explain but sets the max value of
                // Wandering Times to a big number and minimum to 0.
                switch (Data_Name)
                {
                    case "Version_DoNotEdit":
                        Version_DoNotEdit.Text = "Version: " + Data_Value;
                        break;
                    case "EnableMods":
                        EnableMods.Checked = Convert.ToBoolean(Data_Value);
                        break;
                    case "SilenceSounds":
                        SilenceSounds.Checked = Convert.ToBoolean(Data_Value);
                        break;
                    case "Task_CanAttackMouse":
                        Task_CanAttackMouse.Checked = Convert.ToBoolean(Data_Value);
                        break;
                    case "AttackRandomly":
                        AttackRandomly.Checked = Convert.ToBoolean(Data_Value);
                        break;
                    case "UseCustomColors":
                        UseCustomColors.Checked = Convert.ToBoolean(Data_Value);
                        break;
                    case "GooseDefaultWhite":
                        GooseWhiteHex = Data_Value;
                        GooseDefaultWhite.BackColor = ColorTranslator.FromHtml(Data_Value);
                        // Converts color from hex to rgb
                        break;
                    case "GooseDefaultOrange":
                        GooseOrangeHex = Data_Value;
                        GooseDefaultOrange.BackColor = ColorTranslator.FromHtml(Data_Value);
                        // Converts color from hex to rgb
                        break;
                    case "GooseDefaultOutline":
                        GooseOutlineHex = Data_Value;
                        GooseDefaultOutline.BackColor = ColorTranslator.FromHtml(Data_Value);
                        // Converts color from hex to rgb
                        
                        break;
                    case "MinWanderingTimeSeconds":
                        MinWanderingTimeSeconds.Value = Convert.ToInt32(Data_Value);
                        
                        break;
                    case "MaxWanderingTimeSeconds":
                        MaxWanderingTimeSeconds.Value = Convert.ToInt32(Data_Value);
                        
                        break;
                    case "FirstWanderTimeSeconds":
                        FirstWanderTimeSeconds.Value = Convert.ToInt32(Data_Value);
                        break;
                }
            }
            MaxWanderingTimeSeconds.Minimum = MinWanderingTimeSeconds.Value;
            MinWanderingTimeSeconds.Maximum = MaxWanderingTimeSeconds.Value;
            // Sets the MaxWanderingTime's minimum possible value to MinWanderinTime's value and same for MinWanderingTime
            ColorsSettings.Enabled = UseCustomColors.Checked;
            // If use custom colors is false, disable the Colors settings.
            this.TopMost = true;
            this.TopMost = false;
            // Shows the app in the top, idk why 😔
            SetConfigText(); // Sets the text shown in right corner of app.
        }

        public void SetConfigText()
            // Sets the config text
        {
            configText.Text = $"{config[0]}\nEnableMods={EnableMods.Checked}\nSilenceSounds={SilenceSounds.Checked}\nTask_CanAttackMouse={Task_CanAttackMouse.Enabled}\n" +
                $"AttackRandomly={AttackRandomly.Checked}\nUseCustomColors={UseCustomColors.Checked}\nGooseDefaultWhite={GooseWhiteHex}\nGooseDefaultOrange={GooseOrangeHex}\n" +
                $"GooseDefaultOutline={GooseOutlineHex}\nMinWanderingTimeSeconds={MinWanderingTimeSeconds.Value}\nMaxWanderingTimeSeconds={MaxWanderingTimeSeconds.Value}\n" +
                $"FirstWanderTimeSeconds={FirstWanderTimeSeconds.Value}";
        }

        private void UseCustomColors_CheckedChanged(object sender, EventArgs e)
            // when UseCustomColors value has changed:
        {
            ColorsSettings.Enabled = UseCustomColors.Checked;
            SetConfigText();
        }
        private void SetGooseDefaultWhite_Click(object sender, EventArgs e)
        // when "Set Goose's color" button has clicked:
        {
            if (colorDialog.ShowDialog() == DialogResult.OK) // When user chose a color
            {
                Color chosenColor = colorDialog.Color; // Gets the color
                GooseWhiteHex = ("#" + chosenColor.R.ToString("X2") + chosenColor.G.ToString("X2") + chosenColor.B.ToString("X2")).ToLower();
                // Converts color to hex.
                GooseDefaultWhite.BackColor = colorDialog.Color;
                // Sets color
                SetConfigText(); // Sets config text
            }
        }

        private void SetGooseDefaultOrange_Click(object sender, EventArgs e)
            // When "Set Goose's beak color" button has clicked:
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color chosenColor = colorDialog.Color;
                GooseOrangeHex = ("#" + chosenColor.R.ToString("X2") + chosenColor.G.ToString("X2") + chosenColor.B.ToString("X2")).ToLower();
                // Converts color to hex.
                GooseDefaultOrange.BackColor = colorDialog.Color;
                // Sets color
                SetConfigText(); // Sets config text
            }

        }

        private void SetGooseDefaultOutline_Click(object sender, EventArgs e)
            // When set goose outline button has clicked
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color chosenColor = colorDialog.Color; // Gets the color
                GooseOutlineHex = ("#" + chosenColor.R.ToString("X2") + chosenColor.G.ToString("X2") + chosenColor.B.ToString("X2")).ToLower();
                // Converts color to hex.
                GooseDefaultOutline.BackColor = colorDialog.Color;
                // Sets color
                SetConfigText(); // Sets config text
            }
        }

        // Set Config Text whenever a setting has changed, repeats until line 290:
        private void EnableMods_CheckedChanged(object sender, EventArgs e)
        {
            SetConfigText();
        }

        private void SilenceSounds_CheckedChanged(object sender, EventArgs e)
        {
            SetConfigText();
        }

        private void Task_CanAttackMouse_CheckedChanged(object sender, EventArgs e)
        {
            SetConfigText();
        }

        private void AttackRandomly_CheckedChanged(object sender, EventArgs e)
        {
            SetConfigText();
        }

        private void MinWanderingTimeSeconds_ValueChanged(object sender, EventArgs e)
        {
            MaxWanderingTimeSeconds.Minimum = MinWanderingTimeSeconds.Value;
            // Sets maximum wanderin time seconds' minimum value to MinWanderinTime's values
            SetConfigText();
        }

        private void MaxWanderingTimeSeconds_ValueChanged(object sender, EventArgs e)
        {
            MinWanderingTimeSeconds.Maximum = MaxWanderingTimeSeconds.Value;
            // Sets Maximum value of MinWanderinTime's to MaxWa...'s value
            SetConfigText();
        }

        private void FirstWanderTimeSeconds_ValueChanged(object sender, EventArgs e)
        {
            SetConfigText();
        }
        private void ApplySettings_Click(object sender, EventArgs e)
            // When apply settings button has clicked:
        {
            try
            {
                File.WriteAllText(ConfigFilePath, configText.Text); // Try to write to config.ini file
                MessageBox.Show("Settings applied successfully.\nPlease restart the goose to see changes.", "Success - Desktop Goose Customizer", MessageBoxButtons.OK);
            }
            catch (Exception)
            // When error
            {
                MessageBox.Show("Unable to apply settings\nPlease try again.", "Error - Desktop Goose Customizer", MessageBoxButtons.OK);
                // Warns user to try again.
            }
        }
        
        // Tool Tips when the user hovers an item, repeats until line 367
        private void EnableMods_MouseHover(object sender, EventArgs e)
        {
            hvr.Show("If checked, it will enable using downloaded mods\n(Warning: Mods are not created by the maker of Desktop goose and can contaion maicious code that might hurt your computer.)", EnableMods);
        }

        private void SilenceSounds_MouseHover(object sender, EventArgs e)
        {
            hvr.Show("If checked, goose and its sound effects will be muted", SilenceSounds);
        }

        private void Task_CanAttackMouse_MouseHover(object sender, EventArgs e)
        {
            hvr.Show("If checked, goose will be able to attack mouse", Task_CanAttackMouse);
        }

        private void AttackRandomly_MouseHover(object sender, EventArgs e)
        {
            hvr.Show("If checked, goose will be able to attack randomly to your mouse", AttackRandomly);
        }

        private void UseCustomColors_MouseHover(object sender, EventArgs e)
        {
            hvr.Show("If checked, goose's colors will be the colors below", UseCustomColors);
        }

        private void GooseDefaultWhite_MouseHover(object sender, EventArgs e)
        {
            hvr.Show("Goose's body color: " + GooseDefaultWhite.BackColor.R + "-" + GooseDefaultWhite.BackColor.G + "-" + GooseDefaultWhite.BackColor.B, GooseDefaultWhite);
        }

        private void GooseDefaultOrange_MouseHover(object sender, EventArgs e)
        {
            hvr.Show("Goose's beak color: " + GooseDefaultOrange.BackColor.R + "-" + GooseDefaultOrange.BackColor.G + "-" + GooseDefaultOrange.BackColor.B, GooseDefaultOrange);
        }

        private void GooseDefaultOutline_MouseHover(object sender, EventArgs e)
        {
            hvr.Show("Goose's outline color: " + GooseDefaultOutline.BackColor.R + "-" + GooseDefaultOutline.BackColor.G + "-" + GooseDefaultOutline.BackColor.B, GooseDefaultOutline);
        }

        private void minLabel_MouseHover(object sender, EventArgs e)
        {
            hvr.Show("The minimum time before goose goes to bring a meme/text/image", minLabel);
        }

        private void maxLabel_MouseHover(object sender, EventArgs e)
        {
            hvr.Show("The maximum time before goose goes to bring a meme/text/image", maxLabel);
        }

        private void firstLabel_MouseHover(object sender, EventArgs e)
        {
            hvr.Show("The time before goose goes to bring a meme/text/image for the first time", firstLabel);
        }

        private void ApplySettings_MouseHover(object sender, EventArgs e)
        {
            hvr.Show("Will apply settings (You must restart the goose to see them)", ApplySettings);
        }

        private void saveSet_Click(object sender, EventArgs e)
            // When save settings button has clicked
        {
            Properties.Settings.Default.SaveSlots[this.SlotIndex] = configText.Text;
            // Sets the Save Slots' value at SlotIndex to our settings.
            Properties.Settings.Default.Save(); // Saves changed things
        }

        private void loadSet_Click(object sender, EventArgs e)
            // When load settings button has clicked
        {
            this.dgc_Load(string.Join( "\n", Properties.Settings.Default.SaveSlots[this.SlotIndex].Split('\\')), e);
            // Loads the SaveSlots' SlotIndex'th value
        }

        // ToolTip thingy again
        private void saveSet_MouseHover(object sender, EventArgs e)
        {
            hvr.Show("Save the current settings", saveSet);
        }

        private void loadSet_MouseHover(object sender, EventArgs e)
        {
            hvr.Show("Load the saved settings", loadSet);
        }

        private void dgc_SizeChanged(object sender, EventArgs e)
            // When user resizes app
        {
            footer.Size = new Size(this.Size.Width + 5, footer.Size.Height);
            // Sets footer size so it looks good
        }

        private void manageSlots_Click(object sender, EventArgs e)
            // When manage slots button has clicked
        {
            ManageSlots manageSlots = new ManageSlots(SlotIndex);
            // Creates a new Slot Manager dialog
            if(manageSlots.ShowDialog() == DialogResult.OK)
                // If user chose a slot
            {
                this.SlotIndex = manageSlots.SlotIndex; // Sets our SlotIndex to selected slot
                SlotGroup.Text = "Slot: " + SlotIndex; // Sets the text
                saveSet.Enabled = (manageSlots.SlotIndex != 0); // If user didn't chose slot 0, enable ability to saving it.
            }

        }
    }
}
