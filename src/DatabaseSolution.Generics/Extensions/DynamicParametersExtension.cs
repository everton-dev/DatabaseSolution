using Dapper;
using System;

namespace DatabaseSolution.Generics
{
    public static class DynamicParametersExtension
    {
        public static void AddParameter(this DynamicParameters param, string name, object value)
        {
            if (value is string)
                param.AddParameter(name, value.ToString());

            else if (value is UInt16)
                param.AddParameter(name, (UInt16)value);

            else if (value is UInt16?)
                param.AddParameter(name, (UInt16?)value);

            else if (value is UInt32)
                param.AddParameter(name, (UInt32)value);

            else if (value is UInt32?)
                param.AddParameter(name, (UInt32?)value);

            else if (value is UInt64)
                param.AddParameter(name, (UInt64)value);

            else if (value is UInt64?)
                param.AddParameter(name, (UInt64?)value);

            else if (value is short)
                param.AddParameter(name, (short)value);

            else if (value is short?)
                param.AddParameter(name, (short?)value);

            else if (value is int)
                param.AddParameter(name, (int)value);

            else if (value is int?)
                param.AddParameter(name, (int?)value);

            else if (value is long)
                param.AddParameter(name, (long)value);

            else if (value is long?)
                param.AddParameter(name, (long?)value);

            else if (value is bool)
                param.AddParameter(name, (bool)value);

            else if (value is bool?)
                param.AddParameter(name, (bool?)value);

            else if (value is DateTime)
                param.AddParameter(name, (DateTime)value);

            else if (value is DateTime?)
                param.AddParameter(name, (DateTime?)value);

            else if (value is byte[])
                param.AddParameter(name, (byte[])value);

            else if (value is byte)
                param.AddParameter(name, (byte)value);

            else if (value is byte?)
                param.AddParameter(name, (byte?)value);

            else if (value is decimal)
                param.AddParameter(name, (decimal)value);

            else if (value is decimal?)
                param.AddParameter(name, (decimal?)value);

            else if (value is double)
                param.AddParameter(name, (double)value);

            else if (value is double?)
                param.AddParameter(name, (double?)value);

            else if (value is Guid)
                param.AddParameter(name, (Guid)value);

            else if (value is Guid?)
                param.AddParameter(name, (Guid?)value);
        }

        public static void AddParameter(this DynamicParameters param, string name, string value)
        {
            param.Add(name, value, System.Data.DbType.String, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, UInt16 value)
        {
            param.Add(name, value, System.Data.DbType.UInt16, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, UInt16? value)
        {
            param.Add(name, value, System.Data.DbType.UInt16, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, UInt32 value)
        {
            param.Add(name, value, System.Data.DbType.UInt32, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, UInt32? value)
        {
            param.Add(name, value, System.Data.DbType.UInt32, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, UInt64 value)
        {
            param.Add(name, value, System.Data.DbType.UInt64, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, UInt64? value)
        {
            param.Add(name, value, System.Data.DbType.UInt64, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, short value)
        {
            param.Add(name, value, System.Data.DbType.Int16, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, short? value)
        {
            param.Add(name, value, System.Data.DbType.Int16, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, int value)
        {
            param.Add(name, value, System.Data.DbType.Int32, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, int? value)
        {
            param.Add(name, value, System.Data.DbType.Int32, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, long value)
        {
            param.Add(name, value, System.Data.DbType.Int64, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, long? value)
        {
            param.Add(name, value, System.Data.DbType.Int64, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, bool value)
        {
            param.Add(name, value, System.Data.DbType.Boolean, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, bool? value)
        {
            param.Add(name, value, System.Data.DbType.Boolean, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, DateTime value)
        {
            param.Add(name, value, System.Data.DbType.DateTime, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, DateTime? value)
        {
            param.Add(name, value, System.Data.DbType.DateTime, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, byte[] value)
        {
            param.Add(name, value, System.Data.DbType.Binary, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, byte value)
        {
            param.Add(name, value, System.Data.DbType.Byte, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, byte? value)
        {
            param.Add(name, value, System.Data.DbType.Byte, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, decimal value)
        {
            param.Add(name, value, System.Data.DbType.Decimal, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, decimal? value)
        {
            param.Add(name, value, System.Data.DbType.Decimal, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, double value)
        {
            param.Add(name, value, System.Data.DbType.Double, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, double? value)
        {
            param.Add(name, value, System.Data.DbType.Double, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, Guid value)
        {
            param.Add(name, value, System.Data.DbType.Guid, System.Data.ParameterDirection.Input, null);
        }

        public static void AddParameter(this DynamicParameters param, string name, Guid? value)
        {
            param.Add(name, value, System.Data.DbType.Guid, System.Data.ParameterDirection.Input, null);
        }

    }
}