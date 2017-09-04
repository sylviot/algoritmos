defmodule Condition do
  def main do
    if true, do: :isso, else: :aquilo

    if true do
      # Condição verdadeira
    else
      # Condição else
    end

    case {1, 2, 3} do
      {4, 5, 6} -> "Não combina"
      {1, x, 3} when rem(x, 2) == 0 -> "Combina"
              _ -> "Opção padrão"
    end

    x = 2
    case 1 do
      ^x -> "Não combina x != 1"
       _ -> "Combina"
    end

    cond do
      2 + 2 == 5 -> "Não é verdadeiro"
      2 * 2 == 3 -> "Nem esse"
      1 + 1 == 2 -> "Esse é verdadeiro"
            true -> "Caso nenhum seja verdadeiro"
    end

  end
end

Condition.main
