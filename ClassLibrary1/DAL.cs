using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using getset;

namespace DAl
{
    public class DAL
    {
        SqlConnection con;
        DataSet ds;
        SqlDataAdapter ada;
        // getdata g = new getdata();



        public SqlConnection getconnection()
        {
            return (new SqlConnection(@"data source=DESKTOP-7F3S625;initial catalog= addressbook; integrated security=true;"));
        }
        public DataSet sqlset()
        {
            return (new DataSet());

        }
        public SqlDataAdapter sqlada()
        {
            return (new SqlDataAdapter("select * from addrsbook", con));

        }
        void FillData()
        {
            con = getconnection();
            ds = sqlset();
            ada = sqlada();
            ada.Fill(ds);

        }
        public int insertrecord(getdata g)
        {
            FillData();
            SqlCommandBuilder cb = new SqlCommandBuilder(ada);

            foreach (DataRow d in ds.Tables[0].Rows)
            {
                if (g.addressid == Convert.ToByte(d["address_id"]))
                {
                    return 0;
                }

            }
            DataRow dr = ds.Tables[0].NewRow();
            dr["address_id"] = g.addressid;
            dr["lname"] = g.lname;
            dr["fname"] = g.fname;
            dr["phn_no"] = g.phn_no;
            ds.Tables[0].Rows.Add(dr);
            ada.Update(ds);
            return 1;
        }
        public int deletedata(getdata g)
        {
            FillData();
            SqlCommandBuilder cb = new SqlCommandBuilder(ada);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (Convert.ToInt16(dr["address_id"]) == g.addressid)
                {
                    dr.Delete();
                    ada.Update(ds);
                    return 1;
                }

            }
            return 0;
        }

        public int update(getdata g)
        {
            FillData();
            SqlCommandBuilder cb = new SqlCommandBuilder(ada);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (Convert.ToInt32(dr["address_id"]) == g.addressid)
                {
                    dr["fname"] = g.fname;
                    ada.Update(ds);

                    return 1;
                }
            }
            return 0;

        }
        public getdata search(getdata g)
        {
            FillData();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (Convert.ToInt16(dr["address_id"]) == g.addressid)
                {
                    g.lname = dr["lname"].ToString();
                    g.fname = dr["fname"].ToString();
                    g.phn_no = dr["phn_no"].ToString();
                    g.addressid = Convert.ToInt16(dr["address_id"]);

                }

            }
            return g;
        }

    }
}
