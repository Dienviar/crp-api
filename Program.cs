using crp_api.Data;
using crp_api.GQL.Mutations;
using crp_api.GQL.Queries;
using crp_api.Services;
using crp_api.XSystem;
using GraphQL.Server.Ui.Voyager;
using HotChocolate.Data.Filters;
using HotChocolate.Types.Descriptors;
using HotChocolate.Types.NodaTime;
using HotChocolate.Types.Pagination;
using Microsoft.EntityFrameworkCore;
using NodaTime;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPooledDbContextFactory<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), x => x.UseNodaTime());
});
builder.Services.AddScoped<AppDbContext>(
    sp => sp.GetRequiredService<IDbContextFactory<AppDbContext>>().CreateDbContext()
);
builder.Services.AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>()
                .AddType<UploadType>()
                .AddType<LocalDateType>()
                .AddType<LocalDateTimeType>()
                .AddType<LocalTimeType>()
                .AddType<InstantType>()
                .AddType<OffsetDateTimeType>()
                .AddProjections()
                .AddFiltering()
                .AddSorting()
                .AddAuthorization()
                .AddType(new UuidType('D'))
                .AddConvention<INamingConventions>(new GraphQLNamingConvention())
                .AddConvention<IFilterConvention>(new FilterConventionExtension(configure =>
                {
                    configure.BindRuntimeType<Instant, ComparableOperationFilterInputType<Instant>>();
                    configure.BindRuntimeType<Instant?, ComparableOperationFilterInputType<Instant?>>();
                    configure.BindRuntimeType<LocalDate, ComparableOperationFilterInputType<LocalDate>>();
                    configure.BindRuntimeType<LocalDate?, ComparableOperationFilterInputType<LocalDate?>>();
                    configure.BindRuntimeType<LocalDateTime, ComparableOperationFilterInputType<LocalDateTime>>();
                    configure.BindRuntimeType<LocalDateTime?, ComparableOperationFilterInputType<LocalDateTime?>>();
                    configure.BindRuntimeType<OffsetDateTime, ComparableOperationFilterInputType<OffsetDateTime>>();
                    configure.BindRuntimeType<OffsetDateTime?, ComparableOperationFilterInputType<OffsetDateTime?>>();
                    configure.BindRuntimeType<Duration, ComparableOperationFilterInputType<Duration>>();
                    configure.BindRuntimeType<Duration?, ComparableOperationFilterInputType<Duration?>>();
                    configure.BindRuntimeType<Period, ComparableOperationFilterInputType<Period>>();
                    configure.BindRuntimeType<Period?, ComparableOperationFilterInputType<Period?>>();
                    configure.BindRuntimeType<LocalTime, ComparableOperationFilterInputType<LocalTime>>();
                    configure.BindRuntimeType<LocalTime?, ComparableOperationFilterInputType<LocalTime?>>();
                }))
                .SetPagingOptions(
                    new PagingOptions
                    {
                        IncludeTotalCount = true
                    })
                .ModifyRequestOptions(opt => opt.IncludeExceptionDetails = true);
Dapper.SqlMapper.AddTypeHandler(new DapperInstantHandler());


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapRazorPages();

app.MapGraphQL("/graphql");
app.UseGraphQLVoyager(new VoyagerOptions()
{
    GraphQLEndPoint = "/graphql"
});

app.Run();


