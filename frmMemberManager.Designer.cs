
namespace MyStoreWinApp
{
    partial class frmMemberManager
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
            panel1 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            btClose = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            btDeleteMember = new System.Windows.Forms.Button();
            btUpdateMember = new System.Windows.Forms.Button();
            btNewMember = new System.Windows.Forms.Button();
            tbMemberCountry = new System.Windows.Forms.TextBox();
            tbMemberCity = new System.Windows.Forms.TextBox();
            tbMemberEmail = new System.Windows.Forms.TextBox();
            tbMemberName = new System.Windows.Forms.TextBox();
            tbMemberPassword = new System.Windows.Forms.TextBox();
            tbMemberId = new System.Windows.Forms.TextBox();
            lbCountry = new System.Windows.Forms.Label();
            lbCity = new System.Windows.Forms.Label();
            lbMemberEmail = new System.Windows.Forms.Label();
            lbMemberName = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            lbMemberID = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            btSearch = new System.Windows.Forms.Button();
            tbSearchName = new System.Windows.Forms.TextBox();
            chbSort = new System.Windows.Forms.CheckBox();
            tbSearchId = new System.Windows.Forms.TextBox();
            lbSearch = new System.Windows.Forms.Label();
            lbSearchName = new System.Windows.Forms.Label();
            lbSearchId = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            btFilter = new System.Windows.Forms.Button();
            cbFilterCountry = new System.Windows.Forms.ComboBox();
            cbFilterCity = new System.Windows.Forms.ComboBox();
            lbFIlterCountry = new System.Windows.Forms.Label();
            lbFilterCity = new System.Windows.Forms.Label();
            lbFilter = new System.Windows.Forms.Label();
            grMemberList = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grMemberList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btClose);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btDeleteMember);
            panel1.Controls.Add(btUpdateMember);
            panel1.Controls.Add(btNewMember);
            panel1.Controls.Add(tbMemberCountry);
            panel1.Controls.Add(tbMemberCity);
            panel1.Controls.Add(tbMemberEmail);
            panel1.Controls.Add(tbMemberName);
            panel1.Controls.Add(tbMemberPassword);
            panel1.Controls.Add(tbMemberId);
            panel1.Controls.Add(lbCountry);
            panel1.Controls.Add(lbCity);
            panel1.Controls.Add(lbMemberEmail);
            panel1.Controls.Add(lbMemberName);
            panel1.Controls.Add(lbPassword);
            panel1.Controls.Add(lbMemberID);
            panel1.Location = new System.Drawing.Point(6, 67);
            panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1751, 274);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(4, 0);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(152, 28);
            label3.TabIndex = 6;
            label3.Text = "Manage System";
            // 
            // btClose
            // 
            btClose.BackColor = System.Drawing.Color.Yellow;
            btClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btClose.ForeColor = System.Drawing.SystemColors.ControlText;
            btClose.Location = new System.Drawing.Point(1381, 100);
            btClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btClose.Name = "btClose";
            btClose.Size = new System.Drawing.Size(290, 67);
            btClose.TabIndex = 9;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(3, 26);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(352, 25);
            label2.TabIndex = 15;
            label2.Text = "You must enter Member ID before using";
            // 
            // btDeleteMember
            // 
            btDeleteMember.BackColor = System.Drawing.Color.Red;
            btDeleteMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            btDeleteMember.Location = new System.Drawing.Point(1094, 214);
            btDeleteMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btDeleteMember.Name = "btDeleteMember";
            btDeleteMember.Size = new System.Drawing.Size(118, 50);
            btDeleteMember.TabIndex = 14;
            btDeleteMember.Text = "Delete";
            btDeleteMember.UseVisualStyleBackColor = false;
            btDeleteMember.Click += btDeleteMember_Click;
            // 
            // btUpdateMember
            // 
            btUpdateMember.BackColor = System.Drawing.Color.Lime;
            btUpdateMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            btUpdateMember.Location = new System.Drawing.Point(1094, 117);
            btUpdateMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btUpdateMember.Name = "btUpdateMember";
            btUpdateMember.Size = new System.Drawing.Size(118, 50);
            btUpdateMember.TabIndex = 13;
            btUpdateMember.Text = "Update";
            btUpdateMember.UseVisualStyleBackColor = false;
            btUpdateMember.Click += btUpdateMember_Click;
            // 
            // btNewMember
            // 
            btNewMember.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btNewMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            btNewMember.Location = new System.Drawing.Point(1094, 20);
            btNewMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btNewMember.Name = "btNewMember";
            btNewMember.Size = new System.Drawing.Size(118, 50);
            btNewMember.TabIndex = 12;
            btNewMember.Text = "New";
            btNewMember.UseVisualStyleBackColor = false;
            btNewMember.Click += btNewMember_Click;
            // 
            // tbMemberCountry
            // 
            tbMemberCountry.Location = new System.Drawing.Point(555, 225);
            tbMemberCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbMemberCountry.Name = "tbMemberCountry";
            tbMemberCountry.Size = new System.Drawing.Size(214, 31);
            tbMemberCountry.TabIndex = 11;
            // 
            // tbMemberCity
            // 
            tbMemberCity.Location = new System.Drawing.Point(554, 143);
            tbMemberCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbMemberCity.Name = "tbMemberCity";
            tbMemberCity.Size = new System.Drawing.Size(215, 31);
            tbMemberCity.TabIndex = 10;
            // 
            // tbMemberEmail
            // 
            tbMemberEmail.Location = new System.Drawing.Point(557, 102);
            tbMemberEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbMemberEmail.Name = "tbMemberEmail";
            tbMemberEmail.Size = new System.Drawing.Size(215, 31);
            tbMemberEmail.TabIndex = 9;
            // 
            // tbMemberName
            // 
            tbMemberName.Location = new System.Drawing.Point(554, 184);
            tbMemberName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbMemberName.Name = "tbMemberName";
            tbMemberName.Size = new System.Drawing.Size(214, 31);
            tbMemberName.TabIndex = 8;
            // 
            // tbMemberPassword
            // 
            tbMemberPassword.Location = new System.Drawing.Point(557, 61);
            tbMemberPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbMemberPassword.Name = "tbMemberPassword";
            tbMemberPassword.Size = new System.Drawing.Size(215, 31);
            tbMemberPassword.TabIndex = 7;
            // 
            // tbMemberId
            // 
            tbMemberId.Location = new System.Drawing.Point(557, 20);
            tbMemberId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbMemberId.Name = "tbMemberId";
            tbMemberId.Size = new System.Drawing.Size(215, 31);
            tbMemberId.TabIndex = 6;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new System.Drawing.Point(381, 231);
            lbCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new System.Drawing.Size(75, 25);
            lbCountry.TabIndex = 5;
            lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new System.Drawing.Point(381, 149);
            lbCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbCity.Name = "lbCity";
            lbCity.Size = new System.Drawing.Size(42, 25);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbMemberEmail
            // 
            lbMemberEmail.AutoSize = true;
            lbMemberEmail.Location = new System.Drawing.Point(381, 108);
            lbMemberEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbMemberEmail.Name = "lbMemberEmail";
            lbMemberEmail.Size = new System.Drawing.Size(54, 25);
            lbMemberEmail.TabIndex = 3;
            lbMemberEmail.Text = "Email";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new System.Drawing.Point(381, 190);
            lbMemberName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new System.Drawing.Size(131, 25);
            lbMemberName.TabIndex = 2;
            lbMemberName.Text = "Member Name";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(381, 67);
            lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(87, 25);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new System.Drawing.Point(381, 26);
            lbMemberID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new System.Drawing.Size(102, 25);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID";
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel2.Controls.Add(btSearch);
            panel2.Controls.Add(tbSearchName);
            panel2.Controls.Add(chbSort);
            panel2.Controls.Add(tbSearchId);
            panel2.Controls.Add(lbSearch);
            panel2.Controls.Add(lbSearchName);
            panel2.Controls.Add(lbSearchId);
            panel2.Location = new System.Drawing.Point(6, 351);
            panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(767, 168);
            panel2.TabIndex = 1;
            // 
            // btSearch
            // 
            btSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            btSearch.Location = new System.Drawing.Point(492, 20);
            btSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btSearch.Name = "btSearch";
            btSearch.Size = new System.Drawing.Size(251, 88);
            btSearch.TabIndex = 5;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // tbSearchName
            // 
            tbSearchName.Location = new System.Drawing.Point(119, 77);
            tbSearchName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbSearchName.Name = "tbSearchName";
            tbSearchName.Size = new System.Drawing.Size(307, 31);
            tbSearchName.TabIndex = 4;
            // 
            // chbSort
            // 
            chbSort.AutoSize = true;
            chbSort.Location = new System.Drawing.Point(40, 130);
            chbSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            chbSort.Name = "chbSort";
            chbSort.Size = new System.Drawing.Size(245, 29);
            chbSort.TabIndex = 4;
            chbSort.Text = "Sort By Descending Name";
            chbSort.UseVisualStyleBackColor = true;
            chbSort.CheckedChanged += chbSort_CheckedChanged;
            chbSort.CheckStateChanged += chbSort_CheckStateChanged;
            // 
            // tbSearchId
            // 
            tbSearchId.Location = new System.Drawing.Point(119, 20);
            tbSearchId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbSearchId.Name = "tbSearchId";
            tbSearchId.Size = new System.Drawing.Size(307, 31);
            tbSearchId.TabIndex = 3;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbSearch.Location = new System.Drawing.Point(4, -5);
            lbSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new System.Drawing.Size(72, 28);
            lbSearch.TabIndex = 0;
            lbSearch.Text = "Search";
            // 
            // lbSearchName
            // 
            lbSearchName.AutoSize = true;
            lbSearchName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbSearchName.Location = new System.Drawing.Point(40, 77);
            lbSearchName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbSearchName.Name = "lbSearchName";
            lbSearchName.Size = new System.Drawing.Size(68, 28);
            lbSearchName.TabIndex = 2;
            lbSearchName.Text = "Name";
            // 
            // lbSearchId
            // 
            lbSearchId.AutoSize = true;
            lbSearchId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbSearchId.Location = new System.Drawing.Point(40, 20);
            lbSearchId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbSearchId.Name = "lbSearchId";
            lbSearchId.Size = new System.Drawing.Size(30, 28);
            lbSearchId.TabIndex = 1;
            lbSearchId.Text = "Id";
            // 
            // panel3
            // 
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel3.Controls.Add(btFilter);
            panel3.Controls.Add(cbFilterCountry);
            panel3.Controls.Add(cbFilterCity);
            panel3.Controls.Add(lbFIlterCountry);
            panel3.Controls.Add(lbFilterCity);
            panel3.Controls.Add(lbFilter);
            panel3.Location = new System.Drawing.Point(6, 546);
            panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(767, 144);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // btFilter
            // 
            btFilter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            btFilter.Location = new System.Drawing.Point(492, 20);
            btFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btFilter.Name = "btFilter";
            btFilter.Size = new System.Drawing.Size(251, 88);
            btFilter.TabIndex = 6;
            btFilter.Text = "Filter";
            btFilter.UseVisualStyleBackColor = false;
            btFilter.Click += btFilter_Click;
            // 
            // cbFilterCountry
            // 
            cbFilterCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbFilterCountry.FormattingEnabled = true;
            cbFilterCountry.Location = new System.Drawing.Point(179, 75);
            cbFilterCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbFilterCountry.Name = "cbFilterCountry";
            cbFilterCountry.Size = new System.Drawing.Size(251, 33);
            cbFilterCountry.TabIndex = 8;
            // 
            // cbFilterCity
            // 
            cbFilterCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbFilterCity.FormattingEnabled = true;
            cbFilterCity.Location = new System.Drawing.Point(179, 27);
            cbFilterCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbFilterCity.Name = "cbFilterCity";
            cbFilterCity.Size = new System.Drawing.Size(251, 33);
            cbFilterCity.TabIndex = 7;
            // 
            // lbFIlterCountry
            // 
            lbFIlterCountry.AutoSize = true;
            lbFIlterCountry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbFIlterCountry.Location = new System.Drawing.Point(44, 78);
            lbFIlterCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbFIlterCountry.Name = "lbFIlterCountry";
            lbFIlterCountry.Size = new System.Drawing.Size(88, 28);
            lbFIlterCountry.TabIndex = 6;
            lbFIlterCountry.Text = "Country";
            // 
            // lbFilterCity
            // 
            lbFilterCity.AutoSize = true;
            lbFilterCity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbFilterCity.Location = new System.Drawing.Point(44, 27);
            lbFilterCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbFilterCity.Name = "lbFilterCity";
            lbFilterCity.Size = new System.Drawing.Size(49, 28);
            lbFilterCity.TabIndex = 6;
            lbFilterCity.Text = "City";
            // 
            // lbFilter
            // 
            lbFilter.AutoSize = true;
            lbFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbFilter.Location = new System.Drawing.Point(7, -5);
            lbFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbFilter.Name = "lbFilter";
            lbFilter.Size = new System.Drawing.Size(59, 28);
            lbFilter.TabIndex = 1;
            lbFilter.Text = "Filter";
            // 
            // grMemberList
            // 
            grMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grMemberList.Location = new System.Drawing.Point(814, 373);
            grMemberList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grMemberList.Name = "grMemberList";
            grMemberList.RowHeadersWidth = 62;
            grMemberList.RowTemplate.Height = 25;
            grMemberList.Size = new System.Drawing.Size(929, 317);
            grMemberList.TabIndex = 3;
            grMemberList.CellContentClick += grMemberList_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(659, 0);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(446, 54);
            label1.TabIndex = 15;
            label1.Text = "Member Management";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(814, 340);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(43, 28);
            label4.TabIndex = 6;
            label4.Text = "List";
            // 
            // frmMemberManager
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1743, 716);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(grMemberList);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "frmMemberManager";
            Text = "frmMemberManager";
            Load += frmMemberManager_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbMemberCountry;
        private System.Windows.Forms.TextBox tbMemberCity;
        private System.Windows.Forms.TextBox tbMemberEmail;
        private System.Windows.Forms.TextBox tbMemberName;
        private System.Windows.Forms.TextBox tbMemberPassword;
        private System.Windows.Forms.TextBox tbMemberId;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbMemberEmail;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Button btDeleteMember;
        private System.Windows.Forms.Button btUpdateMember;
        private System.Windows.Forms.Button btNewMember;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbSearchName;
        private System.Windows.Forms.Label lbSearchId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.TextBox tbSearchId;
        private System.Windows.Forms.ComboBox cbFilterCountry;
        private System.Windows.Forms.ComboBox cbFilterCity;
        private System.Windows.Forms.Label lbFIlterCountry;
        private System.Windows.Forms.Label lbFilterCity;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.DataGridView grMemberList;
        private System.Windows.Forms.CheckBox chbSort;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}