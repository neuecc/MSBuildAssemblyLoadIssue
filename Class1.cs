using MagicOnion;
using MessagePack;

namespace MSBuildAssemblyLoadIssue
{
    [MessagePackObject]
    public class Foo
    {
        [Key(0)]
        public int Bar { get; set; }
    }

    public interface IFooService : IService<IFooService>
    {
        UnaryResult<int> BarAsync(Foo foo);
    }
}
