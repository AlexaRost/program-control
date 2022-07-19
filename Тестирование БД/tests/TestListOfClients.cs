using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace TestSumm
{
    [TestClass()]
    public class TestListOfClients : SqlDatabaseTestClass
    {

        public TestListOfClients()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_ListOfClientsTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestListOfClients));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition ListClients;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ListOfClients2_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition ListOfCl;
            this.dbo_ListOfClientsTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ListOfClients2Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_ListOfClientsTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            ListClients = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ListOfClients2_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            ListOfCl = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            // 
            // dbo_ListOfClientsTestData
            // 
            this.dbo_ListOfClientsTestData.PosttestAction = null;
            this.dbo_ListOfClientsTestData.PretestAction = null;
            this.dbo_ListOfClientsTestData.TestAction = dbo_ListOfClientsTest_TestAction;
            // 
            // dbo_ListOfClientsTest_TestAction
            // 
            dbo_ListOfClientsTest_TestAction.Conditions.Add(ListClients);
            resources.ApplyResources(dbo_ListOfClientsTest_TestAction, "dbo_ListOfClientsTest_TestAction");
            // 
            // ListClients
            // 
            ListClients.Enabled = true;
            ListClients.Name = "ListClients";
            ListClients.ResultSet = 1;
            ListClients.RowCount = 2;
            // 
            // ListOfClients2Data
            // 
            this.ListOfClients2Data.PosttestAction = null;
            this.ListOfClients2Data.PretestAction = null;
            this.ListOfClients2Data.TestAction = ListOfClients2_TestAction;
            // 
            // ListOfClients2_TestAction
            // 
            ListOfClients2_TestAction.Conditions.Add(ListOfCl);
            resources.ApplyResources(ListOfClients2_TestAction, "ListOfClients2_TestAction");
            // 
            // ListOfCl
            // 
            ListOfCl.Enabled = true;
            ListOfCl.Name = "ListOfCl";
            ListOfCl.ResultSet = 1;
            ListOfCl.RowCount = 1;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void dbo_ListOfClientsTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_ListOfClientsTestData;
            // Выполнить скрипт перед тестом
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Выполняется скрипт перед тестом…");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Выполнить скрипт теста
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Выполняется скрипт тест…");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Выполнить скрипт после теста
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Выполняется скрипт после теста…");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void ListOfClients2()
        {
            SqlDatabaseTestActions testActions = this.ListOfClients2Data;
            // Выполнить скрипт перед тестом
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Выполняется скрипт перед тестом…");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Выполнить скрипт теста
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Выполняется скрипт тест…");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Выполнить скрипт после теста
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Выполняется скрипт после теста…");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        private SqlDatabaseTestActions dbo_ListOfClientsTestData;
        private SqlDatabaseTestActions ListOfClients2Data;
    }
}
