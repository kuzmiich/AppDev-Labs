using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba4.modules
{
    public static class ArrExtension
    {
        public static List<object> AsTupleList<T>(this T[,] matrix)
        {
            var col = matrix.GetLength(1);
            var result = new List<object>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                T[] values = new T[col];

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    values[j] = matrix[i, j];
                }

                result.Add(GetTuple(values));
            }

            return result;
        }

        private static object GetTuple<T>(params T[] values)
        {
            Type genericType = Type.GetType("System.Tuple`" + values.Length);
            Type[] typeArgs = values.Select(_ => typeof(T)).ToArray();
            Type specificType = genericType.MakeGenericType(typeArgs);
            object[] constructorArguments = values.Cast<object>().ToArray();
            return Activator.CreateInstance(specificType, constructorArguments);
        }
    }
}
