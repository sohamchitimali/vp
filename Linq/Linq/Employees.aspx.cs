using System;
using System.Configuration;
using System.Linq;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            string conn = ConfigurationManager.ConnectionStrings["EmployeeDBConnectionString"].ConnectionString;

            using (var db = new EmployeeDataDataContext(conn))
            {
                var employees = from emp in db.Employees
                                select emp;
                GridView1.DataSource = employees.ToList();
                GridView1.DataBind();
            }
        }
    }
}
