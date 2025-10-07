public static class LogAnalysis 
{
    public static string SubstringAfter(this string log, string delimiter) =>
        log.Substring(log.LastIndexOf(delimiter) + delimiter.Length);

    public static string SubstringBetween(this string log, string delimiterBegin, string delimiterEnd)
    {
        int beginStringIndex = log.IndexOf(delimiterBegin) + delimiterBegin.Length;
        int realMessageLength = log.Substring(beginStringIndex).Length - log.Substring(log.IndexOf(delimiterEnd)).Length;
        
        return log.Substring(beginStringIndex, realMessageLength);
    }
    
    public static string Message(this string log) => log.Substring(log.IndexOf(":") + 1).Trim();

    public static string LogLevel(this string log) => log.Substring(1, log.IndexOf("]") - 1);
}