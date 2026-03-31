public static class LogAnalysis 
{
    public static string SubstringAfter(this string log, string delimiter) =>
        log.Substring(log.LastIndexOf(delimiter) + delimiter.Length);

    public static string SubstringBetween(this string log, string delimiterBegin, string delimiterEnd)
    {
        string beginPart = log.Substring(0, log.IndexOf(delimiterEnd));
        return beginPart.SubstringAfter(delimiterBegin);
    }
    
    public static string Message(this string log) => log.SubstringAfter(": ");

    public static string LogLevel(this string log) => log.SubstringBetween("[", "]");
}