﻿namespace FeatureAdmin
{
    partial class LocationForm
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
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.FeatureTitlePanel = new System.Windows.Forms.Panel();
            this.FeatureScopeLabel = new System.Windows.Forms.Label();
            this.FeatureIdLabel = new System.Windows.Forms.Label();
            this.FeaturePanelCaption = new System.Windows.Forms.Label();
            this.FeatureNameLabel = new System.Windows.Forms.Label();
            this.LocationGrid = new System.Windows.Forms.DataGridView();
            this.LocationDetailsView = new System.Windows.Forms.ListView();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.FeatureTitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocationGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Name = "MainSplitContainer";
            this.MainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.FeatureTitlePanel);
            this.MainSplitContainer.Panel1.Controls.Add(this.LocationGrid);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.LocationDetailsView);
            this.MainSplitContainer.Size = new System.Drawing.Size(539, 503);
            this.MainSplitContainer.SplitterDistance = 321;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // FeatureTitlePanel
            // 
            this.FeatureTitlePanel.Controls.Add(this.FeatureScopeLabel);
            this.FeatureTitlePanel.Controls.Add(this.FeatureIdLabel);
            this.FeatureTitlePanel.Controls.Add(this.FeaturePanelCaption);
            this.FeatureTitlePanel.Controls.Add(this.FeatureNameLabel);
            this.FeatureTitlePanel.Location = new System.Drawing.Point(3, 3);
            this.FeatureTitlePanel.Name = "FeatureTitlePanel";
            this.FeatureTitlePanel.Size = new System.Drawing.Size(524, 30);
            this.FeatureTitlePanel.TabIndex = 3;
            // 
            // FeatureScopeLabel
            // 
            this.FeatureScopeLabel.AutoSize = true;
            this.FeatureScopeLabel.Location = new System.Drawing.Point(90, 6);
            this.FeatureScopeLabel.Name = "FeatureScopeLabel";
            this.FeatureScopeLabel.Size = new System.Drawing.Size(83, 13);
            this.FeatureScopeLabel.TabIndex = 5;
            this.FeatureScopeLabel.Text = "(Feature Scope)";
            // 
            // FeatureIdLabel
            // 
            this.FeatureIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FeatureIdLabel.AutoSize = true;
            this.FeatureIdLabel.Location = new System.Drawing.Point(354, 6);
            this.FeatureIdLabel.Name = "FeatureIdLabel";
            this.FeatureIdLabel.Size = new System.Drawing.Size(61, 13);
            this.FeatureIdLabel.TabIndex = 4;
            this.FeatureIdLabel.Text = "(Feature Id)";
            // 
            // FeaturePanelCaption
            // 
            this.FeaturePanelCaption.AutoSize = true;
            this.FeaturePanelCaption.Location = new System.Drawing.Point(9, 6);
            this.FeaturePanelCaption.Name = "FeaturePanelCaption";
            this.FeaturePanelCaption.Size = new System.Drawing.Size(43, 13);
            this.FeaturePanelCaption.TabIndex = 3;
            this.FeaturePanelCaption.Text = "Feature";
            // 
            // FeatureNameLabel
            // 
            this.FeatureNameLabel.AutoSize = true;
            this.FeatureNameLabel.Location = new System.Drawing.Point(192, 6);
            this.FeatureNameLabel.Name = "FeatureNameLabel";
            this.FeatureNameLabel.Size = new System.Drawing.Size(80, 13);
            this.FeatureNameLabel.TabIndex = 2;
            this.FeatureNameLabel.Text = "(Feature Name)";
            // 
            // LocationGrid
            // 
            this.LocationGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LocationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocationGrid.Location = new System.Drawing.Point(0, 39);
            this.LocationGrid.Name = "LocationGrid";
            this.LocationGrid.ReadOnly = true;
            this.LocationGrid.Size = new System.Drawing.Size(536, 279);
            this.LocationGrid.TabIndex = 0;
            this.LocationGrid.SelectionChanged += new System.EventHandler(this.LocationGrid_SelectionChanged);
            // 
            // LocationDetailsView
            // 
            this.LocationDetailsView.Location = new System.Drawing.Point(4, 4);
            this.LocationDetailsView.Name = "LocationDetailsView";
            this.LocationDetailsView.Size = new System.Drawing.Size(532, 171);
            this.LocationDetailsView.TabIndex = 0;
            this.LocationDetailsView.UseCompatibleStateImageBehavior = false;
            this.LocationDetailsView.View = System.Windows.Forms.View.Details;
            // 
            // LocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 503);
            this.Controls.Add(this.MainSplitContainer);
            this.Name = "LocationForm";
            this.Text = "LocationForm";
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            this.MainSplitContainer.ResumeLayout(false);
            this.FeatureTitlePanel.ResumeLayout(false);
            this.FeatureTitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocationGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.DataGridView LocationGrid;
        private System.Windows.Forms.Panel FeatureTitlePanel;
        private System.Windows.Forms.Label FeatureIdLabel;
        private System.Windows.Forms.Label FeaturePanelCaption;
        private System.Windows.Forms.Label FeatureNameLabel;
        private System.Windows.Forms.ListView LocationDetailsView;
        private System.Windows.Forms.Label FeatureScopeLabel;
    }
}