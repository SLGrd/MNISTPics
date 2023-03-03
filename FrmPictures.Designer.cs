namespace MNISTPics
{
    partial class FrmPictures
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
            picB = new PictureBox();
            labNumber = new Label();
            btnLoad = new Button();
            btnGetNext = new Button();
            btnGetPrevious = new Button();
            label1 = new Label();
            txtCurrentRow = new TextBox();
            label2 = new Label();
            txtRowCount = new TextBox();
            btnGetFirst = new Button();
            btnGetLast = new Button();
            chkDarkMode = new CheckBox();
            txtFileLocation = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)picB).BeginInit();
            SuspendLayout();
            // 
            // picB
            // 
            picB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picB.BorderStyle = BorderStyle.FixedSingle;
            picB.Location = new Point(94, 152);
            picB.Name = "picB";
            picB.Size = new Size(618, 541);
            picB.TabIndex = 0;
            picB.TabStop = false;
            // 
            // labNumber
            // 
            labNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labNumber.AutoSize = true;
            labNumber.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labNumber.Location = new Point(385, 104);
            labNumber.Name = "labNumber";
            labNumber.Size = new Size(34, 45);
            labNumber.TabIndex = 1;
            labNumber.Text = "?";
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLoad.FlatStyle = FlatStyle.Popup;
            btnLoad.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoad.Location = new Point(769, 367);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(220, 45);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load Data";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += BtnLoad_Click;
            // 
            // btnGetNext
            // 
            btnGetNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGetNext.FlatStyle = FlatStyle.Popup;
            btnGetNext.Location = new Point(463, 721);
            btnGetNext.Name = "btnGetNext";
            btnGetNext.Size = new Size(117, 34);
            btnGetNext.TabIndex = 2;
            btnGetNext.Text = ">>";
            btnGetNext.UseVisualStyleBackColor = true;
            btnGetNext.Click += BtnGetNext_Click;
            // 
            // btnGetPrevious
            // 
            btnGetPrevious.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGetPrevious.FlatStyle = FlatStyle.Popup;
            btnGetPrevious.Location = new Point(227, 721);
            btnGetPrevious.Name = "btnGetPrevious";
            btnGetPrevious.Size = new Size(117, 34);
            btnGetPrevious.TabIndex = 2;
            btnGetPrevious.Text = "<<";
            btnGetPrevious.UseVisualStyleBackColor = true;
            btnGetPrevious.Click += BtnGetPrevious_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(769, 182);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 3;
            label1.Text = "Current Row #";
            // 
            // txtCurrentRow
            // 
            txtCurrentRow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCurrentRow.BorderStyle = BorderStyle.FixedSingle;
            txtCurrentRow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCurrentRow.Location = new Point(769, 210);
            txtCurrentRow.Name = "txtCurrentRow";
            txtCurrentRow.Size = new Size(220, 39);
            txtCurrentRow.TabIndex = 4;
            txtCurrentRow.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(769, 278);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 3;
            label2.Text = "Row Count";
            // 
            // txtRowCount
            // 
            txtRowCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtRowCount.BorderStyle = BorderStyle.FixedSingle;
            txtRowCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRowCount.Location = new Point(769, 306);
            txtRowCount.Name = "txtRowCount";
            txtRowCount.Size = new Size(220, 39);
            txtRowCount.TabIndex = 4;
            txtRowCount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGetFirst
            // 
            btnGetFirst.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGetFirst.FlatStyle = FlatStyle.Popup;
            btnGetFirst.Location = new Point(94, 721);
            btnGetFirst.Name = "btnGetFirst";
            btnGetFirst.Size = new Size(117, 34);
            btnGetFirst.TabIndex = 2;
            btnGetFirst.Text = "<<<<";
            btnGetFirst.UseVisualStyleBackColor = true;
            btnGetFirst.Click += BtnGetFirst_Click;
            // 
            // btnGetLast
            // 
            btnGetLast.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGetLast.FlatStyle = FlatStyle.Popup;
            btnGetLast.Location = new Point(595, 721);
            btnGetLast.Name = "btnGetLast";
            btnGetLast.Size = new Size(117, 34);
            btnGetLast.TabIndex = 2;
            btnGetLast.Text = ">>>>";
            btnGetLast.UseVisualStyleBackColor = true;
            btnGetLast.Click += BtnGetLast_Click;
            // 
            // chkDarkMode
            // 
            chkDarkMode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkDarkMode.CheckAlign = ContentAlignment.BottomRight;
            chkDarkMode.Checked = true;
            chkDarkMode.CheckState = CheckState.Checked;
            chkDarkMode.FlatStyle = FlatStyle.System;
            chkDarkMode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkDarkMode.Location = new Point(769, 457);
            chkDarkMode.Name = "chkDarkMode";
            chkDarkMode.Size = new Size(220, 44);
            chkDarkMode.TabIndex = 5;
            chkDarkMode.Text = "Dark Mode";
            chkDarkMode.UseVisualStyleBackColor = true;
            chkDarkMode.CheckedChanged += ChkDarkMode_CheckedChanged;
            // 
            // txtFileLocation
            // 
            txtFileLocation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFileLocation.BorderStyle = BorderStyle.FixedSingle;
            txtFileLocation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFileLocation.Location = new Point(94, 46);
            txtFileLocation.Name = "txtFileLocation";
            txtFileLocation.Size = new Size(618, 39);
            txtFileLocation.TabIndex = 6;
            txtFileLocation.TextAlign = HorizontalAlignment.Center;
            txtFileLocation.Leave += TxtFileLocation_Leave;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(94, 18);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 7;
            label3.Text = "File Location";
            // 
            // FrmPictures
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 783);
            Controls.Add(label3);
            Controls.Add(txtFileLocation);
            Controls.Add(chkDarkMode);
            Controls.Add(txtRowCount);
            Controls.Add(label2);
            Controls.Add(txtCurrentRow);
            Controls.Add(label1);
            Controls.Add(btnGetLast);
            Controls.Add(btnGetNext);
            Controls.Add(btnGetFirst);
            Controls.Add(btnGetPrevious);
            Controls.Add(btnLoad);
            Controls.Add(labNumber);
            Controls.Add(picB);
            Name = "FrmPictures";
            Text = "MNIST Pics Reader";
            Activated += FrmPictures_Activated;
            ((System.ComponentModel.ISupportInitialize)picB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picB;
        private Label labNumber;
        private Button btnLoad;
        private Button btnGetNext;
        private Button btnGetPrevious;
        private Label label1;
        private TextBox txtCurrentRow;
        private Label label2;
        private TextBox txtRowCount;
        private Button btnGetFirst;
        private Button btnGetLast;
        private CheckBox chkDarkMode;
        private TextBox txtFileLocation;
        private Label label3;
    }
}