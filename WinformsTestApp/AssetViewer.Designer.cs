﻿using System.Windows.Forms;

namespace WinformsTestApp
{
    partial class AssetViewer
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbExplore = new System.Windows.Forms.TabPage();
            this.cbAssetsFile = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbApk = new System.Windows.Forms.TextBox();
            this.tpCompare = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tpLog = new System.Windows.Forms.TabPage();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.etMain = new WinformsTestApp.ExploreTree();
            this.etLeft = new WinformsTestApp.ExploreTree();
            this.etRight = new WinformsTestApp.ExploreTree();
            this.tabControl1.SuspendLayout();
            this.tbExplore.SuspendLayout();
            this.tpCompare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tpLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbExplore);
            this.tabControl1.Controls.Add(this.tpCompare);
            this.tabControl1.Controls.Add(this.tpLog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(923, 539);
            this.tabControl1.TabIndex = 5;
            // 
            // tbExplore
            // 
            this.tbExplore.Controls.Add(this.cbAssetsFile);
            this.tbExplore.Controls.Add(this.label2);
            this.tbExplore.Controls.Add(this.etMain);
            this.tbExplore.Controls.Add(this.btnLoad);
            this.tbExplore.Controls.Add(this.label1);
            this.tbExplore.Controls.Add(this.tbApk);
            this.tbExplore.Location = new System.Drawing.Point(4, 29);
            this.tbExplore.Name = "tbExplore";
            this.tbExplore.Padding = new System.Windows.Forms.Padding(3);
            this.tbExplore.Size = new System.Drawing.Size(915, 506);
            this.tbExplore.TabIndex = 0;
            this.tbExplore.Text = "Explore";
            this.tbExplore.UseVisualStyleBackColor = true;
            // 
            // cbAssetsFile
            // 
            this.cbAssetsFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAssetsFile.FormattingEnabled = true;
            this.cbAssetsFile.Location = new System.Drawing.Point(582, 6);
            this.cbAssetsFile.Name = "cbAssetsFile";
            this.cbAssetsFile.Size = new System.Drawing.Size(327, 28);
            this.cbAssetsFile.TabIndex = 5;
            this.cbAssetsFile.SelectedIndexChanged += new System.EventHandler(this.CbAssetsFile_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Assets File:";
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(391, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 41);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "APK:";
            // 
            // tbApk
            // 
            this.tbApk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApk.Location = new System.Drawing.Point(56, 7);
            this.tbApk.Name = "tbApk";
            this.tbApk.Size = new System.Drawing.Size(329, 26);
            this.tbApk.TabIndex = 0;
            this.tbApk.Text = "c:\\users\\vr\\desktop\\platform-tools_r28.0.3-windows\\base.apk";
            // 
            // tpCompare
            // 
            this.tpCompare.Controls.Add(this.label3);
            this.tpCompare.Controls.Add(this.label4);
            this.tpCompare.Controls.Add(this.splitContainer1);
            this.tpCompare.Location = new System.Drawing.Point(4, 29);
            this.tpCompare.Name = "tpCompare";
            this.tpCompare.Padding = new System.Windows.Forms.Padding(3);
            this.tpCompare.Size = new System.Drawing.Size(915, 506);
            this.tpCompare.TabIndex = 1;
            this.tpCompare.Text = "Clone Test";
            this.tpCompare.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer1.Panel1MinSize = 28;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(909, 500);
            this.splitContainer1.SplitterDistance = 28;
            this.splitContainer1.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.etLeft);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.etRight);
            this.splitContainer2.Size = new System.Drawing.Size(909, 468);
            this.splitContainer2.SplitterDistance = 198;
            this.splitContainer2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Original Object";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(797, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cloned Object";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tpLog
            // 
            this.tpLog.Controls.Add(this.btnClearLog);
            this.tpLog.Controls.Add(this.tbLog);
            this.tpLog.Location = new System.Drawing.Point(4, 29);
            this.tpLog.Name = "tpLog";
            this.tpLog.Size = new System.Drawing.Size(915, 506);
            this.tpLog.TabIndex = 2;
            this.tpLog.Text = "Log";
            this.tpLog.UseVisualStyleBackColor = true;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(13, 3);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(105, 40);
            this.btnClearLog.TabIndex = 1;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.BtnClearLog_Click);
            // 
            // tbLog
            // 
            this.tbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLog.Location = new System.Drawing.Point(0, 49);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(890, 445);
            this.tbLog.TabIndex = 0;
            // 
            // etMain
            // 
            this.etMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.etMain.AutoExpand = true;
            this.etMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.etMain.DataSource = null;
            this.etMain.HighlightColor = System.Drawing.Color.LightBlue;
            this.etMain.Location = new System.Drawing.Point(6, 51);
            this.etMain.Name = "etMain";
            this.etMain.SelectedNode = null;
            this.etMain.Size = new System.Drawing.Size(903, 449);
            this.etMain.TabIndex = 3;
            this.etMain.NodeRightClicked += new System.EventHandler<System.Windows.Forms.TreeNodeMouseClickEventArgs>(this.EtMain_NodeRightClicked);
            // 
            // etLeft
            // 
            this.etLeft.AutoExpand = true;
            this.etLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.etLeft.DataSource = null;
            this.etLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.etLeft.HighlightColor = System.Drawing.Color.Thistle;
            this.etLeft.Location = new System.Drawing.Point(0, 0);
            this.etLeft.Name = "etLeft";
            this.etLeft.SelectedNode = null;
            this.etLeft.Size = new System.Drawing.Size(198, 468);
            this.etLeft.TabIndex = 0;
            // 
            // etRight
            // 
            this.etRight.AutoExpand = true;
            this.etRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.etRight.DataSource = null;
            this.etRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.etRight.HighlightColor = System.Drawing.Color.PaleGoldenrod;
            this.etRight.Location = new System.Drawing.Point(0, 0);
            this.etRight.Name = "etRight";
            this.etRight.SelectedNode = null;
            this.etRight.Size = new System.Drawing.Size(707, 468);
            this.etRight.TabIndex = 0;
            // 
            // AssetViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 539);
            this.Controls.Add(this.tabControl1);
            this.Name = "AssetViewer";
            this.Text = "Asset Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tbExplore.ResumeLayout(false);
            this.tbExplore.PerformLayout();
            this.tpCompare.ResumeLayout(false);
            this.tpCompare.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tpLog.ResumeLayout(false);
            this.tpLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbExplore;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbApk;
        private System.Windows.Forms.TabPage tpCompare;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private ExploreTree etLeft;
        private ExploreTree etRight;
        private ExploreTree etMain;
        private System.Windows.Forms.ComboBox cbAssetsFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tpLog;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private SplitContainer splitContainer1;
    }
}
