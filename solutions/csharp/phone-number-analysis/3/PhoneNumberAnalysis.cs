public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] splittedNum = phoneNumber.Split('-');
        
        return (splittedNum[0] == "212", splittedNum[1] == "555", splittedNum[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) 
        => phoneNumberInfo.IsFake;
}
