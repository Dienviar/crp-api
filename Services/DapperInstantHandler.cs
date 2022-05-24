using System;
using System.Data;
using Dapper;
using NodaTime;

namespace crp_api.Services
{
    public class DapperInstantHandler : SqlMapper.TypeHandler<Instant>
    {
        public override Instant Parse(object value)
        {
            if (value is DateTime time)
            {
                return Instant.FromDateTimeUtc(DateTime.SpecifyKind(time, DateTimeKind.Utc));
            }

            throw new DataException($"Unable to convert {value} to LocalDate");
        }

        public override void SetValue(IDbDataParameter parameter, Instant value)
        {
            parameter.Value = value.InUtc().ToDateTimeUnspecified();
        }
    }
}