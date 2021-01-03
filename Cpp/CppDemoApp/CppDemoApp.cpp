// CppDemoApp.cpp : This file contains the 'main' function. Program execution begins and ends there.
//


#include <string>
#include <iostream>
#include <vector>
#include <fstream>
using namespace std;

int main()
{
	ofstream writeToFile;
	ifstream readFromFile;
	string textToWrite = ""; 
	string textFromFile = ""; 
	writeToFile.open("test.txt", ios_base::out | ios_base::trunc);

	if (writeToFile.is_open()) 
	{
		writeToFile << "Beginning of the file\n";
		cout << "Enter data to write: ";
		getline(cin, textToWrite);
		writeToFile << textToWrite;
		writeToFile.close();
	}

	readFromFile.open("test.txt", ios_base::in);
	if (readFromFile.is_open()) 
	{
		while (readFromFile.good()) 
		{
			getline(readFromFile, textFromFile);
			cout << textFromFile << "\n";
		}
		readFromFile.close();
	}

	
}


// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
