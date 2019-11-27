#include <iostream>

using namespace std;

class LabirintBuilder{
{
public:
    virtual BuildLabirint(){};
    virtual BuildCamera(){};
    virtual BuildUsa(int Nr1, int Nr2){};
    virtual Labirint * GetResult(){return 0;};
protected:
    LabirintBuilder();
};
};

class Labirint(){
public:
    Labirint();
    void AdaugaCamera(Camera*);
    Camera*NumarDeCamera(int) const;
};

class LabirintJoc(){
public:
    Labirint*CreareLabirint(LabirintBuilder&Builder);
};

Labirint*LabirintJoc::CreareLabirint(LabirintBuilder&Bulder)
{

}
int main()
{
    cout << "Hello world!" << endl;
    return 0;
}
