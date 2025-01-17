#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.16.0)
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 * </auto-generated>
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
//using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
//using Thrift.Transport;
//using Thrift.Transport.Client;
//using Thrift.Transport.Server;
//using Thrift.Processor;


#nullable disable                // suppress C# 8.0 nullable contexts (we still support earlier versions)
#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Parquet.Thrift
{

  /// <summary>
  /// LogicalType annotations to replace ConvertedType.
  /// 
  /// To maintain compatibility, implementations using LogicalType for a
  /// SchemaElement must also set the corresponding ConvertedType (if any)
  /// from the following table.
  /// </summary>
  public partial class LogicalType : TBase
  {
    private global::Parquet.Thrift.StringType _STRING;
    private global::Parquet.Thrift.MapType _MAP;
    private global::Parquet.Thrift.ListType _LIST;
    private global::Parquet.Thrift.EnumType _ENUM;
    private global::Parquet.Thrift.DecimalType _DECIMAL;
    private global::Parquet.Thrift.DateType _DATE;
    private global::Parquet.Thrift.TimeType _TIME;
    private global::Parquet.Thrift.TimestampType _TIMESTAMP;
    private global::Parquet.Thrift.IntType _INTEGER;
    private global::Parquet.Thrift.NullType _UNKNOWN;
    private global::Parquet.Thrift.JsonType _JSON;
    private global::Parquet.Thrift.BsonType _BSON;
    private global::Parquet.Thrift.UUIDType _UUID;

    public global::Parquet.Thrift.StringType STRING
    {
      get
      {
        return _STRING;
      }
      set
      {
        __isset.@STRING = true;
        this._STRING = value;
      }
    }

    public global::Parquet.Thrift.MapType MAP
    {
      get
      {
        return _MAP;
      }
      set
      {
        __isset.MAP = true;
        this._MAP = value;
      }
    }

    public global::Parquet.Thrift.ListType LIST
    {
      get
      {
        return _LIST;
      }
      set
      {
        __isset.LIST = true;
        this._LIST = value;
      }
    }

    public global::Parquet.Thrift.EnumType ENUM
    {
      get
      {
        return _ENUM;
      }
      set
      {
        __isset.@ENUM = true;
        this._ENUM = value;
      }
    }

    public global::Parquet.Thrift.DecimalType DECIMAL
    {
      get
      {
        return _DECIMAL;
      }
      set
      {
        __isset.@DECIMAL = true;
        this._DECIMAL = value;
      }
    }

    public global::Parquet.Thrift.DateType DATE
    {
      get
      {
        return _DATE;
      }
      set
      {
        __isset.DATE = true;
        this._DATE = value;
      }
    }

    public global::Parquet.Thrift.TimeType TIME
    {
      get
      {
        return _TIME;
      }
      set
      {
        __isset.TIME = true;
        this._TIME = value;
      }
    }

    public global::Parquet.Thrift.TimestampType TIMESTAMP
    {
      get
      {
        return _TIMESTAMP;
      }
      set
      {
        __isset.TIMESTAMP = true;
        this._TIMESTAMP = value;
      }
    }

    public global::Parquet.Thrift.IntType INTEGER
    {
      get
      {
        return _INTEGER;
      }
      set
      {
        __isset.INTEGER = true;
        this._INTEGER = value;
      }
    }

    public global::Parquet.Thrift.NullType UNKNOWN
    {
      get
      {
        return _UNKNOWN;
      }
      set
      {
        __isset.UNKNOWN = true;
        this._UNKNOWN = value;
      }
    }

    public global::Parquet.Thrift.JsonType JSON
    {
      get
      {
        return _JSON;
      }
      set
      {
        __isset.JSON = true;
        this._JSON = value;
      }
    }

    public global::Parquet.Thrift.BsonType BSON
    {
      get
      {
        return _BSON;
      }
      set
      {
        __isset.BSON = true;
        this._BSON = value;
      }
    }

    public global::Parquet.Thrift.UUIDType UUID
    {
      get
      {
        return _UUID;
      }
      set
      {
        __isset.UUID = true;
        this._UUID = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool @STRING;
      public bool MAP;
      public bool LIST;
      public bool @ENUM;
      public bool @DECIMAL;
      public bool DATE;
      public bool TIME;
      public bool TIMESTAMP;
      public bool INTEGER;
      public bool UNKNOWN;
      public bool JSON;
      public bool BSON;
      public bool UUID;
    }

    public LogicalType()
    {
    }

    public LogicalType DeepCopy()
    {
      var tmp78 = new LogicalType();
      if((STRING != null) && __isset.@STRING)
      {
        tmp78.STRING = (global::Parquet.Thrift.StringType)this.STRING.DeepCopy();
      }
      tmp78.__isset.@STRING = this.__isset.@STRING;
      if((MAP != null) && __isset.MAP)
      {
        tmp78.MAP = (global::Parquet.Thrift.MapType)this.MAP.DeepCopy();
      }
      tmp78.__isset.MAP = this.__isset.MAP;
      if((LIST != null) && __isset.LIST)
      {
        tmp78.LIST = (global::Parquet.Thrift.ListType)this.LIST.DeepCopy();
      }
      tmp78.__isset.LIST = this.__isset.LIST;
      if((ENUM != null) && __isset.@ENUM)
      {
        tmp78.ENUM = (global::Parquet.Thrift.EnumType)this.ENUM.DeepCopy();
      }
      tmp78.__isset.@ENUM = this.__isset.@ENUM;
      if((DECIMAL != null) && __isset.@DECIMAL)
      {
        tmp78.DECIMAL = (global::Parquet.Thrift.DecimalType)this.DECIMAL.DeepCopy();
      }
      tmp78.__isset.@DECIMAL = this.__isset.@DECIMAL;
      if((DATE != null) && __isset.DATE)
      {
        tmp78.DATE = (global::Parquet.Thrift.DateType)this.DATE.DeepCopy();
      }
      tmp78.__isset.DATE = this.__isset.DATE;
      if((TIME != null) && __isset.TIME)
      {
        tmp78.TIME = (global::Parquet.Thrift.TimeType)this.TIME.DeepCopy();
      }
      tmp78.__isset.TIME = this.__isset.TIME;
      if((TIMESTAMP != null) && __isset.TIMESTAMP)
      {
        tmp78.TIMESTAMP = (global::Parquet.Thrift.TimestampType)this.TIMESTAMP.DeepCopy();
      }
      tmp78.__isset.TIMESTAMP = this.__isset.TIMESTAMP;
      if((INTEGER != null) && __isset.INTEGER)
      {
        tmp78.INTEGER = (global::Parquet.Thrift.IntType)this.INTEGER.DeepCopy();
      }
      tmp78.__isset.INTEGER = this.__isset.INTEGER;
      if((UNKNOWN != null) && __isset.UNKNOWN)
      {
        tmp78.UNKNOWN = (global::Parquet.Thrift.NullType)this.UNKNOWN.DeepCopy();
      }
      tmp78.__isset.UNKNOWN = this.__isset.UNKNOWN;
      if((JSON != null) && __isset.JSON)
      {
        tmp78.JSON = (global::Parquet.Thrift.JsonType)this.JSON.DeepCopy();
      }
      tmp78.__isset.JSON = this.__isset.JSON;
      if((BSON != null) && __isset.BSON)
      {
        tmp78.BSON = (global::Parquet.Thrift.BsonType)this.BSON.DeepCopy();
      }
      tmp78.__isset.BSON = this.__isset.BSON;
      if((UUID != null) && __isset.UUID)
      {
        tmp78.UUID = (global::Parquet.Thrift.UUIDType)this.UUID.DeepCopy();
      }
      tmp78.__isset.UUID = this.__isset.UUID;
      return tmp78;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.Struct)
              {
                STRING = new global::Parquet.Thrift.StringType();
                await STRING.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                MAP = new global::Parquet.Thrift.MapType();
                await MAP.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Struct)
              {
                LIST = new global::Parquet.Thrift.ListType();
                await LIST.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.Struct)
              {
                ENUM = new global::Parquet.Thrift.EnumType();
                await ENUM.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.Struct)
              {
                DECIMAL = new global::Parquet.Thrift.DecimalType();
                await DECIMAL.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.Struct)
              {
                DATE = new global::Parquet.Thrift.DateType();
                await DATE.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.Struct)
              {
                TIME = new global::Parquet.Thrift.TimeType();
                await TIME.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.Struct)
              {
                TIMESTAMP = new global::Parquet.Thrift.TimestampType();
                await TIMESTAMP.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 10:
              if (field.Type == TType.Struct)
              {
                INTEGER = new global::Parquet.Thrift.IntType();
                await INTEGER.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 11:
              if (field.Type == TType.Struct)
              {
                UNKNOWN = new global::Parquet.Thrift.NullType();
                await UNKNOWN.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 12:
              if (field.Type == TType.Struct)
              {
                JSON = new global::Parquet.Thrift.JsonType();
                await JSON.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 13:
              if (field.Type == TType.Struct)
              {
                BSON = new global::Parquet.Thrift.BsonType();
                await BSON.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 14:
              if (field.Type == TType.Struct)
              {
                UUID = new global::Parquet.Thrift.UUIDType();
                await UUID.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var tmp79 = new TStruct("LogicalType");
        await oprot.WriteStructBeginAsync(tmp79, cancellationToken);
        var tmp80 = new TField();
        if((STRING != null) && __isset.@STRING)
        {
          tmp80.Name = "STRING";
          tmp80.Type = TType.Struct;
          tmp80.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp80, cancellationToken);
          await STRING.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((MAP != null) && __isset.MAP)
        {
          tmp80.Name = "MAP";
          tmp80.Type = TType.Struct;
          tmp80.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp80, cancellationToken);
          await MAP.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((LIST != null) && __isset.LIST)
        {
          tmp80.Name = "LIST";
          tmp80.Type = TType.Struct;
          tmp80.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp80, cancellationToken);
          await LIST.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((ENUM != null) && __isset.@ENUM)
        {
          tmp80.Name = "ENUM";
          tmp80.Type = TType.Struct;
          tmp80.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp80, cancellationToken);
          await ENUM.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((DECIMAL != null) && __isset.@DECIMAL)
        {
          tmp80.Name = "DECIMAL";
          tmp80.Type = TType.Struct;
          tmp80.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp80, cancellationToken);
          await DECIMAL.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((DATE != null) && __isset.DATE)
        {
          tmp80.Name = "DATE";
          tmp80.Type = TType.Struct;
          tmp80.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp80, cancellationToken);
          await DATE.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((TIME != null) && __isset.TIME)
        {
          tmp80.Name = "TIME";
          tmp80.Type = TType.Struct;
          tmp80.ID = 7;
          await oprot.WriteFieldBeginAsync(tmp80, cancellationToken);
          await TIME.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((TIMESTAMP != null) && __isset.TIMESTAMP)
        {
          tmp80.Name = "TIMESTAMP";
          tmp80.Type = TType.Struct;
          tmp80.ID = 8;
          await oprot.WriteFieldBeginAsync(tmp80, cancellationToken);
          await TIMESTAMP.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((INTEGER != null) && __isset.INTEGER)
        {
          tmp80.Name = "INTEGER";
          tmp80.Type = TType.Struct;
          tmp80.ID = 10;
          await oprot.WriteFieldBeginAsync(tmp80, cancellationToken);
          await INTEGER.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((UNKNOWN != null) && __isset.UNKNOWN)
        {
          tmp80.Name = "UNKNOWN";
          tmp80.Type = TType.Struct;
          tmp80.ID = 11;
          await oprot.WriteFieldBeginAsync(tmp80, cancellationToken);
          await UNKNOWN.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((JSON != null) && __isset.JSON)
        {
          tmp80.Name = "JSON";
          tmp80.Type = TType.Struct;
          tmp80.ID = 12;
          await oprot.WriteFieldBeginAsync(tmp80, cancellationToken);
          await JSON.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((BSON != null) && __isset.BSON)
        {
          tmp80.Name = "BSON";
          tmp80.Type = TType.Struct;
          tmp80.ID = 13;
          await oprot.WriteFieldBeginAsync(tmp80, cancellationToken);
          await BSON.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((UUID != null) && __isset.UUID)
        {
          tmp80.Name = "UUID";
          tmp80.Type = TType.Struct;
          tmp80.ID = 14;
          await oprot.WriteFieldBeginAsync(tmp80, cancellationToken);
          await UUID.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      if (!(that is LogicalType other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.@STRING == other.__isset.@STRING) && ((!__isset.@STRING) || (global::System.Object.Equals(STRING, other.STRING))))
        && ((__isset.MAP == other.__isset.MAP) && ((!__isset.MAP) || (global::System.Object.Equals(MAP, other.MAP))))
        && ((__isset.LIST == other.__isset.LIST) && ((!__isset.LIST) || (global::System.Object.Equals(LIST, other.LIST))))
        && ((__isset.@ENUM == other.__isset.@ENUM) && ((!__isset.@ENUM) || (global::System.Object.Equals(ENUM, other.ENUM))))
        && ((__isset.@DECIMAL == other.__isset.@DECIMAL) && ((!__isset.@DECIMAL) || (global::System.Object.Equals(DECIMAL, other.DECIMAL))))
        && ((__isset.DATE == other.__isset.DATE) && ((!__isset.DATE) || (global::System.Object.Equals(DATE, other.DATE))))
        && ((__isset.TIME == other.__isset.TIME) && ((!__isset.TIME) || (global::System.Object.Equals(TIME, other.TIME))))
        && ((__isset.TIMESTAMP == other.__isset.TIMESTAMP) && ((!__isset.TIMESTAMP) || (global::System.Object.Equals(TIMESTAMP, other.TIMESTAMP))))
        && ((__isset.INTEGER == other.__isset.INTEGER) && ((!__isset.INTEGER) || (global::System.Object.Equals(INTEGER, other.INTEGER))))
        && ((__isset.UNKNOWN == other.__isset.UNKNOWN) && ((!__isset.UNKNOWN) || (global::System.Object.Equals(UNKNOWN, other.UNKNOWN))))
        && ((__isset.JSON == other.__isset.JSON) && ((!__isset.JSON) || (global::System.Object.Equals(JSON, other.JSON))))
        && ((__isset.BSON == other.__isset.BSON) && ((!__isset.BSON) || (global::System.Object.Equals(BSON, other.BSON))))
        && ((__isset.UUID == other.__isset.UUID) && ((!__isset.UUID) || (global::System.Object.Equals(UUID, other.UUID))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((STRING != null) && __isset.@STRING)
        {
          hashcode = (hashcode * 397) + STRING.GetHashCode();
        }
        if((MAP != null) && __isset.MAP)
        {
          hashcode = (hashcode * 397) + MAP.GetHashCode();
        }
        if((LIST != null) && __isset.LIST)
        {
          hashcode = (hashcode * 397) + LIST.GetHashCode();
        }
        if((ENUM != null) && __isset.@ENUM)
        {
          hashcode = (hashcode * 397) + ENUM.GetHashCode();
        }
        if((DECIMAL != null) && __isset.@DECIMAL)
        {
          hashcode = (hashcode * 397) + DECIMAL.GetHashCode();
        }
        if((DATE != null) && __isset.DATE)
        {
          hashcode = (hashcode * 397) + DATE.GetHashCode();
        }
        if((TIME != null) && __isset.TIME)
        {
          hashcode = (hashcode * 397) + TIME.GetHashCode();
        }
        if((TIMESTAMP != null) && __isset.TIMESTAMP)
        {
          hashcode = (hashcode * 397) + TIMESTAMP.GetHashCode();
        }
        if((INTEGER != null) && __isset.INTEGER)
        {
          hashcode = (hashcode * 397) + INTEGER.GetHashCode();
        }
        if((UNKNOWN != null) && __isset.UNKNOWN)
        {
          hashcode = (hashcode * 397) + UNKNOWN.GetHashCode();
        }
        if((JSON != null) && __isset.JSON)
        {
          hashcode = (hashcode * 397) + JSON.GetHashCode();
        }
        if((BSON != null) && __isset.BSON)
        {
          hashcode = (hashcode * 397) + BSON.GetHashCode();
        }
        if((UUID != null) && __isset.UUID)
        {
          hashcode = (hashcode * 397) + UUID.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp81 = new StringBuilder("LogicalType(");
      int tmp82 = 0;
      if((STRING != null) && __isset.@STRING)
      {
        if(0 < tmp82++) { tmp81.Append(", "); }
        tmp81.Append("STRING: ");
        STRING.ToString(tmp81);
      }
      if((MAP != null) && __isset.MAP)
      {
        if(0 < tmp82++) { tmp81.Append(", "); }
        tmp81.Append("MAP: ");
        MAP.ToString(tmp81);
      }
      if((LIST != null) && __isset.LIST)
      {
        if(0 < tmp82++) { tmp81.Append(", "); }
        tmp81.Append("LIST: ");
        LIST.ToString(tmp81);
      }
      if((ENUM != null) && __isset.@ENUM)
      {
        if(0 < tmp82++) { tmp81.Append(", "); }
        tmp81.Append("ENUM: ");
        ENUM.ToString(tmp81);
      }
      if((DECIMAL != null) && __isset.@DECIMAL)
      {
        if(0 < tmp82++) { tmp81.Append(", "); }
        tmp81.Append("DECIMAL: ");
        DECIMAL.ToString(tmp81);
      }
      if((DATE != null) && __isset.DATE)
      {
        if(0 < tmp82++) { tmp81.Append(", "); }
        tmp81.Append("DATE: ");
        DATE.ToString(tmp81);
      }
      if((TIME != null) && __isset.TIME)
      {
        if(0 < tmp82++) { tmp81.Append(", "); }
        tmp81.Append("TIME: ");
        TIME.ToString(tmp81);
      }
      if((TIMESTAMP != null) && __isset.TIMESTAMP)
      {
        if(0 < tmp82++) { tmp81.Append(", "); }
        tmp81.Append("TIMESTAMP: ");
        TIMESTAMP.ToString(tmp81);
      }
      if((INTEGER != null) && __isset.INTEGER)
      {
        if(0 < tmp82++) { tmp81.Append(", "); }
        tmp81.Append("INTEGER: ");
        INTEGER.ToString(tmp81);
      }
      if((UNKNOWN != null) && __isset.UNKNOWN)
      {
        if(0 < tmp82++) { tmp81.Append(", "); }
        tmp81.Append("UNKNOWN: ");
        UNKNOWN.ToString(tmp81);
      }
      if((JSON != null) && __isset.JSON)
      {
        if(0 < tmp82++) { tmp81.Append(", "); }
        tmp81.Append("JSON: ");
        JSON.ToString(tmp81);
      }
      if((BSON != null) && __isset.BSON)
      {
        if(0 < tmp82++) { tmp81.Append(", "); }
        tmp81.Append("BSON: ");
        BSON.ToString(tmp81);
      }
      if((UUID != null) && __isset.UUID)
      {
        if(0 < tmp82++) { tmp81.Append(", "); }
        tmp81.Append("UUID: ");
        UUID.ToString(tmp81);
      }
      tmp81.Append(')');
      return tmp81.ToString();
    }
  }

}
