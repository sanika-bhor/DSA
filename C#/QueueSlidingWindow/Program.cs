using tflQueeue;

Console.WriteLine("Enter Queue Size");
int queueSize=int.Parse(Console.ReadLine());

Console.WriteLine("Enter Window Size");
int windowSize = int.Parse(Console.ReadLine());
if(queueSize%windowSize == 0 )
{
    int noOfWindow = queueSize / windowSize;


    QueueDataStructure newQueue = new QueueDataStructure(queueSize);

    Window[] windows = new Window[noOfWindow];

    for (int i = 0; i < noOfWindow; i++)
    {
        int startIndex = i * windowSize;
        int endIndex = startIndex + windowSize - 1;

        Window window = new Window(startIndex, endIndex);
        windows[i] = window;
    }


    newQueue.DisplayQueue(windows[0]);
    Console.WriteLine("*************WIndow 1********************");
    newQueue.EnQueue(windows[0], 10);
    newQueue.EnQueue(windows[0], 20);
    newQueue.EnQueue(windows[0], 30);
    newQueue.EnQueue(windows[0], 40);
    newQueue.EnQueue(windows[0], 50);
    newQueue.DisplayQueue(windows[0]);
    newQueue.EnQueue(windows[0], 60);
    newQueue.DisplayQueue(windows[0]);


    Console.WriteLine("*************WIndow 2********************");
    newQueue.EnQueue(windows[1], 600);
    newQueue.EnQueue(windows[1], 700);
    newQueue.DisplayQueue(windows[1]);



    // newQueue.EnQueue(60);
    // newQueue.EnQueue(60);

    // newQueue.DisplayQueue();

    // newQueue.EnQueue(60);
    // newQueue.EnQueue(60);
    // newQueue.EnQueue(60);


    // newQueue.DisplayQueue();

    Console.WriteLine("*************WIndow 1********************");
    newQueue.DeQueue(windows[0]);
    newQueue.DeQueue(windows[0]);

    newQueue.DisplayQueue(windows[0]);


    Console.WriteLine("*************WIndow 1 enqueue********************");
    newQueue.EnQueue(windows[0], 10);
    newQueue.EnQueue(windows[0], 20);

    newQueue.DisplayQueue(windows[0]);


    Console.WriteLine("*************WIndow 2********************");
    newQueue.EnQueue(windows[1], 800);
    newQueue.EnQueue(windows[1], 900);
    newQueue.EnQueue(windows[1], 1000);
    newQueue.EnQueue(windows[1], 1100);

    newQueue.DisplayQueue(windows[1]);


    Console.WriteLine("*************WIndow 3********************");
    newQueue.DisplayQueue(windows[2]);
    // newQueue.DeQueue();
    // newQueue.DeQueue();
    // newQueue.DeQueue();
    // newQueue.DeQueue();
    // newQueue.DeQueue();
    // newQueue.DeQueue();
    // newQueue.DeQueue();
    // newQueue.DeQueue();
    // newQueue.DeQueue();
    // newQueue.DeQueue();
    // newQueue.DeQueue();
    // newQueue.DeQueue();
    // newQueue.DeQueue();

    // newQueue.DisplayQueue();
}
else
{
    Console.WriteLine("Invalid Configuration");
}
