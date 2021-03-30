using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MFR.Objects
{
    public static class TypeExtensions
    {
        /// <summary>
        /// caching a Dictionary of IList types for faster browsing
        /// </summary>
        /// <param name="type">
        /// </param>
        /// <returns>
        /// </returns>
        private static readonly Dictionary<Type, Type> CachedActualType =
            new Dictionary<Type, Type>();

        // Get Internal type of IList. When the type is not a list then it will
        // return the same type. if type is List<T> it will return the type of T
        public static Type GetActualType(this Type type)
        {
            if (CachedActualType.ContainsKey(type))
                return CachedActualType[type];

            if (type.GetTypeInfo().IsArray)
                CachedActualType.Add(type, type.GetElementType());
            else if (type.GenericTypeArguments.Any())
                CachedActualType.Add(
                    type, type.GenericTypeArguments.First()
                ); // this is almost always find the right type of an IList but if it fail then do the below. Don't really remember why this fail sometimes.
            else if (type.FullName?.Contains("List`1") ?? false)
                CachedActualType.Add(
                    type, type.GetRuntimeProperty("Item").PropertyType
                );
            else
                CachedActualType.Add(type, type);

            return CachedActualType[type];
        }
    }
}