using System.Collections.Generic;
using UnityEngine;

namespace Kuroha.GUI.Editor.Table
{
    public static class CommonTableDelegate
    {
        public delegate bool FilterMethod<in T>(int mask, T data, string std);

        public delegate void SelectMethod<T>(in List<T> dataList);

        public delegate void ExportMethod<T>(string filePath, in List<T> dataList);

        public delegate void DrawCellMethod<in T>(Rect cellRect, T item);

        public delegate int CompareMethod<in T>(T data1, T data2, bool sortType);
    }
}