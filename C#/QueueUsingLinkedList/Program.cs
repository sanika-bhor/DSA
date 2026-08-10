using tflQueeue;

QueueDataStructure queueDataStructure=new QueueDataStructure();

queueDataStructure.DisplayQueue();

queueDataStructure.EnQueue(10);
queueDataStructure.EnQueue(20);
queueDataStructure.EnQueue(30);
queueDataStructure.DisplayQueue();


queueDataStructure.DeQueue();
queueDataStructure.DeQueue();
queueDataStructure.DisplayQueue();