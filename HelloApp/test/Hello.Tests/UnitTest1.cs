using System.Xml.Linq;
using System.Reflection;
using System;
using Xunit;
using AppAPI;

namespace Hello.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
          var api = new  AppAPI.Controllers.ValuesController();
          string[] results = api.Get();

        }

    }
}
