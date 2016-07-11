#include <bits/stdc++.h>

using namespace std;

int left(int x) { return x<<1; }
int right(int x){ return (x<<1)+1; }


class SegmentTree
{
	vector<int> array, tree;
	
public:
	
	void init(vector<int> A)
	{
		int N = A.size();
		
		array = A;

		tree.assign(4 * N, 0);

		build(1, 0, N-1);
	}
	
	int query(int i, int j)
	{
		int R = ((int)array.size())-1;
		return query(1, i - 1, j - 1, 0, R);
	}
	
private:

	int comparable(int vA, int vB)
	{
		return min(vA, vB);
	}

	void build(int p, int L, int R)
	{
		if(L == R){ tree[p] = array[L]; }
		else
		{
			int mid = (L+R) / 2;
			build( left(p),     L, mid);
			build(right(p), mid+1,   R);

			int valueLeft = tree[left(p)],
				valueRight = tree[right(p)];

			tree[p] = comparable(valueLeft, valueRight);
		}
	}

	int query(int p, int i, int j, int L, int R)
	{
		if(j < L || i > R) return INT_MAX;
		if(L >= i && R <= j) return tree[p];

		int mid = (L+R) / 2;
		int valueLeft  = query( left(p), i, j,     L, mid),
			valueRight = query(right(p), i, j, mid+1,   R);

		return comparable(valueLeft, valueRight);
	}
};

int main()
{
	SegmentTree segment_tree;

	vector<int> numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
	
	segment_tree.init(numbers);
	cout << segment_tree.query(5, numbers.size());

	return 0;
}
