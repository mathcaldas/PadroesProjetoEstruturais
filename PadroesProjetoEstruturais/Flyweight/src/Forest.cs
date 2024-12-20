namespace Flyweight.src;

public class Forest
{
    private readonly List<Tree> _trees = new();

    public void AddTree(Tree tree)
    {
        _trees.Add(tree);
    }

    public void Render()
    {
        foreach (var tree in _trees)
        {
            tree.Render();
        }
    }
}