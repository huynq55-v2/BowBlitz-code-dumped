class <Module>
{
}

namespace System
{
    namespace Configuration
    {
        class ConfigurationElement
        {
            /*0x233241c*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            /*0x2332454*/ bool IsModified();
            /*0x233248c*/ void Reset(System.Configuration.ConfigurationElement parentElement);
            /*0x23324c4*/ void ResetModified();
        }

        class ConfigurationSection : System.Configuration.ConfigurationElement
        {
            /*0x23324fc*/ void DeserializeSection(System.Xml.XmlReader reader);
            /*0x2332534*/ bool IsModified();
            /*0x233256c*/ void ResetModified();
            /*0x23325a4*/ string SerializeSection(System.Configuration.ConfigurationElement parentElement, string name, System.Configuration.ConfigurationSaveMode saveMode);
        }

        enum ConfigurationSaveMode
        {
            Full = 2,
            Minimal = 1,
            Modified = 0,
        }

        class ConfigurationPropertyCollection
        {
        }

        class ConfigurationElementCollection : System.Configuration.ConfigurationElement
        {
        }

        class ConfigurationCollectionAttribute : System.Attribute
        {
            /*0x23325dc*/ ConfigurationCollectionAttribute(System.Type itemType);
        }

        class ConfigurationSectionGroup
        {
        }

        class IgnoreSection : System.Configuration.ConfigurationSection
        {
            /*0x23325e0*/ IgnoreSection();
            /*0x2332618*/ System.Configuration.ConfigurationPropertyCollection get_Properties();
            /*0x2332650*/ void DeserializeSection(System.Xml.XmlReader xmlReader);
            /*0x2332688*/ bool IsModified();
            /*0x23326c0*/ void Reset(System.Configuration.ConfigurationElement parentSection);
            /*0x23326f8*/ void ResetModified();
            /*0x2332730*/ string SerializeSection(System.Configuration.ConfigurationElement parentSection, string name, System.Configuration.ConfigurationSaveMode saveMode);
        }
    }
}

namespace Unity
{
    class ThrowStub : System.ObjectDisposedException
    {
        static /*0x2332768*/ void ThrowNotSupportedException();
    }
}
