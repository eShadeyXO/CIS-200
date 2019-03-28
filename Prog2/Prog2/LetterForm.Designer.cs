namespace Prog2
{
    partial class LetterForm
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
            this.originLabel = new System.Windows.Forms.Label();
            this.destLabel = new System.Windows.Forms.Label();
            this.originCombo = new System.Windows.Forms.ComboBox();
            this.destCombo = new System.Windows.Forms.ComboBox();
            this.fixedCostLabel = new System.Windows.Forms.Label();
            this.fixedCostTextBox = new System.Windows.Forms.TextBox();
            this.addLetterButton = new System.Windows.Forms.Button();
            this.cancelLetterButton = new System.Windows.Forms.Button();
            this.originErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.destErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.costErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.originErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Location = new System.Drawing.Point(79, 9);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(211, 32);
            this.originLabel.TabIndex = 0;
            this.originLabel.Text = "Origin Address:";
            // 
            // destLabel
            // 
            this.destLabel.AutoSize = true;
            this.destLabel.Location = new System.Drawing.Point(12, 64);
            this.destLabel.Name = "destLabel";
            this.destLabel.Size = new System.Drawing.Size(278, 32);
            this.destLabel.TabIndex = 1;
            this.destLabel.Text = "Destination Address:";
            // 
            // originCombo
            // 
            this.originCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originCombo.FormattingEnabled = true;
            this.originCombo.Location = new System.Drawing.Point(297, 9);
            this.originCombo.Name = "originCombo";
            this.originCombo.Size = new System.Drawing.Size(314, 39);
            this.originCombo.TabIndex = 2;
            this.originCombo.Validating += new System.ComponentModel.CancelEventHandler(this.originCombo_Validating);
            this.originCombo.Validated += new System.EventHandler(this.originCombo_Validated);
            // 
            // destCombo
            // 
            this.destCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destCombo.FormattingEnabled = true;
            this.destCombo.Location = new System.Drawing.Point(297, 64);
            this.destCombo.Name = "destCombo";
            this.destCombo.Size = new System.Drawing.Size(314, 39);
            this.destCombo.TabIndex = 3;
            this.destCombo.Validating += new System.ComponentModel.CancelEventHandler(this.destCombo_Validating);
            this.destCombo.Validated += new System.EventHandler(this.destCombo_Validated);
            // 
            // fixedCostLabel
            // 
            this.fixedCostLabel.AutoSize = true;
            this.fixedCostLabel.Location = new System.Drawing.Point(132, 122);
            this.fixedCostLabel.Name = "fixedCostLabel";
            this.fixedCostLabel.Size = new System.Drawing.Size(158, 32);
            this.fixedCostLabel.TabIndex = 4;
            this.fixedCostLabel.Text = "Fixed Cost:";
            // 
            // fixedCostTextBox
            // 
            this.fixedCostTextBox.Location = new System.Drawing.Point(297, 120);
            this.fixedCostTextBox.Name = "fixedCostTextBox";
            this.fixedCostTextBox.Size = new System.Drawing.Size(216, 38);
            this.fixedCostTextBox.TabIndex = 5;
            this.fixedCostTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.fixedCostTextBox_Validating);
            this.fixedCostTextBox.Validated += new System.EventHandler(this.fixedCostTextBox_Validated);
            // 
            // addLetterButton
            // 
            this.addLetterButton.Location = new System.Drawing.Point(104, 179);
            this.addLetterButton.Name = "addLetterButton";
            this.addLetterButton.Size = new System.Drawing.Size(186, 55);
            this.addLetterButton.TabIndex = 6;
            this.addLetterButton.Text = "Add Letter";
            this.addLetterButton.UseVisualStyleBackColor = true;
            this.addLetterButton.Click += new System.EventHandler(this.addLetterButton_Click);
            // 
            // cancelLetterButton
            // 
            this.cancelLetterButton.Location = new System.Drawing.Point(297, 179);
            this.cancelLetterButton.Name = "cancelLetterButton";
            this.cancelLetterButton.Size = new System.Drawing.Size(160, 54);
            this.cancelLetterButton.TabIndex = 7;
            this.cancelLetterButton.Text = "Cancel";
            this.cancelLetterButton.UseVisualStyleBackColor = true;
            this.cancelLetterButton.Click += new System.EventHandler(this.cancelLetterButton_Click);
            // 
            // originErrorProvider
            // 
            this.originErrorProvider.ContainerControl = this;
            // 
            // destErrorProvider
            // 
            this.destErrorProvider.ContainerControl = this;
            // 
            // costErrorProvider
            // 
            this.costErrorProvider.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 246);
            this.Controls.Add(this.cancelLetterButton);
            this.Controls.Add(this.addLetterButton);
            this.Controls.Add(this.fixedCostTextBox);
            this.Controls.Add(this.fixedCostLabel);
            this.Controls.Add(this.destCombo);
            this.Controls.Add(this.originCombo);
            this.Controls.Add(this.destLabel);
            this.Controls.Add(this.originLabel);
            this.Name = "LetterForm";
            this.Text = "Letter Form";
            ((System.ComponentModel.ISupportInitialize)(this.originErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originLabel;
        private System.Windows.Forms.Label destLabel;
        private System.Windows.Forms.ComboBox originCombo;
        private System.Windows.Forms.ComboBox destCombo;
        private System.Windows.Forms.Label fixedCostLabel;
        private System.Windows.Forms.TextBox fixedCostTextBox;
        private System.Windows.Forms.Button addLetterButton;
        private System.Windows.Forms.Button cancelLetterButton;
        private System.Windows.Forms.ErrorProvider originErrorProvider;
        private System.Windows.Forms.ErrorProvider destErrorProvider;
        private System.Windows.Forms.ErrorProvider costErrorProvider;
    }
}