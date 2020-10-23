namespace ElcomPlusTestApp
{
    partial class MainForm
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
            this.xmlAdressBox = new System.Windows.Forms.TextBox();
            this.buildTreeButton = new System.Windows.Forms.Button();
            this.xmlTreeView = new System.Windows.Forms.TreeView();
            this.propertiesTextBox = new System.Windows.Forms.TextBox();
            this.propertiesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xmlAdressBox
            // 
            this.xmlAdressBox.Location = new System.Drawing.Point(12, 12);
            this.xmlAdressBox.Name = "xmlAdressBox";
            this.xmlAdressBox.Size = new System.Drawing.Size(271, 20);
            this.xmlAdressBox.TabIndex = 0;
            // 
            // buildTreeButton
            // 
            this.buildTreeButton.Location = new System.Drawing.Point(12, 38);
            this.buildTreeButton.Name = "buildTreeButton";
            this.buildTreeButton.Size = new System.Drawing.Size(75, 23);
            this.buildTreeButton.TabIndex = 1;
            this.buildTreeButton.Text = "build tree";
            this.buildTreeButton.UseVisualStyleBackColor = true;
            this.buildTreeButton.Click += new System.EventHandler(this.buildTreeButton_Click);
            // 
            // xmlTreeView
            // 
            this.xmlTreeView.Location = new System.Drawing.Point(12, 67);
            this.xmlTreeView.Name = "xmlTreeView";
            this.xmlTreeView.Size = new System.Drawing.Size(423, 371);
            this.xmlTreeView.TabIndex = 2;
            this.xmlTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.xmlTreeView_BeforeExpand);
            this.xmlTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.xmlTreeView_AfterSelect);
            // 
            // propertiesTextBox
            // 
            this.propertiesTextBox.Location = new System.Drawing.Point(472, 67);
            this.propertiesTextBox.Multiline = true;
            this.propertiesTextBox.Name = "propertiesTextBox";
            this.propertiesTextBox.ReadOnly = true;
            this.propertiesTextBox.Size = new System.Drawing.Size(296, 172);
            this.propertiesTextBox.TabIndex = 3;
            // 
            // propertiesLabel
            // 
            this.propertiesLabel.AutoSize = true;
            this.propertiesLabel.Location = new System.Drawing.Point(469, 48);
            this.propertiesLabel.Name = "propertiesLabel";
            this.propertiesLabel.Size = new System.Drawing.Size(54, 13);
            this.propertiesLabel.TabIndex = 4;
            this.propertiesLabel.Text = "Properties";
            this.propertiesLabel.Click += new System.EventHandler(this.propertiesLabel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.propertiesLabel);
            this.Controls.Add(this.propertiesTextBox);
            this.Controls.Add(this.xmlTreeView);
            this.Controls.Add(this.buildTreeButton);
            this.Controls.Add(this.xmlAdressBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xmlAdressBox;
        private System.Windows.Forms.Button buildTreeButton;
        private System.Windows.Forms.TreeView xmlTreeView;
        private System.Windows.Forms.TextBox propertiesTextBox;
        private System.Windows.Forms.Label propertiesLabel;
    }
}