namespace VitaReg
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripLabelEntryIndex = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabelEntryOffset = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelValueIndex = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabelValueType = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpTheRegistryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rewriteTheRegistryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registryInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutTheDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanksToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usefulWebsitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valuePicker1 = new VitaReg.ValuePicker();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(52, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Value";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelEntryIndex,
            this.toolStripLabelEntryOffset,
            this.toolStripSeparator1,
            this.toolStripLabelValueIndex,
            this.toolStripLabelValueType});
            this.statusStrip1.Location = new System.Drawing.Point(0, 242);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(368, 23);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripLabelEntryIndex
            // 
            this.toolStripLabelEntryIndex.Name = "toolStripLabelEntryIndex";
            this.toolStripLabelEntryIndex.Size = new System.Drawing.Size(55, 18);
            this.toolStripLabelEntryIndex.Text = "Entry 000";
            // 
            // toolStripLabelEntryOffset
            // 
            this.toolStripLabelEntryOffset.Name = "toolStripLabelEntryOffset";
            this.toolStripLabelEntryOffset.Size = new System.Drawing.Size(33, 18);
            this.toolStripLabelEntryOffset.Text = "Off 0";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabelValueIndex
            // 
            this.toolStripLabelValueIndex.Name = "toolStripLabelValueIndex";
            this.toolStripLabelValueIndex.Size = new System.Drawing.Size(56, 18);
            this.toolStripLabelValueIndex.Text = "Value 000";
            // 
            // toolStripLabelValueType
            // 
            this.toolStripLabelValueType.Name = "toolStripLabelValueType";
            this.toolStripLabelValueType.Size = new System.Drawing.Size(41, 18);
            this.toolStripLabelValueType.Text = "Type 0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(368, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dumpTheRegistryToolStripMenuItem,
            this.rewriteTheRegistryToolStripMenuItem,
            this.registryInformationToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutTheDeveloperToolStripMenuItem,
            this.thanksToToolStripMenuItem,
            this.usefulWebsitesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // dumpTheRegistryToolStripMenuItem
            // 
            this.dumpTheRegistryToolStripMenuItem.Name = "dumpTheRegistryToolStripMenuItem";
            this.dumpTheRegistryToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.dumpTheRegistryToolStripMenuItem.Text = "Dump the registry";
            this.dumpTheRegistryToolStripMenuItem.Click += new System.EventHandler(this.dumpTheRegistryToolStripMenuItem_Click);
            // 
            // rewriteTheRegistryToolStripMenuItem
            // 
            this.rewriteTheRegistryToolStripMenuItem.Name = "rewriteTheRegistryToolStripMenuItem";
            this.rewriteTheRegistryToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.rewriteTheRegistryToolStripMenuItem.Text = "Rewrite the registry";
            this.rewriteTheRegistryToolStripMenuItem.Click += new System.EventHandler(this.rewriteTheRegistryToolStripMenuItem_Click);
            // 
            // registryInformationToolStripMenuItem
            // 
            this.registryInformationToolStripMenuItem.Name = "registryInformationToolStripMenuItem";
            this.registryInformationToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.registryInformationToolStripMenuItem.Text = "Registry information";
            this.registryInformationToolStripMenuItem.Click += new System.EventHandler(this.registryInformationToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(179, 6);
            // 
            // aboutTheDeveloperToolStripMenuItem
            // 
            this.aboutTheDeveloperToolStripMenuItem.Name = "aboutTheDeveloperToolStripMenuItem";
            this.aboutTheDeveloperToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.aboutTheDeveloperToolStripMenuItem.Text = "About the developer";
            this.aboutTheDeveloperToolStripMenuItem.Click += new System.EventHandler(this.aboutTheDeveloperToolStripMenuItem_Click);
            // 
            // pSVitaSceneMembersToolStripMenuItem
            // 
            this.thanksToToolStripMenuItem.Name = "pSVitaSceneMembersToolStripMenuItem";
            this.thanksToToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.thanksToToolStripMenuItem.Text = "Thanks to...";
            this.thanksToToolStripMenuItem.Click += new System.EventHandler(this.thanksToToolStripMenuItem_Click);
            // 
            // usefulWebsitesToolStripMenuItem
            // 
            this.usefulWebsitesToolStripMenuItem.Name = "usefulWebsitesToolStripMenuItem";
            this.usefulWebsitesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.usefulWebsitesToolStripMenuItem.Text = "Useful websites";
            this.usefulWebsitesToolStripMenuItem.Click += new System.EventHandler(this.usefulWebsitesToolStripMenuItem_Click);
            // 
            // valuePicker1
            // 
            this.valuePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valuePicker1.CurrentRegistry = null;
            this.valuePicker1.Location = new System.Drawing.Point(0, 27);
            this.valuePicker1.Name = "valuePicker1";
            this.valuePicker1.Size = new System.Drawing.Size(356, 192);
            this.valuePicker1.TabIndex = 0;
            this.valuePicker1.OnSelectedEntry += new VitaReg.ValuePicker.SelectedEntry(this.valuePicker1_OnSelectedEntry);
            this.valuePicker1.OnSelectedValue += new VitaReg.ValuePicker.SelectedValue(this.valuePicker1_OnSelectedValue);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 265);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.valuePicker1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "VitaReg";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ValuePicker valuePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelEntryIndex;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelEntryOffset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelValueIndex;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelValueType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dumpTheRegistryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rewriteTheRegistryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registryInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem aboutTheDeveloperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanksToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usefulWebsitesToolStripMenuItem;
    }
}

