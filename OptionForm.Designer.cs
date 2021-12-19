﻿namespace FanCtrl
{
    partial class OptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
            this.mIntervalGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mIntervalTextBox = new System.Windows.Forms.TextBox();
            this.mMinimizeCheckBox = new System.Windows.Forms.CheckBox();
            this.mStartupCheckBox = new System.Windows.Forms.CheckBox();
            this.mOKButton = new System.Windows.Forms.Button();
            this.mToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mLibraryGroupBox = new System.Windows.Forms.GroupBox();
            this.mOHMMemoryCheckBox = new System.Windows.Forms.CheckBox();
            this.mLHMMemoryCheckBox = new System.Windows.Forms.CheckBox();
            this.mOHMStorageCheckBox = new System.Windows.Forms.CheckBox();
            this.mOHMControllerCheckBox = new System.Windows.Forms.CheckBox();
            this.mOHMGPUCheckBox = new System.Windows.Forms.CheckBox();
            this.mOHMMBCheckBox = new System.Windows.Forms.CheckBox();
            this.mOHMCPUCheckBox = new System.Windows.Forms.CheckBox();
            this.mOHMCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mLHMStorageCheckBox = new System.Windows.Forms.CheckBox();
            this.mLHMControllerCheckBox = new System.Windows.Forms.CheckBox();
            this.mLHMGPUCheckBox = new System.Windows.Forms.CheckBox();
            this.mLHMMBCheckBox = new System.Windows.Forms.CheckBox();
            this.mLHMCPUCheckBox = new System.Windows.Forms.CheckBox();
            this.mLHMCheckBox = new System.Windows.Forms.CheckBox();
            this.mGigabyteGPUCheckBox = new System.Windows.Forms.CheckBox();
            this.mGigabyteCPUCheckBox = new System.Windows.Forms.CheckBox();
            this.mGigabyteCheckBox = new System.Windows.Forms.CheckBox();
            this.mDimmCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mNvApiCheckBox = new System.Windows.Forms.CheckBox();
            this.mHWInfoCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mRGBnFCButton = new System.Windows.Forms.Button();
            this.mRGBnFCCheckBox = new System.Windows.Forms.CheckBox();
            this.mCLCButton = new System.Windows.Forms.Button();
            this.mCLCCheckBox = new System.Windows.Forms.CheckBox();
            this.mKrakenLCDCheckBox = new System.Windows.Forms.CheckBox();
            this.mKrakenLightCheckBox = new System.Windows.Forms.CheckBox();
            this.mEtcGroupBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mKrakenLCDButton = new System.Windows.Forms.Button();
            this.mStartupDelayTextBox = new System.Windows.Forms.TextBox();
            this.mKrakenLightButton = new System.Windows.Forms.Button();
            this.mStartupDelayLabel = new System.Windows.Forms.Label();
            this.mFahrenheitCheckBox = new System.Windows.Forms.CheckBox();
            this.mAnimationCheckBox = new System.Windows.Forms.CheckBox();
            this.mResetButton = new System.Windows.Forms.Button();
            this.mIntervalGroupBox.SuspendLayout();
            this.mLibraryGroupBox.SuspendLayout();
            this.mEtcGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mIntervalGroupBox
            // 
            this.mIntervalGroupBox.Controls.Add(this.label1);
            this.mIntervalGroupBox.Controls.Add(this.mIntervalTextBox);
            this.mIntervalGroupBox.Location = new System.Drawing.Point(12, 12);
            this.mIntervalGroupBox.Name = "mIntervalGroupBox";
            this.mIntervalGroupBox.Size = new System.Drawing.Size(188, 58);
            this.mIntervalGroupBox.TabIndex = 0;
            this.mIntervalGroupBox.TabStop = false;
            this.mIntervalGroupBox.Text = "Interval";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ms";
            // 
            // mIntervalTextBox
            // 
            this.mIntervalTextBox.Location = new System.Drawing.Point(13, 21);
            this.mIntervalTextBox.MaxLength = 4;
            this.mIntervalTextBox.Name = "mIntervalTextBox";
            this.mIntervalTextBox.Size = new System.Drawing.Size(143, 28);
            this.mIntervalTextBox.TabIndex = 0;
            // 
            // mMinimizeCheckBox
            // 
            this.mMinimizeCheckBox.AutoSize = true;
            this.mMinimizeCheckBox.Location = new System.Drawing.Point(5, 294);
            this.mMinimizeCheckBox.Name = "mMinimizeCheckBox";
            this.mMinimizeCheckBox.Size = new System.Drawing.Size(155, 22);
            this.mMinimizeCheckBox.TabIndex = 28;
            this.mMinimizeCheckBox.Text = "Start minimized";
            this.mMinimizeCheckBox.UseVisualStyleBackColor = true;
            // 
            // mStartupCheckBox
            // 
            this.mStartupCheckBox.AutoSize = true;
            this.mStartupCheckBox.Location = new System.Drawing.Point(5, 319);
            this.mStartupCheckBox.Name = "mStartupCheckBox";
            this.mStartupCheckBox.Size = new System.Drawing.Size(188, 22);
            this.mStartupCheckBox.TabIndex = 29;
            this.mStartupCheckBox.Text = "Start with Windows";
            this.mStartupCheckBox.UseVisualStyleBackColor = true;
            // 
            // mOKButton
            // 
            this.mOKButton.Location = new System.Drawing.Point(280, 561);
            this.mOKButton.Name = "mOKButton";
            this.mOKButton.Size = new System.Drawing.Size(116, 38);
            this.mOKButton.TabIndex = 32;
            this.mOKButton.Text = "OK";
            this.mOKButton.UseVisualStyleBackColor = true;
            this.mOKButton.Click += new System.EventHandler(this.onOKButtonClick);
            // 
            // mToolTip
            // 
            this.mToolTip.IsBalloon = true;
            // 
            // mLibraryGroupBox
            // 
            this.mLibraryGroupBox.Controls.Add(this.mOHMMemoryCheckBox);
            this.mLibraryGroupBox.Controls.Add(this.mLHMMemoryCheckBox);
            this.mLibraryGroupBox.Controls.Add(this.mOHMStorageCheckBox);
            this.mLibraryGroupBox.Controls.Add(this.mOHMControllerCheckBox);
            this.mLibraryGroupBox.Controls.Add(this.mOHMGPUCheckBox);
            this.mLibraryGroupBox.Controls.Add(this.mOHMMBCheckBox);
            this.mLibraryGroupBox.Controls.Add(this.mOHMCPUCheckBox);
            this.mLibraryGroupBox.Controls.Add(this.mOHMCheckBox);
            this.mLibraryGroupBox.Controls.Add(this.label4);
            this.mLibraryGroupBox.Controls.Add(this.mLHMStorageCheckBox);
            this.mLibraryGroupBox.Controls.Add(this.mLHMControllerCheckBox);
            this.mLibraryGroupBox.Controls.Add(this.mLHMGPUCheckBox);
            this.mLibraryGroupBox.Controls.Add(this.mLHMMBCheckBox);
            this.mLibraryGroupBox.Controls.Add(this.mLHMCPUCheckBox);
            this.mLibraryGroupBox.Controls.Add(this.mLHMCheckBox);
            this.mLibraryGroupBox.Controls.Add(this.mGigabyteGPUCheckBox);
            this.mLibraryGroupBox.Controls.Add(this.mGigabyteCPUCheckBox);
            this.mLibraryGroupBox.Controls.Add(this.mGigabyteCheckBox);
            this.mLibraryGroupBox.Controls.Add(this.label2);
            this.mLibraryGroupBox.Location = new System.Drawing.Point(12, 77);
            this.mLibraryGroupBox.Name = "mLibraryGroupBox";
            this.mLibraryGroupBox.Size = new System.Drawing.Size(188, 478);
            this.mLibraryGroupBox.TabIndex = 5;
            this.mLibraryGroupBox.TabStop = false;
            this.mLibraryGroupBox.Text = "Library";
            // 
            // mOHMMemoryCheckBox
            // 
            this.mOHMMemoryCheckBox.AutoSize = true;
            this.mOHMMemoryCheckBox.Location = new System.Drawing.Point(17, 389);
            this.mOHMMemoryCheckBox.Name = "mOHMMemoryCheckBox";
            this.mOHMMemoryCheckBox.Size = new System.Drawing.Size(101, 22);
            this.mOHMMemoryCheckBox.TabIndex = 34;
            this.mOHMMemoryCheckBox.Text = "Memory";
            this.mOHMMemoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // mLHMMemoryCheckBox
            // 
            this.mLHMMemoryCheckBox.AutoSize = true;
            this.mLHMMemoryCheckBox.Location = new System.Drawing.Point(17, 228);
            this.mLHMMemoryCheckBox.Name = "mLHMMemoryCheckBox";
            this.mLHMMemoryCheckBox.Size = new System.Drawing.Size(101, 22);
            this.mLHMMemoryCheckBox.TabIndex = 33;
            this.mLHMMemoryCheckBox.Text = "Memory";
            this.mLHMMemoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // mOHMStorageCheckBox
            // 
            this.mOHMStorageCheckBox.AutoSize = true;
            this.mOHMStorageCheckBox.Location = new System.Drawing.Point(17, 367);
            this.mOHMStorageCheckBox.Name = "mOHMStorageCheckBox";
            this.mOHMStorageCheckBox.Size = new System.Drawing.Size(97, 22);
            this.mOHMStorageCheckBox.TabIndex = 15;
            this.mOHMStorageCheckBox.Text = "Storage";
            this.mOHMStorageCheckBox.UseVisualStyleBackColor = true;
            // 
            // mOHMControllerCheckBox
            // 
            this.mOHMControllerCheckBox.AutoSize = true;
            this.mOHMControllerCheckBox.Location = new System.Drawing.Point(17, 345);
            this.mOHMControllerCheckBox.Name = "mOHMControllerCheckBox";
            this.mOHMControllerCheckBox.Size = new System.Drawing.Size(111, 22);
            this.mOHMControllerCheckBox.TabIndex = 14;
            this.mOHMControllerCheckBox.Text = "Controller";
            this.mOHMControllerCheckBox.UseVisualStyleBackColor = true;
            // 
            // mOHMGPUCheckBox
            // 
            this.mOHMGPUCheckBox.AutoSize = true;
            this.mOHMGPUCheckBox.Location = new System.Drawing.Point(17, 323);
            this.mOHMGPUCheckBox.Name = "mOHMGPUCheckBox";
            this.mOHMGPUCheckBox.Size = new System.Drawing.Size(68, 22);
            this.mOHMGPUCheckBox.TabIndex = 13;
            this.mOHMGPUCheckBox.Text = "GPU";
            this.mOHMGPUCheckBox.UseVisualStyleBackColor = true;
            // 
            // mOHMMBCheckBox
            // 
            this.mOHMMBCheckBox.AutoSize = true;
            this.mOHMMBCheckBox.Location = new System.Drawing.Point(17, 301);
            this.mOHMMBCheckBox.Name = "mOHMMBCheckBox";
            this.mOHMMBCheckBox.Size = new System.Drawing.Size(138, 22);
            this.mOHMMBCheckBox.TabIndex = 12;
            this.mOHMMBCheckBox.Text = "Motherboard";
            this.mOHMMBCheckBox.UseVisualStyleBackColor = true;
            // 
            // mOHMCPUCheckBox
            // 
            this.mOHMCPUCheckBox.AutoSize = true;
            this.mOHMCPUCheckBox.Location = new System.Drawing.Point(17, 279);
            this.mOHMCPUCheckBox.Name = "mOHMCPUCheckBox";
            this.mOHMCPUCheckBox.Size = new System.Drawing.Size(68, 22);
            this.mOHMCPUCheckBox.TabIndex = 11;
            this.mOHMCPUCheckBox.Text = "CPU";
            this.mOHMCPUCheckBox.UseVisualStyleBackColor = true;
            // 
            // mOHMCheckBox
            // 
            this.mOHMCheckBox.AutoSize = true;
            this.mOHMCheckBox.Location = new System.Drawing.Point(6, 257);
            this.mOHMCheckBox.Name = "mOHMCheckBox";
            this.mOHMCheckBox.Size = new System.Drawing.Size(215, 22);
            this.mOHMCheckBox.TabIndex = 10;
            this.mOHMCheckBox.Text = "OpenHardwareMonitor";
            this.mOHMCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(5, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 2);
            this.label4.TabIndex = 20;
            // 
            // mLHMStorageCheckBox
            // 
            this.mLHMStorageCheckBox.AutoSize = true;
            this.mLHMStorageCheckBox.Location = new System.Drawing.Point(17, 206);
            this.mLHMStorageCheckBox.Name = "mLHMStorageCheckBox";
            this.mLHMStorageCheckBox.Size = new System.Drawing.Size(97, 22);
            this.mLHMStorageCheckBox.TabIndex = 9;
            this.mLHMStorageCheckBox.Text = "Storage";
            this.mLHMStorageCheckBox.UseVisualStyleBackColor = true;
            // 
            // mLHMControllerCheckBox
            // 
            this.mLHMControllerCheckBox.AutoSize = true;
            this.mLHMControllerCheckBox.Location = new System.Drawing.Point(17, 184);
            this.mLHMControllerCheckBox.Name = "mLHMControllerCheckBox";
            this.mLHMControllerCheckBox.Size = new System.Drawing.Size(111, 22);
            this.mLHMControllerCheckBox.TabIndex = 8;
            this.mLHMControllerCheckBox.Text = "Controller";
            this.mLHMControllerCheckBox.UseVisualStyleBackColor = true;
            // 
            // mLHMGPUCheckBox
            // 
            this.mLHMGPUCheckBox.AutoSize = true;
            this.mLHMGPUCheckBox.Location = new System.Drawing.Point(17, 162);
            this.mLHMGPUCheckBox.Name = "mLHMGPUCheckBox";
            this.mLHMGPUCheckBox.Size = new System.Drawing.Size(68, 22);
            this.mLHMGPUCheckBox.TabIndex = 7;
            this.mLHMGPUCheckBox.Text = "GPU";
            this.mLHMGPUCheckBox.UseVisualStyleBackColor = true;
            // 
            // mLHMMBCheckBox
            // 
            this.mLHMMBCheckBox.AutoSize = true;
            this.mLHMMBCheckBox.Location = new System.Drawing.Point(17, 140);
            this.mLHMMBCheckBox.Name = "mLHMMBCheckBox";
            this.mLHMMBCheckBox.Size = new System.Drawing.Size(138, 22);
            this.mLHMMBCheckBox.TabIndex = 6;
            this.mLHMMBCheckBox.Text = "Motherboard";
            this.mLHMMBCheckBox.UseVisualStyleBackColor = true;
            // 
            // mLHMCPUCheckBox
            // 
            this.mLHMCPUCheckBox.AutoSize = true;
            this.mLHMCPUCheckBox.Location = new System.Drawing.Point(17, 118);
            this.mLHMCPUCheckBox.Name = "mLHMCPUCheckBox";
            this.mLHMCPUCheckBox.Size = new System.Drawing.Size(68, 22);
            this.mLHMCPUCheckBox.TabIndex = 5;
            this.mLHMCPUCheckBox.Text = "CPU";
            this.mLHMCPUCheckBox.UseVisualStyleBackColor = true;
            // 
            // mLHMCheckBox
            // 
            this.mLHMCheckBox.AutoSize = true;
            this.mLHMCheckBox.Location = new System.Drawing.Point(6, 96);
            this.mLHMCheckBox.Name = "mLHMCheckBox";
            this.mLHMCheckBox.Size = new System.Drawing.Size(210, 22);
            this.mLHMCheckBox.TabIndex = 4;
            this.mLHMCheckBox.Text = "LibreHardwareMonitor";
            this.mLHMCheckBox.UseVisualStyleBackColor = true;
            // 
            // mGigabyteGPUCheckBox
            // 
            this.mGigabyteGPUCheckBox.AutoSize = true;
            this.mGigabyteGPUCheckBox.Location = new System.Drawing.Point(17, 64);
            this.mGigabyteGPUCheckBox.Name = "mGigabyteGPUCheckBox";
            this.mGigabyteGPUCheckBox.Size = new System.Drawing.Size(68, 22);
            this.mGigabyteGPUCheckBox.TabIndex = 3;
            this.mGigabyteGPUCheckBox.Text = "GPU";
            this.mGigabyteGPUCheckBox.UseVisualStyleBackColor = true;
            // 
            // mGigabyteCPUCheckBox
            // 
            this.mGigabyteCPUCheckBox.AutoSize = true;
            this.mGigabyteCPUCheckBox.Location = new System.Drawing.Point(17, 42);
            this.mGigabyteCPUCheckBox.Name = "mGigabyteCPUCheckBox";
            this.mGigabyteCPUCheckBox.Size = new System.Drawing.Size(184, 22);
            this.mGigabyteCPUCheckBox.TabIndex = 2;
            this.mGigabyteCPUCheckBox.Text = "CPU, Motherboard";
            this.mGigabyteCPUCheckBox.UseVisualStyleBackColor = true;
            // 
            // mGigabyteCheckBox
            // 
            this.mGigabyteCheckBox.AutoSize = true;
            this.mGigabyteCheckBox.Location = new System.Drawing.Point(6, 20);
            this.mGigabyteCheckBox.Name = "mGigabyteCheckBox";
            this.mGigabyteCheckBox.Size = new System.Drawing.Size(245, 22);
            this.mGigabyteCheckBox.TabIndex = 1;
            this.mGigabyteCheckBox.Text = "Gigabyte (with AppCenter)";
            this.mGigabyteCheckBox.UseVisualStyleBackColor = true;
            // 
            // mDimmCheckBox
            // 
            this.mDimmCheckBox.AutoSize = true;
            this.mDimmCheckBox.Location = new System.Drawing.Point(5, 198);
            this.mDimmCheckBox.Name = "mDimmCheckBox";
            this.mDimmCheckBox.Size = new System.Drawing.Size(141, 22);
            this.mDimmCheckBox.TabIndex = 17;
            this.mDimmCheckBox.Text = "DIMM sensor";
            this.mDimmCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(5, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 2);
            this.label2.TabIndex = 4;
            // 
            // mNvApiCheckBox
            // 
            this.mNvApiCheckBox.AutoSize = true;
            this.mNvApiCheckBox.Location = new System.Drawing.Point(5, 173);
            this.mNvApiCheckBox.Name = "mNvApiCheckBox";
            this.mNvApiCheckBox.Size = new System.Drawing.Size(149, 22);
            this.mNvApiCheckBox.TabIndex = 16;
            this.mNvApiCheckBox.Text = "NvAPIWrapper";
            this.mNvApiCheckBox.UseVisualStyleBackColor = true;
            // 
            // mHWInfoCheckBox
            // 
            this.mHWInfoCheckBox.AutoSize = true;
            this.mHWInfoCheckBox.Location = new System.Drawing.Point(5, 149);
            this.mHWInfoCheckBox.Name = "mHWInfoCheckBox";
            this.mHWInfoCheckBox.Size = new System.Drawing.Size(97, 22);
            this.mHWInfoCheckBox.TabIndex = 24;
            this.mHWInfoCheckBox.Text = "HWiNFO";
            this.mHWInfoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(5, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 2);
            this.label9.TabIndex = 32;
            // 
            // mRGBnFCButton
            // 
            this.mRGBnFCButton.Location = new System.Drawing.Point(117, 106);
            this.mRGBnFCButton.Name = "mRGBnFCButton";
            this.mRGBnFCButton.Size = new System.Drawing.Size(64, 23);
            this.mRGBnFCButton.TabIndex = 23;
            this.mRGBnFCButton.Text = "Lighting";
            this.mRGBnFCButton.UseVisualStyleBackColor = true;
            this.mRGBnFCButton.Click += new System.EventHandler(this.onRGBnFCButtonClick);
            // 
            // mRGBnFCCheckBox
            // 
            this.mRGBnFCCheckBox.Location = new System.Drawing.Point(5, 103);
            this.mRGBnFCCheckBox.Name = "mRGBnFCCheckBox";
            this.mRGBnFCCheckBox.Size = new System.Drawing.Size(104, 30);
            this.mRGBnFCCheckBox.TabIndex = 22;
            this.mRGBnFCCheckBox.Text = "NZXT RGB＆Fan Controller";
            this.mRGBnFCCheckBox.UseVisualStyleBackColor = true;
            // 
            // mCLCButton
            // 
            this.mCLCButton.Location = new System.Drawing.Point(117, 76);
            this.mCLCButton.Name = "mCLCButton";
            this.mCLCButton.Size = new System.Drawing.Size(64, 23);
            this.mCLCButton.TabIndex = 21;
            this.mCLCButton.Text = "Lighting";
            this.mCLCButton.UseVisualStyleBackColor = true;
            this.mCLCButton.Click += new System.EventHandler(this.onCLCButtonClick);
            // 
            // mCLCCheckBox
            // 
            this.mCLCCheckBox.AutoSize = true;
            this.mCLCCheckBox.Location = new System.Drawing.Point(5, 80);
            this.mCLCCheckBox.Name = "mCLCCheckBox";
            this.mCLCCheckBox.Size = new System.Drawing.Size(119, 22);
            this.mCLCCheckBox.TabIndex = 21;
            this.mCLCCheckBox.Text = "EVGA CLC";
            this.mCLCCheckBox.UseVisualStyleBackColor = true;
            // 
            // mKrakenLCDCheckBox
            // 
            this.mKrakenLCDCheckBox.AutoSize = true;
            this.mKrakenLCDCheckBox.Location = new System.Drawing.Point(5, 21);
            this.mKrakenLCDCheckBox.Name = "mKrakenLCDCheckBox";
            this.mKrakenLCDCheckBox.Size = new System.Drawing.Size(157, 22);
            this.mKrakenLCDCheckBox.TabIndex = 18;
            this.mKrakenLCDCheckBox.Text = "NZXT Kraken Z";
            this.mKrakenLCDCheckBox.UseVisualStyleBackColor = true;
            // 
            // mKrakenLightCheckBox
            // 
            this.mKrakenLightCheckBox.AutoSize = true;
            this.mKrakenLightCheckBox.Location = new System.Drawing.Point(5, 51);
            this.mKrakenLightCheckBox.Name = "mKrakenLightCheckBox";
            this.mKrakenLightCheckBox.Size = new System.Drawing.Size(157, 22);
            this.mKrakenLightCheckBox.TabIndex = 18;
            this.mKrakenLightCheckBox.Text = "NZXT Kraken X";
            this.mKrakenLightCheckBox.UseVisualStyleBackColor = true;
            // 
            // mEtcGroupBox
            // 
            this.mEtcGroupBox.Controls.Add(this.label10);
            this.mEtcGroupBox.Controls.Add(this.mKrakenLCDButton);
            this.mEtcGroupBox.Controls.Add(this.mStartupDelayTextBox);
            this.mEtcGroupBox.Controls.Add(this.mKrakenLightButton);
            this.mEtcGroupBox.Controls.Add(this.mStartupDelayLabel);
            this.mEtcGroupBox.Controls.Add(this.mFahrenheitCheckBox);
            this.mEtcGroupBox.Controls.Add(this.mHWInfoCheckBox);
            this.mEtcGroupBox.Controls.Add(this.mAnimationCheckBox);
            this.mEtcGroupBox.Controls.Add(this.mKrakenLCDCheckBox);
            this.mEtcGroupBox.Controls.Add(this.label9);
            this.mEtcGroupBox.Controls.Add(this.mKrakenLightCheckBox);
            this.mEtcGroupBox.Controls.Add(this.mStartupCheckBox);
            this.mEtcGroupBox.Controls.Add(this.mMinimizeCheckBox);
            this.mEtcGroupBox.Controls.Add(this.mCLCButton);
            this.mEtcGroupBox.Controls.Add(this.mCLCCheckBox);
            this.mEtcGroupBox.Controls.Add(this.mRGBnFCCheckBox);
            this.mEtcGroupBox.Controls.Add(this.mRGBnFCButton);
            this.mEtcGroupBox.Controls.Add(this.mDimmCheckBox);
            this.mEtcGroupBox.Controls.Add(this.mNvApiCheckBox);
            this.mEtcGroupBox.Location = new System.Drawing.Point(210, 77);
            this.mEtcGroupBox.Name = "mEtcGroupBox";
            this.mEtcGroupBox.Size = new System.Drawing.Size(188, 478);
            this.mEtcGroupBox.TabIndex = 5;
            this.mEtcGroupBox.TabStop = false;
            this.mEtcGroupBox.Text = "Etc";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(3, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 2);
            this.label10.TabIndex = 33;
            // 
            // mKrakenLCDButton
            // 
            this.mKrakenLCDButton.Location = new System.Drawing.Point(117, 17);
            this.mKrakenLCDButton.Name = "mKrakenLCDButton";
            this.mKrakenLCDButton.Size = new System.Drawing.Size(64, 23);
            this.mKrakenLCDButton.TabIndex = 19;
            this.mKrakenLCDButton.Text = "LCD";
            this.mKrakenLCDButton.UseVisualStyleBackColor = true;
            this.mKrakenLCDButton.Click += new System.EventHandler(this.onKrakenZButtonClick);
            // 
            // mStartupDelayTextBox
            // 
            this.mStartupDelayTextBox.Location = new System.Drawing.Point(110, 338);
            this.mStartupDelayTextBox.MaxLength = 2;
            this.mStartupDelayTextBox.Name = "mStartupDelayTextBox";
            this.mStartupDelayTextBox.Size = new System.Drawing.Size(73, 28);
            this.mStartupDelayTextBox.TabIndex = 30;
            this.mStartupDelayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mKrakenLightButton
            // 
            this.mKrakenLightButton.Location = new System.Drawing.Point(117, 47);
            this.mKrakenLightButton.Name = "mKrakenLightButton";
            this.mKrakenLightButton.Size = new System.Drawing.Size(64, 23);
            this.mKrakenLightButton.TabIndex = 20;
            this.mKrakenLightButton.Text = "Lighting";
            this.mKrakenLightButton.UseVisualStyleBackColor = true;
            this.mKrakenLightButton.Click += new System.EventHandler(this.onKrakenXButtonClick);
            // 
            // mStartupDelayLabel
            // 
            this.mStartupDelayLabel.AutoSize = true;
            this.mStartupDelayLabel.Location = new System.Drawing.Point(22, 343);
            this.mStartupDelayLabel.Name = "mStartupDelayLabel";
            this.mStartupDelayLabel.Size = new System.Drawing.Size(112, 18);
            this.mStartupDelayLabel.TabIndex = 15;
            this.mStartupDelayLabel.Text = "Delay(sec) : ";
            // 
            // mFahrenheitCheckBox
            // 
            this.mFahrenheitCheckBox.AutoSize = true;
            this.mFahrenheitCheckBox.Location = new System.Drawing.Point(5, 269);
            this.mFahrenheitCheckBox.Name = "mFahrenheitCheckBox";
            this.mFahrenheitCheckBox.Size = new System.Drawing.Size(151, 22);
            this.mFahrenheitCheckBox.TabIndex = 27;
            this.mFahrenheitCheckBox.Text = "Fahrenheit (°F)";
            this.mFahrenheitCheckBox.UseVisualStyleBackColor = true;
            // 
            // mAnimationCheckBox
            // 
            this.mAnimationCheckBox.AutoSize = true;
            this.mAnimationCheckBox.Location = new System.Drawing.Point(5, 244);
            this.mAnimationCheckBox.Name = "mAnimationCheckBox";
            this.mAnimationCheckBox.Size = new System.Drawing.Size(193, 22);
            this.mAnimationCheckBox.TabIndex = 26;
            this.mAnimationCheckBox.Text = "Tray Icon animation";
            this.mAnimationCheckBox.UseVisualStyleBackColor = true;
            // 
            // mResetButton
            // 
            this.mResetButton.Location = new System.Drawing.Point(208, 561);
            this.mResetButton.Name = "mResetButton";
            this.mResetButton.Size = new System.Drawing.Size(66, 38);
            this.mResetButton.TabIndex = 31;
            this.mResetButton.Text = "Reset";
            this.mResetButton.UseVisualStyleBackColor = true;
            this.mResetButton.Click += new System.EventHandler(this.onResetButtonClick);
            // 
            // OptionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(406, 607);
            this.Controls.Add(this.mResetButton);
            this.Controls.Add(this.mLibraryGroupBox);
            this.Controls.Add(this.mEtcGroupBox);
            this.Controls.Add(this.mOKButton);
            this.Controls.Add(this.mIntervalGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Option";
            this.mIntervalGroupBox.ResumeLayout(false);
            this.mIntervalGroupBox.PerformLayout();
            this.mLibraryGroupBox.ResumeLayout(false);
            this.mLibraryGroupBox.PerformLayout();
            this.mEtcGroupBox.ResumeLayout(false);
            this.mEtcGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mIntervalGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mIntervalTextBox;
        private System.Windows.Forms.CheckBox mMinimizeCheckBox;
        private System.Windows.Forms.CheckBox mStartupCheckBox;
        private System.Windows.Forms.Button mOKButton;
        private System.Windows.Forms.ToolTip mToolTip;
        private System.Windows.Forms.GroupBox mLibraryGroupBox;
        private System.Windows.Forms.GroupBox mEtcGroupBox;
        private System.Windows.Forms.CheckBox mNvApiCheckBox;
        private System.Windows.Forms.CheckBox mKrakenLCDCheckBox;
        private System.Windows.Forms.CheckBox mKrakenLightCheckBox;
        private System.Windows.Forms.Button mCLCButton;
        private System.Windows.Forms.Button mKrakenLCDButton;
        private System.Windows.Forms.Button mKrakenLightButton;
        private System.Windows.Forms.CheckBox mCLCCheckBox;
        private System.Windows.Forms.CheckBox mGigabyteCheckBox;
        private System.Windows.Forms.CheckBox mAnimationCheckBox;
        private System.Windows.Forms.CheckBox mDimmCheckBox;
        private System.Windows.Forms.CheckBox mFahrenheitCheckBox;
        private System.Windows.Forms.CheckBox mRGBnFCCheckBox;
        private System.Windows.Forms.Button mRGBnFCButton;
        private System.Windows.Forms.Label mStartupDelayLabel;
        private System.Windows.Forms.TextBox mStartupDelayTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox mLHMControllerCheckBox;
        private System.Windows.Forms.CheckBox mLHMGPUCheckBox;
        private System.Windows.Forms.CheckBox mLHMMBCheckBox;
        private System.Windows.Forms.CheckBox mLHMCPUCheckBox;
        private System.Windows.Forms.CheckBox mLHMCheckBox;
        private System.Windows.Forms.CheckBox mGigabyteGPUCheckBox;
        private System.Windows.Forms.CheckBox mGigabyteCPUCheckBox;
        private System.Windows.Forms.CheckBox mLHMStorageCheckBox;
        private System.Windows.Forms.CheckBox mOHMStorageCheckBox;
        private System.Windows.Forms.CheckBox mOHMControllerCheckBox;
        private System.Windows.Forms.CheckBox mOHMGPUCheckBox;
        private System.Windows.Forms.CheckBox mOHMMBCheckBox;
        private System.Windows.Forms.CheckBox mOHMCPUCheckBox;
        private System.Windows.Forms.CheckBox mOHMCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button mResetButton;
        private System.Windows.Forms.CheckBox mHWInfoCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox mOHMMemoryCheckBox;
        private System.Windows.Forms.CheckBox mLHMMemoryCheckBox;
        private System.Windows.Forms.Label label10;
    }
}