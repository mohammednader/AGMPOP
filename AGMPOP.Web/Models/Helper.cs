using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AGMPOP.Web.Models
{
    public static class Helper
    {
        public static string ToSentenceCase(this string str)
        {
            try
            {
                return Regex.Replace(str, "[a-z][A-Z]", m => $"{m.Value[0]} {m.Value[1]}");
            }
            catch
            {
                return str;
            }
        }


        public static DataTable GenerateDataTable<T>(T[] list)
        {
            var dt = new DataTable();
            var props = typeof(T).GetProperties().Where(p => p.CanRead && p.GetGetMethod(false) != null).ToArray();
            for (var i = 0; i < props.Length; i++)
            {
                var prop = props[i];
                var type = prop.PropertyType;
                if (Nullable.GetUnderlyingType(type) != null)
                {
                    type = Nullable.GetUnderlyingType(type);
                }
                var name = prop.Name.ToSentenceCase();
                var displayNameAttr = prop.GetCustomAttributes(typeof(DisplayNameAttribute), true);
                if (displayNameAttr?.Count() > 0)
                {
                    name = ((DisplayNameAttribute)displayNameAttr[0]).DisplayName;
                }
                dt.Columns.Add(name, type);
            }

            for (int i = 0; i < list.Length; i++)
            {
                var item = list[i];
                var row = dt.NewRow();
                for (var j = 0; j < props.Length; j++)
                {
                    var prop = props[j];
                    var value = prop.GetValue(item);
                    row[j] = value ?? DBNull.Value;

                }
                dt.Rows.Add(row);
            }

            return dt;
        }



    }
}
