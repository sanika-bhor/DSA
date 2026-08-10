public class WindowManager
{
    public Window window;
    public int queueSize{get;set;}
    public int windowSize{get;set;}
    public int WindowNumber{get;set;}=0;

    Dictionary<int, WindowState> windowsState= new Dictionary<int, WindowState>();

public WindowManager(int queueSize,int windowSize)
    { 
        this.window = new Window(0,0+windowSize-1);
        this.queueSize = queueSize;
        this.windowSize = windowSize;
// Store initial state of Window 0  
// WindowState state =
//     new WindowState(window.StartIndex - 1,
//                     window.StartIndex - 1);

// windowsState.Add(WindowNumber, state);
    }
    public void MoveNext()
    {

        if(window.EndIndex==queueSize-1)
        {
            Console.WriteLine("can't move next");
        }
        else
        {
            SaveWindowState(window);
            WindowNumber++;
            window.StartIndex = window.EndIndex + 1;
            window.EndIndex = window.StartIndex + windowSize - 1;

            if(!windowsState.ContainsKey(WindowNumber))
            {
                WindowState state=new WindowState(window.StartIndex-1, window.StartIndex-1);
                windowsState.Add(WindowNumber, state);
                window.Front = state.Front;
                window.Rear = state.Rear;
            }
            else
            {
                WindowState oldState=windowsState[WindowNumber];
                window.Front=oldState.Front;
                window.Rear=oldState.Rear;

            }


        }

    }


    public void MoveBack()
    {

        if (window.StartIndex == 0)
        {
            Console.WriteLine("can't move back");
        }
        else
        {
            SaveWindowState(window);
            WindowNumber--;
            // window.EndIndex =window.StartIndex;
            // window.StartIndex = window.EndIndex - windowSize;

            window.StartIndex = window.StartIndex -windowSize;
            window.EndIndex = window.StartIndex + windowSize - 1;

            if (!windowsState.ContainsKey(WindowNumber))
            {
                WindowState state = new WindowState(window.StartIndex - 1, window.StartIndex - 1);
                windowsState.Add(WindowNumber, state);
                window.Front = state.Front;
                window.Rear = state.Rear;

            }
            else
            {
                WindowState oldState = windowsState[WindowNumber];
                window.Front = oldState.Front;
                window.Rear = oldState.Rear;
            }


        }

    }

    public void SaveWindowState(Window window)
    {
        WindowState newState = new WindowState(window.Rear, window.Front);
        windowsState[WindowNumber] = newState;
    }
}


// public class WindowManager
// {
//     public Window window;
//     public int queueSize { get; set; }
//     public int windowSize { get; set; }
//     public int WindowNumber { get; set; } = 0;

//     Dictionary<int, WindowState> windowsState =
//         new Dictionary<int, WindowState>();


//     public WindowManager(int queueSize, int windowSize)
//     {
//         this.window = new Window(0, windowSize - 1);
//         this.queueSize = queueSize;
//         this.windowSize = windowSize;

//         // Store initial state of Window 0
//         WindowState state =
//             new WindowState(window.StartIndex - 1,
//                             window.StartIndex - 1);

//         windowsState.Add(WindowNumber, state);
//     }


//     public void MoveNext()
//     {
//         if (window.EndIndex == queueSize - 1)
//         {
//             Console.WriteLine("can't move next");
//         }
//         else
//         {
//             // Save current window state
//             SaveWindowState(window);

//             // Move to next window
//             WindowNumber++;

//             window.StartIndex = window.EndIndex + 1;
//             window.EndIndex =
//                 window.StartIndex + windowSize - 1;


//             if (!windowsState.ContainsKey(WindowNumber))
//             {
//                 WindowState state =
//                     new WindowState(
//                         window.StartIndex - 1,
//                         window.StartIndex - 1
//                     );

//                 windowsState.Add(WindowNumber, state);

//                 window.Front = state.Front;
//                 window.Rear = state.Rear;
//             }
//             else
//             {
//                 WindowState oldState =
//                     windowsState[WindowNumber];

//                 window.Front = oldState.Front;
//                 window.Rear = oldState.Rear;
//             }
//         }
//     }


//     public void MoveBack()
//     {
//         if (window.StartIndex == 0)
//         {
//             Console.WriteLine("can't move back");
//         }
//         else
//         {
//             // Save current window state
//             SaveWindowState(window);

//             // Move to previous window
//             WindowNumber--;

//             window.StartIndex =
//                 window.StartIndex - windowSize;

//             window.EndIndex =
//                 window.StartIndex + windowSize - 1;


//             if (!windowsState.ContainsKey(WindowNumber))
//             {
//                 WindowState state =
//                     new WindowState(
//                         window.StartIndex - 1,
//                         window.StartIndex - 1
//                     );

//                 windowsState.Add(WindowNumber, state);

//                 window.Front = state.Front;
//                 window.Rear = state.Rear;
//             }
//             else
//             {
//                 WindowState oldState =
//                     windowsState[WindowNumber];

//                 window.Front = oldState.Front;
//                 window.Rear = oldState.Rear;
//             }
//         }
//     }


//     public void SaveWindowState(Window window)
//     {
//         WindowState newState =
//             new WindowState(
//                 window.Rear,
//                 window.Front
//             );

//         windowsState[WindowNumber] = newState;
//     }
// }