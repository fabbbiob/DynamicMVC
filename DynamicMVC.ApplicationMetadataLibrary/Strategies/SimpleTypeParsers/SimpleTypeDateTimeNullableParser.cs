using System;
using DynamicMVC.ApplicationMetadataLibrary.Interfaces;
using DynamicMVC.Shared.Enums;
using DynamicMVC.Shared.Interfaces;

namespace DynamicMVC.ApplicationMetadataLibrary.Strategies.SimpleTypeParsers
{
    /// <summary>
    /// Simple Type Parser for Nullable DateTime datatype
    /// </summary>
    public class SimpleTypeDateTimeNullableParser : ISimpleTypeParser
    {
        public Type GetSimpleType()
        {
            return typeof(DateTime?);
        }

        public dynamic Parse(string value)
        {
            return (DateTime?)DateTime.Parse(value);
        }

        public SimpleTypeEnum SimpleTypeEnum()
        {
            return Shared.Enums.SimpleTypeEnum.DateTimeNullable;
        }
    }
}
