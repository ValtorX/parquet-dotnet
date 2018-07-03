﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Parquet.Data;

namespace Parquet.Data.Concrete
{
    class ByteArrayDataTypeHandler : BasicDataTypeHandler<byte[]>
    {
        public ByteArrayDataTypeHandler() : base(DataType.ByteArray, Thrift.Type.BYTE_ARRAY)
        {
        }

        public override Array GetArray(int minCount, bool rent, bool isNullable)
        {
            throw new NotImplementedException();
        }

        public override void ReturnArray(Array array, bool isNullable)
        {
            throw new NotImplementedException();
        }

        protected override byte[] ReadOne(BinaryReader reader)
        {
            int length = reader.ReadInt32();
            byte[] data = reader.ReadBytes(length);
            return data;
        }

        protected override void WriteOne(BinaryWriter writer, byte[] value)
        {
            writer.Write(value.Length);
            writer.Write(value);
        }
    }
}
