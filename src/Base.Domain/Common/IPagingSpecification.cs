﻿namespace Base.Domain.Common
{
    public interface IPagingSpecification<T> : ISpecification<T>
        where T : class
    {
        int Page { get; }
        int PageSize { get; }
        string OrderBy { get; }
        bool Desc { get; }
        string Ext1 { get; }
        string Ext2 { get; }
    }
}
