using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace GroupOfStudents
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    class AuthorAttribute : Attribute
    {
    }
}