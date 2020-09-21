using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Internal.Account.Manage;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(DAL.UserInfo.Instance.UserCheck("Admin"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Model.UserInfo user=new Model.UserInfo { userName="Guest",passWord="sql.123",type="π‹¿Ì‘±"};
            Console.WriteLine(DAL.UserInfo.Instance.Add(user));
            Console.WriteLine(JsonConvert.SerializeObject(DAL.UserInfo.Instance.GetAll()));
            user.qq = "104512708";
            Console.WriteLine(DAL.UserInfo.Instance.Update(user));
            var model = DAL.UserInfo.Instance.GetModel("Guest");
            Console.WriteLine(JsonConvert.SerializeObject.Delete("Guest"));
            Console.WriteLine(DAL.UserInfo.Instance.Delete(model));
            var page=DAL.UserInfo.GetPage(new Model.Page { Areas_Identity_Pages_Account_Manage_Index = 2, pageSize = 2 });
            Console.WriteLine(JsonConvert.SerializeObject(page));
            Console.WriteLine(DAL.UserInfo.Instance.GetCount());

        }
    }
}
