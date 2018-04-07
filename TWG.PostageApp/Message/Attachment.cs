using System;
using System.IO;

namespace TWG.PostageApp.Message
{
    /// <summary>
    /// Represents message attachment.
    /// </summary>
    public class Attachment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attachment"/> class.
        /// </summary>
        /// <param name="stream">
        /// The stream.
        /// </param>
        /// <param name="fileName">
        /// The filename.
        /// </param>
        /// <param name="contentType">
        /// The content type.
        /// </param>
        public Attachment(Stream stream, string fileName, string contentType = "application/octet-stream")
        {
            ContentStream = stream ?? throw new ArgumentNullException("stream");
            ContentType = contentType;
            FileName = fileName ?? throw new ArgumentNullException("fileName");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attachment"/> class.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        /// <param name="fileName">
        /// The filename.
        /// </param>
        /// <param name="contentType">
        /// The content type.
        /// </param>
        public Attachment(byte[] data, string fileName, string contentType = "application/octet-stream")
        {
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }

            ContentStream = new MemoryStream(data);
            ContentType = contentType;
            FileName = fileName ?? throw new ArgumentNullException("fileName");
        }

        /// <summary>
        /// Gets file name.
        /// </summary>
        public string FileName { get; private set; }

        /// <summary>
        /// Gets content type.
        /// </summary>
        public string ContentType { get; private set; }

        /// <summary>
        /// Gets content.
        /// </summary>
        public Stream ContentStream { get; private set; }
    }
}