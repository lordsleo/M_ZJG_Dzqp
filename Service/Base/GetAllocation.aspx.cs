﻿//
//文件名：    GetAllocation.aspx.cs
//功能描述：  获取货位（堆）列表数据（基础数据）
//创建时间：  2015/09/18
//作者：      
//修改时间：  暂无
//修改描述：  暂无
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using Leo;
using ServiceInterface.Common;


namespace M_ZJG_Dzqp.Service.Base
{
    public partial class GetAllocation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //公司编码
            var codeCompany = Request.Params["CodeCompany"];

            //codeCompany = "14";

            try
            {
                if (codeCompany == null)
                {
                    string warning = string.Format("参数CodeCompany不能为nul！举例：http://218.92.115.55/M_ZJG_Dzqp/Service/Base/GetAllocation.aspx?CodeCompany=14");
                    Json = JsonConvert.SerializeObject(new DicPackage(false, null, warning).DicInfo());
                    return;

                }
                string strSql =
                    string.Format("select distinct code_allocation,allocation,logogram from TB_CODE_ALLOCATION where code_company='{0}' order by logogram asc", codeCompany);
                var dt = new Leo.Oracle.DataAccess(RegistryKey.KeyPathZBase).ExecuteTable(strSql);
                if (dt.Rows.Count <= 0)
                {
                    Json = JsonConvert.SerializeObject(new DicPackage(false, null, "暂无数据！").DicInfo());
                    return;
                }

                string[,] strArray = new string[dt.Rows.Count, 3];
                for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                {
                    strArray[iRow, 0] = Convert.ToString(dt.Rows[iRow]["code_allocation"]);
                    strArray[iRow, 1] = Convert.ToString(dt.Rows[iRow]["allocation"]);
                    strArray[iRow, 2] = Convert.ToString(dt.Rows[iRow]["logogram"]);
                }

                Json = JsonConvert.SerializeObject(new DicPackage(true, strArray, null).DicInfo());
            }
            catch (Exception ex)
            {
                Json = JsonConvert.SerializeObject(new DicPackage(false, null, string.Format("{0}：获取数据发生异常。{1}", ex.Source, ex.Message)).DicInfo());
            }
        }
        protected string Json;
    }
}