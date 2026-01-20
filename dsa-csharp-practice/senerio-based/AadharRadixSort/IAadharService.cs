namespace AadharRadixSort
{
    interface IAadharService
    {
        void AddAadhar(string number);
        void RadixSort();
        int BinarySearch(string target);
        void Display();
    }
}
