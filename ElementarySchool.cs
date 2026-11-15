public class GradeSchool
{
    private readonly Dictionary<int, List<string>> _roster = new Dictionary<int, List<string>>();
  
    public bool Add(string student, int grade)
    {
        foreach (var studentsInGrade in _roster.Values)
        {
            if (studentsInGrade.Contains(student))
            {
                return false;
            }
        }
      
        if (!_roster.ContainsKey(grade))
        {
            _roster[grade] = new List<string>();
        }
      
        _roster[grade].Add(student);
        _roster[grade].Sort();
        return true;
    }
  
    public IEnumerable<string> Roster()
    {
        return _roster.OrderBy(g => g.Key).SelectMany(g => g.Value);
    }
  
    public IEnumerable<string> Grade(int grade)
    {
        if (_roster.ContainsKey(grade))
        {
            return _roster[grade];
        }
        
        return Enumerable.Empty<string>();
    }
}
