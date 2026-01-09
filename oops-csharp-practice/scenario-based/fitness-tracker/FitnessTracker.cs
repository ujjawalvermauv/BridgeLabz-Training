public abstract class FitnessTracker : ITrackable
{
    protected int duration;

    public FitnessTracker(int duration)
    {
        this.duration = duration;
    }

    public abstract void Start();
    public abstract void End();
    public abstract int CaloriesBurned();
}
