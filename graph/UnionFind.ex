defmodule UnionFind do
  def initset(arr, index) when index < 0 do
    {:ok, arr}
  end

  def initset(arr, index) do
    initset([index] ++ arr, index-1)
  end

  def findset(arr, x) do
    if (Enum.at(arr, x) == x), do: x,
    else: findset(arr, Enum.at(arr, x))
  end

  def unionset(arr, a, b) do
    x = findset(arr, a)
    y = findset(arr, b)

    if (x != y), do: 
      arr = List.update_at(arr, y, &(&1 = x))

    {:ok, arr}
  end
end

{:ok, arr} = UnionFind.initset([], 10)

{:ok, arr} = UnionFind.unionset(arr, 2, 4)
{:ok, arr} = UnionFind.unionset(arr, 4, 6)
{:ok, arr} = UnionFind.unionset(arr, 6, 8)
{:ok, arr} = UnionFind.unionset(arr, 8, 10)

{:ok, arr} = UnionFind.unionset(arr, 1, 3)
{:ok, arr} = UnionFind.unionset(arr, 3, 5)
{:ok, arr} = UnionFind.unionset(arr, 5, 7)
{:ok, arr} = UnionFind.unionset(arr, 7, 9)

{:ok, arr} = UnionFind.unionset(arr, 1, 2)
