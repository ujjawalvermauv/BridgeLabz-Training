namespace ParcelTracker
{
    class ParcelNode
    {
        private string stage;
        private ParcelNode next;

        public string Stage
        {
            get { return stage; }
            set { stage = value; }
        }

        public ParcelNode Next
        {
            get { return next; }
            set { next = value; }
        }

        public ParcelNode(string stage)
        {
            this.stage = stage;
            this.next = null; 
        }

        public override string ToString()
        {
            return stage;
        }
    }
}
