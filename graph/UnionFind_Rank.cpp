#include <bits/stdc++.h>

using namespace std;

int P[], R[];

int findset(int x)
{
	if(P[x] == x) return x;

	return findset(P[x]);
}

void unionset(int a, int b)
{
	int A = findset(a), B = findset(b);

	if(A == B) return;

	if(R[A] > R[B])
	{
		P[B] = A;
	}
	else
	{
		P[A] = B;

		if(R[A] = R[B]) R[B]++;
	}
}

int main()
{
	
	return 0;
}
