

namespace JREndean.Lang.Chainings
{
    using System;
    using System.Text;

    public class WriteTo<TValue>
        : VoidError
    {
        private readonly Type type;
        private readonly TValue contents;

        public WriteTo(Type type, TValue contents)
            : base()
        {
            this.type = type;
            this.contents = contents;
        }

        public WriteTo(Type type, TValue contents, Exception exception)
            : base(exception)
        {
            this.type = type;
            this.contents = contents;
        }

        public enum Type
        {
            Text,
            Bytes,
        }

        public WriteTo<TValue> File(string filePath)
        {
            if (!this.HasError)
            {
                try
                {
                    switch (this.type)
                    {
                        case Type.Bytes:
                            System.IO.File.WriteAllBytes(filePath, (byte[])Convert.ChangeType(this.contents, typeof(byte[])));
                            break;

                        case Type.Text:
                            System.IO.File.WriteAllText(filePath, (string)Convert.ChangeType(this.contents, typeof(string)));
                            break;

                        default:
                            throw new NotSupportedException();
                    }
                }
                catch (Exception ex)
                {
                    return new WriteTo<TValue>(this.type, this.contents, ex);
                }
            }

            return this;
        }

        public WriteTo<TValue> Screen()
        {
            if (!this.HasError)
            {
                try
                {
                    switch (this.type)
                    {
                        case Type.Bytes:
                            Console.WriteLine(Encoding.ASCII.GetString((byte[])Convert.ChangeType(this.contents, typeof(byte[]))));
                            break;

                        case Type.Text:
                            Console.WriteLine((string)Convert.ChangeType(this.contents, typeof(string)));
                            break;

                        default:
                            throw new NotSupportedException();
                    }
                }
                catch (Exception ex)
                {
                    return new WriteTo<TValue>(this.type, this.contents, ex);
                }
            }

            return this;
        }

        public WriteTo<TValue> Website(string url)
        {
            if (!this.HasError)
            {
                try
                {
                    switch (this.type)
                    {
                        case Type.Bytes:
                            // TODO:
                            break;

                        case Type.Text:
                            // TODO: 
                            break;

                        default:
                            throw new NotSupportedException();
                    }
                }
                catch (Exception ex)
                {
                    return new WriteTo<TValue>(this.type, this.contents, ex);
                }
            }

            return this;
        }
    }
}
