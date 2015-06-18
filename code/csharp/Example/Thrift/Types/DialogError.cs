/**
 * Autogenerated by Thrift Compiler (1.0.0-dev)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Example.Thrift.Types
{

  /// <summary>
  /// Ошибка сервиса диалогов.
  /// 
  /// message: сообщение об ошибке.
  /// 
  /// code: код ошибки.
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class DialogError : TException, TBase
  {
    private short _code;

    public string Message { get; set; }

    public short Code
    {
      get
      {
        return _code;
      }
      set
      {
        __isset.code = true;
        this._code = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool code;
    }

    public DialogError() {
    }

    public DialogError(string message) : this() {
      this.Message = message;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_message = false;
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              Message = iprot.ReadString();
              isset_message = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I16) {
              Code = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
      if (!isset_message)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("DialogError");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "message";
      field.Type = TType.String;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Message);
      oprot.WriteFieldEnd();
      if (__isset.code) {
        field.Name = "code";
        field.Type = TType.I16;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Code);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("DialogError(");
      __sb.Append(", Message: ");
      __sb.Append(Message);
      if (__isset.code) {
        __sb.Append(", Code: ");
        __sb.Append(Code);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}