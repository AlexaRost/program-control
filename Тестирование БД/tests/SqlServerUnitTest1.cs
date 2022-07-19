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
    public class SqlServerUnitTest1 : SqlDatabaseTestClass
    {

        public SqlServerUnitTest1()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_SummTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlServerUnitTest1));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition TestSum1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction SummTest2_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Summ;
            this.dbo_SummTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.SummTest2Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_SummTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            TestSum1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            SummTest2_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Summ = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // dbo_SummTest_TestAction
            // 
            dbo_SummTest_TestAction.Conditions.Add(TestSum1);
            resources.ApplyResources(dbo_SummTest_TestAction, "dbo_SummTest_TestAction");
            // 
            // dbo_SummTestData
            // 
            this.dbo_SummTestData.PosttestAction = null;
            this.dbo_SummTestData.PretestAction = null;
            this.dbo_SummTestData.TestAction = dbo_SummTest_TestAction;
            // 
            // TestSum1
            // 
            TestSum1.ColumnNumber = 1;
            TestSum1.Enabled = true;
            TestSum1.ExpectedValue = "20000";
            TestSum1.Name = "TestSum1";
            TestSum1.NullExpected = false;
            TestSum1.ResultSet = 1;
            TestSum1.RowNumber = 1;
            // 
            // SummTest2Data
            // 
            this.SummTest2Data.PosttestAction = null;
            this.SummTest2Data.PretestAction = null;
            this.SummTest2Data.TestAction = SummTest2_TestAction;
            // 
            // SummTest2_TestAction
            // 
            SummTest2_TestAction.Conditions.Add(Summ);
            resources.ApplyResources(SummTest2_TestAction, "SummTest2_TestAction");
            // 
            // Summ
            // 
            Summ.ColumnNumber = 1;
            Summ.Enabled = true;
            Summ.ExpectedValue = "11000";
            Summ.Name = "Summ";
            Summ.NullExpected = false;
            Summ.ResultSet = 1;
            Summ.RowNumber = 1;
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
        public void dbo_SummTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_SummTestData;
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
        public void SummTest2()
        {
            SqlDatabaseTestActions testActions = this.SummTest2Data;
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

        private SqlDatabaseTestActions dbo_SummTestData;
        private SqlDatabaseTestActions SummTest2Data;
    }
}
