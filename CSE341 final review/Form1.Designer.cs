namespace CSE341_final_review
{
    partial class Form1
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
            this.HwSelectPanel = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.HWSelectInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HWSelectLoadButton = new System.Windows.Forms.Button();
            this.HWSelectNEWButton = new System.Windows.Forms.Button();
            this.HwSelectLabel = new System.Windows.Forms.Label();
            this.HWSelectRangeRB = new System.Windows.Forms.RadioButton();
            this.HWIncludeListRB = new System.Windows.Forms.RadioButton();
            this.HWViewPanel = new System.Windows.Forms.Panel();
            this.gotoMenu = new System.Windows.Forms.Button();
            this.HWViewTitle = new System.Windows.Forms.Label();
            this.SKIP = new System.Windows.Forms.Button();
            this.ShowAnswer = new System.Windows.Forms.Button();
            this.QPanelView = new System.Windows.Forms.Panel();
            this.DoneMarker = new System.Windows.Forms.Button();
            this.HwSelectPanel.SuspendLayout();
            this.HWViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HwSelectPanel
            // 
            this.HwSelectPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HwSelectPanel.Controls.Add(this.comboBox2);
            this.HwSelectPanel.Controls.Add(this.comboBox1);
            this.HwSelectPanel.Controls.Add(this.HWSelectInput);
            this.HwSelectPanel.Controls.Add(this.label1);
            this.HwSelectPanel.Controls.Add(this.HWSelectLoadButton);
            this.HwSelectPanel.Controls.Add(this.HWSelectNEWButton);
            this.HwSelectPanel.Controls.Add(this.HwSelectLabel);
            this.HwSelectPanel.Controls.Add(this.HWSelectRangeRB);
            this.HwSelectPanel.Controls.Add(this.HWIncludeListRB);
            this.HwSelectPanel.Location = new System.Drawing.Point(-6, -5);
            this.HwSelectPanel.Name = "HwSelectPanel";
            this.HwSelectPanel.Size = new System.Drawing.Size(810, 458);
            this.HwSelectPanel.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox2.Location = new System.Drawing.Point(413, 216);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(69, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox1.Location = new System.Drawing.Point(280, 216);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(64, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // HWSelectInput
            // 
            this.HWSelectInput.Location = new System.Drawing.Point(295, 124);
            this.HWSelectInput.Name = "HWSelectInput";
            this.HWSelectInput.Size = new System.Drawing.Size(100, 20);
            this.HWSelectInput.TabIndex = 9;
            this.HWSelectInput.Text = "2,4,5,7,8,9\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "through";
            // 
            // HWSelectLoadButton
            // 
            this.HWSelectLoadButton.Location = new System.Drawing.Point(32, 394);
            this.HWSelectLoadButton.Name = "HWSelectLoadButton";
            this.HWSelectLoadButton.Size = new System.Drawing.Size(140, 40);
            this.HWSelectLoadButton.TabIndex = 5;
            this.HWSelectLoadButton.Text = "Continue PREV";
            this.HWSelectLoadButton.UseVisualStyleBackColor = true;
            this.HWSelectLoadButton.Click += new System.EventHandler(this.HWSelectLoadButton_Click);
            // 
            // HWSelectNEWButton
            // 
            this.HWSelectNEWButton.Location = new System.Drawing.Point(638, 394);
            this.HWSelectNEWButton.Name = "HWSelectNEWButton";
            this.HWSelectNEWButton.Size = new System.Drawing.Size(140, 40);
            this.HWSelectNEWButton.TabIndex = 4;
            this.HWSelectNEWButton.Text = "Start NEW";
            this.HWSelectNEWButton.UseVisualStyleBackColor = true;
            this.HWSelectNEWButton.Click += new System.EventHandler(this.HWSelectNEWButton_Click);
            // 
            // HwSelectLabel
            // 
            this.HwSelectLabel.AutoSize = true;
            this.HwSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HwSelectLabel.Location = new System.Drawing.Point(242, 23);
            this.HwSelectLabel.Name = "HwSelectLabel";
            this.HwSelectLabel.Size = new System.Drawing.Size(338, 37);
            this.HwSelectLabel.TabIndex = 3;
            this.HwSelectLabel.Text = "Select HWs to include:";
            // 
            // HWSelectRangeRB
            // 
            this.HWSelectRangeRB.AutoSize = true;
            this.HWSelectRangeRB.Location = new System.Drawing.Point(249, 187);
            this.HWSelectRangeRB.Name = "HWSelectRangeRB";
            this.HWSelectRangeRB.Size = new System.Drawing.Size(95, 17);
            this.HWSelectRangeRB.TabIndex = 1;
            this.HWSelectRangeRB.TabStop = true;
            this.HWSelectRangeRB.Text = "Include Range";
            this.HWSelectRangeRB.UseVisualStyleBackColor = true;
            this.HWSelectRangeRB.CheckedChanged += new System.EventHandler(this.HWSelectRangeRB_CheckedChanged);
            // 
            // HWIncludeListRB
            // 
            this.HWIncludeListRB.AutoSize = true;
            this.HWIncludeListRB.Location = new System.Drawing.Point(249, 88);
            this.HWIncludeListRB.Name = "HWIncludeListRB";
            this.HWIncludeListRB.Size = new System.Drawing.Size(190, 17);
            this.HWIncludeListRB.TabIndex = 0;
            this.HWIncludeListRB.TabStop = true;
            this.HWIncludeListRB.Text = "Select HWs (comma separated list)";
            this.HWIncludeListRB.UseVisualStyleBackColor = true;
            this.HWIncludeListRB.CheckedChanged += new System.EventHandler(this.HWIncludeListRB_CheckedChanged);
            // 
            // HWViewPanel
            // 
            this.HWViewPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.HWViewPanel.Controls.Add(this.DoneMarker);
            this.HWViewPanel.Controls.Add(this.QPanelView);
            this.HWViewPanel.Controls.Add(this.ShowAnswer);
            this.HWViewPanel.Controls.Add(this.SKIP);
            this.HWViewPanel.Controls.Add(this.gotoMenu);
            this.HWViewPanel.Controls.Add(this.HWViewTitle);
            this.HWViewPanel.Location = new System.Drawing.Point(-6, 0);
            this.HWViewPanel.Name = "HWViewPanel";
            this.HWViewPanel.Size = new System.Drawing.Size(810, 453);
            this.HWViewPanel.TabIndex = 1;
            // 
            // gotoMenu
            // 
            this.gotoMenu.Location = new System.Drawing.Point(18, 3);
            this.gotoMenu.Name = "gotoMenu";
            this.gotoMenu.Size = new System.Drawing.Size(121, 47);
            this.gotoMenu.TabIndex = 1;
            this.gotoMenu.Text = "Back to Menu";
            this.gotoMenu.UseVisualStyleBackColor = true;
            this.gotoMenu.Click += new System.EventHandler(this.gotoMenu_Click);
            // 
            // HWViewTitle
            // 
            this.HWViewTitle.AutoSize = true;
            this.HWViewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HWViewTitle.Location = new System.Drawing.Point(292, 24);
            this.HWViewTitle.Name = "HWViewTitle";
            this.HWViewTitle.Size = new System.Drawing.Size(122, 26);
            this.HWViewTitle.TabIndex = 0;
            this.HWViewTitle.Text = "\'HW#\' \'Q#\'";
            this.HWViewTitle.UseMnemonic = false;
            // 
            // SKIP
            // 
            this.SKIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SKIP.Location = new System.Drawing.Point(638, 389);
            this.SKIP.Name = "SKIP";
            this.SKIP.Size = new System.Drawing.Size(120, 40);
            this.SKIP.TabIndex = 2;
            this.SKIP.Text = "SKIP";
            this.SKIP.UseVisualStyleBackColor = true;
            this.SKIP.Click += new System.EventHandler(this.SKIP_Click);
            // 
            // ShowAnswer
            // 
            this.ShowAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAnswer.Location = new System.Drawing.Point(202, 389);
            this.ShowAnswer.Name = "ShowAnswer";
            this.ShowAnswer.Size = new System.Drawing.Size(120, 40);
            this.ShowAnswer.TabIndex = 3;
            this.ShowAnswer.Text = "Show Answer";
            this.ShowAnswer.UseVisualStyleBackColor = true;
            this.ShowAnswer.Click += new System.EventHandler(this.ShowAnswer_Click);
            // 
            // QPanelView
            // 
            this.QPanelView.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.QPanelView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QPanelView.Location = new System.Drawing.Point(18, 58);
            this.QPanelView.Name = "QPanelView";
            this.QPanelView.Size = new System.Drawing.Size(776, 325);
            this.QPanelView.TabIndex = 4;
            // 
            // DoneMarker
            // 
            this.DoneMarker.Location = new System.Drawing.Point(413, 389);
            this.DoneMarker.Name = "DoneMarker";
            this.DoneMarker.Size = new System.Drawing.Size(120, 40);
            this.DoneMarker.TabIndex = 5;
            this.DoneMarker.Text = "Mark as Done";
            this.DoneMarker.UseVisualStyleBackColor = true;
            this.DoneMarker.Click += new System.EventHandler(this.DoneMarker_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HWViewPanel);
            this.Controls.Add(this.HwSelectPanel);
            this.Name = "Form1";
            this.Text = "CSE341 Final Review";
            this.HwSelectPanel.ResumeLayout(false);
            this.HwSelectPanel.PerformLayout();
            this.HWViewPanel.ResumeLayout(false);
            this.HWViewPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HwSelectPanel;
        private System.Windows.Forms.TextBox HWSelectInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HWSelectLoadButton;
        private System.Windows.Forms.Button HWSelectNEWButton;
        private System.Windows.Forms.Label HwSelectLabel;
        private System.Windows.Forms.RadioButton HWSelectRangeRB;
        private System.Windows.Forms.RadioButton HWIncludeListRB;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel HWViewPanel;
        private System.Windows.Forms.Label HWViewTitle;
        private System.Windows.Forms.Button gotoMenu;
        private System.Windows.Forms.Panel QPanelView;
        private System.Windows.Forms.Button ShowAnswer;
        private System.Windows.Forms.Button SKIP;
        private System.Windows.Forms.Button DoneMarker;
    }
}

