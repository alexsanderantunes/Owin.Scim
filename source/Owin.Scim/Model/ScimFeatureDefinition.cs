namespace Owin.Scim.Model
{
    using Configuration;

    public class ScimFeatureDefinition : ScimTypeDefinitionBuilder<ScimFeature>
    {
        public ScimFeatureDefinition()
        {
            For(f => f.Supported)
                .SetDescription(@"A boolean value specifying whether or not the operation is supported.")
                .SetRequired(true)
                .SetMutability(Mutability.ReadOnly);
        }
    }
}