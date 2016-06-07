namespace swg
{
    partial class MainWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgTrainers = new System.Windows.Forms.DataGridView();
            this.colProfession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlanet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWaypoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTrainers = new System.Windows.Forms.TabPage();
            this.cbTrainersCity = new System.Windows.Forms.ComboBox();
            this.cbTrainersPlanet = new System.Windows.Forms.ComboBox();
            this.cbTrainerProfession = new System.Windows.Forms.ComboBox();
            this.tabInformants = new System.Windows.Forms.TabPage();
            this.dgInformants = new System.Windows.Forms.DataGridView();
            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infColPlanet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infColCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infColWaypoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrainers)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabTrainers.SuspendLayout();
            this.tabInformants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInformants)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTrainers
            // 
            this.dgTrainers.AllowUserToAddRows = false;
            this.dgTrainers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            this.dgTrainers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgTrainers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTrainers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTrainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTrainers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProfession,
            this.colPlanet,
            this.colCity,
            this.colWaypoint});
            this.dgTrainers.Location = new System.Drawing.Point(3, 37);
            this.dgTrainers.Name = "dgTrainers";
            this.dgTrainers.RowHeadersVisible = false;
            this.dgTrainers.Size = new System.Drawing.Size(660, 421);
            this.dgTrainers.TabIndex = 0;
            // 
            // colProfession
            // 
            this.colProfession.HeaderText = "Profession";
            this.colProfession.Name = "colProfession";
            // 
            // colPlanet
            // 
            this.colPlanet.HeaderText = "Planet";
            this.colPlanet.Name = "colPlanet";
            // 
            // colCity
            // 
            this.colCity.HeaderText = "City";
            this.colCity.Name = "colCity";
            // 
            // colWaypoint
            // 
            this.colWaypoint.HeaderText = "Waypoint";
            this.colWaypoint.Name = "colWaypoint";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabTrainers);
            this.tabControl.Controls.Add(this.tabInformants);
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.Location = new System.Drawing.Point(2, 26);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(674, 487);
            this.tabControl.TabIndex = 1;
            // 
            // tabTrainers
            // 
            this.tabTrainers.Controls.Add(this.cbTrainersCity);
            this.tabTrainers.Controls.Add(this.cbTrainersPlanet);
            this.tabTrainers.Controls.Add(this.dgTrainers);
            this.tabTrainers.Controls.Add(this.cbTrainerProfession);
            this.tabTrainers.Location = new System.Drawing.Point(4, 22);
            this.tabTrainers.Name = "tabTrainers";
            this.tabTrainers.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrainers.Size = new System.Drawing.Size(666, 461);
            this.tabTrainers.TabIndex = 0;
            this.tabTrainers.Text = "Trainers";
            this.tabTrainers.UseVisualStyleBackColor = true;
            // 
            // cbTrainersCity
            // 
            this.cbTrainersCity.FormattingEnabled = true;
            this.cbTrainersCity.Items.AddRange(new object[] {
            "Select City...",
            "Anchorhead",
            "Bela Vistal",
            "Bestine",
            "Coronet",
            "Dearic",
            "Deeja City",
            "Dee\'ja Peak",
            "Doaba Guerfel",
            "Kaadara",
            "Keren",
            "Kor Vella",
            "Moenia",
            "Moenia City",
            "Mos Eisley",
            "Mos Entha",
            "Mos Espa",
            "Namle",
            "Nashal",
            "Nym\'s Stronghold",
            "Rebel Base",
            "Rebel Outpost",
            "Restuss",
            "Theed",
            "Theed City",
            "Tyrena",
            "Vreni Island",
            "Wayfar"});
            this.cbTrainersCity.Location = new System.Drawing.Point(330, 10);
            this.cbTrainersCity.Name = "cbTrainersCity";
            this.cbTrainersCity.Size = new System.Drawing.Size(148, 21);
            this.cbTrainersCity.TabIndex = 4;
            // 
            // cbTrainersPlanet
            // 
            this.cbTrainersPlanet.FormattingEnabled = true;
            this.cbTrainersPlanet.Items.AddRange(new object[] {
            "Select Planet...",
            "Corellia",
            "Dantooine",
            "Lok",
            "Naboo",
            "Rori",
            "Talus",
            "Tatooine"});
            this.cbTrainersPlanet.Location = new System.Drawing.Point(172, 10);
            this.cbTrainersPlanet.Name = "cbTrainersPlanet";
            this.cbTrainersPlanet.Size = new System.Drawing.Size(148, 21);
            this.cbTrainersPlanet.TabIndex = 3;
            // 
            // cbTrainerProfession
            // 
            this.cbTrainerProfession.FormattingEnabled = true;
            this.cbTrainerProfession.Items.AddRange(new object[] {
            "Select Profession...",
            "Architect",
            "Armorsmith",
            "Artisan",
            "Bio-Engineer",
            "Bounty Hunter",
            "Brawler",
            "Carbineer",
            "Chef",
            "Combat Medic",
            "Commando",
            "Creature Handler",
            "Dancer",
            "Doctor",
            "Droid Engineer",
            "Entertainer",
            "Fencer",
            "Image Designer",
            "Marksman",
            "Medic",
            "Merchant",
            "Musician",
            "Pikeman",
            "Pistoleer",
            "Politician",
            "Ranger",
            "Rifleman",
            "Scout",
            "Shipwright",
            "Smuggler",
            "Squad Leader",
            "Swordsman",
            "Tailor",
            "Teras Kasi",
            "Weaponsmith"});
            this.cbTrainerProfession.Location = new System.Drawing.Point(6, 10);
            this.cbTrainerProfession.Name = "cbTrainerProfession";
            this.cbTrainerProfession.Size = new System.Drawing.Size(155, 21);
            this.cbTrainerProfession.TabIndex = 2;
            // 
            // tabInformants
            // 
            this.tabInformants.Controls.Add(this.dgInformants);
            this.tabInformants.Location = new System.Drawing.Point(4, 22);
            this.tabInformants.Name = "tabInformants";
            this.tabInformants.Padding = new System.Windows.Forms.Padding(3);
            this.tabInformants.Size = new System.Drawing.Size(666, 461);
            this.tabInformants.TabIndex = 1;
            this.tabInformants.Text = "Informants";
            this.tabInformants.UseVisualStyleBackColor = true;
            // 
            // dgInformants
            // 
            this.dgInformants.AllowUserToAddRows = false;
            this.dgInformants.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            this.dgInformants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgInformants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgInformants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInformants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRank,
            this.infColPlanet,
            this.infColCity,
            this.infColWaypoint});
            this.dgInformants.Location = new System.Drawing.Point(3, 3);
            this.dgInformants.Name = "dgInformants";
            this.dgInformants.RowHeadersVisible = false;
            this.dgInformants.Size = new System.Drawing.Size(660, 422);
            this.dgInformants.TabIndex = 1;
            // 
            // colRank
            // 
            this.colRank.HeaderText = "Rank";
            this.colRank.Name = "colRank";
            // 
            // infColPlanet
            // 
            this.infColPlanet.HeaderText = "Planet";
            this.infColPlanet.Name = "infColPlanet";
            // 
            // infColCity
            // 
            this.infColCity.HeaderText = "City";
            this.infColCity.Name = "infColCity";
            // 
            // infColWaypoint
            // 
            this.infColWaypoint.HeaderText = "Waypoint";
            this.infColWaypoint.Name = "infColWaypoint";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 514);
            this.Controls.Add(this.tabControl);
            this.Name = "MainWindow";
            this.Text = "SWG";
            ((System.ComponentModel.ISupportInitialize)(this.dgTrainers)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabTrainers.ResumeLayout(false);
            this.tabInformants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInformants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTrainers;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTrainers;
        private System.Windows.Forms.TabPage tabInformants;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfession;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlanet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWaypoint;
        private System.Windows.Forms.DataGridView dgInformants;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn infColPlanet;
        private System.Windows.Forms.DataGridViewTextBoxColumn infColCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn infColWaypoint;
        private System.Windows.Forms.ComboBox cbTrainerProfession;
        private System.Windows.Forms.ComboBox cbTrainersPlanet;
        private System.Windows.Forms.ComboBox cbTrainersCity;
    }
}

