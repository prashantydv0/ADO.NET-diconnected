using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using getset;
using BAL;

namespace CLIENT2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        getdata g = new getdata();
        bussinessAl bal = new bussinessAl();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            g.addressid = Convert.ToByte(textid.Text);
            g.fname = textfname.Text;
            g.lname = textlname.Text;
            g.phn_no = textphnno.Text;
           int flag= bal.insertrecord(g);
            if (flag == 1)
                TextBox1.Text = "record inserted";
            else TextBox1.Text = "id already present record not inserted";
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            g.addressid = Convert.ToByte(textid.Text);
            int flag = bal.deletedata(g);
            if (flag == 1)
                TextBox1.Text = "record deleted";
            else TextBox1.Text = "id not  present record not deleted";
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            g.addressid= Convert.ToByte(textid.Text);
            g.fname = textfname.Text;
            int flag=bal.update(g);
            if (flag == 1)
                TextBox1.Text = "record updated";
            else TextBox1.Text = "id not  present record not updated";


        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            g.addressid = Convert.ToByte(textid.Text);
            g=bal.search(g);
            textlname.Text = g.lname;
            textfname.Text = g.fname;
            textphnno.Text = g.phn_no.ToString();


        }
    }
}