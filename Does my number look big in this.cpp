// Does my number look big in this.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
#include <cmath>
int main()
{
    int value = 371;
    int newvalue = value;
    int digits;
    int toadd;
    int total = 0;
    //Find the length of the value integer and assign it to the digits variable
    digits = std::to_string(value).length();
    int splitvalue[20];
    //Assign each digit of the integer value to the splitvalue array
    for (int x = 0; x < digits; x++) {
        splitvalue[x] = newvalue % 10;
        newvalue /= 10;
    }

    for (int y = digits; y > 0; y--) {
        toadd = pow(splitvalue[y - 1], digits);
        total += toadd;
    }

    if (total == value) {
        std::cout << "true";
        return true;
    }
    else {
        std::cout << "false";
        return false;
    }
}