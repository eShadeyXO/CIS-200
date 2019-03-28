namespace Prog2
{
    partial class AddressForm
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
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateCombo = new System.Windows.Forms.ComboBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.addAddressButton = new System.Windows.Forms.Button();
            this.cancelAddressButton = new System.Windows.Forms.Button();
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.addressErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cityErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.stateErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.zipErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(88, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(98, 32);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(192, 9);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(393, 38);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            this.nameTextBox.Validated += new System.EventHandler(this.nameTextBox_Validated);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(59, 67);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(127, 32);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Address:";
            // 
            // address1TextBox
            // 
            this.address1TextBox.Location = new System.Drawing.Point(192, 61);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(393, 38);
            this.address1TextBox.TabIndex = 3;
            this.address1TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.address1TextBox_Validating);
            this.address1TextBox.Validated += new System.EventHandler(this.address1TextBox_Validated);
            // 
            // address2TextBox
            // 
            this.address2TextBox.Location = new System.Drawing.Point(192, 112);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(393, 38);
            this.address2TextBox.TabIndex = 4;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(114, 170);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(72, 32);
            this.cityLabel.TabIndex = 5;
            this.cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(192, 167);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(393, 38);
            this.cityTextBox.TabIndex = 6;
            this.cityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cityTextBox_Validating);
            this.cityTextBox.Validated += new System.EventHandler(this.cityTextBox_Validated);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(96, 236);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(90, 32);
            this.stateLabel.TabIndex = 7;
            this.stateLabel.Text = "State:";
            // 
            // stateCombo
            // 
            this.stateCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateCombo.FormattingEnabled = true;
            this.stateCombo.Location = new System.Drawing.Point(192, 233);
            this.stateCombo.Name = "stateCombo";
            this.stateCombo.Size = new System.Drawing.Size(143, 39);
            this.stateCombo.TabIndex = 8;
            this.stateCombo.Validating += new System.ComponentModel.CancelEventHandler(this.stateCombo_Validating);
            this.stateCombo.Validated += new System.EventHandler(this.stateCombo_Validated);
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(48, 298);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(138, 32);
            this.zipLabel.TabIndex = 9;
            this.zipLabel.Text = "Zip Code:";
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(192, 298);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(213, 38);
            this.zipTextBox.TabIndex = 10;
            this.zipTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.zipTextBox_Validating);
            this.zipTextBox.Validated += new System.EventHandler(this.zipTextBox_Validated);
            // 
            // addAddressButton
            // 
            this.addAddressButton.Location = new System.Drawing.Point(138, 370);
            this.addAddressButton.Name = "addAddressButton";
            this.addAddressButton.Size = new System.Drawing.Size(197, 52);
            this.addAddressButton.TabIndex = 11;
            this.addAddressButton.Text = "Add Address";
            this.addAddressButton.UseVisualStyleBackColor = true;
            this.addAddressButton.Click += new System.EventHandler(this.addAddressButton_Click);
            // 
            // cancelAddressButton
            // 
            this.cancelAddressButton.Location = new System.Drawing.Point(341, 371);
            this.cancelAddressButton.Name = "cancelAddressButton";
            this.cancelAddressButton.Size = new System.Drawing.Size(147, 51);
            this.cancelAddressButton.TabIndex = 12;
            this.cancelAddressButton.Text = "Cancel";
            this.cancelAddressButton.UseVisualStyleBackColor = true;
            this.cancelAddressButton.Click += new System.EventHandler(this.cancelAddressButton_Click);
            // 
            // nameErrorProvider
            // 
            this.nameErrorProvider.ContainerControl = this;
            // 
            // addressErrorProvider
            // 
            this.addressErrorProvider.ContainerControl = this;
            // 
            // cityErrorProvider
            // 
            this.cityErrorProvider.ContainerControl = this;
            // 
            // stateErrorProvider
            // 
            this.stateErrorProvider.ContainerControl = this;
            // 
            // zipErrorProvider
            // 
            this.zipErrorProvider.ContainerControl = this;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 434);
            this.Controls.Add(this.cancelAddressButton);
            this.Controls.Add(this.addAddressButton);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateCombo);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddressForm";
            this.Text = "Address Form";
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.ComboBox stateCombo;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Button addAddressButton;
        private System.Windows.Forms.Button cancelAddressButton;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        private System.Windows.Forms.ErrorProvider addressErrorProvider;
        private System.Windows.Forms.ErrorProvider cityErrorProvider;
        private System.Windows.Forms.ErrorProvider stateErrorProvider;
        private System.Windows.Forms.ErrorProvider zipErrorProvider;
    }
}