defmodule Array do
  def main do
    arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
    x = 8
    p = binary_search(x, arr, 0, length(arr))

    IO.puts "[#{x}] está na posição: #{p}"
  end

  def binary_search(x, arr, l, r) do
    m = div(l+r, 2) 

    case Enum.at(arr, m) do
      a when x > a -> binary_search(x, arr, m+1, r)
      a when x < a -> binary_search(x, arr, l, m)
      a when x == a -> m
      _ -> -1
    end 
  end
end

Array.main
