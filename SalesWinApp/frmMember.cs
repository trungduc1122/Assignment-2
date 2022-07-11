using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmMember : Form
    {
        public frmMember()
        {
            InitializeComponent();
        }
        BindingSource source;
        IMemberRepository memberRepository1 = new MemberRepository();
        public void Loadmembers()
        {
            var list = memberRepository1.GetMembers();
            source = new BindingSource();
            source.DataSource = list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail
            {
                Text = "Add member",
                InsertOrUpdate = false,
                memberRepository = memberRepository1
            };
            if(frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                Loadmembers();
            }
        }

        
    }
}
