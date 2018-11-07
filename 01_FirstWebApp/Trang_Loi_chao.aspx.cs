using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_FirstWebApp
{
    public partial class Trang_Loi_chao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDongY_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            string chuoi = "Xin chào bạn " + ten;
            string chuoiHTML = "<h3>" + chuoi + "</h3>";
            lblLoiChao.Text = chuoiHTML;
        }
    }
}