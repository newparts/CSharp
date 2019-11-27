#include <iostream>

using namespace std;

class Student
{
    int NrMatricol;
public:
    Student(){};
};

class Masterand:public Student{
protected:
    int codMasterand;
public:
    Masterand(){};
    void SetCod(int a){codMasterand=a;};
};

class Secretariat{
public:
    Secretariat(){};
    virtual Student*MetodaFactory()=0;
    virtual void Inmatriculare()=0;
};

class SecretariatMasterat:public Secretariat{
public:
    SecretariatMasterat(){};
    Masterand*MetodaFactory()
    {return new Masterand;};
    void Inmatriculare()
    {
        cout<<"Inmatriculat Master"<<endl;
        MetodaFactory();
    }
};
int main()
{
    Secretariat*sec=new SecretariatMasterat();
    sec->Inmatriculare();
    //getch();
    return 0;
}
