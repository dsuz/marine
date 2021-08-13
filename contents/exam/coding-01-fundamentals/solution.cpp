#include <iostream>
using namespace std;
int main(void){
    string line;
    getline(cin, line);
    int a, b;
    int pos = line.find(' ');
    a = stoi(line.substr(0, pos));
    b = stoi(line.substr(pos + 1));
    cout << a + b << endl;
    cout << a - b << endl;
    cout << a * b << endl;
}
