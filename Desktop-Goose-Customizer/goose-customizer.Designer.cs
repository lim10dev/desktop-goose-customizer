namespace Desktop_Goose_Customizer
{
    partial class dgc
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dgc));
            this.configText = new System.Windows.Forms.RichTextBox();
            this.Version_DoNotEdit = new System.Windows.Forms.Label();
            this.EnableMods = new System.Windows.Forms.CheckBox();
            this.SilenceSounds = new System.Windows.Forms.CheckBox();
            this.Task_CanAttackMouse = new System.Windows.Forms.CheckBox();
            this.AttackRandomly = new System.Windows.Forms.CheckBox();
            this.UseCustomColors = new System.Windows.Forms.CheckBox();
            this.ColorsSettings = new System.Windows.Forms.GroupBox();
            this.GooseDefaultOutline = new System.Windows.Forms.PictureBox();
            this.GooseDefaultOrange = new System.Windows.Forms.PictureBox();
            this.GooseDefaultWhite = new System.Windows.Forms.PictureBox();
            this.SetGooseDefaultOutline = new System.Windows.Forms.Button();
            this.SetGooseDefaultOrange = new System.Windows.Forms.Button();
            this.SetGooseDefaultWhite = new System.Windows.Forms.Button();
            this.minLabel = new System.Windows.Forms.Label();
            this.MinWanderingTimeSeconds = new System.Windows.Forms.NumericUpDown();
            this.MaxWanderingTimeSeconds = new System.Windows.Forms.NumericUpDown();
            this.maxLabel = new System.Windows.Forms.Label();
            this.firstLabel = new System.Windows.Forms.Label();
            this.FirstWanderTimeSeconds = new System.Windows.Forms.NumericUpDown();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.ApplySettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hvr = new System.Windows.Forms.ToolTip(this.components);
            this.confinilabel = new System.Windows.Forms.Label();
            this.creditslabel = new System.Windows.Forms.Label();
            this.saveSet = new System.Windows.Forms.Button();
            this.loadSet = new System.Windows.Forms.Button();
            this.footer = new System.Windows.Forms.PictureBox();
            this.apppic = new System.Windows.Forms.PictureBox();
            this.manageSlots = new System.Windows.Forms.Button();
            this.SlotGroup = new System.Windows.Forms.GroupBox();
            this.ColorsSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GooseDefaultOutline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GooseDefaultOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GooseDefaultWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinWanderingTimeSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxWanderingTimeSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstWanderTimeSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apppic)).BeginInit();
            this.SlotGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // configText
            // 
            this.configText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.configText.BackColor = System.Drawing.Color.White;
            this.configText.Location = new System.Drawing.Point(281, 192);
            this.configText.Name = "configText";
            this.configText.ReadOnly = true;
            this.configText.Size = new System.Drawing.Size(180, 169);
            this.configText.TabIndex = 0;
            this.configText.Text = resources.GetString("configText.Text");
            // 
            // Version_DoNotEdit
            // 
            this.Version_DoNotEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Version_DoNotEdit.AutoSize = true;
            this.Version_DoNotEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Version_DoNotEdit.Location = new System.Drawing.Point(12, 9);
            this.Version_DoNotEdit.Name = "Version_DoNotEdit";
            this.Version_DoNotEdit.Size = new System.Drawing.Size(65, 16);
            this.Version_DoNotEdit.TabIndex = 1;
            this.Version_DoNotEdit.Text = "Version:";
            // 
            // EnableMods
            // 
            this.EnableMods.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EnableMods.AutoSize = true;
            this.EnableMods.Location = new System.Drawing.Point(15, 28);
            this.EnableMods.Name = "EnableMods";
            this.EnableMods.Size = new System.Drawing.Size(88, 17);
            this.EnableMods.TabIndex = 2;
            this.EnableMods.Text = "Enable Mods";
            this.EnableMods.UseVisualStyleBackColor = true;
            this.EnableMods.CheckedChanged += new System.EventHandler(this.EnableMods_CheckedChanged);
            this.EnableMods.MouseHover += new System.EventHandler(this.EnableMods_MouseHover);
            // 
            // SilenceSounds
            // 
            this.SilenceSounds.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SilenceSounds.AutoSize = true;
            this.SilenceSounds.Location = new System.Drawing.Point(15, 51);
            this.SilenceSounds.Name = "SilenceSounds";
            this.SilenceSounds.Size = new System.Drawing.Size(100, 17);
            this.SilenceSounds.TabIndex = 3;
            this.SilenceSounds.Text = "Silence Sounds";
            this.SilenceSounds.UseVisualStyleBackColor = true;
            this.SilenceSounds.CheckedChanged += new System.EventHandler(this.SilenceSounds_CheckedChanged);
            this.SilenceSounds.MouseHover += new System.EventHandler(this.SilenceSounds_MouseHover);
            // 
            // Task_CanAttackMouse
            // 
            this.Task_CanAttackMouse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Task_CanAttackMouse.AutoSize = true;
            this.Task_CanAttackMouse.Location = new System.Drawing.Point(15, 74);
            this.Task_CanAttackMouse.Name = "Task_CanAttackMouse";
            this.Task_CanAttackMouse.Size = new System.Drawing.Size(145, 17);
            this.Task_CanAttackMouse.TabIndex = 4;
            this.Task_CanAttackMouse.Text = "Goose can attack mouse";
            this.Task_CanAttackMouse.UseVisualStyleBackColor = true;
            this.Task_CanAttackMouse.CheckedChanged += new System.EventHandler(this.Task_CanAttackMouse_CheckedChanged);
            this.Task_CanAttackMouse.MouseHover += new System.EventHandler(this.Task_CanAttackMouse_MouseHover);
            // 
            // AttackRandomly
            // 
            this.AttackRandomly.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AttackRandomly.AutoSize = true;
            this.AttackRandomly.Location = new System.Drawing.Point(15, 97);
            this.AttackRandomly.Name = "AttackRandomly";
            this.AttackRandomly.Size = new System.Drawing.Size(107, 17);
            this.AttackRandomly.TabIndex = 5;
            this.AttackRandomly.Text = "Attack Randomly";
            this.AttackRandomly.UseVisualStyleBackColor = true;
            this.AttackRandomly.CheckedChanged += new System.EventHandler(this.AttackRandomly_CheckedChanged);
            this.AttackRandomly.MouseHover += new System.EventHandler(this.AttackRandomly_MouseHover);
            // 
            // UseCustomColors
            // 
            this.UseCustomColors.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UseCustomColors.AutoSize = true;
            this.UseCustomColors.Location = new System.Drawing.Point(15, 120);
            this.UseCustomColors.Name = "UseCustomColors";
            this.UseCustomColors.Size = new System.Drawing.Size(115, 17);
            this.UseCustomColors.TabIndex = 6;
            this.UseCustomColors.Text = "Use Custom Colors";
            this.UseCustomColors.UseVisualStyleBackColor = true;
            this.UseCustomColors.CheckedChanged += new System.EventHandler(this.UseCustomColors_CheckedChanged);
            this.UseCustomColors.MouseHover += new System.EventHandler(this.UseCustomColors_MouseHover);
            // 
            // ColorsSettings
            // 
            this.ColorsSettings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ColorsSettings.Controls.Add(this.GooseDefaultOutline);
            this.ColorsSettings.Controls.Add(this.GooseDefaultOrange);
            this.ColorsSettings.Controls.Add(this.GooseDefaultWhite);
            this.ColorsSettings.Controls.Add(this.SetGooseDefaultOutline);
            this.ColorsSettings.Controls.Add(this.SetGooseDefaultOrange);
            this.ColorsSettings.Controls.Add(this.SetGooseDefaultWhite);
            this.ColorsSettings.Location = new System.Drawing.Point(15, 143);
            this.ColorsSettings.Name = "ColorsSettings";
            this.ColorsSettings.Size = new System.Drawing.Size(162, 144);
            this.ColorsSettings.TabIndex = 7;
            this.ColorsSettings.TabStop = false;
            this.ColorsSettings.Text = "Colors";
            // 
            // GooseDefaultOutline
            // 
            this.GooseDefaultOutline.Location = new System.Drawing.Point(115, 109);
            this.GooseDefaultOutline.Name = "GooseDefaultOutline";
            this.GooseDefaultOutline.Size = new System.Drawing.Size(30, 23);
            this.GooseDefaultOutline.TabIndex = 5;
            this.GooseDefaultOutline.TabStop = false;
            this.GooseDefaultOutline.MouseHover += new System.EventHandler(this.GooseDefaultOutline_MouseHover);
            // 
            // GooseDefaultOrange
            // 
            this.GooseDefaultOrange.Location = new System.Drawing.Point(115, 68);
            this.GooseDefaultOrange.Name = "GooseDefaultOrange";
            this.GooseDefaultOrange.Size = new System.Drawing.Size(30, 23);
            this.GooseDefaultOrange.TabIndex = 4;
            this.GooseDefaultOrange.TabStop = false;
            this.GooseDefaultOrange.MouseHover += new System.EventHandler(this.GooseDefaultOrange_MouseHover);
            // 
            // GooseDefaultWhite
            // 
            this.GooseDefaultWhite.Location = new System.Drawing.Point(115, 28);
            this.GooseDefaultWhite.Name = "GooseDefaultWhite";
            this.GooseDefaultWhite.Size = new System.Drawing.Size(30, 23);
            this.GooseDefaultWhite.TabIndex = 3;
            this.GooseDefaultWhite.TabStop = false;
            this.GooseDefaultWhite.MouseHover += new System.EventHandler(this.GooseDefaultWhite_MouseHover);
            // 
            // SetGooseDefaultOutline
            // 
            this.SetGooseDefaultOutline.Location = new System.Drawing.Point(6, 109);
            this.SetGooseDefaultOutline.Name = "SetGooseDefaultOutline";
            this.SetGooseDefaultOutline.Size = new System.Drawing.Size(101, 23);
            this.SetGooseDefaultOutline.TabIndex = 2;
            this.SetGooseDefaultOutline.Text = "Set Goose Outline";
            this.SetGooseDefaultOutline.UseVisualStyleBackColor = true;
            this.SetGooseDefaultOutline.Click += new System.EventHandler(this.SetGooseDefaultOutline_Click);
            // 
            // SetGooseDefaultOrange
            // 
            this.SetGooseDefaultOrange.Location = new System.Drawing.Point(6, 68);
            this.SetGooseDefaultOrange.Name = "SetGooseDefaultOrange";
            this.SetGooseDefaultOrange.Size = new System.Drawing.Size(101, 23);
            this.SetGooseDefaultOrange.TabIndex = 1;
            this.SetGooseDefaultOrange.Text = "Set Goose Beak";
            this.SetGooseDefaultOrange.UseVisualStyleBackColor = true;
            this.SetGooseDefaultOrange.Click += new System.EventHandler(this.SetGooseDefaultOrange_Click);
            // 
            // SetGooseDefaultWhite
            // 
            this.SetGooseDefaultWhite.Location = new System.Drawing.Point(6, 28);
            this.SetGooseDefaultWhite.Name = "SetGooseDefaultWhite";
            this.SetGooseDefaultWhite.Size = new System.Drawing.Size(101, 23);
            this.SetGooseDefaultWhite.TabIndex = 0;
            this.SetGooseDefaultWhite.Text = "Set Goose Body";
            this.SetGooseDefaultWhite.UseVisualStyleBackColor = true;
            this.SetGooseDefaultWhite.Click += new System.EventHandler(this.SetGooseDefaultWhite_Click);
            // 
            // minLabel
            // 
            this.minLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(12, 299);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(165, 13);
            this.minLabel.TabIndex = 8;
            this.minLabel.Text = "Minimum wandering time seconds";
            this.minLabel.MouseHover += new System.EventHandler(this.minLabel_MouseHover);
            // 
            // MinWanderingTimeSeconds
            // 
            this.MinWanderingTimeSeconds.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MinWanderingTimeSeconds.Location = new System.Drawing.Point(15, 315);
            this.MinWanderingTimeSeconds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MinWanderingTimeSeconds.Name = "MinWanderingTimeSeconds";
            this.MinWanderingTimeSeconds.Size = new System.Drawing.Size(72, 20);
            this.MinWanderingTimeSeconds.TabIndex = 9;
            this.MinWanderingTimeSeconds.ValueChanged += new System.EventHandler(this.MinWanderingTimeSeconds_ValueChanged);
            // 
            // MaxWanderingTimeSeconds
            // 
            this.MaxWanderingTimeSeconds.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MaxWanderingTimeSeconds.Location = new System.Drawing.Point(15, 364);
            this.MaxWanderingTimeSeconds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MaxWanderingTimeSeconds.Name = "MaxWanderingTimeSeconds";
            this.MaxWanderingTimeSeconds.Size = new System.Drawing.Size(72, 20);
            this.MaxWanderingTimeSeconds.TabIndex = 10;
            this.MaxWanderingTimeSeconds.ValueChanged += new System.EventHandler(this.MaxWanderingTimeSeconds_ValueChanged);
            // 
            // maxLabel
            // 
            this.maxLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(12, 348);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(168, 13);
            this.maxLabel.TabIndex = 11;
            this.maxLabel.Text = "Maximum wandering time seconds";
            this.maxLabel.MouseHover += new System.EventHandler(this.maxLabel_MouseHover);
            // 
            // firstLabel
            // 
            this.firstLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.firstLabel.AutoSize = true;
            this.firstLabel.Location = new System.Drawing.Point(12, 400);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(129, 13);
            this.firstLabel.TabIndex = 13;
            this.firstLabel.Text = "First wander time seconds";
            this.firstLabel.MouseHover += new System.EventHandler(this.firstLabel_MouseHover);
            // 
            // FirstWanderTimeSeconds
            // 
            this.FirstWanderTimeSeconds.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FirstWanderTimeSeconds.Location = new System.Drawing.Point(15, 416);
            this.FirstWanderTimeSeconds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FirstWanderTimeSeconds.Name = "FirstWanderTimeSeconds";
            this.FirstWanderTimeSeconds.Size = new System.Drawing.Size(72, 20);
            this.FirstWanderTimeSeconds.TabIndex = 12;
            this.FirstWanderTimeSeconds.ValueChanged += new System.EventHandler(this.FirstWanderTimeSeconds_ValueChanged);
            // 
            // openFile
            // 
            this.openFile.DefaultExt = "ini";
            this.openFile.FileName = "config.ini";
            this.openFile.Filter = "Goose Config|*ini";
            this.openFile.Title = "Choose config.ini file...";
            // 
            // ApplySettings
            // 
            this.ApplySettings.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ApplySettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApplySettings.Location = new System.Drawing.Point(368, 367);
            this.ApplySettings.Name = "ApplySettings";
            this.ApplySettings.Size = new System.Drawing.Size(93, 51);
            this.ApplySettings.TabIndex = 14;
            this.ApplySettings.Text = "Apply";
            this.ApplySettings.UseVisualStyleBackColor = true;
            this.ApplySettings.Click += new System.EventHandler(this.ApplySettings_Click);
            this.ApplySettings.MouseHover += new System.EventHandler(this.ApplySettings_MouseHover);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(235, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "You need to restart the goose to apply settings";
            // 
            // confinilabel
            // 
            this.confinilabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.confinilabel.AutoSize = true;
            this.confinilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.confinilabel.Location = new System.Drawing.Point(362, 177);
            this.confinilabel.Name = "confinilabel";
            this.confinilabel.Size = new System.Drawing.Size(99, 12);
            this.confinilabel.TabIndex = 17;
            this.confinilabel.Text = "config.ini File Text";
            // 
            // creditslabel
            // 
            this.creditslabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.creditslabel.AutoSize = true;
            this.creditslabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.creditslabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.creditslabel.Location = new System.Drawing.Point(32, 456);
            this.creditslabel.Name = "creditslabel";
            this.creditslabel.Size = new System.Drawing.Size(402, 13);
            this.creditslabel.TabIndex = 19;
            this.creditslabel.Text = "Desktop Goose made by Samperson. Desktop Goose Customizer made by lim10dev";
            // 
            // saveSet
            // 
            this.saveSet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveSet.Location = new System.Drawing.Point(4, 19);
            this.saveSet.Name = "saveSet";
            this.saveSet.Size = new System.Drawing.Size(50, 36);
            this.saveSet.TabIndex = 20;
            this.saveSet.Text = "Save Settings";
            this.saveSet.UseVisualStyleBackColor = true;
            this.saveSet.Click += new System.EventHandler(this.saveSet_Click);
            this.saveSet.MouseHover += new System.EventHandler(this.saveSet_MouseHover);
            // 
            // loadSet
            // 
            this.loadSet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.loadSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loadSet.Location = new System.Drawing.Point(4, 60);
            this.loadSet.Name = "loadSet";
            this.loadSet.Size = new System.Drawing.Size(50, 36);
            this.loadSet.TabIndex = 21;
            this.loadSet.Text = "Load Settings";
            this.loadSet.UseVisualStyleBackColor = true;
            this.loadSet.Click += new System.EventHandler(this.loadSet_Click);
            this.loadSet.MouseHover += new System.EventHandler(this.loadSet_MouseHover);
            // 
            // footer
            // 
            this.footer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.footer.Location = new System.Drawing.Point(-1, 451);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(490, 31);
            this.footer.TabIndex = 18;
            this.footer.TabStop = false;
            // 
            // apppic
            // 
            this.apppic.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.apppic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("apppic.BackgroundImage")));
            this.apppic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.apppic.Location = new System.Drawing.Point(238, 12);
            this.apppic.Name = "apppic";
            this.apppic.Size = new System.Drawing.Size(223, 133);
            this.apppic.TabIndex = 16;
            this.apppic.TabStop = false;
            // 
            // manageSlots
            // 
            this.manageSlots.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.manageSlots.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageSlots.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.manageSlots.Location = new System.Drawing.Point(4, 102);
            this.manageSlots.Name = "manageSlots";
            this.manageSlots.Size = new System.Drawing.Size(50, 61);
            this.manageSlots.TabIndex = 23;
            this.manageSlots.Text = "Manage Slots";
            this.manageSlots.UseVisualStyleBackColor = true;
            this.manageSlots.Click += new System.EventHandler(this.manageSlots_Click);
            // 
            // SlotGroup
            // 
            this.SlotGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SlotGroup.Controls.Add(this.manageSlots);
            this.SlotGroup.Controls.Add(this.loadSet);
            this.SlotGroup.Controls.Add(this.saveSet);
            this.SlotGroup.Location = new System.Drawing.Point(215, 192);
            this.SlotGroup.Name = "SlotGroup";
            this.SlotGroup.Size = new System.Drawing.Size(60, 169);
            this.SlotGroup.TabIndex = 25;
            this.SlotGroup.TabStop = false;
            this.SlotGroup.Text = "Slot: 0";
            // 
            // dgc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 478);
            this.Controls.Add(this.SlotGroup);
            this.Controls.Add(this.creditslabel);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.confinilabel);
            this.Controls.Add(this.apppic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApplySettings);
            this.Controls.Add(this.firstLabel);
            this.Controls.Add(this.FirstWanderTimeSeconds);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.MaxWanderingTimeSeconds);
            this.Controls.Add(this.MinWanderingTimeSeconds);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.ColorsSettings);
            this.Controls.Add(this.UseCustomColors);
            this.Controls.Add(this.AttackRandomly);
            this.Controls.Add(this.Task_CanAttackMouse);
            this.Controls.Add(this.SilenceSounds);
            this.Controls.Add(this.EnableMods);
            this.Controls.Add(this.Version_DoNotEdit);
            this.Controls.Add(this.configText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(489, 517);
            this.Name = "dgc";
            this.Text = "Desktop Goose Customizer";
            this.Load += new System.EventHandler(this.dgc_Load);
            this.SizeChanged += new System.EventHandler(this.dgc_SizeChanged);
            this.ColorsSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GooseDefaultOutline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GooseDefaultOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GooseDefaultWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinWanderingTimeSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxWanderingTimeSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstWanderTimeSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apppic)).EndInit();
            this.SlotGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox configText;
        private System.Windows.Forms.Label Version_DoNotEdit;
        private System.Windows.Forms.CheckBox EnableMods;
        private System.Windows.Forms.CheckBox SilenceSounds;
        private System.Windows.Forms.CheckBox Task_CanAttackMouse;
        private System.Windows.Forms.CheckBox AttackRandomly;
        private System.Windows.Forms.CheckBox UseCustomColors;
        private System.Windows.Forms.GroupBox ColorsSettings;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.NumericUpDown MinWanderingTimeSeconds;
        private System.Windows.Forms.NumericUpDown MaxWanderingTimeSeconds;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.NumericUpDown FirstWanderTimeSeconds;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button SetGooseDefaultWhite;
        private System.Windows.Forms.Button SetGooseDefaultOrange;
        private System.Windows.Forms.Button SetGooseDefaultOutline;
        private System.Windows.Forms.PictureBox GooseDefaultWhite;
        private System.Windows.Forms.PictureBox GooseDefaultOrange;
        private System.Windows.Forms.PictureBox GooseDefaultOutline;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button ApplySettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip hvr;
        private System.Windows.Forms.PictureBox apppic;
        private System.Windows.Forms.Label confinilabel;
        private System.Windows.Forms.PictureBox footer;
        private System.Windows.Forms.Label creditslabel;
        private System.Windows.Forms.Button saveSet;
        private System.Windows.Forms.Button loadSet;
        private System.Windows.Forms.Button manageSlots;
        private System.Windows.Forms.GroupBox SlotGroup;
    }
}

