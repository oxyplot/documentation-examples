namespace ExampleGenerator
{
    using System;

    /// <summary>
    /// Defines that the model should be exported.
    /// </summary>
    public class ExportAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportAttribute"/> class.
        /// </summary>
        /// <param name="filename">The filename.</param>
        public ExportAttribute(string filename)
        {
            this.Filename = filename;
        }

        /// <summary>
        /// Gets the filename.
        /// </summary>
        /// <value>The filename.</value>
        public string Filename { get; private set; }
    }
}