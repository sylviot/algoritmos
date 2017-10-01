defmodule Sort do
  def quick(arr, left, right) do
    {arr, index} = partition(arr, left, right)

    if (left < index - 1), do: arr = quick(arr, left, index - 1)
    if (index < right), do: arr = quick(arr, index, right)

    arr
  end

  def partition(arr, left, right) do
    i = left
    j = right
    pivot = Enum.at(arr, div(left + right, 2))

    compare(arr, i, j, pivot)
  end

  def compare(arr, i, j, pivot) do
    cond do
      Enum.at(arr, i) < pivot -> compare(arr, i+1, j, pivot)
      Enum.at(arr, j) > pivot -> compare(arr, i, j-1, pivot)
      true ->
        if (i <= j) do
          arr = swap(arr, i, j)
          compare(arr, i+1, j-1, pivot)
        else
          {arr, i}
        end
    end
  end

  def swap(arr, l, r) do
    {x, y} = {Enum.at(arr, l), Enum.at(arr, r)}

    arr = List.replace_at(arr, l, y)
    arr = List.replace_at(arr, r, x)
  end
end

array = Enum.shuffle(1..50) # [2, 3, 1, 5, 4]

array_sorted = Sort.quick(array, 0, length(array))

IO.inspect array_sorted
