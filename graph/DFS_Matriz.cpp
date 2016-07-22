#include <bits/stdc++.h>
#define MAX 10

using namespace std;

bool G[MAX][MAX];
bool V[MAX];

int dfs(int v, int p)
{
	V[v] = true;

	for(int w = 0; w < MAX; w++)
	{
		if(G[v][w] && !V[w])
		{
			dfs(w, v);
		}
	}
}

int dfs(int v)
{
	memset(V, false, sizeof(V));

	dfs(v, -1);
}

void addEdge(int v, int w)
{
	G[v][w] = true;
	G[w][v] = true;
}

int main()
{
	/*
	         1---3
	        / \   \
	       2---4   5
            \ /    |
             6     7
	*/

    addEdge(1, 2);
    addEdge(1, 3);
    addEdge(1, 4);
    addEdge(2, 4);
    addEdge(2, 6);
    addEdge(3, 5);
    addEdge(4, 6);
    addEdge(5, 7);

    dfs(1);

	return 0;
}