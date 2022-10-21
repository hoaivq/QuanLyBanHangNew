using HCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace QuanLyBanHangService
{
    /// <summary>
    /// Summary description for Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service : System.Web.Services.WebService
    {

        [WebMethod]
        public MsgResult<DataTable> LoadListBill()
        {
            try
            {
                using (DataTable dt = MyApp.Dao.GetTable("SELECT * FROM tblBill WHERE Status = @Status", new SqlParameter[] { new SqlParameter("Status", SqlDbType.Int) { Value = Status.Book} })) 
                {
                    return new MsgResult<DataTable>(true, dt);
                }
            }
            catch (Exception ex)
            {
                return new MsgResult<DataTable>(false, ex, "LoadListBill");
            }
        }
    }
}
