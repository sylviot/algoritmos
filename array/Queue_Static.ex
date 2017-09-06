defmodule Queue do
  def initialize(max) do
    [elements: [], max: max]
  end

  def enqueue(queue, element) do
    if length(queue[:elements]) < queue[:max], do:
      queue = List.keyreplace(queue, :elements, 0, {:elements, queue[:elements] ++ [element]})

    queue
  end

  def dequeue(queue) do
    if length(queue[:elements]) > 0 do
      {n, elements} = List.pop_at(queue[:elements], 0)
      queue = List.keyreplace(queue, :elements, 0, {:elements, elements}) 
      {:ok, queue, n}
    else
      {:error, queue, nil}
    end
  end
end

queue = Queue.initialize(5)
queue = Queue.enqueue(queue, 1)
queue = Queue.enqueue(queue, 2)
queue = Queue.enqueue(queue, 3)
queue = Queue.enqueue(queue, 4)
queue = Queue.enqueue(queue, 5)
# queue = Queue.enqueue(queue, 6)

{:ok, queue, n1} = Queue.dequeue(queue)
{:ok, queue, n2} = Queue.dequeue(queue)
{:ok, queue, n3} = Queue.dequeue(queue)
{:ok, queue, n4} = Queue.dequeue(queue)
{:ok, queue, n5} = Queue.dequeue(queue)
# {:error, queue, nil} = Queue.dequeue(queue)

IO.inspect queue
