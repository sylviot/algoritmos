defmodule Input do
  def main do
    {input_int, _} = IO.gets("") |> Integer.parse
    {input_float, _} = IO.gets("") |> Float.parse
    input_string = IO.gets("")
  end
end

Input.main
