
namespace SystemHR.UserInterface.Forms
{
    partial class MainForm
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
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.btnPositions = new System.Windows.Forms.Button();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.btnSalaries = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btnOrganizationalStructure = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnContracts = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.tpConfiguration = new System.Windows.Forms.TabPage();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.pMain = new System.Windows.Forms.Panel();
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.tabControl1.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpGeneral);
            this.tabControl1.Controls.Add(this.tpConfiguration);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1023, 75);
            this.tabControl1.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.btnPositions);
            this.tpGeneral.Controls.Add(this.splitter5);
            this.tpGeneral.Controls.Add(this.btnDepartments);
            this.tpGeneral.Controls.Add(this.splitter4);
            this.tpGeneral.Controls.Add(this.btnSalaries);
            this.tpGeneral.Controls.Add(this.splitter3);
            this.tpGeneral.Controls.Add(this.btnOrganizationalStructure);
            this.tpGeneral.Controls.Add(this.splitter2);
            this.tpGeneral.Controls.Add(this.btnContracts);
            this.tpGeneral.Controls.Add(this.splitter1);
            this.tpGeneral.Controls.Add(this.btnEmployees);
            this.tpGeneral.Location = new System.Drawing.Point(4, 32);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(1015, 39);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Ogólne";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // btnPositions
            // 
            this.btnPositions.BackColor = System.Drawing.Color.White;
            this.btnPositions.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPositions.Image = global::SystemHR.UserInterface.Properties.Resources.Positions_32;
            this.btnPositions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPositions.Location = new System.Drawing.Point(772, 3);
            this.btnPositions.Name = "btnPositions";
            this.btnPositions.Size = new System.Drawing.Size(137, 33);
            this.btnPositions.TabIndex = 10;
            this.btnPositions.Text = "Stanowiska";
            this.btnPositions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPositions.UseVisualStyleBackColor = false;
            // 
            // splitter5
            // 
            this.splitter5.Location = new System.Drawing.Point(767, 3);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(5, 33);
            this.splitter5.TabIndex = 9;
            this.splitter5.TabStop = false;
            // 
            // btnDepartments
            // 
            this.btnDepartments.BackColor = System.Drawing.Color.White;
            this.btnDepartments.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDepartments.Image = global::SystemHR.UserInterface.Properties.Resources.Departments_32;
            this.btnDepartments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartments.Location = new System.Drawing.Point(668, 3);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Size = new System.Drawing.Size(99, 33);
            this.btnDepartments.TabIndex = 8;
            this.btnDepartments.Text = "Działy";
            this.btnDepartments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDepartments.UseVisualStyleBackColor = false;
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(663, 3);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(5, 33);
            this.splitter4.TabIndex = 7;
            this.splitter4.TabStop = false;
            // 
            // btnSalaries
            // 
            this.btnSalaries.BackColor = System.Drawing.Color.White;
            this.btnSalaries.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalaries.Image = global::SystemHR.UserInterface.Properties.Resources.Salary_32;
            this.btnSalaries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalaries.Location = new System.Drawing.Point(504, 3);
            this.btnSalaries.Name = "btnSalaries";
            this.btnSalaries.Size = new System.Drawing.Size(159, 33);
            this.btnSalaries.TabIndex = 6;
            this.btnSalaries.Text = "Wynarodzenia";
            this.btnSalaries.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalaries.UseVisualStyleBackColor = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(499, 3);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(5, 33);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // btnOrganizationalStructure
            // 
            this.btnOrganizationalStructure.BackColor = System.Drawing.Color.White;
            this.btnOrganizationalStructure.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrganizationalStructure.Image = global::SystemHR.UserInterface.Properties.Resources.OrganizationalUnits_32;
            this.btnOrganizationalStructure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrganizationalStructure.Location = new System.Drawing.Point(269, 3);
            this.btnOrganizationalStructure.Name = "btnOrganizationalStructure";
            this.btnOrganizationalStructure.Size = new System.Drawing.Size(230, 33);
            this.btnOrganizationalStructure.TabIndex = 4;
            this.btnOrganizationalStructure.Text = "Struktura organizacyjna";
            this.btnOrganizationalStructure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrganizationalStructure.UseVisualStyleBackColor = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(264, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 33);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // btnContracts
            // 
            this.btnContracts.BackColor = System.Drawing.Color.White;
            this.btnContracts.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnContracts.Image = global::SystemHR.UserInterface.Properties.Resources.Contracts_32;
            this.btnContracts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContracts.Location = new System.Drawing.Point(149, 3);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(115, 33);
            this.btnContracts.TabIndex = 2;
            this.btnContracts.Text = "Umowy";
            this.btnContracts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContracts.UseVisualStyleBackColor = false;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(144, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 33);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.White;
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEmployees.Image = global::SystemHR.UserInterface.Properties.Resources.Emplyees_32;
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(3, 3);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(141, 33);
            this.btnEmployees.TabIndex = 0;
            this.btnEmployees.Text = "Pracownicy";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // tpConfiguration
            // 
            this.tpConfiguration.Location = new System.Drawing.Point(4, 32);
            this.tpConfiguration.Name = "tpConfiguration";
            this.tpConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfiguration.Size = new System.Drawing.Size(1015, 39);
            this.tpConfiguration.TabIndex = 1;
            this.tpConfiguration.Text = "Konfiguracja";
            this.tpConfiguration.UseVisualStyleBackColor = true;
            // 
            // ssMain
            // 
            this.ssMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersion,
            this.tsslDatabase,
            this.tsslUser});
            this.ssMain.Location = new System.Drawing.Point(0, 562);
            this.ssMain.Name = "ssMain";
            this.ssMain.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.ssMain.Size = new System.Drawing.Size(1023, 26);
            this.ssMain.SizingGrip = false;
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(98, 20);
            this.tsslVersion.Text = "Wersja 1.0.0.0";
            // 
            // tsslDatabase
            // 
            this.tsslDatabase.Image = global::SystemHR.UserInterface.Properties.Resources.Database_16;
            this.tsslDatabase.Name = "tsslDatabase";
            this.tsslDatabase.Size = new System.Drawing.Size(182, 20);
            this.tsslDatabase.Text = "Baza: HumanResources";
            // 
            // tsslUser
            // 
            this.tsslUser.Image = global::SystemHR.UserInterface.Properties.Resources.User_16;
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(163, 20);
            this.tsslUser.Text = "Użytkownik: Damian";
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.White;
            this.pMain.Controls.Add(this.tcTabs);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 75);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1023, 487);
            this.pMain.TabIndex = 2;
            // 
            // tcTabs
            // 
            this.tcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcTabs.ItemSize = new System.Drawing.Size(105, 22);
            this.tcTabs.Location = new System.Drawing.Point(0, 0);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(1023, 487);
            this.tcTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcTabs.TabIndex = 0;
            this.tcTabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcTabs_DrawItem);
            this.tcTabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tcTabs_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 588);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System HR";
            this.tabControl1.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.Button btnPositions;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Button btnSalaries;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button btnOrganizationalStructure;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.TabPage tpConfiguration;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripStatusLabel tsslDatabase;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.TabControl tcTabs;
    }
}