using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using getset;
using DAl;

namespace BAL
{
    public class bussinessAl
    {
        DAL d = new DAL();
        public int insertrecord(getdata g)
        {
            return (d.insertrecord(g));
        }
        public int deletedata(getdata g)
        {
            return (d.deletedata(g));
        }
        public int update(getdata g)
        {
            return (d.update(g));
        }
        public getdata search(getdata g)
        {
            return (d.search(g));
        }
    }
}
