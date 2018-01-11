using System.IO;
using System.Threading.Tasks;
using MLS.Agent.Tools;

namespace WorkspaceServer.Tests
{
    public class InMemoryWorkspaceInitializer : IWorkspaceInitializer
    {
        public int InitializeCount { get; private set; }

        public Task Initialize(DirectoryInfo directory)
        {
            InitializeCount++;
            return Task.CompletedTask;
        }
    }
}