namespace AadharRadixSort
{
    class Aadhar
    {
        private string number; // 12-digit number as string (safe for radix)

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public Aadhar(string number)
        {
            this.number = number;
        }

        public override string ToString()
        {
            return number;
        }
    }
}
