using System;

namespace EnumHelper.Classes.Enums.Helper
{
    public interface IEnumHelpers<T> where T : struct
    {
        String ToString(T t);
        T GetValue(String t);
    }
}
