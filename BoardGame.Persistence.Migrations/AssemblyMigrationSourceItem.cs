using System.Reflection;
using FluentMigrator;
using FluentMigrator.Runner.Initialization;

namespace BoardGame.Persistence.Migrations;

/// <summary>
/// Implementation of <see cref="IMigrationSourceItem"/> that accepts a collection of assemblies.
/// </summary>
internal class AssemblyMigrationSourceItem(IReadOnlyCollection<Assembly> assemblies) : IMigrationSourceItem
{
    public required bool ScanOnlyExportedTypes { get; set; }

    /// <inheritdoc />
    public IEnumerable<Type> MigrationTypeCandidates
    {
        get
        {
            IEnumerable<Type> types;
            if (ScanOnlyExportedTypes)
            {
                types = assemblies.SelectMany(a => a.GetExportedTypes());
            }
            else
            {
                types = assemblies.SelectMany(a => a.GetTypes());
            }
            return types.Where(t => typeof(IMigration).IsAssignableFrom(t) && !t.IsAbstract);
        }
    }
}
