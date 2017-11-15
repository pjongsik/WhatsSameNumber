using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace WhatsSameNumber
{
    class Utility
    {
        public static List<T> GetChildren<T>(Control container) where T : class
        {
            List<T> controls = new List<T>();

            GetChildrenCore(container, controls);

            return controls;
        }

        private static void GetChildrenCore<T>(Control container, List<T> controls) where T : class
        {
            var fields = container.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
           // var fields2 = container.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.FlattenHierarchy);

            foreach (var field in fields)
            {
                if (field.FieldType.IsSubclassOf(typeof(UserControl)))
                {
                    GetChildrenCore((UserControl)field.GetValue(container), controls);
                }

                //                if (field.FieldType.IsSubclassOf(typeof(T))) // T 가 인터페이스이면 동작하지 않음
                if (typeof(T).IsAssignableFrom(field.FieldType))
                {
                    T control = (T)field.GetValue(container);

                    // container가 ApprovalWizardForm인 경우 SnapControl이 필드로 인식됨. 이유 불상.
                    if (control != null)
                        controls.Add(control);
                }
            }
        }
    }
}
