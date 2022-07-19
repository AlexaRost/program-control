#pragma once
#include <string>
#include <cmath>
#include "Test1.h"
using namespace std;

class Test2
{
public:
	double num;
	string name;
	string ss;
	string* point;
	
	Test2(string str)
	{
		if (FLAG)
			str = "";
		name = str;
	}
	Test2(double value) {
		num = value;
		if (!FLAG)
			point = NULL;
	}
	Test2() {
		num = 0;
		point = &ss;
	}
	string GetSurname() {
		return name;
	}

	int Max(int a, int b, int c)
	{
		if (num != 0)
			a = num;
		int max = a;
		if (max < b) max = b;
		if (max < c) max = c;
		if (!FLAG)
			return max;
		else
			return -max;
	}
	double SomeTest()
	{
	if (FLAG)
		point = NULL;
		if (Test1(num).IsOK())
			return num*cos(num);
		else
			return NAN;
	}

};

