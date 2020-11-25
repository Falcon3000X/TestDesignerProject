/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Xml2CSharp
{
    public class Group
    {
        public int ID { get; set; }

        public string GroupName { get; set; }

        public List<User> Users { get; set; }

    }

}

