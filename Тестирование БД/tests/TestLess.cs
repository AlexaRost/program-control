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
    public class TestLess : SqlDatabaseTestClass
    {

        public TestLess()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_lessTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestLess));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Counts;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction lessTest2_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Counts2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExecutionTimeCondition TimeTest;
            this.dbo_lessTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.lessTest2Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_lessTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Counts = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            lessTest2_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Counts2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            TimeTest = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExecutionTimeCondition();
            // 
            // dbo_lessTestData
            // 
            this.dbo_lessTestData.PosttestAction = null;
            this.dbo_lessTestData.PretestAction = null;
            this.dbo_lessTestData.TestAction = dbo_lessTest_TestAction;
            // 
            // dbo_lessTest_TestAction
            // 
            dbo_lessTest_TestAction.Conditions.Add(Counts);
            resources.ApplyResources(dbo_lessTest_TestAction, "dbo_lessTest_TestAction");
            // 
            // Counts
            // 
            Counts.Enabled = true;
            Counts.Name = "Counts";
            Counts.ResultSet = 1;
            Counts.RowCount = 7;
            // 
            // lessTest2Data
            // 
            this.lessTest2Data.PosttestAction = null;
            this.lessTest2Data.PretestAction = null;
            this.lessTest2Data.TestAction = lessTest2_TestAction;
            // 
            // lessTest2_TestAction
            // 
            lessTest2_TestAction.Conditions.Add(Counts2);
            lessTest2_TestAction.Conditions.Add(TimeTest);
            resources.ApplyResources(lessTest2_TestAction, "lessTest2_TestAction");
            // 
            // Counts2
            // 
            Counts2.Enabled = true;
            Counts2.Name = "Counts2";
            Counts2.ResultSet = 1;
            Counts2.RowCount = 3;
            // 
            // TimeTest
            // 
            TimeTest.Enabled = true;
            TimeTest.ExecutionTime = System.TimeSpan.Parse("00:00:10");
            TimeTest.Name = "TimeTest";
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
        public void dbo_lessTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_lessTestData;
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
        public void lessTest2()
        {
            SqlDatabaseTestActions testActions = this.lessTest2Data;
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

        private SqlDatabaseTestActions dbo_lessTestData;
        private SqlDatabaseTestActions lessTest2Data;
    }
}
