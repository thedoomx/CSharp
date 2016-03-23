using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    [Serializable]
    public class Author : ISerializable
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Book> Books { get; set; }

        public Author()
        {

        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("name", this.Name, typeof(string));
            info.AddValue("email", this.Email, typeof(string));
        }

        public Author(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("name", typeof(string));
            Email = (string)info.GetValue("email", typeof(string)); 
        }
    }
}
