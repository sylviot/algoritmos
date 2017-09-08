defmodule Sort do
  def insert(arr, l \\ 0, r \\ 1) do
    cond do
      r == length(arr) -> arr
      l < 0 -> insert(arr, r, r+1)
      true ->
        if compare(arr, l, r) do
          {x, y} = {Enum.at(arr, l), Enum.at(arr, r)}

          arr = swap(arr, l, r)
          insert(arr, l-1, l)
        else
          insert(arr, l-1, r)
        end
    end
  end

  def swap(arr, l, r) do
    {x, y} = {Enum.at(arr, l), Enum.at(arr, r)}

    arr = List.replace_at(arr, l, y)
    arr = List.replace_at(arr, r, x)
  end

  def compare(arr, l, r) do
    {x, y} = {Enum.at(arr, l), Enum.at(arr, r)}

    x > y
  end
end

array = [2, 3, 1, 5, 4]

array_sorted = Sort.insert(array)

IO.inspect array_sorted
