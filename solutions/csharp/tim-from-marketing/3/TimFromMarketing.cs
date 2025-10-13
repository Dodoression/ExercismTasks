static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string resultID = id == null ? "" : ($"[{id}] - ");
        department = department ?? "OWNER";
        
        return ($"{resultID}{name} - {department.ToUpper()}");
    }
}
