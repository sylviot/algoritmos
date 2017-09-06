defmodule Queue do
  def initialize, do: []
  
  def enqueue(queue, element), do:  queue ++ [element]

  def dequeue(queue) do
    {n, queue} = List.pop_at(queue, 0)

    {:ok, queue, n}
  end
end

queue = Queue.initialize

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
