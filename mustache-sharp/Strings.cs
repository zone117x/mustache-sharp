using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mustache.Properties
{
   public static class Resources 
   {
      public readonly static string BlankParameterName = "An attempt was made to define a parameter with a null or an invalid identifier.";

      public readonly static string BlankTagName = "An attempt was made to define a tag with a null or an invalid identifier.";

      public readonly static string DuplicateParameter = "A parameter with the same name already exists within the tag.";

      public readonly static string DuplicateTagDefinition = "The {0} tag has already been registered.";

      public readonly static string KeyNotFound = "The key {0} could not be found.";

      public readonly static string MissingClosingTag = "Expected a matching {0} tag but none was found";

      public readonly static string UnknownTag = "Encountered an unknown tag: {0}. It was either not registered or exists in a different context";

      public readonly static string WrongNumberOfArguments = "The wrong number of arguments were passed to an {0} tag.";
   }
}
