namespace ProjektForms
{
    partial class Form1
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
            this.GraphPanel = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CountButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.IP1 = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.inputlabel1 = new System.Windows.Forms.Label();
            this.inputLabel2 = new System.Windows.Forms.Label();
            this.IP2 = new System.Windows.Forms.TextBox();
            this.inputLabel3 = new System.Windows.Forms.Label();
            this.K = new System.Windows.Forms.TextBox();
            this.AddConnectionButton = new System.Windows.Forms.Button();
            this.DeleteConnectionButton = new System.Windows.Forms.Button();
            this.FCButton = new System.Windows.Forms.Button();
            this.FC2Button = new System.Windows.Forms.Button();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.radioButtonG = new System.Windows.Forms.RadioButton();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GraphPanel
            // 
            this.GraphPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphPanel.AutoSize = true;
            this.GraphPanel.BackColor = System.Drawing.SystemColors.Window;
            this.GraphPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GraphPanel.Location = new System.Drawing.Point(10, 9);
            this.GraphPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GraphPanel.Name = "GraphPanel";
            this.GraphPanel.Size = new System.Drawing.Size(839, 327);
            this.GraphPanel.TabIndex = 200;
            this.GraphPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphPanel_Paint);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.Location = new System.Drawing.Point(10, 384);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(82, 22);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Location = new System.Drawing.Point(98, 384);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(82, 22);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchButton.Location = new System.Drawing.Point(186, 384);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(82, 22);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CountButton
            // 
            this.CountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CountButton.Location = new System.Drawing.Point(273, 384);
            this.CountButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(82, 22);
            this.CountButton.TabIndex = 8;
            this.CountButton.Text = "Count";
            this.CountButton.UseVisualStyleBackColor = true;
            this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StatusLabel.Location = new System.Drawing.Point(370, 354);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(350, 20);
            this.StatusLabel.TabIndex = 66;
            this.StatusLabel.Text = "Status:";
            // 
            // IP1
            // 
            this.IP1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IP1.Location = new System.Drawing.Point(10, 355);
            this.IP1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IP1.MaxLength = 15;
            this.IP1.Name = "IP1";
            this.IP1.Size = new System.Drawing.Size(105, 23);
            this.IP1.TabIndex = 0;
            this.IP1.TextChanged += new System.EventHandler(this.IP1_TextChanged);
            this.IP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.avoidLetters);
            // 
            // LoadButton
            // 
            this.LoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadButton.Location = new System.Drawing.Point(766, 358);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(82, 22);
            this.LoadButton.TabIndex = 68;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.Location = new System.Drawing.Point(766, 384);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(82, 22);
            this.RefreshButton.TabIndex = 9;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // inputlabel1
            // 
            this.inputlabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inputlabel1.AutoSize = true;
            this.inputlabel1.Location = new System.Drawing.Point(12, 338);
            this.inputlabel1.Name = "inputlabel1";
            this.inputlabel1.Size = new System.Drawing.Size(26, 15);
            this.inputlabel1.TabIndex = 201;
            this.inputlabel1.Text = "ip1:";
            // 
            // inputLabel2
            // 
            this.inputLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inputLabel2.AutoSize = true;
            this.inputLabel2.Location = new System.Drawing.Point(120, 338);
            this.inputLabel2.Name = "inputLabel2";
            this.inputLabel2.Size = new System.Drawing.Size(26, 15);
            this.inputLabel2.TabIndex = 202;
            this.inputLabel2.Text = "ip2:";
            // 
            // IP2
            // 
            this.IP2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IP2.Location = new System.Drawing.Point(120, 355);
            this.IP2.MaxLength = 15;
            this.IP2.Name = "IP2";
            this.IP2.Size = new System.Drawing.Size(105, 23);
            this.IP2.TabIndex = 203;
            this.IP2.TextChanged += new System.EventHandler(this.IP2_TextChanged);
            this.IP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.avoidLetters);
            // 
            // inputLabel3
            // 
            this.inputLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inputLabel3.AutoSize = true;
            this.inputLabel3.Location = new System.Drawing.Point(231, 338);
            this.inputLabel3.Name = "inputLabel3";
            this.inputLabel3.Size = new System.Drawing.Size(16, 15);
            this.inputLabel3.TabIndex = 204;
            this.inputLabel3.Text = "k:";
            this.inputLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // K
            // 
            this.K.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.K.Location = new System.Drawing.Point(231, 355);
            this.K.MaxLength = 1;
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(37, 23);
            this.K.TabIndex = 205;
            this.K.TextChanged += new System.EventHandler(this.K_TextChanged);
            this.K.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.avoidLettersK);
            // 
            // AddConnectionButton
            // 
            this.AddConnectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddConnectionButton.Location = new System.Drawing.Point(361, 384);
            this.AddConnectionButton.Name = "AddConnectionButton";
            this.AddConnectionButton.Size = new System.Drawing.Size(75, 23);
            this.AddConnectionButton.TabIndex = 206;
            this.AddConnectionButton.Text = "Add conn.";
            this.AddConnectionButton.UseVisualStyleBackColor = true;
            this.AddConnectionButton.Click += new System.EventHandler(this.AddConnectionButton_Click);
            // 
            // DeleteConnectionButton
            // 
            this.DeleteConnectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteConnectionButton.Location = new System.Drawing.Point(442, 384);
            this.DeleteConnectionButton.Name = "DeleteConnectionButton";
            this.DeleteConnectionButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteConnectionButton.TabIndex = 207;
            this.DeleteConnectionButton.Text = "Del conn.";
            this.DeleteConnectionButton.UseVisualStyleBackColor = true;
            this.DeleteConnectionButton.Click += new System.EventHandler(this.DeletConnectionButton_Click);
            // 
            // FCButton
            // 
            this.FCButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FCButton.Location = new System.Drawing.Point(523, 384);
            this.FCButton.Name = "FCButton";
            this.FCButton.Size = new System.Drawing.Size(45, 23);
            this.FCButton.TabIndex = 208;
            this.FCButton.Text = "FC";
            this.FCButton.UseVisualStyleBackColor = true;
            this.FCButton.Click += new System.EventHandler(this.FCButton_Click);
            // 
            // FC2Button
            // 
            this.FC2Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FC2Button.Location = new System.Drawing.Point(574, 384);
            this.FC2Button.Name = "FC2Button";
            this.FC2Button.Size = new System.Drawing.Size(45, 23);
            this.FC2Button.TabIndex = 209;
            this.FC2Button.Text = "FC2";
            this.FC2Button.UseVisualStyleBackColor = true;
            this.FC2Button.Click += new System.EventHandler(this.FC2Button_Click);
            // 
            // radioButtonM
            // 
            this.radioButtonM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(328, 341);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(36, 19);
            this.radioButtonM.TabIndex = 0;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "M";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // radioButtonG
            // 
            this.radioButtonG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonG.AutoSize = true;
            this.radioButtonG.Location = new System.Drawing.Point(328, 361);
            this.radioButtonG.Name = "radioButtonG";
            this.radioButtonG.Size = new System.Drawing.Size(33, 19);
            this.radioButtonG.TabIndex = 210;
            this.radioButtonG.TabStop = true;
            this.radioButtonG.Text = "G";
            this.radioButtonG.UseVisualStyleBackColor = true;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CostTextBox.Location = new System.Drawing.Point(274, 355);
            this.CostTextBox.MaxLength = 100;
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(48, 23);
            this.CostTextBox.TabIndex = 211;
            this.CostTextBox.TextChanged += new System.EventHandler(this.CostTextBox_TextChanged);
            this.CostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.avoidLettersK);
            // 
            // InputLabel
            // 
            this.InputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(274, 338);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(42, 15);
            this.InputLabel.TabIndex = 212;
            this.InputLabel.Text = "Speed:";
            this.InputLabel.Click += new System.EventHandler(this.InputLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 415);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.radioButtonG);
            this.Controls.Add(this.radioButtonM);
            this.Controls.Add(this.FC2Button);
            this.Controls.Add(this.FCButton);
            this.Controls.Add(this.DeleteConnectionButton);
            this.Controls.Add(this.AddConnectionButton);
            this.Controls.Add(this.K);
            this.Controls.Add(this.inputLabel3);
            this.Controls.Add(this.IP2);
            this.Controls.Add(this.inputLabel2);
            this.Controls.Add(this.inputlabel1);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.IP1);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.GraphPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "IpProjekt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GraphPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button CountButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox IP1;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label inputlabel1;
        private System.Windows.Forms.Label inputLabel2;
        private System.Windows.Forms.TextBox IP2;
        private System.Windows.Forms.Label inputLabel3;
        private System.Windows.Forms.TextBox K;
        private System.Windows.Forms.Button AddConnectionButton;
        private System.Windows.Forms.Button DeleteConnectionButton;
        private System.Windows.Forms.Button FCButton;
        private System.Windows.Forms.Button FC2Button;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.RadioButton radioButtonG;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label InputLabel;
    }
}

