public class FitnessTrackerMenu
{
    public static ITrackable GetWorkout(int choice)
    {
        if (choice == 1)
        {
            return new CardioWorkout(30);
        }
        else if (choice == 2)
        {
            return new StrengthWorkout(40);
        }
        else
        {
            return null;
        }
    }
}
