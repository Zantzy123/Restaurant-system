#include <iostream>
#include <string>
using namespace std;

class MenuItem {
public:
    int id;
    string name;
    double price;

    MenuItem(int id, string name, double price) :
        id(id), name(name), price(price) {}
};