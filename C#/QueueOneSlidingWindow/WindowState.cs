public class WindowState
{

    public int Rear { get; set; }
    public int Front { get; set; }

    public WindowState(int rear, int front)
    {
        this.Rear = rear;
        this.Front = front;
    }
}