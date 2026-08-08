public class Window{
    // public int WindowSize{get;set;}
    public int Rear{get;set;}
    public int Front{get;set;}

    public int StartIndex{get;set;}
    public int EndIndex{get;set;}

    public Window(int startIndex, int endIndex)
    {
        // WindowSize = windowSize;
        StartIndex=startIndex;
        EndIndex=endIndex;
        Rear = startIndex-1;
        Front = startIndex-1;
    }
}