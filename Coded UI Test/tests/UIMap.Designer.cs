﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      Этот код был создан построителем кодированных тестов ИП.
//      Версия: 16.0.0.0
//
//      Изменения, внесенные в этот файл, могут привести к неправильной работе кода и будут
//      утрачены при повторном формировании кода.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Построитель кодированных тестов ИП", "16.0.31306.167")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Pyramid - Используйте "PyramidParams" для передачи параметров в этот метод.
        /// </summary>
        public void Pyramid()
        {
            #region Variable Declarations
            WpfEdit uITextBox1Edit = this.UIMainWindowWindow.UITextBox1Edit;
            WpfEdit uITextBox2Edit = this.UIMainWindowWindow.UITextBox2Edit;
            WpfEdit uITextBox3Edit = this.UIMainWindowWindow.UITextBox3Edit;
            WpfButton uIВычислитьButton = this.UIMainWindowWindow.UIВычислитьButton;
            WinButton uIЗакрытьButton = this.UIMainWindowWindow1.UIЗакрытьButton;
            #endregion

            // Запуск "%USERPROFILE%\Desktop\Lab5.exe"
            ApplicationUnderTest uIMainWindowWindow = ApplicationUnderTest.Launch(this.PyramidParams.UIMainWindowWindowExePath, this.PyramidParams.UIMainWindowWindowAlternateExePath);

            // Тип "2" в "textBox1" надпись
            uITextBox1Edit.Text = this.PyramidParams.UITextBox1EditText;

            // Тип "3" в "textBox2" надпись
            uITextBox2Edit.Text = this.PyramidParams.UITextBox2EditText;

            // Тип "4" в "textBox3" надпись
            uITextBox3Edit.Text = this.PyramidParams.UITextBox3EditText;

            // Щелкните "Вычислить" кнопка
            Mouse.Click(uIВычислитьButton, new Point(161, 10));

            // Щелкните "Закрыть" кнопка
            Mouse.Click(uIЗакрытьButton, new Point(32, 6));
        }
        
        /// <summary>
        /// AreEqual1 - Используйте "AreEqual1ExpectedValues" для передачи параметров в этот метод.
        /// </summary>
        public void AreEqual1()
        {
            #region Variable Declarations
            WpfEdit uIText1Edit = this.UIMainWindowWindow.UIText1Edit;
            WpfEdit uIText2Edit = this.UIMainWindowWindow.UIText2Edit;
            #endregion

            // Убедитесь, что свойство Text "Text1" надпись равняется "9"
            Assert.AreEqual(this.AreEqual1ExpectedValues.UIText1EditText, uIText1Edit.Text, "Something went wrong! Expected value is 9!");

            // Убедитесь, что свойство Text "Text2" надпись равняется "2,31"
            Assert.AreEqual(this.AreEqual1ExpectedValues.UIText2EditText, uIText2Edit.Text, "Something went wrong! Expected value is 2,31!");
        }
        
        /// <summary>
        /// AssertMethod1 - Используйте "AssertMethod1ExpectedValues" для передачи параметров в этот метод.
        /// </summary>
        public void AssertMethod1()
        {
            #region Variable Declarations
            WpfEdit uIText1Edit = this.UIMainWindowWindow.UIText1Edit;
            WpfEdit uIText2Edit = this.UIMainWindowWindow.UIText2Edit;
            #endregion

            // Убедитесь, что свойство Text "Text1" надпись равняется "9"
            Assert.AreEqual(this.AssertMethod1ExpectedValues.UIText1EditText, uIText1Edit.Text, "Expected value is 9!");

            // Убедитесь, что свойство Text "Text2" надпись равняется "2,31"
            Assert.AreEqual(this.AssertMethod1ExpectedValues.UIText2EditText, uIText2Edit.Text, "Expected value is 2,31!");
        }
        
        #region Properties
        public virtual PyramidParams PyramidParams
        {
            get
            {
                if ((this.mPyramidParams == null))
                {
                    this.mPyramidParams = new PyramidParams();
                }
                return this.mPyramidParams;
            }
        }
        
        public virtual AreEqual1ExpectedValues AreEqual1ExpectedValues
        {
            get
            {
                if ((this.mAreEqual1ExpectedValues == null))
                {
                    this.mAreEqual1ExpectedValues = new AreEqual1ExpectedValues();
                }
                return this.mAreEqual1ExpectedValues;
            }
        }
        
        public virtual AssertMethod1ExpectedValues AssertMethod1ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod1ExpectedValues == null))
                {
                    this.mAssertMethod1ExpectedValues = new AssertMethod1ExpectedValues();
                }
                return this.mAssertMethod1ExpectedValues;
            }
        }
        
        public UIMainWindowWindow UIMainWindowWindow
        {
            get
            {
                if ((this.mUIMainWindowWindow == null))
                {
                    this.mUIMainWindowWindow = new UIMainWindowWindow();
                }
                return this.mUIMainWindowWindow;
            }
        }
        
        public UIMainWindowWindow1 UIMainWindowWindow1
        {
            get
            {
                if ((this.mUIMainWindowWindow1 == null))
                {
                    this.mUIMainWindowWindow1 = new UIMainWindowWindow1();
                }
                return this.mUIMainWindowWindow1;
            }
        }
        #endregion
        
        #region Fields
        private PyramidParams mPyramidParams;
        
        private AreEqual1ExpectedValues mAreEqual1ExpectedValues;
        
        private AssertMethod1ExpectedValues mAssertMethod1ExpectedValues;
        
        private UIMainWindowWindow mUIMainWindowWindow;
        
        private UIMainWindowWindow1 mUIMainWindowWindow1;
        #endregion
    }
    
    /// <summary>
    /// Параметры для передачи в "Pyramid"
    /// </summary>
    [GeneratedCode("Построитель кодированных тестов ИП", "16.0.31306.167")]
    public class PyramidParams
    {
        
        #region Fields
        /// <summary>
        /// Запуск "%USERPROFILE%\Desktop\Lab5.exe"
        /// </summary>
        public string UIMainWindowWindowExePath = "C:\\Users\\100\\Desktop\\Lab5.exe";
        
        /// <summary>
        /// Запуск "%USERPROFILE%\Desktop\Lab5.exe"
        /// </summary>
        public string UIMainWindowWindowAlternateExePath = "%USERPROFILE%\\Desktop\\Lab5.exe";
        
        /// <summary>
        /// Тип "2" в "textBox1" надпись
        /// </summary>
        public string UITextBox1EditText = "2";
        
        /// <summary>
        /// Тип "3" в "textBox2" надпись
        /// </summary>
        public string UITextBox2EditText = "3";
        
        /// <summary>
        /// Тип "4" в "textBox3" надпись
        /// </summary>
        public string UITextBox3EditText = "4";
        #endregion
    }
    
    /// <summary>
    /// Параметры для передачи в "AreEqual1"
    /// </summary>
    [GeneratedCode("Построитель кодированных тестов ИП", "16.0.31306.167")]
    public class AreEqual1ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Убедитесь, что свойство Text "Text1" надпись равняется "9"
        /// </summary>
        public string UIText1EditText = "9";
        
        /// <summary>
        /// Убедитесь, что свойство Text "Text2" надпись равняется "2,31"
        /// </summary>
        public string UIText2EditText = "2,31";
        #endregion
    }
    
    /// <summary>
    /// Параметры для передачи в "AssertMethod1"
    /// </summary>
    [GeneratedCode("Построитель кодированных тестов ИП", "16.0.31306.167")]
    public class AssertMethod1ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Убедитесь, что свойство Text "Text1" надпись равняется "9"
        /// </summary>
        public string UIText1EditText = "9";
        
        /// <summary>
        /// Убедитесь, что свойство Text "Text2" надпись равняется "2,31"
        /// </summary>
        public string UIText2EditText = "2,31";
        #endregion
    }
    
    [GeneratedCode("Построитель кодированных тестов ИП", "16.0.31306.167")]
    public class UIMainWindowWindow : WpfWindow
    {
        
        public UIMainWindowWindow()
        {
            #region Условия поиска
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "MainWindow";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WpfEdit UITextBox1Edit
        {
            get
            {
                if ((this.mUITextBox1Edit == null))
                {
                    this.mUITextBox1Edit = new WpfEdit(this);
                    #region Условия поиска
                    this.mUITextBox1Edit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "textBox1";
                    this.mUITextBox1Edit.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUITextBox1Edit;
            }
        }
        
        public WpfEdit UITextBox2Edit
        {
            get
            {
                if ((this.mUITextBox2Edit == null))
                {
                    this.mUITextBox2Edit = new WpfEdit(this);
                    #region Условия поиска
                    this.mUITextBox2Edit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "textBox2";
                    this.mUITextBox2Edit.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUITextBox2Edit;
            }
        }
        
        public WpfEdit UITextBox3Edit
        {
            get
            {
                if ((this.mUITextBox3Edit == null))
                {
                    this.mUITextBox3Edit = new WpfEdit(this);
                    #region Условия поиска
                    this.mUITextBox3Edit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "textBox3";
                    this.mUITextBox3Edit.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUITextBox3Edit;
            }
        }
        
        public WpfButton UIВычислитьButton
        {
            get
            {
                if ((this.mUIВычислитьButton == null))
                {
                    this.mUIВычислитьButton = new WpfButton(this);
                    #region Условия поиска
                    this.mUIВычислитьButton.SearchProperties[WpfButton.PropertyNames.Name] = "Вычислить";
                    this.mUIВычислитьButton.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIВычислитьButton;
            }
        }
        
        public WpfEdit UIText2Edit
        {
            get
            {
                if ((this.mUIText2Edit == null))
                {
                    this.mUIText2Edit = new WpfEdit(this);
                    #region Условия поиска
                    this.mUIText2Edit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "Text2";
                    this.mUIText2Edit.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIText2Edit;
            }
        }
        
        public WpfEdit UIText1Edit
        {
            get
            {
                if ((this.mUIText1Edit == null))
                {
                    this.mUIText1Edit = new WpfEdit(this);
                    #region Условия поиска
                    this.mUIText1Edit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "Text1";
                    this.mUIText1Edit.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIText1Edit;
            }
        }
        #endregion
        
        #region Fields
        private WpfEdit mUITextBox1Edit;
        
        private WpfEdit mUITextBox2Edit;
        
        private WpfEdit mUITextBox3Edit;
        
        private WpfButton mUIВычислитьButton;
        
        private WpfEdit mUIText2Edit;
        
        private WpfEdit mUIText1Edit;
        #endregion
    }
    
    [GeneratedCode("Построитель кодированных тестов ИП", "16.0.31306.167")]
    public class UIMainWindowWindow1 : WinWindow
    {
        
        public UIMainWindowWindow1()
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.Name] = "MainWindow";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WinButton UIЗакрытьButton
        {
            get
            {
                if ((this.mUIЗакрытьButton == null))
                {
                    this.mUIЗакрытьButton = new WinButton(this);
                    #region Условия поиска
                    this.mUIЗакрытьButton.SearchProperties[WinButton.PropertyNames.Name] = "Закрыть";
                    this.mUIЗакрытьButton.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIЗакрытьButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIЗакрытьButton;
        #endregion
    }
}
