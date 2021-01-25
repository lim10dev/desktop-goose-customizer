namespace Desktop_Goose_Customizer
{
    partial class ManageSlots
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSlots));
            this.configText = new System.Windows.Forms.RichTextBox();
            this.SlotList = new System.Windows.Forms.ListBox();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SlotName = new System.Windows.Forms.TextBox();
            this.slotMinus = new System.Windows.Forms.Button();
            this.slotPlus = new System.Windows.Forms.Button();
            this.slotCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // configText
            // 
            this.configText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.configText.BackColor = System.Drawing.Color.Teal;
            this.configText.ForeColor = System.Drawing.SystemColors.Info;
            this.configText.Location = new System.Drawing.Point(121, 12);
            this.configText.Name = "configText";
            this.configText.ReadOnly = true;
            this.configText.Size = new System.Drawing.Size(194, 223);
            this.configText.TabIndex = 0;
            this.configText.Text = "";
            // 
            // SlotList
            // 
            this.SlotList.FormattingEnabled = true;
            this.SlotList.Items.AddRange(new object[] {
            "Default",
            "Slot 1"});
            this.SlotList.Location = new System.Drawing.Point(12, 12);
            this.SlotList.Name = "SlotList";
            this.SlotList.Size = new System.Drawing.Size(95, 121);
            this.SlotList.TabIndex = 1;
            this.SlotList.SelectedIndexChanged += new System.EventHandler(this.SlotList_SelectedIndexChanged);
            // 
            // ok
            // 
            this.ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ok.Location = new System.Drawing.Point(234, 243);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(85, 36);
            this.ok.TabIndex = 2;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.Location = new System.Drawing.Point(143, 243);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(85, 36);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // SlotName
            // 
            this.SlotName.Location = new System.Drawing.Point(3, 324);
            this.SlotName.Name = "SlotName";
            this.SlotName.Size = new System.Drawing.Size(92, 20);
            this.SlotName.TabIndex = 4;
            this.SlotName.Visible = false;
            this.SlotName.TextChanged += new System.EventHandler(this.SlotName_TextChanged);
            // 
            // slotMinus
            // 
            this.slotMinus.Location = new System.Drawing.Point(85, 140);
            this.slotMinus.Name = "slotMinus";
            this.slotMinus.Size = new System.Drawing.Size(22, 22);
            this.slotMinus.TabIndex = 5;
            this.slotMinus.Text = "-";
            this.slotMinus.UseVisualStyleBackColor = true;
            this.slotMinus.Click += new System.EventHandler(this.slotMinus_Click);
            // 
            // slotPlus
            // 
            this.slotPlus.Location = new System.Drawing.Point(14, 140);
            this.slotPlus.Name = "slotPlus";
            this.slotPlus.Size = new System.Drawing.Size(23, 22);
            this.slotPlus.TabIndex = 6;
            this.slotPlus.Text = "+";
            this.slotPlus.UseVisualStyleBackColor = true;
            this.slotPlus.Click += new System.EventHandler(this.slotPlus_Click);
            // 
            // slotCount
            // 
            this.slotCount.AutoSize = true;
            this.slotCount.Location = new System.Drawing.Point(36, 145);
            this.slotCount.Name = "slotCount";
            this.slotCount.Size = new System.Drawing.Size(39, 13);
            this.slotCount.TabIndex = 7;
            this.slotCount.Text = "n Slots";
            // 
            // ManageSlots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 289);
            this.Controls.Add(this.slotCount);
            this.Controls.Add(this.slotPlus);
            this.Controls.Add(this.slotMinus);
            this.Controls.Add(this.SlotName);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.SlotList);
            this.Controls.Add(this.configText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(347, 328);
            this.Name = "ManageSlots";
            this.Text = "Desktop Goose Customizer - Choose Slot";
            this.Load += new System.EventHandler(this.ManageSlots_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox configText;
        private System.Windows.Forms.ListBox SlotList;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox SlotName;
        private System.Windows.Forms.Button slotMinus;
        private System.Windows.Forms.Button slotPlus;
        private System.Windows.Forms.Label slotCount;
    }
}