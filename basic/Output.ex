defmodule Output do
  def main do
    output_int = 1
    output_char = '$'
    output_float = 1.2
    output_string = "string"

    IO.puts output_int
    IO.puts output_char
    IO.puts output_float
    IO.puts output_string
  end
end

Output.main
