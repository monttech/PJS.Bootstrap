namespace PJS.Bootstrap
{
    using Orchard.UI.Resources;

    public class ResourceManifestProvider : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();
        }
    }
}
