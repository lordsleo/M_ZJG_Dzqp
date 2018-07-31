using Leo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceInterface.Common
{
    public class DictionaryData
    {
        //应用名称与iport数据库应用组件编码对应字典表
        //<appName, codeAssembly>
        public static Dictionary<string, string> _CODE_ASSEMBLY_DICTIONARY = new Dictionary<string, string>()
        {
            {"WLKG", "177"},
            {"HMW", "178"},
            //{"SPHSJ", "178"},
            {"ZSLB", "180"},
        };

        //应用名称与用户类型对应字典表
        //<appName, userType>
        public static Dictionary<string, string> _USER_TYPE_DICTIONARY = new Dictionary<string, string>()
        {
            {"HMW", "iPort"},    //航贸网
            {"YGHY", "nbw"},     //云港海运
            {"IPORT", "iPort"},  //IPORT
            {"WLKG", "iPort"},   //物流控股
            {"LHGL", "iPort"},   //理货管理（镇江）
            {"ZSLB", "iPort"},   //掌上轮驳
            {"DL_GWTXC", "iPort"},   //港务通现场——东联
        };

        //应用名称与内部网公司ID对应字典表
        //<appName, nbw_CompanyId>
        public static Dictionary<string, string> _NBW_COMPANYID_DICTIONARY = new Dictionary<string, string>()
        {
            {"WLKG", "0179"},
            {"YGHY", "017929"},
            {"ZSLB", "0149"},
        };

        //应用名称与推送数据库表名对应字典表
        //<appName, DBTable>
        public static Dictionary<string, string> _DB_TABLE_DICTIONARY = new Dictionary<string, string>()
        {
            {"LHGL", "TB_SCYWZH_APP_MESSPUSH"},
        };

        /***************************************************************************************************************/

        //应用名称与推送数据库关键字对应字典表
        //<appName, pushKeyDataBase>
        public static Dictionary<string, string> _PUSH_KEY_DATA_BASE_DICTIONARY = new Dictionary<string, string>()
        {
            {"LHGL", RegistryKey.KeyPathNewHarbor},
        };

        //应用名称与Iport关键字对应字典表
        //<appName, iportKeyDataBase>
        public static Dictionary<string, string> _IPORT_KEY_DATA_BASE_DICTIONARY = new Dictionary<string, string>()
        {
            {"HMW",   RegistryKey.KeyPathIport},   
            {"YGHY",  RegistryKey.KeyPathIport},     
            {"IPORT", RegistryKey.KeyPathIport}, 
            {"WLKG",  RegistryKey.KeyPathIport},   
            {"ZSLB",  RegistryKey.KeyPathIport}, 
            {"DL_GWTXC", RegistryKey.KeyPathIport},   //港务通现场——东联


            {"LHGL",  RegistryKey.KeyPathNewIport},          
        };

        //应用名称与移动设备关键字对应字典表
        //<appName, deviceKeyDataBase>
        public static Dictionary<string, string> _DEVICE_KEY_DATA_BASE_DICTIONARY = new Dictionary<string, string>()
        {
            {"HMW",   RegistryKey.KeyPathMa},   
            {"YGHY",  RegistryKey.KeyPathMa},     
            {"IPORT", RegistryKey.KeyPathMa}, 
            {"WLKG",  RegistryKey.KeyPathMa}, 
            {"ZSLB",  RegistryKey.KeyPathMa}, 
            {"DL_GWTXC", RegistryKey.KeyPathMa},   //港务通现场——东联
          
            {"LHGL",  RegistryKey.KeyPathNewHarbor},
        };
    }
}