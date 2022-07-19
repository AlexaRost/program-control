#pragma once
#include <iostream>
#define FLAG 0
#include <cmath>

class Test1
{
public:
	double num;
	Test1() {
		num = 0;
	}
	Test1(double value) {
		num = value;
	}

	bool IsOK() {
		if (!FLAG)
		{
			if (num >= 0)
				return true;
			return false;
		}
		else
		{
			if (num >= 0)
				return false;
			return true;
		}
	}

	bool IsOK(double value) {
		num = value;
		if (!FLAG)
		{
			if (num >= 0)
				return true;
			return false;
		}
		else
		{
			if (num >= 0)
				return false;
			return true;
		}
	}
};

