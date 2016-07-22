#include <bits/stdc++.h>
#define MAX 10

using namespace std;

int P[MAX+1];

void initset()
{
	for(int i = 0; i < MAX; i++)
	{
		P[i] = i;
	}
}

// Path compression
int findset(int x)
{
	if(P[x] != x) P[x] = findset(P[x]);

	return P[x];
}

void unionset(int a, int b)
{
	int A = findset(a);
	int B = findset(b);

	if(A == B) return;

	P[B] = A;
}

int main()
{
	initset();

	unionset(2, 4);
	unionset(4, 6);
	unionset(6, 8);
	unionset(8, 10);

	unionset(1, 3);
	unionset(3, 5);
	unionset(5, 7);
	unionset(7, 9);

	unionset(1, 2);

	return 0;
}
