namespace Patterns.Visitor
{
    public interface IMovableEntityVisitor
    {
        public void Visit(Squad squad);
        public void Visit(Unit unit);
    }
}
