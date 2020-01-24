using System;


namespace R5T.Stockholm
{
    public interface IStreamSerializerOptions<T>
    {
        bool AddByteOrderMark { get; }
    }
}
