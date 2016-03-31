// List_LinkList.cpp : main project file.

#include "stdafx.h"
#include <iostream>;
#include <string>;
#include <array>;

using namespace System;
using namespace std;

const int imax = 25;
//Danh sach lien ket cac String
class MyStringList 
{
private:
	string data[imax];
	int count ;
public:
//Ham khoi tao
	MyStringList()
	{
		count = 0;
	}

	MyStringList(MyStringList &L)
	{
		count = L.count;
	}
//Kiem tra list rong
	bool isEmpty()
	{
		return count == 0;
	}
	bool isEmpty(MyStringList &L)
	{
		return L.count == 0;
	}
//Kiem tra list full
	bool isFull()
	{
		return count == imax;
	}
	bool isFull(MyStringList &L)
	{
		return L.count == imax;
	}
//Lay gia tri
	string getData(int k)
	{
		if (isEmpty()) return "File not found!";
		if (k <= 0  || k > count) return "File not found!";
		return data[k];
	}
	string getData(MyStringList &L, int k)
	{
		if (isEmpty(L)) return "File not found!";
		if (k <= 0  || k > count) return "File not found!";

		return L.data[k];
	}
//Sua
	void changeData(string s, int k)
	{
		if (isEmpty())
		{
			cout << "File not found!\n";
			return;
		}
		if (k <= 0  || k > count)
		{
			cout << "File not found!\n";
			return;
		}

		data[k] = s;
		cout << "Change successful!\n";
	}
	void changeData(MyStringList %L, string s, int k)
	{
		if (isEmpty(L))
		{
			cout << "File not found!\n";
			return;
		}
		if (k <= 0  || k > count)
		{
			cout << "File not found!\n";
			return;
		}

		L.data[k] = s;
		cout << "Change successful!\n";
	}
//In danh sach
	void printList()
	{
		cout << "My string List: \n";
		for (int i = 0; i < count; i++)
			cout << data[i] << endl;
	}
	void printList(MyStringList &L)
	{
		cout << "My string List: \n";
		for (int i = 0; i < count; i++)
			cout << L.data[i] << endl;
	}
//Xoa 
	void remove(int k)
	{
		if (isEmpty())
		{
			cout << "File not found!\n";
			return;
		}
		if (k <= 0  || k > count)
		{
			cout << "File not found!\n";
			return;
		}

		for (int i = 0; i < count; i++)
			data[i] = data[i+1];
		count--;
	}
	void remove(MyStringList &L ,int k)
	{
		if (isEmpty(L))
		{
			cout << "File not found!\n";
			return;
		}
		if (k <= 0  || k > count)
		{
			cout << "File not found!\n";
			return;
		}

		for (int i = 0; i < count; i++)
			L.data[i] = L.data[i+1];
		L.count--;
	}
//Chen mot phan tu vaovi tri k
	void addData(string s, int k)
	{
		if (isEmpty())
		{
			data[0] = s;
			count++;
			return;
		}
		else 
		{
			if (isFull()) cout << "List is FULL. Cant add item!" << endl;
		}

		if (k < 0  || k > count)
		{
			cout << "Invalid position!\n";
			return;
		}		

		for (int i = count + 1; i > k; i--)
		{
			data[i] = data[i-1];
		}
		data[k] = s;
		count++;
	}
	void addData(string s)
	{
		if (isEmpty())
		{
			data[0] = s;
			count++;
			return;
		}
		if (!isFull())
		{
			data[count] = s;
			count++;
		}
		else 
			cout << "File is full.Cant add item!" << endl;
	}

};

class MyIntegerLinkList
{
private:
	int data;
	MyIntegerLinkList *next;
public:
	MyIntegerLinkList(){next = NULL;}
	MyIntegerLinkList(int n)
	{
		data = n;
		next = NULL;
	}
	
	void addData(int n)
	{
		MyIntegerLinkList *p = new MyIntegerLinkList(n);
		if (head == NULL) head = p;
	}

	void print()
	{
		
		for (MyIntegerLinkList *p = head; p->next != NULL; p = p->next)
			cout << p->data << endl;
	}





}*head;



int main()
{
	cout << "Hello world"<< endl;
	/*
	MyStringList list = MyStringList();


	list.addData("hihi");
	list.addData("hehehe");
	
	list.printList();
	*/
	MyIntegerLinkList p;
	int n[] =  {1,2,3,4,5,6,9,8,7};
	p.addData(1);
	p.addData(2);
	p.addData(4);
	p.addData(5);
	p.addData(7);
	p.addData(9);
	p.addData(3);
	p.addData(8);
	p.print();
	Console::ReadLine();
    return 0;
}
