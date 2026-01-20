namespace ParcelTracker
{
    interface IParcelTracker
    {
        void AddStage(string stage);
        void AddAfter(string existingStage, string newStage);
        void TrackParcel();
    }
}
