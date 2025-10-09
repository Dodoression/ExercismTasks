public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] splittedNum = phoneNumber.Split('-');
        
        return (splittedNum[0] == "212" ? true : false, splittedNum[1] == "555" ? true : false, 
                splittedNum[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
