using System;
using System.Linq;

namespace XDASv2Net.Extensions
{
    public static class EnumExtensions
    {
        public static TAttribute GetAttribute<TAttribute>(this Enum value)
            where TAttribute : Attribute
        {
            try
            {
                var type = value.GetType();
                var name = Enum.GetName(type, value);
                return type.GetField(name).GetCustomAttributes(false).OfType<TAttribute>().SingleOrDefault() ?? (TAttribute)Activator.CreateInstance(typeof(TAttribute));
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
