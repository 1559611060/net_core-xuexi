// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/grpcapi.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GRpcApi {
  public static partial class Deparments
  {
    static readonly string __ServiceName = "gAPI.Deparments";

    static readonly grpc::Marshaller<global::GRpcApi.GetAllDepartmentsRequest> __Marshaller_gAPI_GetAllDepartmentsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GRpcApi.GetAllDepartmentsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GRpcApi.GetAllDepartmentsResponse> __Marshaller_gAPI_GetAllDepartmentsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GRpcApi.GetAllDepartmentsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GRpcApi.AddDepatmentRequest> __Marshaller_gAPI_AddDepatmentRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GRpcApi.AddDepatmentRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GRpcApi.AddDepartmentResponse> __Marshaller_gAPI_AddDepartmentResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GRpcApi.AddDepartmentResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::GRpcApi.GetAllDepartmentsRequest, global::GRpcApi.GetAllDepartmentsResponse> __Method_GetAll = new grpc::Method<global::GRpcApi.GetAllDepartmentsRequest, global::GRpcApi.GetAllDepartmentsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAll",
        __Marshaller_gAPI_GetAllDepartmentsRequest,
        __Marshaller_gAPI_GetAllDepartmentsResponse);

    static readonly grpc::Method<global::GRpcApi.AddDepatmentRequest, global::GRpcApi.AddDepartmentResponse> __Method_Add = new grpc::Method<global::GRpcApi.AddDepatmentRequest, global::GRpcApi.AddDepartmentResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Add",
        __Marshaller_gAPI_AddDepatmentRequest,
        __Marshaller_gAPI_AddDepartmentResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GRpcApi.GrpcapiReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Deparments</summary>
    [grpc::BindServiceMethod(typeof(Deparments), "BindService")]
    public abstract partial class DeparmentsBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GRpcApi.GetAllDepartmentsResponse> GetAll(global::GRpcApi.GetAllDepartmentsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GRpcApi.AddDepartmentResponse> Add(global::GRpcApi.AddDepatmentRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DeparmentsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAll, serviceImpl.GetAll)
          .AddMethod(__Method_Add, serviceImpl.Add).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DeparmentsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAll, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GRpcApi.GetAllDepartmentsRequest, global::GRpcApi.GetAllDepartmentsResponse>(serviceImpl.GetAll));
      serviceBinder.AddMethod(__Method_Add, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GRpcApi.AddDepatmentRequest, global::GRpcApi.AddDepartmentResponse>(serviceImpl.Add));
    }

  }
  public static partial class Employees
  {
    static readonly string __ServiceName = "gAPI.Employees";

    static readonly grpc::Marshaller<global::GRpcApi.GetByDepartmentIdRequest> __Marshaller_gAPI_GetByDepartmentIdRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GRpcApi.GetByDepartmentIdRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GRpcApi.GetByDepartmentIdRsponse> __Marshaller_gAPI_GetByDepartmentIdRsponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GRpcApi.GetByDepartmentIdRsponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GRpcApi.AddEmployeeRequest> __Marshaller_gAPI_AddEmployeeRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GRpcApi.AddEmployeeRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GRpcApi.AddEmployeeRsponse> __Marshaller_gAPI_AddEmployeeRsponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GRpcApi.AddEmployeeRsponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GRpcApi.FireEmployeeRequest> __Marshaller_gAPI_FireEmployeeRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GRpcApi.FireEmployeeRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GRpcApi.FireEmployeeRsponse> __Marshaller_gAPI_FireEmployeeRsponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GRpcApi.FireEmployeeRsponse.Parser.ParseFrom);

    static readonly grpc::Method<global::GRpcApi.GetByDepartmentIdRequest, global::GRpcApi.GetByDepartmentIdRsponse> __Method_GetByDepartmentId = new grpc::Method<global::GRpcApi.GetByDepartmentIdRequest, global::GRpcApi.GetByDepartmentIdRsponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetByDepartmentId",
        __Marshaller_gAPI_GetByDepartmentIdRequest,
        __Marshaller_gAPI_GetByDepartmentIdRsponse);

    static readonly grpc::Method<global::GRpcApi.AddEmployeeRequest, global::GRpcApi.AddEmployeeRsponse> __Method_AddEmployee = new grpc::Method<global::GRpcApi.AddEmployeeRequest, global::GRpcApi.AddEmployeeRsponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddEmployee",
        __Marshaller_gAPI_AddEmployeeRequest,
        __Marshaller_gAPI_AddEmployeeRsponse);

    static readonly grpc::Method<global::GRpcApi.FireEmployeeRequest, global::GRpcApi.FireEmployeeRsponse> __Method_FireEmployee = new grpc::Method<global::GRpcApi.FireEmployeeRequest, global::GRpcApi.FireEmployeeRsponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "FireEmployee",
        __Marshaller_gAPI_FireEmployeeRequest,
        __Marshaller_gAPI_FireEmployeeRsponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GRpcApi.GrpcapiReflection.Descriptor.Services[1]; }
    }

    /// <summary>Base class for server-side implementations of Employees</summary>
    [grpc::BindServiceMethod(typeof(Employees), "BindService")]
    public abstract partial class EmployeesBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GRpcApi.GetByDepartmentIdRsponse> GetByDepartmentId(global::GRpcApi.GetByDepartmentIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GRpcApi.AddEmployeeRsponse> AddEmployee(global::GRpcApi.AddEmployeeRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GRpcApi.FireEmployeeRsponse> FireEmployee(global::GRpcApi.FireEmployeeRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(EmployeesBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetByDepartmentId, serviceImpl.GetByDepartmentId)
          .AddMethod(__Method_AddEmployee, serviceImpl.AddEmployee)
          .AddMethod(__Method_FireEmployee, serviceImpl.FireEmployee).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, EmployeesBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetByDepartmentId, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GRpcApi.GetByDepartmentIdRequest, global::GRpcApi.GetByDepartmentIdRsponse>(serviceImpl.GetByDepartmentId));
      serviceBinder.AddMethod(__Method_AddEmployee, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GRpcApi.AddEmployeeRequest, global::GRpcApi.AddEmployeeRsponse>(serviceImpl.AddEmployee));
      serviceBinder.AddMethod(__Method_FireEmployee, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GRpcApi.FireEmployeeRequest, global::GRpcApi.FireEmployeeRsponse>(serviceImpl.FireEmployee));
    }

  }
}
#endregion
