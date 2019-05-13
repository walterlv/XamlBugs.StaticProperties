// This namespace can be changed to any other and the bug still reproduces.
namespace XamlBugs.StaticProperties
{
    /// <summary>
    /// The class that provide a `Border` property.
    /// You can change this class name to any other and the bug still reproduces.
    /// </summary>
    public static class FooClass
    {
        /// <summary>
        /// The correct value for this property is `string.Empty`, but you'll see `1` in actual.
        /// </summary>
        public static string Border => "";
    }
}
