namespace GISTeaDecider
{
    partial class TeaDecider
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.chkListTeam = new System.Windows.Forms.CheckedListBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeselectAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnDeselectAllIncluded = new System.Windows.Forms.Button();
            this.chkListIncluded = new System.Windows.Forms.CheckedListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblWildcardText = new System.Windows.Forms.Label();
            this.lblEmailResult = new System.Windows.Forms.Label();
            this.gBoxIncludedMembers = new System.Windows.Forms.GroupBox();
            this.btnSelectAllIncluded = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBoxTeamMembers = new System.Windows.Forms.GroupBox();
            this.gbChosenOne = new System.Windows.Forms.GroupBox();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.lblResultMsg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TTSelectAllTeamMembers = new System.Windows.Forms.ToolTip(this.components);
            this.TTDeselectAllTeamMembers = new System.Windows.Forms.ToolTip(this.components);
            this.TTAddMembers = new System.Windows.Forms.ToolTip(this.components);
            this.TTRemove = new System.Windows.Forms.ToolTip(this.components);
            this.TTSelectAllIncludedMembers = new System.Windows.Forms.ToolTip(this.components);
            this.TTDeslectAllIncludedMembers = new System.Windows.Forms.ToolTip(this.components);
            this.TTGenerate = new System.Windows.Forms.ToolTip(this.components);
            this.gBoxIncludedMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gBoxTeamMembers.SuspendLayout();
            this.gbChosenOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGenerate.Location = new System.Drawing.Point(12, 230);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(274, 165);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.TTGenerate.SetToolTip(this.btnGenerate, "Generate a random number");
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // chkListTeam
            // 
            this.chkListTeam.CheckOnClick = true;
            this.chkListTeam.FormattingEnabled = true;
            this.chkListTeam.Items.AddRange(new object[] {
            "James Wright",
            "James Wilkinson",
            "Paul Griffiths",
            "Paul Knight",
            "Tom Bodington",
            "Alessandro Scolozzi",
            "Dan Goodwin",
            "Charnelle Gibbon"});
            this.chkListTeam.Location = new System.Drawing.Point(132, 22);
            this.chkListTeam.Name = "chkListTeam";
            this.chkListTeam.Size = new System.Drawing.Size(139, 166);
            this.chkListTeam.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(7, 24);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(169, 89);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "***";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Location = new System.Drawing.Point(342, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 42);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.TTAddMembers.SetToolTip(this.btnAdd, "Include selected team members");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeselectAll
            // 
            this.btnDeselectAll.BackColor = System.Drawing.Color.Red;
            this.btnDeselectAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeselectAll.Location = new System.Drawing.Point(14, 93);
            this.btnDeselectAll.Name = "btnDeselectAll";
            this.btnDeselectAll.Size = new System.Drawing.Size(103, 42);
            this.btnDeselectAll.TabIndex = 5;
            this.btnDeselectAll.Text = "Deselect all";
            this.TTSelectAllTeamMembers.SetToolTip(this.btnDeselectAll, "Deselect All Team Members");
            this.btnDeselectAll.UseVisualStyleBackColor = false;
            this.btnDeselectAll.Click += new System.EventHandler(this.btnDeselectAll_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSelectAll.Location = new System.Drawing.Point(14, 45);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(103, 42);
            this.btnSelectAll.TabIndex = 10;
            this.btnSelectAll.Text = "Select all";
            this.TTDeselectAllTeamMembers.SetToolTip(this.btnSelectAll, "Select all team members");
            this.btnSelectAll.UseVisualStyleBackColor = false;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnDeselectAllIncluded
            // 
            this.btnDeselectAllIncluded.BackColor = System.Drawing.Color.Red;
            this.btnDeselectAllIncluded.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeselectAllIncluded.Location = new System.Drawing.Point(174, 93);
            this.btnDeselectAllIncluded.Name = "btnDeselectAllIncluded";
            this.btnDeselectAllIncluded.Size = new System.Drawing.Size(103, 42);
            this.btnDeselectAllIncluded.TabIndex = 21;
            this.btnDeselectAllIncluded.Text = "Deselect All";
            this.TTDeslectAllIncludedMembers.SetToolTip(this.btnDeselectAllIncluded, "Deselect All Included Members");
            this.btnDeselectAllIncluded.UseVisualStyleBackColor = false;
            this.btnDeselectAllIncluded.Click += new System.EventHandler(this.btnDeselectAllIncluded_Click_1);
            // 
            // chkListIncluded
            // 
            this.chkListIncluded.CheckOnClick = true;
            this.chkListIncluded.FormattingEnabled = true;
            this.chkListIncluded.Location = new System.Drawing.Point(17, 22);
            this.chkListIncluded.Name = "chkListIncluded";
            this.chkListIncluded.Size = new System.Drawing.Size(139, 166);
            this.chkListIncluded.TabIndex = 22;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemove.Location = new System.Drawing.Point(342, 110);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(103, 42);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "Remove";
            this.TTRemove.SetToolTip(this.btnRemove, "Remove selected included members");
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblWildcardText
            // 
            this.lblWildcardText.AutoSize = true;
            this.lblWildcardText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWildcardText.ForeColor = System.Drawing.Color.Red;
            this.lblWildcardText.Location = new System.Drawing.Point(34, 117);
            this.lblWildcardText.Name = "lblWildcardText";
            this.lblWildcardText.Size = new System.Drawing.Size(111, 13);
            this.lblWildcardText.TabIndex = 24;
            this.lblWildcardText.Text = "*** WILDCARD ***";
            this.lblWildcardText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWildcardText.Visible = false;
            // 
            // lblEmailResult
            // 
            this.lblEmailResult.AutoSize = true;
            this.lblEmailResult.Location = new System.Drawing.Point(159, 126);
            this.lblEmailResult.Name = "lblEmailResult";
            this.lblEmailResult.Size = new System.Drawing.Size(84, 15);
            this.lblEmailResult.TabIndex = 26;
            this.lblEmailResult.Text = "lblEmailResult";
            this.lblEmailResult.Visible = false;
            // 
            // gBoxIncludedMembers
            // 
            this.gBoxIncludedMembers.Controls.Add(this.btnSelectAllIncluded);
            this.gBoxIncludedMembers.Controls.Add(this.pictureBox2);
            this.gBoxIncludedMembers.Controls.Add(this.label1);
            this.gBoxIncludedMembers.Controls.Add(this.chkListIncluded);
            this.gBoxIncludedMembers.Controls.Add(this.btnDeselectAllIncluded);
            this.gBoxIncludedMembers.Location = new System.Drawing.Point(481, 16);
            this.gBoxIncludedMembers.Name = "gBoxIncludedMembers";
            this.gBoxIncludedMembers.Size = new System.Drawing.Size(510, 202);
            this.gBoxIncludedMembers.TabIndex = 27;
            this.gBoxIncludedMembers.TabStop = false;
            this.gBoxIncludedMembers.Text = "Included Members";
            // 
            // btnSelectAllIncluded
            // 
            this.btnSelectAllIncluded.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSelectAllIncluded.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelectAllIncluded.Location = new System.Drawing.Point(174, 45);
            this.btnSelectAllIncluded.Name = "btnSelectAllIncluded";
            this.btnSelectAllIncluded.Size = new System.Drawing.Size(103, 42);
            this.btnSelectAllIncluded.TabIndex = 11;
            this.btnSelectAllIncluded.Text = "Select all";
            this.TTDeslectAllIncludedMembers.SetToolTip(this.btnSelectAllIncluded, "Select all included members");
            this.btnSelectAllIncluded.UseVisualStyleBackColor = false;
            this.btnSelectAllIncluded.Click += new System.EventHandler(this.btnSelectAllIncluded_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GISTeaDecider.Properties.Resources.tea_311844_640;
            this.pictureBox2.Location = new System.Drawing.Point(373, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Choose the team members that \r\nyou want to include in the decider!";
            // 
            // gBoxTeamMembers
            // 
            this.gBoxTeamMembers.Controls.Add(this.chkListTeam);
            this.gBoxTeamMembers.Controls.Add(this.btnDeselectAll);
            this.gBoxTeamMembers.Controls.Add(this.btnSelectAll);
            this.gBoxTeamMembers.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxTeamMembers.Location = new System.Drawing.Point(14, 16);
            this.gBoxTeamMembers.Name = "gBoxTeamMembers";
            this.gBoxTeamMembers.Size = new System.Drawing.Size(289, 202);
            this.gBoxTeamMembers.TabIndex = 28;
            this.gBoxTeamMembers.TabStop = false;
            this.gBoxTeamMembers.Text = "Team Members";
            // 
            // gbChosenOne
            // 
            this.gbChosenOne.Controls.Add(this.pbPersonImage);
            this.gbChosenOne.Controls.Add(this.lblResultMsg);
            this.gbChosenOne.Controls.Add(this.lblEmailResult);
            this.gbChosenOne.Location = new System.Drawing.Point(482, 224);
            this.gbChosenOne.Name = "gbChosenOne";
            this.gbChosenOne.Size = new System.Drawing.Size(509, 171);
            this.gbChosenOne.TabIndex = 29;
            this.gbChosenOne.TabStop = false;
            this.gbChosenOne.Text = "The Chosen One";
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Image = global::GISTeaDecider.Properties.Resources.Silhouette_question_mark;
            this.pbPersonImage.Location = new System.Drawing.Point(12, 25);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(140, 126);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonImage.TabIndex = 30;
            this.pbPersonImage.TabStop = false;
            // 
            // lblResultMsg
            // 
            this.lblResultMsg.AutoSize = true;
            this.lblResultMsg.Location = new System.Drawing.Point(159, 35);
            this.lblResultMsg.Name = "lblResultMsg";
            this.lblResultMsg.Size = new System.Drawing.Size(77, 15);
            this.lblResultMsg.TabIndex = 30;
            this.lblResultMsg.Text = "lblResultMsg";
            this.lblResultMsg.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GISTeaDecider.Properties.Resources.amaze;
            this.pictureBox1.Location = new System.Drawing.Point(799, 407);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.lblWildcardText);
            this.groupBox1.Location = new System.Drawing.Point(293, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 171);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Random Number";
            // 
            // TeaDecider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 457);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbChosenOne);
            this.Controls.Add(this.gBoxTeamMembers);
            this.Controls.Add(this.gBoxIncludedMembers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGenerate);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TeaDecider";
            this.Text = "GIS Tea Decider";
            this.gBoxIncludedMembers.ResumeLayout(false);
            this.gBoxIncludedMembers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gBoxTeamMembers.ResumeLayout(false);
            this.gbChosenOne.ResumeLayout(false);
            this.gbChosenOne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckedListBox chkListTeam;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeselectAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnDeselectAllIncluded;
        private System.Windows.Forms.CheckedListBox chkListIncluded;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblWildcardText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEmailResult;
        private System.Windows.Forms.GroupBox gBoxIncludedMembers;
        private System.Windows.Forms.GroupBox gBoxTeamMembers;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gbChosenOne;
        private System.Windows.Forms.Button btnSelectAllIncluded;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultMsg;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip TTSelectAllTeamMembers;
        private System.Windows.Forms.ToolTip TTDeselectAllTeamMembers;
        private System.Windows.Forms.ToolTip TTAddMembers;
        private System.Windows.Forms.ToolTip TTRemove;
        private System.Windows.Forms.ToolTip TTGenerate;
        private System.Windows.Forms.ToolTip TTDeslectAllIncludedMembers;
        private System.Windows.Forms.ToolTip TTSelectAllIncludedMembers;
    }
}

