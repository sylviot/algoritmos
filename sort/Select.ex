defmodule Sort do
  def select(arr, l \\ 0) do
    cond do
      l == length(arr) -> arr
      true ->
        min_index = minimum(arr, l+1, l)

        if l != min_index and compare(arr, l, min_index), do:
          arr = swap(arr, l, min_index)

        select(arr, l+1)
    end
  end

  def minimum(arr, l, i) do
    cond do
      l == length(arr) -> i
      true ->
        if compare(arr, i, l), do:
          i = l
        minimum(arr, l+1, i)
    end
  end

  def compare(arr, l, r) do
    {x, y} = {Enum.at(arr, l), Enum.at(arr, r)}

    x > y
  end

  def swap(arr, l, r) do
    {x, y} = {Enum.at(arr, l), Enum.at(arr, r)}

    arr = List.replace_at(arr, l, y)
    arr = List.replace_at(arr, r, x)
  end
end

array = [3, 2, 1, 5, 4]

array_sorted = Sort.select(array)

IO.inspect array_sorted
