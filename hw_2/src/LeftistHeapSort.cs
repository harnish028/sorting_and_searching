public static class LeftistHeapS
{
    static LeftistHeapNode leftistHeap;

    public static void LeftistHeapSort(int[] arr)
    {
        LeftistHeapNode node;
            
        for (int i = 0; i < arr.Length - 1; i++)
        {
            node = new LeftistHeapNode(arr[i]);
            AddNodeTo(ref leftistHeap, ref node);
        }

        for (int i = arr.Length - 1; i > 0; i--)
        {
          arr[i] = ExtractMaxKey(ref leftistHeap);
        }
    }

    class LeftistHeapNode
    {
        public LeftistHeapNode left;
        public LeftistHeapNode right;
        public LeftistHeapNode parent;
        public int key;
        public int npl; //null-path-length     

        public LeftistHeapNode(int key)
        {
            this.key = key;
            this.npl = 0;
        }
    }

    static LeftistHeapNode Merge(ref LeftistHeapNode x, ref LeftistHeapNode y)
    {
        if (x == null)
        {
            return y;
        }

        if (y == null)
        {
            return x;
        }

        if (y.key < x.key)
        {
            Swap(ref x, ref y);
        }

        x.right = Merge(ref x.right, ref y);
        if (x.left == null || x.left.npl < x.right.npl) 
        {
            Swap(ref x.right, ref x.left);  
        }
        
        if (x.right == null || x.left == null)
        {
            x.npl = 0;
        }
        else
        {
            x.npl = (x.left.npl > x.right.npl) ? x.right.npl + 1 : x.left.npl + 1;
        }

        return x;
    }

    static void AddNodeTo(ref LeftistHeapNode leftistHeap, ref LeftistHeapNode node)
    {
        leftistHeap = Merge(ref leftistHeap , ref node);
    }

    static int ExtractMaxKey(ref LeftistHeapNode node)
    {   
        int maxKey = node.key;
        node = Merge(ref node.left, ref node.right);
        
        return maxKey;
    }

    static void Swap(ref LeftistHeapNode node1, ref LeftistHeapNode node2)
    {
        LeftistHeapNode temp = node1;
        node1 = node2;
        node2 = temp;
    }
}
