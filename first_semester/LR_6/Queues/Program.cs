using Queues;

QueueImpl theQueue = new QueueImpl(10);
PriorityQueueImpl priorityQueue = new PriorityQueueImpl(10);
theQueue.insert(3);
theQueue.insert(3);
theQueue.insert(3);
theQueue.insert(3);
theQueue.insert(3);
theQueue.insert(3);
theQueue.insert(3);
theQueue.insert(3);
theQueue.insert(3);
theQueue.insert(3);
theQueue.insert(3);
theQueue.insert(3);
theQueue.insert(3);
theQueue.insert(3);

priorityQueue.insert(3);
priorityQueue.insert(3);
priorityQueue.insert(3);
priorityQueue.insert(3);
priorityQueue.insert(3);
priorityQueue.insert(3);
priorityQueue.insert(3);
priorityQueue.insert(3);
priorityQueue.insert(3);
priorityQueue.insert(3);
priorityQueue.insert(3);
priorityQueue.insert(3);
priorityQueue.insert(3);
priorityQueue.insert(3);
Console.WriteLine(theQueue.peekFront());
Console.WriteLine(priorityQueue.peekMin());

