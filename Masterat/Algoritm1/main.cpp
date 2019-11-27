#include <iostream>
#include <cstdlib>
#include <math.h>
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

using namespace std;

int dimPop; //dimensiunea populatiei
int lg; //lungimea comozomuliui
int Tmax; //nr. maxim de generatii
float a, b;

typedef struct{
		float x;
		int gene[30];
		float fit;
	}TCromozom;

TCromozom Pop[200];
TCromozom Popnoua[200];

void codificare(TCromozom &c){
	float xt;
	xt = (c.x - a)/(b - a);
	for(int i=1; i<=lg; i++){
		c.gene[i] = xt * 2;
		xt = xt - c.gene[i];
	}
}

void decodificare(TCromozom &c){
	float xt;
	int i;
	xt = 0;
	for(i=1; i<=lg; i++){
		xt = xt+c.gene[i]*pow(2,-i);
		c.x = a+(b-a)*xt;
		//cout<<"c.x: "<<c.x;
	}
}

void generareaPopulatiei(){
	int i;
	for(i=1; i<=dimPop; i++){
		Pop[i].x = a + (float)rand()/(float)(RAND_MAX) * (b-a);
	//	codificare(Pop[i]);
		cout<<Pop[i].x<<" ";
	}
}

float fitness(TCromozom &c){
	c.fit = sin(c.x);
	return c.fit;
}

void evaluare(){
	for(int i=1; i<=dimPop; i++){
	//	decodificare(Pop[i]);
		fitness(Pop[i]);
	}
}

int selectiaConcursBinar(){
	int poz1, poz2;
	poz1 = 1 + (float)rand()/(float)(RAND_MAX) * (dimPop - 1);
	poz2 = 1 + (float)rand()/(float)(RAND_MAX) * (dimPop - 1);
	if(Pop[poz1].fit > Pop[poz2].fit) return poz1;
	else return poz2;
}

void mutatie(TCromozom c, TCromozom &m){
	int i;
	for(i=1; i<=lg; i++){
		m.gene[i] = c.gene[i];
	}
	int poz;
	poz = 1+(float)rand()/(float)(RAND_MAX) * lg;
	m.gene[poz] = 1 - m.gene[poz];
}

void incrucisare(TCromozom p1, TCromozom p2, TCromozom &fiu){
	int taietura, i;
	taietura = 1 + (float)rand()/(float)(RAND_MAX) * lg;
	for(i=1; i<taietura; i++){
		fiu.gene[i] = p1.gene[i];
		for(i=taietura; i<=lg; i++){
			fiu.gene[i] = p2.gene[i];
		}
	}
}


void mutatieReal(TCromozom c, TCromozom &m){
	float q=(float)rand()/(float)(RAND_MAX);
	if (q<=0.5)
	m.x=c.x+(float)rand()*(b-c.x)/(float)(RAND_MAX) ;
	    else
	m.x=c.x-(float)rand()*(c.x-a)/(float)(RAND_MAX) ;

}

void incrucisareReal(TCromozom p1, TCromozom p2, TCromozom &fiu){
	float q=(float)rand()/(float)(RAND_MAX);
	fiu.x=q*p1.x+(1-q)*p2.x;
}

int best(){
	int pozmax, i;
	pozmax = 1;
	for(i=2; i<=dimPop; i++){
		if(Pop[i].fit > Pop[pozmax].fit) pozmax = i;
	}
}


int main(int argc, char** argv) {

	int i, t, ind1, ind2;
	cout<<"Dati dimPop ";
	cin>>dimPop;
	cout<<"Dati lg ";
	cin>>lg;
	cout<<"Dati Tmax ";
	cin>>Tmax;
	cout<<"Dati a: ";
	cin>>a;
	cout<<"Dati b: ";
	cin>>b;
	generareaPopulatiei();
	evaluare();
	for(t=1; t<=Tmax; t++){
		for(i=1; i<=dimPop; i++){
			ind1 = selectiaConcursBinar();
			ind2 = selectiaConcursBinar();
			incrucisareReal(Pop[ind1], Pop[ind2], Popnoua[i]);
		}
		for(i=1; i<=dimPop; i++){
			for(int j=1; j<=lg; j++){
				Pop[i].gene[j]=Popnoua[i].gene[j];
			}
		}
		evaluare();
		for(int k=1; k<=dimPop/10; k++){
			ind1 = selectiaConcursBinar();
			mutatieReal(Pop[ind1], Pop[ind1]);
			//decodificare(Pop[ind1]);
			fitness(Pop[ind1]);
		}
	}
	ind1=best();
	cout<<Pop[ind1].x<<" ";
	cout<<"ultimu: "<<Pop[ind1].fit;

	return 0;
}
