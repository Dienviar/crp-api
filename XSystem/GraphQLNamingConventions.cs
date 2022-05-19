using System;
using System.Reflection;
using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors;
using Humanizer;
using crp_api.GQL.Mutations;
using crp_api.GQL.Queries;

namespace crp_api.XSystem
{
    public class GraphQLNamingConvention : DefaultNamingConventions
    {
        // public override NameString GetEnumValueName(object value)
        // {
        //     // Console.WriteLine(value);
        //     return value.ToString().Underscore().ToUpper();
        // }
        public override NameString GetTypeName(Type type)
        {
            // Console.WriteLine(type.Name);
            return base.GetTypeName(type);
        }
        public override NameString GetMemberName(MemberInfo member, MemberKind kind)
        {
            if (member.ReflectedType != null &&
                (member.ReflectedType == typeof(Query) || member.ReflectedType == typeof(Mutation)))
                return base.GetMemberName(member, kind).ToString().Camelize();
            return base.GetMemberName(member, kind).ToString().ToUpper();
        }
    }
}