
namespace ASCIIArtToImage
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            " ",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            ".",
            "28"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            ",",
            "56"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            ":",
            "84"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "~",
            "112"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "=",
            "130"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "+",
            "158"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "7",
            "186"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "?",
            "222"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "I",
            "255"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.outputDisplay = new System.Windows.Forms.PictureBox();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.openFileLabel = new System.Windows.Forms.Label();
            this.fileBrowserButton = new System.Windows.Forms.Button();
            this.optionsGroup = new System.Windows.Forms.GroupBox();
            this.charSet = new System.Windows.Forms.TextBox();
            this.charSetLabel = new System.Windows.Forms.Label();
            this.delChar = new System.Windows.Forms.Button();
            this.changeChar = new System.Windows.Forms.Button();
            this.addChar = new System.Windows.Forms.Button();
            this.lumaStrength = new System.Windows.Forms.TrackBar();
            this.lumaLabel = new System.Windows.Forms.Label();
            this.charEditBox = new System.Windows.Forms.TextBox();
            this.charLabel = new System.Windows.Forms.Label();
            this.charEditLabel = new System.Windows.Forms.Label();
            this.lumaIndexView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.imgScaleBar = new System.Windows.Forms.TrackBar();
            this.scaleDisplayLabel = new System.Windows.Forms.Label();
            this.renderButton = new System.Windows.Forms.Button();
            this.renderProgressBar = new System.Windows.Forms.ProgressBar();
            this.progressGroup = new System.Windows.Forms.GroupBox();
            this.inputGroup = new System.Windows.Forms.GroupBox();
            this.outputGroup = new System.Windows.Forms.GroupBox();
            this.outputScaleMode = new System.Windows.Forms.ComboBox();
            this.openASCII = new System.Windows.Forms.OpenFileDialog();
            this.saveOutputAs = new System.Windows.Forms.SaveFileDialog();
            this.progressCatcher = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.outputDisplay)).BeginInit();
            this.optionsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lumaStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScaleBar)).BeginInit();
            this.progressGroup.SuspendLayout();
            this.inputGroup.SuspendLayout();
            this.outputGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputDisplay
            // 
            this.outputDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDisplay.Location = new System.Drawing.Point(6, 25);
            this.outputDisplay.Name = "outputDisplay";
            this.outputDisplay.Size = new System.Drawing.Size(283, 413);
            this.outputDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.outputDisplay.TabIndex = 0;
            this.outputDisplay.TabStop = false;
            // 
            // saveAsButton
            // 
            this.saveAsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveAsButton.Enabled = false;
            this.saveAsButton.Location = new System.Drawing.Point(6, 444);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(75, 23);
            this.saveAsButton.TabIndex = 2;
            this.saveAsButton.Text = "Save a&s...";
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // fileNameBox
            // 
            this.fileNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameBox.Location = new System.Drawing.Point(6, 44);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(362, 23);
            this.fileNameBox.TabIndex = 4;
            this.fileNameBox.TextChanged += new System.EventHandler(this.fileNameBox_TextChanged);
            // 
            // openFileLabel
            // 
            this.openFileLabel.AutoSize = true;
            this.openFileLabel.Location = new System.Drawing.Point(6, 25);
            this.openFileLabel.Name = "openFileLabel";
            this.openFileLabel.Size = new System.Drawing.Size(125, 16);
            this.openFileLabel.TabIndex = 5;
            this.openFileLabel.Text = "Open file (Not loaded)";
            this.openFileLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fileBrowserButton
            // 
            this.fileBrowserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileBrowserButton.Location = new System.Drawing.Point(374, 44);
            this.fileBrowserButton.Name = "fileBrowserButton";
            this.fileBrowserButton.Size = new System.Drawing.Size(75, 23);
            this.fileBrowserButton.TabIndex = 6;
            this.fileBrowserButton.Text = "browser";
            this.fileBrowserButton.UseVisualStyleBackColor = true;
            this.fileBrowserButton.Click += new System.EventHandler(this.fileBrowserButton_Click);
            // 
            // optionsGroup
            // 
            this.optionsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsGroup.Controls.Add(this.charSet);
            this.optionsGroup.Controls.Add(this.charSetLabel);
            this.optionsGroup.Controls.Add(this.delChar);
            this.optionsGroup.Controls.Add(this.changeChar);
            this.optionsGroup.Controls.Add(this.addChar);
            this.optionsGroup.Controls.Add(this.lumaStrength);
            this.optionsGroup.Controls.Add(this.lumaLabel);
            this.optionsGroup.Controls.Add(this.charEditBox);
            this.optionsGroup.Controls.Add(this.charLabel);
            this.optionsGroup.Controls.Add(this.charEditLabel);
            this.optionsGroup.Controls.Add(this.lumaIndexView);
            this.optionsGroup.Controls.Add(this.imgScaleBar);
            this.optionsGroup.Controls.Add(this.scaleDisplayLabel);
            this.optionsGroup.Location = new System.Drawing.Point(318, 95);
            this.optionsGroup.Name = "optionsGroup";
            this.optionsGroup.Size = new System.Drawing.Size(454, 396);
            this.optionsGroup.TabIndex = 8;
            this.optionsGroup.TabStop = false;
            this.optionsGroup.Text = "Options";
            // 
            // charSet
            // 
            this.charSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charSet.Location = new System.Drawing.Point(223, 275);
            this.charSet.Name = "charSet";
            this.charSet.ReadOnly = true;
            this.charSet.Size = new System.Drawing.Size(225, 23);
            this.charSet.TabIndex = 13;
            // 
            // charSetLabel
            // 
            this.charSetLabel.AutoSize = true;
            this.charSetLabel.Location = new System.Drawing.Point(223, 256);
            this.charSetLabel.Name = "charSetLabel";
            this.charSetLabel.Size = new System.Drawing.Size(75, 16);
            this.charSetLabel.TabIndex = 12;
            this.charSetLabel.Text = "Character set";
            // 
            // delChar
            // 
            this.delChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delChar.Location = new System.Drawing.Point(301, 179);
            this.delChar.Name = "delChar";
            this.delChar.Size = new System.Drawing.Size(75, 23);
            this.delChar.TabIndex = 11;
            this.delChar.Text = "Remove";
            this.delChar.UseVisualStyleBackColor = true;
            this.delChar.Click += new System.EventHandler(this.delChar_Click);
            // 
            // changeChar
            // 
            this.changeChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeChar.Location = new System.Drawing.Point(220, 208);
            this.changeChar.Name = "changeChar";
            this.changeChar.Size = new System.Drawing.Size(75, 23);
            this.changeChar.TabIndex = 10;
            this.changeChar.Text = "Replace";
            this.changeChar.UseVisualStyleBackColor = true;
            this.changeChar.Click += new System.EventHandler(this.changeChar_Click);
            // 
            // addChar
            // 
            this.addChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addChar.Location = new System.Drawing.Point(220, 179);
            this.addChar.Name = "addChar";
            this.addChar.Size = new System.Drawing.Size(75, 23);
            this.addChar.TabIndex = 9;
            this.addChar.Text = "Add";
            this.addChar.UseVisualStyleBackColor = true;
            this.addChar.Click += new System.EventHandler(this.addChar_Click);
            // 
            // lumaStrength
            // 
            this.lumaStrength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lumaStrength.Location = new System.Drawing.Point(265, 144);
            this.lumaStrength.Maximum = 255;
            this.lumaStrength.Name = "lumaStrength";
            this.lumaStrength.Size = new System.Drawing.Size(137, 45);
            this.lumaStrength.TabIndex = 8;
            this.lumaStrength.TickFrequency = 10;
            // 
            // lumaLabel
            // 
            this.lumaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lumaLabel.AutoSize = true;
            this.lumaLabel.Location = new System.Drawing.Point(223, 144);
            this.lumaLabel.Name = "lumaLabel";
            this.lumaLabel.Size = new System.Drawing.Size(36, 16);
            this.lumaLabel.TabIndex = 7;
            this.lumaLabel.Text = "Luma";
            // 
            // charEditBox
            // 
            this.charEditBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.charEditBox.Location = new System.Drawing.Point(260, 115);
            this.charEditBox.MaxLength = 1;
            this.charEditBox.Name = "charEditBox";
            this.charEditBox.Size = new System.Drawing.Size(30, 23);
            this.charEditBox.TabIndex = 6;
            // 
            // charLabel
            // 
            this.charLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.charLabel.AutoSize = true;
            this.charLabel.Location = new System.Drawing.Point(223, 118);
            this.charLabel.Name = "charLabel";
            this.charLabel.Size = new System.Drawing.Size(31, 16);
            this.charLabel.TabIndex = 5;
            this.charLabel.Text = "Char";
            // 
            // charEditLabel
            // 
            this.charEditLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.charEditLabel.AutoSize = true;
            this.charEditLabel.Location = new System.Drawing.Point(19, 86);
            this.charEditLabel.Name = "charEditLabel";
            this.charEditLabel.Size = new System.Drawing.Size(91, 16);
            this.charEditLabel.TabIndex = 4;
            this.charEditLabel.Text = "Character editor";
            // 
            // lumaIndexView
            // 
            this.lumaIndexView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lumaIndexView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lumaIndexView.FullRowSelect = true;
            this.lumaIndexView.GridLines = true;
            this.lumaIndexView.HideSelection = false;
            this.lumaIndexView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.lumaIndexView.Location = new System.Drawing.Point(19, 115);
            this.lumaIndexView.MultiSelect = false;
            this.lumaIndexView.Name = "lumaIndexView";
            this.lumaIndexView.Size = new System.Drawing.Size(191, 271);
            this.lumaIndexView.TabIndex = 3;
            this.lumaIndexView.UseCompatibleStateImageBehavior = false;
            this.lumaIndexView.View = System.Windows.Forms.View.Details;
            this.lumaIndexView.SelectedIndexChanged += new System.EventHandler(this.lumaIndexView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Char";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Luma";
            // 
            // imgScaleBar
            // 
            this.imgScaleBar.Location = new System.Drawing.Point(19, 38);
            this.imgScaleBar.Maximum = 50;
            this.imgScaleBar.Minimum = 1;
            this.imgScaleBar.Name = "imgScaleBar";
            this.imgScaleBar.Size = new System.Drawing.Size(225, 45);
            this.imgScaleBar.TabIndex = 2;
            this.imgScaleBar.Value = 1;
            this.imgScaleBar.Scroll += new System.EventHandler(this.imgScaleBar_Scroll);
            // 
            // scaleDisplayLabel
            // 
            this.scaleDisplayLabel.AutoSize = true;
            this.scaleDisplayLabel.Location = new System.Drawing.Point(19, 19);
            this.scaleDisplayLabel.Name = "scaleDisplayLabel";
            this.scaleDisplayLabel.Size = new System.Drawing.Size(59, 16);
            this.scaleDisplayLabel.TabIndex = 1;
            this.scaleDisplayLabel.Text = "Scale = 1x";
            // 
            // renderButton
            // 
            this.renderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.renderButton.Location = new System.Drawing.Point(87, 444);
            this.renderButton.Name = "renderButton";
            this.renderButton.Size = new System.Drawing.Size(75, 23);
            this.renderButton.TabIndex = 9;
            this.renderButton.Text = "Generate";
            this.renderButton.UseVisualStyleBackColor = true;
            this.renderButton.Click += new System.EventHandler(this.renderButton_Click);
            // 
            // renderProgressBar
            // 
            this.renderProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renderProgressBar.Location = new System.Drawing.Point(6, 23);
            this.renderProgressBar.Name = "renderProgressBar";
            this.renderProgressBar.Size = new System.Drawing.Size(748, 23);
            this.renderProgressBar.TabIndex = 10;
            // 
            // progressGroup
            // 
            this.progressGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressGroup.Controls.Add(this.renderProgressBar);
            this.progressGroup.Location = new System.Drawing.Point(12, 497);
            this.progressGroup.Name = "progressGroup";
            this.progressGroup.Size = new System.Drawing.Size(760, 52);
            this.progressGroup.TabIndex = 11;
            this.progressGroup.TabStop = false;
            this.progressGroup.Text = "Generator progress";
            // 
            // inputGroup
            // 
            this.inputGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputGroup.Controls.Add(this.openFileLabel);
            this.inputGroup.Controls.Add(this.fileNameBox);
            this.inputGroup.Controls.Add(this.fileBrowserButton);
            this.inputGroup.Location = new System.Drawing.Point(318, 12);
            this.inputGroup.Name = "inputGroup";
            this.inputGroup.Size = new System.Drawing.Size(454, 77);
            this.inputGroup.TabIndex = 12;
            this.inputGroup.TabStop = false;
            this.inputGroup.Text = "Input";
            // 
            // outputGroup
            // 
            this.outputGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputGroup.Controls.Add(this.outputScaleMode);
            this.outputGroup.Controls.Add(this.outputDisplay);
            this.outputGroup.Controls.Add(this.saveAsButton);
            this.outputGroup.Controls.Add(this.renderButton);
            this.outputGroup.Location = new System.Drawing.Point(18, 12);
            this.outputGroup.Name = "outputGroup";
            this.outputGroup.Size = new System.Drawing.Size(295, 479);
            this.outputGroup.TabIndex = 13;
            this.outputGroup.TabStop = false;
            this.outputGroup.Text = "Output";
            // 
            // outputScaleMode
            // 
            this.outputScaleMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputScaleMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputScaleMode.Enabled = false;
            this.outputScaleMode.FormattingEnabled = true;
            this.outputScaleMode.Items.AddRange(new object[] {
            "Center",
            "ActualSize",
            "Zoom",
            "Stretch"});
            this.outputScaleMode.Location = new System.Drawing.Point(168, 444);
            this.outputScaleMode.Name = "outputScaleMode";
            this.outputScaleMode.Size = new System.Drawing.Size(121, 24);
            this.outputScaleMode.TabIndex = 14;
            this.outputScaleMode.SelectedIndexChanged += new System.EventHandler(this.outputScaleMode_SelectedIndexChanged);
            // 
            // openASCII
            // 
            this.openASCII.Filter = "All plain text files|*.*";
            this.openASCII.Title = "Open file";
            // 
            // saveOutputAs
            // 
            this.saveOutputAs.Filter = "Bitmap image|*.bmp|Portable Network Graphics|*.png|Graphics Interchange Format|*." +
    "gif";
            this.saveOutputAs.Title = "Save ascii2Pixel output";
            // 
            // progressCatcher
            // 
            this.progressCatcher.Enabled = true;
            this.progressCatcher.Tick += new System.EventHandler(this.progressCatcher_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.outputGroup);
            this.Controls.Add(this.inputGroup);
            this.Controls.Add(this.progressGroup);
            this.Controls.Add(this.optionsGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(673, 483);
            this.Name = "Main";
            this.Text = "ascii2Pixels by markustegelane";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputDisplay)).EndInit();
            this.optionsGroup.ResumeLayout(false);
            this.optionsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lumaStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScaleBar)).EndInit();
            this.progressGroup.ResumeLayout(false);
            this.inputGroup.ResumeLayout(false);
            this.inputGroup.PerformLayout();
            this.outputGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox outputDisplay;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.TextBox fileNameBox;
        private System.Windows.Forms.Label openFileLabel;
        private System.Windows.Forms.Button fileBrowserButton;
        private System.Windows.Forms.GroupBox optionsGroup;
        private System.Windows.Forms.Button delChar;
        private System.Windows.Forms.Button changeChar;
        private System.Windows.Forms.Button addChar;
        private System.Windows.Forms.TrackBar lumaStrength;
        private System.Windows.Forms.Label lumaLabel;
        private System.Windows.Forms.TextBox charEditBox;
        private System.Windows.Forms.Label charLabel;
        private System.Windows.Forms.Label charEditLabel;
        private System.Windows.Forms.ListView lumaIndexView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TrackBar imgScaleBar;
        private System.Windows.Forms.Label scaleDisplayLabel;
        private System.Windows.Forms.Button renderButton;
        private System.Windows.Forms.ProgressBar renderProgressBar;
        private System.Windows.Forms.GroupBox progressGroup;
        private System.Windows.Forms.GroupBox inputGroup;
        private System.Windows.Forms.GroupBox outputGroup;
        private System.Windows.Forms.ComboBox outputScaleMode;
        private System.Windows.Forms.OpenFileDialog openASCII;
        private System.Windows.Forms.SaveFileDialog saveOutputAs;
        private System.Windows.Forms.Timer progressCatcher;
        private System.Windows.Forms.TextBox charSet;
        private System.Windows.Forms.Label charSetLabel;
    }
}

