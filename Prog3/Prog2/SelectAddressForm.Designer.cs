namespace UPVApp
{
    partial class SelectAddressForm
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
            this.selectAddressLabel = new System.Windows.Forms.Label();
            this.editAddressCombo = new System.Windows.Forms.ComboBox();
            this.editAddressButton = new System.Windows.Forms.Button();
            this.editAddressErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.editAddressErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // selectAddressLabel
            // 
            this.selectAddressLabel.AutoSize = true;
            this.selectAddressLabel.Location = new System.Drawing.Point(30, 36);
            this.selectAddressLabel.Name = "selectAddressLabel";
            this.selectAddressLabel.Size = new System.Drawing.Size(296, 32);
            this.selectAddressLabel.TabIndex = 0;
            this.selectAddressLabel.Text = "Select address to edit:";
            // 
            // editAddressCombo
            // 
            this.editAddressCombo.FormattingEnabled = true;
            this.editAddressCombo.Location = new System.Drawing.Point(333, 36);
            this.editAddressCombo.Name = "editAddressCombo";
            this.editAddressCombo.Size = new System.Drawing.Size(385, 39);
            this.editAddressCombo.TabIndex = 1;
            this.editAddressCombo.Validating += new System.ComponentModel.CancelEventHandler(this.editAddressCombo_Validating);
            this.editAddressCombo.Validated += new System.EventHandler(this.editAddressCombo_Validated);
            // 
            // editAddressButton
            // 
            this.editAddressButton.Location = new System.Drawing.Point(284, 96);
            this.editAddressButton.Name = "editAddressButton";
            this.editAddressButton.Size = new System.Drawing.Size(227, 67);
            this.editAddressButton.TabIndex = 2;
            this.editAddressButton.Text = "Edit Address";
            this.editAddressButton.UseVisualStyleBackColor = true;
            this.editAddressButton.Click += new System.EventHandler(this.editAddressButton_Click);
            // 
            // editAddressErrorProvider
            // 
            this.editAddressErrorProvider.ContainerControl = this;
            // 
            // SelectAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 185);
            this.Controls.Add(this.editAddressButton);
            this.Controls.Add(this.editAddressCombo);
            this.Controls.Add(this.selectAddressLabel);
            this.Name = "SelectAddressForm";
            this.Text = "SelectAddressForm";
            this.Load += new System.EventHandler(this.SelectAddressForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editAddressErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectAddressLabel;
        private System.Windows.Forms.ComboBox editAddressCombo;
        private System.Windows.Forms.Button editAddressButton;
        private System.Windows.Forms.ErrorProvider editAddressErrorProvider;
    }
}