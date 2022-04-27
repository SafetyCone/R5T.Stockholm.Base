using System;
using System.IO;

using R5T.T0064;


namespace R5T.Stockholm
{
    /// <summary>
    /// Allows the behavior of stream de/serializing generic types to be encapsulated in an object instance.
    /// The details of what format (binary, XML, JSON, text, etc.) <typeparamref name="T"/> instances are serialized in is left unspecified.
    /// </summary>
    /// <remarks>
    /// Note to implementers: The input streams should be left open!
    /// </remarks>
    /// <typeparam name="T">The type to be de/serialized.</typeparam>
    [ServiceDefinitionMarker]
    public interface IStreamSerializer<T> : IServiceDefinition
    {
        /// <summary>
        /// Deserializes a <typeparamref name="T"/> instance from a stream.
        /// </summary>
        T Deserialize(Stream stream);

        /// <summary>
        /// Serializes a <typeparamref name="T"/> instance to a stream.
        /// </summary>
        void Serialize(Stream stream, T value);
    }
}
