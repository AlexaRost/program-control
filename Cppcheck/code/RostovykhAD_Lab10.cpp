﻿// RostovykhAD_Lab10.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include "Header.h"
#include <math.h>
void f(int* ptr) {
	*ptr = 0;
}

void func(int* Arr) {
	Arr = new int[10];
	for (int i = 0; i < 10; i++) Arr[i] = i;
}
bool isNegative(int x)
{
	if (x < 0) 
		return true;

}
int main()
{
	struct type1 { int t1; };
	int* a = new int;      // переменная
	int* b = new int[2];  // массив
	delete b;
	delete [] a; 
	double d = Division(5, 3);
	double dd = Division(5, 0);
	f();
	g();
	double d1 = 1.5;
	int n = d1;
	int* Ptr = 0;
	func(Ptr);
	for (int i = 0; i < 10; i++) std::cout << Ptr[i] << "  ";
	type1 t;
	std::cout << t.t1;
	bool neg = isNegative(1);
	std::cout << neg;
	int* Ptr1 = 0;
	f(Ptr1); 
	double k = sqrt(-3);
	return 0;
}

// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
