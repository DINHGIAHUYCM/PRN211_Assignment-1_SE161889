﻿using System;
using System.IO;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.Repository;
using Newtonsoft.Json;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        private IMemberRepository memberRepository;
        private AdminObject admin;
        public frmLogin()
        {
            InitializeComponent();
            memberRepository = new MemberRepository();
        }



        private void btLogin_Click(object sender, EventArgs e)
        {
            var Email = tbEmail.Text;
            var Password = tbPassword.Text;

            if (String.IsNullOrEmpty(Email) || String.IsNullOrWhiteSpace(Email)
                || String.IsNullOrEmpty(Password) || String.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Please enter Email and Password!!");
                return;
            }

            if (Email.Equals(admin.adminEmail) && Password.Equals(admin.adminPassword))
            {
                this.Hide();
                frmMemberManager AdminForm = new frmMemberManager();
                AdminForm.Closed += (sender, e) => this.Close();
                AdminForm.Show();
                return; 
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
            using StreamReader streamReader = new StreamReader(@"C:\Users\dinhg\Desktop\PRN ASSIGNMENT\Assignment1_PRN-main\appsettings.json");
            string json = streamReader.ReadToEnd();
            admin = JsonConvert.DeserializeObject<AdminObject>(json);
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
