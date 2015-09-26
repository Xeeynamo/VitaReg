namespace VitaReg
{
    partial class ValuePicker
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

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.listValues = new System.Windows.Forms.ListBox();
            this.listEntries = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listValues
            // 
            this.listValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listValues.FormattingEnabled = true;
            this.listValues.Location = new System.Drawing.Point(197, 0);
            this.listValues.Name = "listValues";
            this.listValues.Size = new System.Drawing.Size(150, 134);
            this.listValues.TabIndex = 2;
            this.listValues.SelectedIndexChanged += new System.EventHandler(this.listValues_SelectedIndexChanged);
            // 
            // listEntries
            // 
            this.listEntries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listEntries.FormattingEnabled = true;
            this.listEntries.Location = new System.Drawing.Point(0, 0);
            this.listEntries.Name = "listEntries";
            this.listEntries.Size = new System.Drawing.Size(192, 134);
            this.listEntries.TabIndex = 3;
            this.listEntries.SelectedIndexChanged += new System.EventHandler(this.listEntries_SelectedIndexChanged);
            // 
            // ValuePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listEntries);
            this.Controls.Add(this.listValues);
            this.Name = "ValuePicker";
            this.Size = new System.Drawing.Size(348, 134);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listValues;
        private System.Windows.Forms.ListBox listEntries;
    }
}
