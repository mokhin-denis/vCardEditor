﻿
namespace vCardEditor.View.Customs
{
    partial class AddressBox
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExtAddrValue = new vCardEditor.View.StateTextBox();
            this.ExtAdressLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.StreetValue = new vCardEditor.View.StateTextBox();
            this.POBoxLabel = new System.Windows.Forms.Label();
            this.CountryValue = new vCardEditor.View.StateTextBox();
            this.Country = new System.Windows.Forms.Label();
            this.POBoxValue = new vCardEditor.View.StateTextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.RegionValue = new vCardEditor.View.StateTextBox();
            this.CityValue = new vCardEditor.View.StateTextBox();
            this.StateLabel = new System.Windows.Forms.Label();
            this.ZipLabel = new System.Windows.Forms.Label();
            this.ZipValue = new vCardEditor.View.StateTextBox();
            this.SuspendLayout();
            // 
            // ExtAddrValue
            // 
            this.ExtAddrValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExtAddrValue.Location = new System.Drawing.Point(90, 45);
            this.ExtAddrValue.Margin = new System.Windows.Forms.Padding(4);
            this.ExtAddrValue.Name = "ExtAddrValue";
            this.ExtAddrValue.oldText = null;
            this.ExtAddrValue.Size = new System.Drawing.Size(237, 22);
            this.ExtAddrValue.TabIndex = 27;
            this.ExtAddrValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.ExtAddrValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // ExtAdressLabel
            // 
            this.ExtAdressLabel.Location = new System.Drawing.Point(1, 42);
            this.ExtAdressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExtAdressLabel.Name = "ExtAdressLabel";
            this.ExtAdressLabel.Size = new System.Drawing.Size(87, 23);
            this.ExtAdressLabel.TabIndex = 26;
            this.ExtAdressLabel.Text = "Ext Address:";
            this.ExtAdressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StreetLabel
            // 
            this.StreetLabel.Location = new System.Drawing.Point(2, 14);
            this.StreetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(65, 23);
            this.StreetLabel.TabIndex = 14;
            this.StreetLabel.Text = "Address:";
            this.StreetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StreetValue
            // 
            this.StreetValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StreetValue.Location = new System.Drawing.Point(90, 14);
            this.StreetValue.Margin = new System.Windows.Forms.Padding(4);
            this.StreetValue.Name = "StreetValue";
            this.StreetValue.oldText = "";
            this.StreetValue.Size = new System.Drawing.Size(613, 22);
            this.StreetValue.TabIndex = 15;
            this.StreetValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.StreetValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // POBoxLabel
            // 
            this.POBoxLabel.Location = new System.Drawing.Point(334, 75);
            this.POBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.POBoxLabel.Name = "POBoxLabel";
            this.POBoxLabel.Size = new System.Drawing.Size(59, 23);
            this.POBoxLabel.TabIndex = 16;
            this.POBoxLabel.Text = "PO Box:";
            this.POBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            
            // 
            // CountryValue
            // 
            this.CountryValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryValue.Location = new System.Drawing.Point(579, 76);
            this.CountryValue.Margin = new System.Windows.Forms.Padding(4);
            this.CountryValue.Name = "CountryValue";
            this.CountryValue.oldText = null;
            this.CountryValue.Size = new System.Drawing.Size(125, 22);
            this.CountryValue.TabIndex = 25;
            this.CountryValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.CountryValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // Country
            // 
            this.Country.Location = new System.Drawing.Point(505, 76);
            this.Country.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(65, 23);
            this.Country.TabIndex = 24;
            this.Country.Text = "Country:";
            this.Country.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // POBoxValue
            // 
            this.POBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.POBoxValue.Location = new System.Drawing.Point(397, 75);
            this.POBoxValue.Margin = new System.Windows.Forms.Padding(4);
            this.POBoxValue.Name = "POBoxValue";
            this.POBoxValue.oldText = null;
            this.POBoxValue.Size = new System.Drawing.Size(100, 22);
            this.POBoxValue.TabIndex = 17;
            this.POBoxValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.POBoxValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // CityLabel
            // 
            this.CityLabel.Location = new System.Drawing.Point(338, 45);
            this.CityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(32, 23);
            this.CityLabel.TabIndex = 18;
            this.CityLabel.Text = "City:";
            this.CityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RegionValue
            // 
            this.RegionValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegionValue.Location = new System.Drawing.Point(90, 75);
            this.RegionValue.Margin = new System.Windows.Forms.Padding(4);
            this.RegionValue.Name = "RegionValue";
            this.RegionValue.oldText = null;
            this.RegionValue.Size = new System.Drawing.Size(236, 22);
            this.RegionValue.TabIndex = 23;
            this.RegionValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.RegionValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // CityValue
            // 
            this.CityValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityValue.Location = new System.Drawing.Point(397, 45);
            this.CityValue.Margin = new System.Windows.Forms.Padding(4);
            this.CityValue.Name = "CityValue";
            this.CityValue.oldText = null;
            this.CityValue.Size = new System.Drawing.Size(127, 22);
            this.CityValue.TabIndex = 19;
            this.CityValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.CityValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // StateLabel
            // 
            this.StateLabel.Location = new System.Drawing.Point(17, 74);
            this.StateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(61, 23);
            this.StateLabel.TabIndex = 22;
            this.StateLabel.Text = "Region:";
            this.StateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ZipLabel
            // 
            this.ZipLabel.Location = new System.Drawing.Point(533, 45);
            this.ZipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(37, 23);
            this.ZipLabel.TabIndex = 20;
            this.ZipLabel.Text = "Zip:";
            this.ZipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ZipValue
            // 
            this.ZipValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZipValue.Location = new System.Drawing.Point(579, 46);
            this.ZipValue.Margin = new System.Windows.Forms.Padding(4);
            this.ZipValue.Name = "ZipValue";
            this.ZipValue.oldText = null;
            this.ZipValue.Size = new System.Drawing.Size(124, 22);
            this.ZipValue.TabIndex = 21;
            this.ZipValue.LostFocus += new System.EventHandler(this.Value_TextChanged);
            this.ZipValue.Validated += new System.EventHandler(this.Value_TextChanged);
            // 
            // AddressBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExtAddrValue);
            this.Controls.Add(this.ExtAdressLabel);
            this.Controls.Add(this.StreetLabel);
            this.Controls.Add(this.StreetValue);
            this.Controls.Add(this.POBoxLabel);
            this.Controls.Add(this.CountryValue);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.POBoxValue);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.RegionValue);
            this.Controls.Add(this.CityValue);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.ZipLabel);
            this.Controls.Add(this.ZipValue);
            this.Name = "AddressBox";
            this.Size = new System.Drawing.Size(706, 104);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal StateTextBox ExtAddrValue;
        internal System.Windows.Forms.Label ExtAdressLabel;
        internal System.Windows.Forms.Label StreetLabel;
        internal StateTextBox StreetValue;
        internal System.Windows.Forms.Label POBoxLabel;
        internal StateTextBox CountryValue;
        internal System.Windows.Forms.Label Country;
        internal StateTextBox POBoxValue;
        internal System.Windows.Forms.Label CityLabel;
        internal StateTextBox RegionValue;
        internal StateTextBox CityValue;
        internal System.Windows.Forms.Label StateLabel;
        internal System.Windows.Forms.Label ZipLabel;
        internal StateTextBox ZipValue;
    }
}
