using System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace yzslz.Tools
{
    class FillTools
    {
        public static T FillEntity<T>(DataRow dr) where T : new ()
        {
            T t = new T();
            Type type = t.GetType();
            PropertyInfo[] propertyInfos = type.GetProperties();

            foreach (PropertyInfo item in propertyInfos)
            {
               
            }

            return t;
        }

        public static List<T> MyFill<T>()
        {

            List<T> list = new List<T>();


            return list;




        }

        public static T FillEntityByDt<T>(DataTable dt) where T : new()
        {
            T t = new T();
            Type type = t.GetType();
            PropertyInfo[] propertyInfos = type.GetProperties();
            DataRow dr = dt.Rows[0];
            foreach (PropertyInfo item in propertyInfos)
            {
                if (dt.Columns.Contains(item.Name))
                {
                    if (item.PropertyType == typeof(string))
                    {
                        item.SetValue(t, Convert.ToString(dr[item.Name]), null);
                    }
                }
            }
            return t;
        }

        public static List<T> FillListByDt<T>(DataTable dt) where T : new()
        {
            List<T> list = new List<T>();

            foreach (DataRow dr in dt.Rows)
            {
                T t = new T();
                Type type = t.GetType();
                PropertyInfo[] propertyInfos = type.GetProperties();
                foreach (PropertyInfo item in propertyInfos)
                {
                    if (dt.Columns.Contains(item.Name))
                    {
                        if (item.PropertyType == typeof(string))
                        {
                            item.SetValue(t, Convert.ToString(dr[item.Name]), null);
                        }
                        if (item.PropertyType == typeof(int))
                        {
                            item.SetValue(t, Convert.ToInt32(dr[item.Name]), null);
                        }
                    }

                }
                list.Add(t);
            }
            return list;
        }




    }
}
