#include <bits/stdc++.h>

using namespace std;

int A[] = {1,2,3,4,5,6,7,8,9,10};

int binary_search(int x, int l, int r)
{
	int m = (l+r)/2;

	if(A[m] == x) return m;

	if(x > A[m]) return binary_search(x, m+1, r);
	if(x < A[m]) return binary_search(x, l, m);

	// Caso não encontrar.
	return -1;
}

int main()
{
	int x = binary_search(8, 0, 10);

	printf("%d\n", x);

	return 0;
}