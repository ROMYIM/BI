﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataBase.Mongo.Models
{
    internal static class Types
    {
        internal static readonly Type Int16 = typeof(short);
        internal static readonly Type Int32 = typeof(int);
        internal static readonly Type Int64 = typeof(long);
        internal static readonly Type UInt32 = typeof(uint);
        internal static readonly Type Float = typeof(float);
        internal static readonly Type Double = typeof(double);
        internal static readonly Type Decimal = typeof(decimal);
        internal static readonly Type DateTime = typeof(DateTime);
        internal static readonly Type Enum = typeof(Enum);
    }
}
