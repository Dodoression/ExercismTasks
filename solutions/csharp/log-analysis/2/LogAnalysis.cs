public static class LogAnalysis 
{
    public static string SubstringAfter(this string log, string delimiter) =>
        log.Substring(log.LastIndexOf(delimiter) + delimiter.Length);

    public static string SubstringBetween(this string log, string delimiterBegin, string delimiterEnd)
    {
        int beginStringIndex = log.IndexOf(log.SubstringAfter(delimiterBegin));
        int realMessageLength = log.SubstringAfter(delimiterBegin).Length - log.Substring(log.IndexOf(delimiterEnd)).Length;
        
        return log.Substring(beginStringIndex, realMessageLength);
    }
    
    public static string Message(this string log) => log.SubstringAfter(":").Trim();

    public static string LogLevel(this string log) => log.SubstringBetween("[", "]").Trim();
}