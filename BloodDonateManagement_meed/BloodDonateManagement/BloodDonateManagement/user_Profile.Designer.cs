namespace BloodDonateManagement
{
    partial class user_Profile
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
            this.mcmbAreaSearch = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtxtBG = new MetroFramework.Controls.MetroTextBox();
            this.mtxtArea = new MetroFramework.Controls.MetroTextBox();
            this.mtxtAge = new MetroFramework.Controls.MetroTextBox();
            this.mtxtName = new MetroFramework.Controls.MetroTextBox();
            this.mlblBG = new MetroFramework.Controls.MetroLabel();
            this.mlblArea = new MetroFramework.Controls.MetroLabel();
            this.mlblAge = new MetroFramework.Controls.MetroLabel();
            this.mlblName = new MetroFramework.Controls.MetroLabel();
            this.mcmbSearch = new MetroFramework.Controls.MetroComboBox();
            this.UsrGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signUpTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bloodDonorDataSet = new BloodDonateManagement.BloodDonorDataSet();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.adminDataSet = new BloodDonateManagement.AdminDataSet();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_TableTableAdapter = new BloodDonateManagement.AdminDataSetTableAdapters.User_TableTableAdapter();
            this.signUp_TableTableAdapter = new BloodDonateManagement.BloodDonorDataSetTableAdapters.SignUp_TableTableAdapter();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.selectedNameTxt = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.UsrGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signUpTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mcmbAreaSearch
            // 
            this.mcmbAreaSearch.AllowDrop = true;
            this.mcmbAreaSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "B+",
            "A+",
            "B-",
            "A-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.mcmbAreaSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.mcmbAreaSearch.FormattingEnabled = true;
            this.mcmbAreaSearch.ItemHeight = 23;
            this.mcmbAreaSearch.Items.AddRange(new object[] {
            "Khilkhet",
            "Nikunjo",
            "Bashundhora",
            "Kuril",
            "Mirpur",
            "Tongi",
            "Abdullahpur",
            "Airport",
            "Gazipur",
            "Banani",
            "Dhanmondi",
            "Gulshan"});
            this.mcmbAreaSearch.Location = new System.Drawing.Point(620, 110);
            this.mcmbAreaSearch.Name = "mcmbAreaSearch";
            this.mcmbAreaSearch.Size = new System.Drawing.Size(121, 29);
            this.mcmbAreaSearch.TabIndex = 20;
            this.mcmbAreaSearch.SelectedIndexChanged += new System.EventHandler(this.mcmbAreaSearch_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(495, 110);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "Area";
            // 
            // mtxtBG
            // 
            this.mtxtBG.Location = new System.Drawing.Point(132, 234);
            this.mtxtBG.Name = "mtxtBG";
            this.mtxtBG.ReadOnly = true;
            this.mtxtBG.Size = new System.Drawing.Size(75, 23);
            this.mtxtBG.TabIndex = 15;
            // 
            // mtxtArea
            // 
            this.mtxtArea.Location = new System.Drawing.Point(93, 201);
            this.mtxtArea.Name = "mtxtArea";
            this.mtxtArea.Size = new System.Drawing.Size(75, 23);
            this.mtxtArea.TabIndex = 16;
            // 
            // mtxtAge
            // 
            this.mtxtAge.Location = new System.Drawing.Point(93, 169);
            this.mtxtAge.Name = "mtxtAge";
            this.mtxtAge.ReadOnly = true;
            this.mtxtAge.Size = new System.Drawing.Size(75, 23);
            this.mtxtAge.TabIndex = 17;
            // 
            // mtxtName
            // 
            this.mtxtName.Location = new System.Drawing.Point(93, 132);
            this.mtxtName.Name = "mtxtName";
            this.mtxtName.ReadOnly = true;
            this.mtxtName.Size = new System.Drawing.Size(75, 23);
            this.mtxtName.TabIndex = 18;
            // 
            // mlblBG
            // 
            this.mlblBG.AutoSize = true;
            this.mlblBG.Location = new System.Drawing.Point(41, 234);
            this.mlblBG.Name = "mlblBG";
            this.mlblBG.Size = new System.Drawing.Size(85, 19);
            this.mlblBG.TabIndex = 11;
            this.mlblBG.Text = "Blood Group";
            // 
            // mlblArea
            // 
            this.mlblArea.AutoSize = true;
            this.mlblArea.Location = new System.Drawing.Point(41, 205);
            this.mlblArea.Name = "mlblArea";
            this.mlblArea.Size = new System.Drawing.Size(37, 19);
            this.mlblArea.TabIndex = 12;
            this.mlblArea.Text = "Area";
            // 
            // mlblAge
            // 
            this.mlblAge.AutoSize = true;
            this.mlblAge.Location = new System.Drawing.Point(41, 169);
            this.mlblAge.Name = "mlblAge";
            this.mlblAge.Size = new System.Drawing.Size(33, 19);
            this.mlblAge.TabIndex = 13;
            this.mlblAge.Text = "Age";
            // 
            // mlblName
            // 
            this.mlblName.AutoSize = true;
            this.mlblName.Location = new System.Drawing.Point(41, 137);
            this.mlblName.Name = "mlblName";
            this.mlblName.Size = new System.Drawing.Size(45, 19);
            this.mlblName.TabIndex = 14;
            this.mlblName.Text = "Name";
            // 
            // mcmbSearch
            // 
            this.mcmbSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "B+",
            "A+",
            "B-",
            "A-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.mcmbSearch.FormattingEnabled = true;
            this.mcmbSearch.ItemHeight = 23;
            this.mcmbSearch.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "A-",
            "B-",
            "O-",
            "AB+",
            "AB-"});
            this.mcmbSearch.Location = new System.Drawing.Point(620, 76);
            this.mcmbSearch.Name = "mcmbSearch";
            this.mcmbSearch.Size = new System.Drawing.Size(121, 29);
            this.mcmbSearch.TabIndex = 10;
            this.mcmbSearch.SelectedIndexChanged += new System.EventHandler(this.mcmbSearch_SelectedIndexChanged);
            // 
            // UsrGrid
            // 
            this.UsrGrid.AutoGenerateColumns = false;
            this.UsrGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsrGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.bloodgroupDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.donorStatusDataGridViewTextBoxColumn});
            this.UsrGrid.DataSource = this.signUpTableBindingSource;
            this.UsrGrid.Location = new System.Drawing.Point(264, 145);
            this.UsrGrid.Name = "UsrGrid";
            this.UsrGrid.Size = new System.Drawing.Size(496, 229);
            this.UsrGrid.TabIndex = 9;
            this.UsrGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsrGrid_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            // 
            // bloodgroupDataGridViewTextBoxColumn
            // 
            this.bloodgroupDataGridViewTextBoxColumn.DataPropertyName = "bloodgroup";
            this.bloodgroupDataGridViewTextBoxColumn.HeaderText = "bloodgroup";
            this.bloodgroupDataGridViewTextBoxColumn.Name = "bloodgroupDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // donorStatusDataGridViewTextBoxColumn
            // 
            this.donorStatusDataGridViewTextBoxColumn.DataPropertyName = "DonorStatus";
            this.donorStatusDataGridViewTextBoxColumn.HeaderText = "DonorStatus";
            this.donorStatusDataGridViewTextBoxColumn.Name = "donorStatusDataGridViewTextBoxColumn";
            // 
            // signUpTableBindingSource
            // 
            this.signUpTableBindingSource.DataMember = "SignUp_Table";
            this.signUpTableBindingSource.DataSource = this.bloodDonorDataSet;
            // 
            // bloodDonorDataSet
            // 
            this.bloodDonorDataSet.DataSetName = "BloodDonorDataSet";
            this.bloodDonorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(495, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Blood Group";
            // 
            // adminDataSet
            // 
            this.adminDataSet.DataSetName = "AdminDataSet";
            this.adminDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "User_Table";
            this.userTableBindingSource.DataSource = this.adminDataSet;
            // 
            // user_TableTableAdapter
            // 
            this.user_TableTableAdapter.ClearBeforeFill = true;
            // 
            // signUp_TableTableAdapter
            // 
            this.signUp_TableTableAdapter.ClearBeforeFill = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(52, 342);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(155, 32);
            this.metroButton1.TabIndex = 21;
            this.metroButton1.Text = "Contact via Mail";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(52, 320);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "You Selected ";
            // 
            // selectedNameTxt
            // 
            this.selectedNameTxt.AutoSize = true;
            this.selectedNameTxt.Location = new System.Drawing.Point(146, 320);
            this.selectedNameTxt.Name = "selectedNameTxt";
            this.selectedNameTxt.Size = new System.Drawing.Size(0, 0);
            this.selectedNameTxt.TabIndex = 23;
            // 
            // user_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectedNameTxt);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.mcmbAreaSearch);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtxtBG);
            this.Controls.Add(this.mtxtArea);
            this.Controls.Add(this.mtxtAge);
            this.Controls.Add(this.mtxtName);
            this.Controls.Add(this.mlblBG);
            this.Controls.Add(this.mlblArea);
            this.Controls.Add(this.mlblAge);
            this.Controls.Add(this.mlblName);
            this.Controls.Add(this.mcmbSearch);
            this.Controls.Add(this.UsrGrid);
            this.Controls.Add(this.metroLabel1);
            this.Name = "user_Profile";
            this.Text = "profile";
            this.Load += new System.EventHandler(this.user_Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsrGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signUpTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox mcmbAreaSearch;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtxtBG;
        private MetroFramework.Controls.MetroTextBox mtxtArea;
        private MetroFramework.Controls.MetroTextBox mtxtAge;
        private MetroFramework.Controls.MetroTextBox mtxtName;
        private MetroFramework.Controls.MetroLabel mlblBG;
        private MetroFramework.Controls.MetroLabel mlblArea;
        private MetroFramework.Controls.MetroLabel mlblAge;
        private MetroFramework.Controls.MetroLabel mlblName;
        private MetroFramework.Controls.MetroComboBox mcmbSearch;
        private System.Windows.Forms.DataGridView UsrGrid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private AdminDataSet adminDataSet;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private AdminDataSetTableAdapters.User_TableTableAdapter user_TableTableAdapter;
        private BloodDonorDataSet bloodDonorDataSet;
        private System.Windows.Forms.BindingSource signUpTableBindingSource;
        private BloodDonorDataSetTableAdapters.SignUp_TableTableAdapter signUp_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorStatusDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel selectedNameTxt;
    }
}