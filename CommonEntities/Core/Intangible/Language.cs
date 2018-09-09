using System.Runtime.Serialization;

namespace CommonEntities.Core.Intangible
{
    /// <summary>
    /// Natural languages such as Spanish, Tamil, Hindi, English, etc. Formal 
    /// language code tags expressed in BCP 47 
    /// (https://en.wikipedia.org/wiki/IETF_language_tag) can be used via the
    /// alternateName property. The Language type previously also covered 
    /// programming languages such as Scheme and Lisp, which are now best 
    /// represented using ComputerLanguage.
    /// </summary>
    [DataContract(Name = "Language", Namespace = "https://schema.org/Language")]
    public class Language : Thing
    {
    }
}
