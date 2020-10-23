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
            this.attributesTextBox = new System.Windows.Forms.TextBox();
            this.attributesLabel = new System.Windows.Forms.Label();
            this.xmlUrlLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xmlAdressBox
            // 
            this.xmlAdressBox.Location = new System.Drawing.Point(12, 36);
            this.xmlAdressBox.Name = "xmlAdressBox";
            this.xmlAdressBox.Size = new System.Drawing.Size(271, 20);
            this.xmlAdressBox.TabIndex = 0;
            // 
            // buildTreeButton
            // 
            this.buildTreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildTreeButton.Location = new System.Drawing.Point(12, 62);
            this.buildTreeButton.Name = "buildTreeButton";
            this.buildTreeButton.Size = new System.Drawing.Size(96, 42);
            this.buildTreeButton.TabIndex = 1;
            this.buildTreeButton.Text = "build tree";
            this.buildTreeButton.UseVisualStyleBackColor = true;
            this.buildTreeButton.Click += new System.EventHandler(this.buildTreeButton_Click);
            // 
            // xmlTreeView
            // 
            this.xmlTreeView.Location = new System.Drawing.Point(12, 117);
            this.xmlTreeView.Name = "xmlTreeView";
            this.xmlTreeView.Size = new System.Drawing.Size(423, 371);
            this.xmlTreeView.TabIndex = 2;
            this.xmlTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.xmlTreeView_AfterSelect);
            // 
            // attributesTextBox
            // 
            this.attributesTextBox.Location = new System.Drawing.Point(472, 117);
            this.attributesTextBox.Multiline = true;
            this.attributesTextBox.Name = "attributesTextBox";
            this.attributesTextBox.ReadOnly = true;
            this.attributesTextBox.Size = new System.Drawing.Size(296, 172);
            this.attributesTextBox.TabIndex = 3;
            // 
            // attributesLabel
            // 
            this.attributesLabel.AutoSize = true;
            this.attributesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attributesLabel.Location = new System.Drawing.Point(469, 87);
            this.attributesLabel.Name = "attributesLabel";
            this.attributesLabel.Size = new System.Drawing.Size(68, 17);
            this.attributesLabel.TabIndex = 4;
            this.attributesLabel.Text = "Attributes";
            // 
            // xmlUrlLabel
            // 
            this.xmlUrlLabel.AutoSize = true;
            this.xmlUrlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xmlUrlLabel.Location = new System.Drawing.Point(12, 9);
            this.xmlUrlLabel.Name = "xmlUrlLabel";
            this.xmlUrlLabel.Size = new System.Drawing.Size(96, 24);
            this.xmlUrlLabel.TabIndex = 5;
            this.xmlUrlLabel.Text = "XML URL:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.xmlUrlLabel);
            this.Controls.Add(this.attributesLabel);
            this.Controls.Add(this.attributesTextBox);
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
        private System.Windows.Forms.TextBox attributesTextBox;
        private System.Windows.Forms.Label attributesLabel;
        private System.Windows.Forms.Label xmlUrlLabel;
    }
}