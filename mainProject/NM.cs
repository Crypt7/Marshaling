using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace mainProject
{
    internal static class NM
    {
        private const string DllName = @"..\..\..\Debug\Project1.dll";

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Add(int a, int b);
    }
}
