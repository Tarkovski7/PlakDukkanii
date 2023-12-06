namespace PlakDukkani
{
    partial class Uygulama
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
            cbStatus = new ComboBox();
            numPrice = new NumericUpDown();
            numDiscount = new NumericUpDown();
            dtpReleaseDate = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtArtistGroup = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lbDiscounted = new ListBox();
            lbLast10 = new ListBox();
            lbContinued = new ListBox();
            lbDiscontinued = new ListBox();
            lvDetails = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            btnUpdate = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnNew = new Button();
            label1 = new Label();
            linklblChangePassword = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDiscount).BeginInit();
            SuspendLayout();
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(436, 539);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(151, 23);
            cbStatus.TabIndex = 75;
            // 
            // numPrice
            // 
            numPrice.Location = new Point(186, 568);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(151, 23);
            numPrice.TabIndex = 74;
            // 
            // numDiscount
            // 
            numDiscount.Location = new Point(436, 508);
            numDiscount.Name = "numDiscount";
            numDiscount.Size = new Size(151, 23);
            numDiscount.TabIndex = 73;
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(186, 536);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(151, 23);
            dtpReleaseDate.TabIndex = 72;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(362, 568);
            label9.Name = "label9";
            label9.Size = new Size(73, 15);
            label9.TabIndex = 71;
            label9.Text = "Artist/Group";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(362, 539);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 70;
            label10.Text = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(362, 510);
            label11.Name = "label11";
            label11.Size = new Size(54, 15);
            label11.TabIndex = 69;
            label11.Text = "Discount";
            // 
            // txtArtistGroup
            // 
            txtArtistGroup.Location = new Point(436, 565);
            txtArtistGroup.Name = "txtArtistGroup";
            txtArtistGroup.Size = new Size(151, 23);
            txtArtistGroup.TabIndex = 68;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(112, 565);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 67;
            label8.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(112, 536);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 66;
            label7.Text = "Release Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 507);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 65;
            label6.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(186, 504);
            txtName.Name = "txtName";
            txtName.Size = new Size(151, 23);
            txtName.TabIndex = 64;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(816, 296);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 63;
            label5.Text = "Discounted";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(620, 296);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 62;
            label4.Text = "Last Added 10 ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(816, 55);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 61;
            label3.Text = "Sales Status Continued";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(620, 55);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 60;
            label2.Text = "Sales Status Discontinued";
            // 
            // lbDiscounted
            // 
            lbDiscounted.FormattingEnabled = true;
            lbDiscounted.ItemHeight = 15;
            lbDiscounted.Location = new Point(816, 314);
            lbDiscounted.Name = "lbDiscounted";
            lbDiscounted.Size = new Size(166, 199);
            lbDiscounted.TabIndex = 59;
            // 
            // lbLast10
            // 
            lbLast10.FormattingEnabled = true;
            lbLast10.ItemHeight = 15;
            lbLast10.Location = new Point(620, 314);
            lbLast10.Name = "lbLast10";
            lbLast10.Size = new Size(166, 199);
            lbLast10.TabIndex = 58;
            // 
            // lbContinued
            // 
            lbContinued.FormattingEnabled = true;
            lbContinued.ItemHeight = 15;
            lbContinued.Location = new Point(816, 73);
            lbContinued.Name = "lbContinued";
            lbContinued.Size = new Size(166, 199);
            lbContinued.TabIndex = 57;
            // 
            // lbDiscontinued
            // 
            lbDiscontinued.FormattingEnabled = true;
            lbDiscontinued.ItemHeight = 15;
            lbDiscontinued.Location = new Point(620, 73);
            lbDiscontinued.Name = "lbDiscontinued";
            lbDiscontinued.Size = new Size(166, 199);
            lbDiscontinued.TabIndex = 56;
            // 
            // lvDetails
            // 
            lvDetails.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lvDetails.FullRowSelect = true;
            lvDetails.GridLines = true;
            lvDetails.Location = new Point(127, 74);
            lvDetails.Name = "lvDetails";
            lvDetails.Size = new Size(459, 390);
            lvDetails.TabIndex = 55;
            lvDetails.UseCompatibleStateImageBehavior = false;
            lvDetails.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Artist/Gruop";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Release Date";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Price";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Discount";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Sales Status";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(484, 619);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(103, 39);
            btnUpdate.TabIndex = 54;
            btnUpdate.Text = "Update Album";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(364, 619);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 39);
            btnSave.TabIndex = 53;
            btnSave.Text = "Save Album";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(245, 619);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 39);
            btnDelete.TabIndex = 52;
            btnDelete.Text = "Delete Album";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(127, 619);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(103, 39);
            btnNew.TabIndex = 51;
            btnNew.Text = "New Album";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 56);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 50;
            label1.Text = "Details";
            // 
            // linklblChangePassword
            // 
            linklblChangePassword.AutoSize = true;
            linklblChangePassword.Location = new Point(881, 646);
            linklblChangePassword.Name = "linklblChangePassword";
            linklblChangePassword.Size = new Size(101, 15);
            linklblChangePassword.TabIndex = 49;
            linklblChangePassword.TabStop = true;
            linklblChangePassword.Text = "Change Password";
            // 
            // Uygulama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 705);
            Controls.Add(cbStatus);
            Controls.Add(numPrice);
            Controls.Add(numDiscount);
            Controls.Add(dtpReleaseDate);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(txtArtistGroup);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbDiscounted);
            Controls.Add(lbLast10);
            Controls.Add(lbContinued);
            Controls.Add(lbDiscontinued);
            Controls.Add(lvDetails);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(label1);
            Controls.Add(linklblChangePassword);
            Name = "Uygulama";
            Text = "Uygulama";
            Load += Uygulama_Load;
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbStatus;
        private NumericUpDown numPrice;
        private NumericUpDown numDiscount;
        private DateTimePicker dtpReleaseDate;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtArtistGroup;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListBox lbDiscounted;
        private ListBox lbLast10;
        private ListBox lbContinued;
        private ListBox lbDiscontinued;
        private ListView lvDetails;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnDelete;
        private Button btnNew;
        private Label label1;
        private LinkLabel linklblChangePassword;
    }
}