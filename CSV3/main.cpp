#include <iostream>

#include <fstream>

using namespace std;

float beta;

float Beta(float mx, float my, float x[], float y[]){

float bs, bj, b;

for(int i = 1; i <= 10; i++){

bs = (x[i] - mx) * (y[i] - my);

bj = (x[i] - mx) * (x[i] - mx);

}

b = bs / bj;

return b;

}

float Alpha(float mx, float my){

float a;

a = my - beta * mx;

return a;

}

float media(float vect[20]){

float elem=0;

for(int i=1; i<=10; i++){

elem=elem+vect[i];

}

elem=elem/10;

return elem;

}

int main(int argc, char** argv) {

float x[20], y[20], mx, my;

int i=1, j=1;

ifstream f("CSV3.txt");

while(!f.eof()){

if(i%2 == 1) f>>x[j];

else{

f>>y[j];

j++;

}

i++;

}

mx = media(x);

my = media(y);

beta = Beta(mx, my, x, y);

cout<<"Beta: "<<beta<<endl;

cout<<"Aplha: "<<Alpha(mx, my)<<endl;



return 0;
}
