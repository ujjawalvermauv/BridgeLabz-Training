using System;

class OtpManager
{
    // a. Method to Generate a 6-digit OTP number
    public int GenerateOtp()
    {
        Random random = new Random();
        return random.Next(100000, 1000000);
    }

    // c. Method to ensure that the OTP numbers generated are unique
    public bool AreOtpsUnique(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                // If any two elements are the same, return false
                if (otps[i] == otps[j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    static void Main()
    {
        OtpManager manager = new OtpManager();
        
        // b. Create an array to save 10 OTP numbers
        int[] otpList = new int[10];

        Console.WriteLine("Generating 10 OTPs:");
        for (int i = 0; i < otpList.Length; i++)
        {
            otpList[i] = manager.GenerateOtp();
            Console.WriteLine("OTP " + (i + 1) + ": " + otpList[i]);
            System.Threading.Thread.Sleep(20); 
        }

        // Validate uniqueness
        bool isUnique = manager.AreOtpsUnique(otpList);

        if (isUnique)
        {
            Console.WriteLine("\nValidation Success: All 10 OTPs are unique.");
        }
        else
        {
            Console.WriteLine("\nValidation Failed: Duplicate OTPs found.");
        }
    }
}