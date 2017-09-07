defmodule Sort do

  def bubble(arr, l \\ 0, r \\ 0) do

    cond do
      l+1 == length(arr) -> arr
      r == length(arr) -> bubble(arr, l+1, l+2)
      true ->
        {x, y} = {Enum.at(arr, l), Enum.at(arr, r)}

        if compare(x, y) do
          arr = swap(arr, l, r)
        end

        bubble(arr, l, r+1)
    end

  end

  def swap(arr, l, r) do
    {x, y} = {Enum.at(arr, l), Enum.at(arr, r)}

    arr = List.replace_at(arr, l, y)
    arr = List.replace_at(arr, r, x)
  end

  def compare(x, y) do
    x > y
  end
end

array = [2, 3, 1, 5, 4]

array_sorted = Sort.bubble(array)

IO.inspect array_sorted
