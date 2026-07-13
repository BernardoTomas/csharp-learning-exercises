namespace Streaming.Models;

class IdGenerator
{
    private int _nextId = 1;

    public int GenerateId (string prefix)
    {
        int newId = int.Parse(prefix + _nextId);
        _nextId ++;
        return newId;
    }
}
