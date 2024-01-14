# hc-6589

https://github.com/ChilliCream/graphql-platform/issues/6589

- `dotnet watch --no-hot-reload`
- http://localhost:5095

```
fail: Microsoft.AspNetCore.Diagnostics.DeveloperExceptionPageMiddleware[1]
      An unhandled exception has occurred while executing the request.
      HotChocolate.SchemaException: For more details look at the `Errors` property.

      1. The name `Test` was already registered by another type. (HotChocolate.Types.ObjectType<hc_6589.Test>)

         at HotChocolate.Configuration.TypeRegistry.Register(String typeName, RegisteredType registeredType)
         at HotChocolate.Configuration.TypeInitializer.CompleteTypeName(RegisteredType registeredType)
         at HotChocolate.Configuration.TypeInitializer.<CompleteNames>b__23_0(RegisteredType type)
         at HotChocolate.Configuration.TypeInitializer.ProcessTypes(TypeDependencyFulfilled fulfilled, Func`2 action)
         at HotChocolate.Configuration.TypeInitializer.CompleteNames()
         at HotChocolate.Configuration.TypeInitializer.Initialize()
         at HotChocolate.SchemaBuilder.Setup.InitializeTypes(SchemaBuilder builder, IDescriptorContext context, IReadOnlyList`1 types)
         at HotChocolate.SchemaBuilder.Setup.Create(SchemaBuilder builder, LazySchema lazySchema, IDescriptorContext context)
         at HotChocolate.SchemaBuilder.Create(IDescriptorContext context)
         at HotChocolate.SchemaBuilder.HotChocolate.ISchemaBuilder.Create(IDescriptorContext context)
         at HotChocolate.Execution.RequestExecutorResolver.CreateSchemaAsync(ConfigurationContext context, RequestExecutorSetup setup, RequestExecutorOptions executorOptions, IServiceProvider schemaServices, TypeModuleChangeMonitor typeModuleChangeMonitor, CancellationToken cancellationToken)
         at HotChocolate.Execution.RequestExecutorResolver.CreateSchemaServicesAsync(ConfigurationContext context, RequestExecutorSetup setup, CancellationToken cancellationToken)
         at HotChocolate.Execution.RequestExecutorResolver.GetRequestExecutorNoLockAsync(String schemaName, CancellationToken cancellationToken)
         at HotChocolate.Execution.RequestExecutorResolver.GetRequestExecutorAsync(String schemaName, CancellationToken cancellationToken)
         at HotChocolate.Execution.RequestExecutorProxy.GetRequestExecutorAsync(CancellationToken cancellationToken)
         at HotChocolate.AspNetCore.HttpPostMiddlewareBase.HandleRequestAsync(HttpContext context)
         at HotChocolate.AspNetCore.HttpPostMiddlewareBase.InvokeAsync(HttpContext context)
         at Microsoft.AspNetCore.Builder.EndpointRouteBuilderExtensions.<>c__DisplayClass19_0.<<UseCancellation>b__1>d.MoveNext()
      --- End of stack trace from previous location ---
```