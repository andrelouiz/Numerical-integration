namespace Numerical_integration
{
    class StackNode<T>
    {
        public T Data { get; set; }
        public StackNode<T> Previous { get; set; }
        public StackNode(T data, StackNode<T> previous)
        {
            Data = data;
            Previous = previous;
        }
    }
}