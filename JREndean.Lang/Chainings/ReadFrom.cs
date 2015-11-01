

using System;
namespace JREndean.Lang.Chainings
{
    using System.IO;
    using System.Text;

    public class ReadFrom<TOutput>
        : ResultsError<string, TOutput>
    {
        private readonly Type type;

        public ReadFrom(Type type)
            : base(null)
        {
            this.type = type;

            this.Results = default(TOutput);
        }

        public ReadFrom(Type type, Exception exception)
            : base(null, exception)
        {
            this.type = type;
        }

        public enum Type
        {
            Text,
            Bytes,
            Key,
        }

        public ReadFrom<TOutput> File(string filePath)
        {
            if (!this.HasError)
            {
                try
                {
                    switch (this.type)
                    {
                        case Type.Bytes:
                            var bytes = System.IO.File.ReadAllBytes(filePath);
                            this.Results = (TOutput)Convert.ChangeType(bytes, typeof(TOutput));
                            break;

                        case Type.Key:
                            throw new NotSupportedException();

                        case Type.Text:
                            var text = System.IO.File.ReadAllText(filePath);
                            this.Results = (TOutput)Convert.ChangeType(text, typeof(TOutput));
                            break;

                        default:
                            throw new NotSupportedException();
                    }
                }
                catch (Exception ex)
                {
                    return new ReadFrom<TOutput>(this.type, ex);
                }
            }

            return this;
        }

        public ReadFrom<TOutput> Screen()
        {
            if (!this.HasError)
            {
                try
                {
                    switch (this.type)
                    {
                        case Type.Bytes:
                            var bytes = Encoding.ASCII.GetBytes(Console.ReadLine());
                            this.Results = (TOutput)Convert.ChangeType(bytes, typeof(TOutput));
                            break;

                        case Type.Key:
                            var key = Console.ReadKey();
                            this.Results = (TOutput)Convert.ChangeType(key, typeof(TOutput));
                            break;

                        case Type.Text:
                            var text = Console.ReadLine();
                            this.Results = (TOutput)Convert.ChangeType(text, typeof(TOutput));
                            break;

                        default:
                            throw new NotSupportedException();
                    }
                }
                catch (Exception ex)
                {
                    return new ReadFrom<TOutput>(this.type, ex);
                }
            }

            return this;
        }

        public ReadFrom<TOutput> Website(string url)
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

                        case Type.Key:
                            throw new NotSupportedException();

                        case Type.Text:
                            // TODO: 
                            break;

                        default:
                            throw new NotSupportedException();
                    }
                }
                catch (Exception ex)
                {
                    return new ReadFrom<TOutput>(this.type, ex);
                }
            }

            return this;
        }
    }
}
