using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;
using BusinessObject;

namespace SalesWinApp
{
    public partial class frmMemberDetail : Form
    {
        public frmMemberDetail()
        {
            InitializeComponent();
        }
        public IMemberRepository memberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Member info;
        private void button3_Click(object sender, EventArgs e) => Close();

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new Member
                {
                    MemberId = int.Parse(txtID.Text),
                    CompanyName=txtName.Text,
                    Email = txtEmail.Text,
                    Password=txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };
                if (InsertOrUpdate == false)
                {
                    memberRepository.UpdateMember(member);
                }
                else
                {
                    memberRepository.AddMember(member);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "add" : "update");
            }
        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
