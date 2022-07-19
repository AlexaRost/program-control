#include "pch.h"
#include "CppUnitTest.h"
#include <string>
#include <cmath>
#include "..\МКПЛаб1\Test1.h"
#include "..\МКПЛаб1\Test2.h"
#include "excpt.h"
#include "stdexcept"


using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace UnitTest1
{
	TEST_CLASS(UnitTest1)
	{
	public:
		TEST_CLASS_INITIALIZE(ClassInitialize)
		{
			Logger::WriteMessage("The test class has been  created.");
		}

		TEST_CLASS_CLEANUP(ClassFinalize)
		{
			Logger::WriteMessage("The test class has been cleaned.");
		}
		

		TEST_METHOD(TestMethod1)
		{
			Test1 Pos(0);
			Assert::AreEqual(true, Pos.IsOK());
			Assert::AreNotEqual(true, Pos.IsOK(-2));
			Assert::AreNotEqual(false, Pos.IsOK(10));
		}
		TEST_METHOD(TestMethod2)
		{
			int i = 172;
			int j = -38.5;
			Test1 Pos;
			Assert::IsTrue(Pos.IsOK(-1));
			Assert::IsFalse(Pos.IsOK(-5));
			Assert::IsTrue(Pos.IsOK(log(i+j)));
		}

		TEST_METHOD(TestMethod3)
		{
			Test2 T;
			if (!FLAG)
				Assert::IsNotNull(&T.ss);
			else 
				Assert::IsNull(&T.ss);
		}

		TEST_METHOD(TestMethod4)
		{
			Test2 T;
			string str = "Лабораторная №1";
			T.ss = str;
			T.SomeTest();
			Assert::AreSame(T.ss, *T.point);
		}

		TEST_METHOD(TestMethod5)
		{
			string name = "Ростовых";
			Test2 T(name);
			Assert::AreEqual(name, T.GetSurname());
		}
		TEST_METHOD(TestMethod6)
		{		
			Test2 T;
			int t;
			if (!FLAG)
				t = 15;
			else
				t = 10;
			Test2 T1(t);
			Assert::AreEqual(10, T.Max(3,10,7));
			Assert::AreNotEqual(10, T1.Max(3, 10, 7));
		}
	};
}
