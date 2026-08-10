using tflQueeue;

Console.WriteLine("Enter Queue Size");
int queueSize=int.Parse(Console.ReadLine());

Console.WriteLine("Enter Window Size");
int windowSize = int.Parse(Console.ReadLine());
if(queueSize%windowSize == 0 )
{
    int noOfWindow = queueSize / windowSize;


    QueueDataStructure newQueue = new QueueDataStructure(queueSize);
    WindowManager windowManager= new WindowManager(queueSize, windowSize);


    newQueue.DisplayQueue(windowManager.window);
    Console.WriteLine("*************WIndow 1********************");
    newQueue.EnQueue(windowManager.window, 10);
    newQueue.EnQueue(windowManager.window, 20);
    // newQueue.EnQueue(windowManager.window, 30);
    // newQueue.EnQueue(windowManager.window, 40);
    // newQueue.EnQueue(windowManager.window, 50);
    newQueue.DisplayQueue(windowManager.window);
    newQueue.EnQueue(windowManager.window, 60);


    // newQueue.DeQueue(windowManager.window); newQueue.DeQueue(windowManager.window);
    newQueue.DisplayQueue(windowManager.window);


windowManager.SaveWindowState(windowManager.window);
windowManager.MoveNext();

    Console.WriteLine("*************WIndow 2********************");
    newQueue.EnQueue(windowManager.window, 600);
    newQueue.EnQueue(windowManager.window, 700);
    newQueue.DeQueue(windowManager.window);
    newQueue.DisplayQueue(windowManager.window);


    Console.WriteLine("*************WIndow 1********************");
    windowManager.SaveWindowState(windowManager.window);
    windowManager.MoveBack();
    newQueue.EnQueue(windowManager.window, 70);
    newQueue.DisplayQueue(windowManager.window);



    Console.WriteLine("************* don't knnow********************");
    windowManager.SaveWindowState(windowManager.window);
    windowManager.MoveNext();
    newQueue.DeQueue(windowManager.window);
    newQueue.DisplayQueue(windowManager.window);
    newQueue.EnQueue(windowManager.window, 60000);
    newQueue.EnQueue(windowManager.window, 70000);
    newQueue.DisplayQueue(windowManager.window);

    //     // newQueue.EnQueue(60);
    //     // newQueue.EnQueue(60);

    //     // newQueue.DisplayQueue();

    //     // newQueue.EnQueue(60);
    //     // newQueue.EnQueue(60);
    //     // newQueue.EnQueue(60);


    //     // newQueue.DisplayQueue();

    //     Console.WriteLine("*************WIndow 1********************");
    //     newQueue.DeQueue(windows[0]);
    //     newQueue.DeQueue(windows[0]);

    //     newQueue.DisplayQueue(windows[0]);


    //     Console.WriteLine("*************WIndow 1 enqueue********************");
    //     newQueue.EnQueue(windows[0], 10);
    //     newQueue.EnQueue(windows[0], 20);

    //     newQueue.DisplayQueue(windows[0]);


    //     Console.WriteLine("*************WIndow 2********************");
    //     newQueue.EnQueue(windows[1], 800);
    //     newQueue.EnQueue(windows[1], 900);
    //     newQueue.EnQueue(windows[1], 1000);
    //     newQueue.EnQueue(windows[1], 1100);

    //     newQueue.DisplayQueue(windows[1]);


    //     Console.WriteLine("*************WIndow 3********************");
    //     newQueue.DisplayQueue(windows[2]);
    //     // newQueue.DeQueue();
    //     // newQueue.DeQueue();
    //     // newQueue.DeQueue();
    //     // newQueue.DeQueue();
    //     // newQueue.DeQueue();
    //     // newQueue.DeQueue();
    //     // newQueue.DeQueue();
    //     // newQueue.DeQueue();
    //     // newQueue.DeQueue();
    //     // newQueue.DeQueue();
    //     // newQueue.DeQueue();
    //     // newQueue.DeQueue();
    //     // newQueue.DeQueue();

    //     // newQueue.DisplayQueue();
    // }
    // else
    // {
    //     Console.WriteLine("Invalid Configuration");
    // }
}