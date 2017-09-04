defmodule Loop do
  def main do
    # for INICIALIZADOR, CONDICAO, do: FAÇA
    for i <- 0..20, i < 10, do: IO.puts i

    for i <- 10..0, do: IO.puts(i)

    for x <- [:a, :b, :c], i <- 1..3, do: {x, i}
  end
end

Loop.main
